pushd %~dp0
@powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
choco install git-lfx
git-lfx files
echo Pre nuget restore
call nuget restore -Source https://chocolatey.org/api/v2
echo Post nuget restore
git --version
for /F "tokens=*" %%i in ('git remote') do git remote get-url %%i
packages\git-lfx.0.1.0\tools\git-lfx checkout
msbuild src\mxbuild\shim\shim.proj /v:m /t:build /p:Configuration="release"
popd