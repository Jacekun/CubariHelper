@echo off
pushd "%~dp0"
powershell Compress-7Zip "CubariHelper\bin\Release" -ArchiveFileName "CubariHelper_AnyCPU.zip" -Format Zip
:exit
popd