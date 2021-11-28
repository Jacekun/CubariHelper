@echo off
pushd "%~dp0"
powershell Compress-7Zip "Release" -ArchiveFileName "SampleAnyCPU.zip" -Format Zip
:exit
popd