msbuild ppt-tools.sln /p:OutDir="..\build" /p:Configuration=Release /p:Platform="Any CPU"
powershell Compress-Archive -Path build\*.exe -DestinationPath ppt-tools.zip