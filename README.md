# AngularCEF
## Dotnet Core 程式執行示意圖
![image](https://user-images.githubusercontent.com/24131541/125229680-daccd580-e309-11eb-9d6a-3ac0f2e90fa3.png)
## Dotnet WinForm 與 Angular 溝通示意圖
![image](https://user-images.githubusercontent.com/24131541/125229738-f506b380-e309-11eb-99e1-42b1212178b4.png)

程式執行步驟
1. dotent core 3.1 sdk 安裝 https://dotnet.microsoft.com/download/dotnet/3.1
2. angular cli 安裝 https://angular.tw/cli
3. vscode 注意
  1. launch.json 範例(注意相對路徑)
  ```
{

  "version": "0.2.0",
  "configurations": [
    {
      "name": ".NET Core Launch (console)",
      "type": "coreclr",
      "request": "launch",
      "preLaunchTask": "build",
      "program": "${workspaceFolder}/AngularCEF/bin/Debug/netcoreapp3.1/win-x64/AngularCEF.dll",
      "args": [],
      "cwd": "${workspaceFolder}/AngularCEF",
      "console": "internalConsole",
      "stopAtEntry": false,
      "env": {
        "ASPNETCORE_ENVIRONMENT": "Development"
        // "ASPNETCORE_ENVIRONMENT": "Release"
      }
    },
    {
      "name": ".NET Core Attach",
      "type": "coreclr",
      "request": "attach"
    }
  ]
}

  ```
      
