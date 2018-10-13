//////////////////////////////////////////////////////////////////////
// TOOLS
//////////////////////////////////////////////////////////////////////

#tool "nuget:?package=xunit.runner.console&version=2.4.0"

#addin "nuget:?package=Cake.Powershell&version=0.4.6"

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Build Configuration
var configuration = EnvironmentVariable("CONFIGURATION") ?? "Release";
var isAppVeyorBuild = BuildSystem.AppVeyor.IsRunningOnAppVeyor;
var isPullRequest = BuildSystem.AppVeyor.Environment.PullRequest.IsPullRequest;

// Version
var gitVersion = GitVersion();

// File/Directory paths
var artifactDirectory = MakeAbsolute(Directory("./artifacts")).FullPath; // Appveyor needs absolute paths
var solutionFile = "./src/Aldsoft.Acord.sln";

// Define global marcos.
Action Abort = () => { throw new Exception("a non-recoverable fatal error occurred."); };

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    CleanDirectories($"./src/**/obj/{configuration}");
    CleanDirectories($"./src/**/bin/{configuration}");
    CleanDirectories("./artifacts");
});

Task("CleanAll")
    .Does(() =>
{
    CleanDirectories("./src/**/obj");
    CleanDirectories("./src/**/bin");
    CleanDirectories("./artifacts");
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore(solutionFile, new NuGetRestoreSettings());
});

Task("Try")
  .Does(() =>
  {
    Information(configuration);
  });

Task("Generate-CsCode")
    .Description("Generates the C# Objects from XSD Schemas")
    .Does(() =>
    {
        Information("Calling Powershell File");

        var resultCollection = StartPowershellFile("./Generate-CsCode.ps1", new PowershellSettings
        {
          WorkingDirectory="./generate"
        });

        var returnCode = int.Parse(resultCollection[0].BaseObject.ToString());
        Information("Result: {0}", returnCode);

        if (returnCode != 0) {
            throw new ApplicationException("Script failed to execute");
        }
    });

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
	MSBuild(solutionFile, settings =>
		settings
            .WithTarget("Build")
            .SetConfiguration(configuration)
            .UseToolVersion(MSBuildToolVersion.VS2017)
            );
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
  XUnit2($"./src/**/bin/{configuration}/**/*.Tests.dll",
        new XUnit2Settings {
            OutputDirectory = artifactDirectory,
            XmlReport = true
        });
});

Task("Create-NuGet-Packages")
    .IsDependentOn("Build")
    .WithCriteria(!isPullRequest)
    .Does(() =>
{
    var settings = new MSBuildSettings()
        .WithTarget("Pack")
        .SetConfiguration(configuration)
        .UseToolVersion(MSBuildToolVersion.VS2017)
        .WithProperty("PackageOutputPath",artifactDirectory);

    MSBuild(solutionFile, settings);
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore-NuGet-Packages")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
    .IsDependentOn("Create-NuGet-Packages");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
