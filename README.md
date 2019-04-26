# What is this project about?
It's a REST library for MQL5. Comprises of a C# dll that deals with the REST communication and an MQL5 sample project.

# Why?
There are numerous examples to call REST API using MQL without a dll. But these examples do not work with backtesting. As a result if you have a functionality in your Expert Advisor (e.g. do not trade during market news) and you have a REST service that provides market news information, it's not possible to call the service from within a backtest. 
