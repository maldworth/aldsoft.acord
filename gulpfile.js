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
var buildArtifactPath = './build_artifacts';
var nugetPackagesPath = './src/packages';
var keyFile = './aldsoft.acord.snk';

//# assemblyInfo
gulp.task('assemblyInfo', ['hash'], function() {
    return gulp
        .src('**/SolutionVersion.cs')
        .pipe(assemblyInfo({
            version: args.buildVersion,
            fileVersion: args.buildVersion,
			informationalVersion: args.buildVersion + ' (master\\\\'+gitHash+')'
        }))
        .pipe(gulp.dest('.'));
});

//# build
gulp.task('build', ['assemblyInfo','nuget-download','clean'], function(callback) {
    return gulp
        .src('**/*.sln')
		.pipe(nuget.restore())
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
        .src(['**/bin/','**/obj/',nugetPackagesPath,buildArtifactPath], { read: false })
        .pipe(clean());
});

//# deploy
gulp.task('deploy', function() {
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
    if(fs.existsSync('nuget.exe')) {
        return callback();
    }
    request.get('https://nuget.org/nuget.exe')
        .pipe(fs.createWriteStream('nuget.exe'))
        .on('close', callback);
});

//# test
gulp.task('test', function () {
    return gulp
        .src(['**/bin/**/*Tests.dll'], { read: false })
        .pipe(nunit({
			executable: 'nunit3-console.exe',
			nologo: true,
			config: 'Release'
		}));
});
