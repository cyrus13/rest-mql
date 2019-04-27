[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# What is this project about?
It's a REST library for MQL5. Comprises of a C# dll that deals with the REST communication and an MQL5 sample project.

# Why?
There are numerous examples to call REST API using MQL without a dll. But these examples do not work with backtesting. As a result if you have a functionality in your Expert Advisor (e.g. do not trade during market news) and you have a REST service that provides market news information, it's not possible to call the service from within a backtest. 

# Dependencies
This project uses the [DLLExport library](https://github.com/3F/DllExport)

# Building DLL from Source
The original dll is built using Visual Studio 2017 and .NET library 4.6.1. Clone the reposity. 
## Add the DllExport dependency
Open command prompt and navigate to the folder you cloned: rest-mql/net-dll/restmql. Issue from command prompt: DllExport_Configure.bat
Then select the solution of the project and for the NameSpace for DLLExport choose: System.Runtime.InteropServices
Select (86+x64) as architecture and press Apply. 
## Build the DLL
Restart Visual Studio and the project should compile without errors. Release the DLL for the architecture you want.

# Precompiled DLL
Alternativery you can download the precompiled DLL from the [releases page](https://github.com/cyrus13/rest-mql/releases).
