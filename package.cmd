%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe Streamio.sln /t:Clean,Rebuild /p:Configuration=Release /fileLogger

if not exist Download\Net4 mkdir Download\Net4\
if not exist Download\package\lib\net35 mkdir Download\package\lib\net35\
if not exist Download\package\lib\net35-client mkdir Download\package\lib\net35-client\
if not exist Download\package\lib\net4 mkdir Download\package\lib\net4\
if not exist Download\package\lib\net4-client mkdir Download\package\lib\net4-client\

copy Streamio\bin\Release\Streamio.dll Download\

copy Streamio.Net4\bin\Release\Streamio.dll Download\Net4\

copy LICENSE.txt Download\
copy README.md Download\
copy README.md Download\package\

copy Streamio\bin\Release\Streamio.dll Download\Package\lib\net35\
copy Streamio\bin\Release\Streamio.dll Download\Package\lib\net35-client\

copy Streamio.Net4\bin\Release\Streamio.dll Download\Package\lib\net4\
copy Streamio.Net4\bin\Release\Streamio.dll Download\Package\lib\net4-client\

.nuget\nuget.exe update -self
.nuget\nuget.exe pack Streamio.nuspec -BasePath Download\Package -Output Download