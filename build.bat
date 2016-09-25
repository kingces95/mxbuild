nuget restore -Source https://chocolatey.org/api/v2
pushd %~dp0
packages\git-lfx.0.1.0\tools\git-lfx checkout
msbuild src\mxbuild\shim\shim.proj /v:m /t:build /p:Configuration="release"
popd