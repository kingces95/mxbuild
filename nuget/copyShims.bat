@echo off
for /D %%i in (%pkgdir%*) do copy /y %rootdir%sub\mxbuild\nuget\shim.* %%i
@echo on