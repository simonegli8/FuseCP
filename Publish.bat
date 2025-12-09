
robocopy "SolidCP\Sources\SolidCP.Server" "C:\SolidCP\Server asp.net v4.5" /E /XF *.cs *.config *.csproj /XD SolidCP\Sources\SolidCP.Server\obj
robocopy "SolidCP\Sources\SolidCP.EnterpriseServer" "C:\SolidCP\Enterprise Server" /E /XF *.cs *.config *.csproj /XD SolidCP\Sources\SolidCP.EnterpriseServer\obj
robocopy "SolidCP\Sources\SolidCP.WebPortal" "C:\SolidCP\Portal" /E /XF *.cs *.config *.csproj /XD SolidCP\Sources\SolidCP.WebPortal\obj
