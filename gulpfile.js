var args = require('yargs').argv;
var assemblyInfo = require('gulp-dotnet-assembly-info');
var clean = require('gulp-clean');
var fs = require('fs');
var git = require('gulp-git');
var gulp = require('gulp');
var msbuild = require('gulp-msbuild');
var nuget = require('gulp-nuget');
var nunit = require('gulp-nunit-runner');
var request = require('request');


//#### Config Variables
var gitHash;
var gitBranchName;
var buildArtifactPath = './build_artifacts';
var nugetExe = 'nuget.exe';
var nugetExePath = './' + nugetExe;
var nugetPackagesPath = './src/packages';
var nunitExe = 'nunit3-console.exe';
var testResultsPath = './TestResult.xml';

//# assemblyInfo
gulp.task('assemblyInfo', ['branchName','hash'], function() {
	var version = '0.0.0';
	if (args.buildVersion) {
		version = args.buildVersion;
	}
	
    return gulp
        .src('**/SolutionVersion.cs')
        .pipe(assemblyInfo({
            version: version,
            fileVersion: version,
			informationalVersion: version + ' ('+gitBranchName+'\\\\'+gitHash+')'
        }))
        .pipe(gulp.dest('.'));
});

//# branchName
gulp.task('branchName', function(callback) {
	return git.revParse({args:'--abbrev-ref HEAD'}, function (err, branchName) {
		if (err) throw err;
		gitBranchName = branchName;
		callback();
	});
});

//# build
gulp.task('build', ['clean','assemblyInfo','nuget-download','nuget-restore'], function() {
    return gulp
        .src('**/*.sln')
        .pipe(msbuild({
            toolsVersion: 14.0,
            targets: ['Clean', 'Build'],
            errorOnFail: true,
			stdout: true
        }));
});

//# clean
gulp.task('clean', function() {
    return gulp
        .src(['**/bin/','**/obj/',nugetExePath,nugetPackagesPath,buildArtifactPath,testResultsPath], { read: false })
        .pipe(clean());
});

//# deploy
gulp.task('package', ['nuget-download'], function() {
  return gulp.src(['src/Aldsoft.Acord.LA.*/*.csproj','!src/Aldsoft.Acord.LA.Tests/*.csproj'])
    .pipe(nuget.pack(
	{
		properties: 'configuration=release'
	}))
    .pipe(gulp.dest(buildArtifactPath));
});

//# hash
gulp.task('hash', function(callback) {
	return git.revParse({args:'--short HEAD'}, function (err, hash) {
		if (err) throw err;
		gitHash = hash;
		callback();
	});
});

//# nuget-download
gulp.task('nuget-download', function(callback) {
    if(fs.existsSync(nugetExePath)) {
        return callback();
    }
    request.get('https://nuget.org/nuget.exe')
        .pipe(fs.createWriteStream(nugetExe))
        .on('close', callback);
});

//# nuget-restore
gulp.task('nuget-restore', ['nuget-download'], function(callback) {
	var stream = gulp
        .src('**/*.sln')
		.pipe(nuget.restore());
    return stream;
});

//# test
gulp.task('test', function () {
    return gulp
        .src(['**/bin/**/*Tests.dll'], { read: false })
        .pipe(nunit({
			executable: nunitExe,
			nologo: true,
			config: 'Release'
		}));
});
