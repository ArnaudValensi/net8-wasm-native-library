# Build

```
dotnet publish /p:NativeLib=Shared -r browser-wasm -c Debug /p:TargetArchitecture=wasm /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false /p:EmccExtraArgs="-s EXPORTED_FUNCTIONS=_Answer -s EXPORTED_RUNTIME_METHODS=cwrap --post-js=invokeLibraryFunction.js" --self-contained
```
