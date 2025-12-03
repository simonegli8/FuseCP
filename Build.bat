echo off
rem --- adjust path to match your VS edition/installation ---
call "%ProgramFiles%\Microsoft Visual Studio\18\Community\Common7\Tools\VsDevCmd.bat"

rem now MSBuild should be in PATH
msbuild SolidCP\Sources\SolidCP.Server.sln /p:Configuration=Release /m
msbuild SolidCP\Sources\SolidCP.EnterpriseServer.sln /p:Configuration=Release /m
msbuild SolidCP\Sources\SolidCP.WebPortal.sln /p:Configuration=Release /m
