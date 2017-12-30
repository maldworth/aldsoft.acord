var args = require('yargs').argv;
var assemblyInfo = require('gulp-dotnet-assembly-info');
var clean = require('gulp-clean');
var fs = require('fs');
var git = require('gulp-git');
var gulp = require('gulp');
var merge = require('merge-stream');
var msbuild = require('gulp-msbuild');
var nuget = require('gulp-nuget');
var nunit = require('gulp-nunit-runner');
var path = require('path');
var rename = require('gulp-rename');
var request = require('request');

//#### Config Variables
var isAppVeyor = Boolean(process.env.APPVEYOR);
var semVer = process.env.SEMVER || '0.0.0'
var buildNumber = process.env.APPVEYOR_BUILD_NUMBER || '0';
var gitHash = process.env.APPVEYOR_REPO_COMMIT;
var gitBranchName = process.env.APPVEYOR_REPO_BRANCH;

//### Paths
var buildArtifactPath = './build_artifacts';
var nugetExe = 'nuget.exe';
var nugetExePath = './' + nugetExe;
var nugetPackagesPath = './src/packages';
var nunitExe = 'nunit3-console.exe';
var srcPath = './src';
var testResultsPath = './TestResult.xml';

//# assemblyInfo
gulp.task('assemblyInfo', ['branchName', 'hash'], function () {
  var version;
  hash = gitHash;
  if (!isAppVeyor) {
    hash = 'nocommit';
  }
  if (args.buildVersion) {
    version = args.buildVersion;
  } else {
    version = semVer;
  }

  var assemblyVersion = version + '.' + buildNumber;

  return gulp
    .src('**/SolutionVersion.cs')
    .pipe(assemblyInfo({
      version: assemblyVersion,
      fileVersion: assemblyVersion,
      informationalVersion: version + '+build.' + buildNumber + ' (' + gitBranchName + '\\\\' + hash + ')'
    }))
    .pipe(gulp.dest('.'));
});

//# branchName
gulp.task('branchName', function (callback) {
  if (gitBranchName) {
    callback();
  } else {
    return git.revParse({ args: '--abbrev-ref HEAD' }, function (err, branchName) {
      if (err) throw err;
      gitBranchName = branchName;
      callback();
    });
  }
});

//# build
gulp.task('build', ['clean', 'assemblyInfo', 'nuget-download', 'nuget-restore'], function () {
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
gulp.task('clean', function () {
  return gulp
    .src(['**/bin/', '**/obj/', './src/Aldsoft.Acord.LA.*/*.nuspec', nugetExePath, nugetPackagesPath, buildArtifactPath, testResultsPath], { read: false })
    .pipe(clean());
});

//# copyNuspec
gulp.task('copyNuspec', ['nuget-download'], function () {
  var folders = getFolders(srcPath).filter(function (folder) {
    var patt = /Aldsoft.Acord.LA.[\d\.]+/i;
    var res = patt.test(folder);
    return res;
  });

  var tasks = folders.map(function (folder) {
    return gulp.src('./template.nuspec')
      .pipe(rename(folder + '/' + folder + '.nuspec'))
      .pipe(gulp.dest('./src'));
  });

  return merge(tasks);
});

//# hash
gulp.task('hash', function (callback) {
  if (gitHash) {
    gitHash = gitHash.substring(0, 7);
    callback();
  } else {
    return git.revParse({ args: '--short HEAD' }, function (err, hash) {
      if (err) throw err;
      gitHash = hash;
      callback();
    });
  }
});

//# nuget-download
gulp.task('nuget-download', function (callback) {
  if (fs.existsSync(nugetExePath)) {
    return callback();
  }
  request.get('https://nuget.org/nuget.exe')
    .pipe(fs.createWriteStream(nugetExe))
    .on('close', callback);
});

//# nuget-restore
gulp.task('nuget-restore', ['nuget-download'], function (callback) {
  var stream = gulp
    .src('**/*.sln')
    .pipe(nuget.restore({configFile: './src/nuget.config'}));
  return stream;
});

//# package
gulp.task('package', ['nuget-download', 'copyNuspec'], function () {
  var nugetVersion = semVer;
  if (!gitBranchName || gitBranchName !== 'master') {
    nugetVersion = nugetVersion + '-pre' + buildNumber;
  }

  return gulp.src(['./src/Aldsoft.Acord.LA.*/*.csproj', '!./src/Aldsoft.Acord.LA.Tests/*.csproj'])
    .pipe(nuget.pack(
      {
        properties: 'configuration=release',
        version: nugetVersion
      }))
    .pipe(gulp.dest(buildArtifactPath));
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


// Helper Functions
function getFolders(dir) {
  return fs.readdirSync(dir)
    .filter(function (file) {
      return fs.statSync(path.join(dir, file)).isDirectory();
    });
}