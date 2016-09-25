nuget restore -Source https://chocolatey.org/api/v2
set path=%path%;%~dp0packages\git-lfx.0.1.0\tools\
git lfx checkout
msbuild %~dp0src\mxbuild\shim\shim.proj /v:m /t:build /p:Configuration="debug;release"