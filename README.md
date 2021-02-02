# serial-log-.net-core

### NuGet package 
```sh
Serilog
Serilog.AspNetCore
Serilog.Formatting.Compact
Serilog.Sinks.File
Serilog.Sinks.DateFormatPath
```

### appsettings.json
```sh
"Serilog": {
    "Using": [ "Serilog.Sinks.File" ],
    "MinimumLevel": "Debug",
    "WriteTo": [
      {
        "Name": "File",
        "Args": {
          "path": "D:\\Logs\\Log.json",
          "formatter": "Serilog.Formatting.Compact.CompactJsonFormatter, Serilog.Formatting.Compact",
          "rollingInterval": "Day",
          "retainedFileCountLimit": 30,
          "fileSizeLimitBytes": 3000,
          "rollOnFileSizeLimit": true
        }
      }
    ],
    "Enrich": [ "FromLogContext", "WithThreadId" ],
    "Properties": {
      "Application": "Demo"
    }
  },
```
