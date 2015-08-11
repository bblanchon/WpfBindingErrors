@call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat"

@pushd WpfBindingErrors

@msbuild /nologo /t:Clean;Build /verbosity:m "/p:Configuration=Release;TargetFrameworkVersion=v4.0;OutputPath=bin/.NET Framework 4"
@msbuild /nologo /t:Clean;Build /verbosity:m "/p:Configuration=Release;TargetFrameworkVersion=v4.5;OutputPath=bin/.NET Framework 4.5"
@msbuild /nologo /t:Clean;Build /verbosity:m "/p:Configuration=Release;TargetFrameworkVersion=v4.5.1;OutputPath=bin/.NET Framework 4.5.1"
@msbuild /nologo /t:Clean;Build /verbosity:m "/p:Configuration=Release;TargetFrameworkVersion=v4.5.2;OutputPath=bin/.NET Framework 4.5.2"
@msbuild /nologo /t:Clean;Build /verbosity:m "/p:Configuration=Release;TargetFrameworkVersion=v4.6;OutputPath=bin/.NET Framework 4.6"

@..\.nuget\nuget.exe pack -NoDefaultExcludes WpfBindingErrors.nuspec

@popd WpfBindingErrors
@pause
