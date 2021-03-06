@echo off

:: visual studio environment
call %~dp0vcvarsallShim.bat

:: check for iOS build host
if "%iosServerAddress%"=="" (echo Please set 'iosServerAddress' to enable building iOS apps.)
if "%iosServerPassword%"=="" (echo Please set 'iosServerPassword' to enable building iOS apps.)
if "%iosServerUser%"=="" (echo Please set 'iosServerUser' to enable building iOS apps.)

:: variables
set platform=

:: msbuild environment
set msbuildVar=%msbuildVar%RootDir;SrcDir;RefDir;SubDir;
set msbuildVar=%msbuildVar%BuildDir;BuildBinDir;BuildTempDir;
set msbuildVar=%msbuildVar%MxbuildDir;MxbuildToolsDir;
set msbuildVar=%msbuildVar%DropDir;ToolsDir;
set msbuildVar=%msbuildVar%PkgDir;LfxDir;
set msbuildVar=%msbuildVar%ShimProj;PublishProj;IdProj;
msbuild %~dp0shell.proj /nologo /v:m /p:property=^"%msbuildVar%^" > init.bat
call init.bat
erase init.bat

:: repo paths
set path=%envDir%;%path%
set path=%mxbuildToolsDir%;%path%
set path=%mxbuildToolsDir%git\cmd\;%path%
set path=%toolsDir%;%path%
set path=%subDir%lfx.shim\;%path%
set path=%packagesDir%NUnit.Runners.2.6.4\tools\;%path%

:: path
set path=%path%;%ProgramFiles(x86)%\MSBuild\Xamarin\Android
set path=%path%;%ProgramFiles(x86)%\Windows Kits\10\Debuggers\x64
set path=%path%;%ProgramFiles(x86)%\Android\android-sdk\platform-tools
set path=%path%;%ProgramFiles(x86)%\Android\android-sdk\tools
set path=%path%;%ProgramFiles(x86)%\Microsoft Emulator Manager\1.0

:: prompt
prompt $p $g

:: title
title %rootDir%

:: alises
set doskey=%~dp0doskey.txt
doskey /macrofile=%doskey%
if exist %rootDir%doskey.txt doskey /macrofile=%rootDir%doskey.txt
color 1f

:: custom cmd
if exist %rootDir%env.bat call %rootDir%env.bat

:: use unicode
REM chcp 65001 >NUL
