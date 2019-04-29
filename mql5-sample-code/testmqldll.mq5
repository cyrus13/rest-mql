//+------------------------------------------------------------------+
//|                                                   testmqldll.mq5 |
//|                                            Copyright 2019, Cyrus |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2019, https://github.com/cyrus13"
#property link      "https://www.mql5.com"
#property version   "1.00"
//+------------------------------------------------------------------+
//| Expert initialization function                                   |
//+------------------------------------------------------------------+

#import "restmql_x64.dll"
   int CPing(string &str);
   string CPing2();
   string Get(string url);
   string Post(string url, string data);
#import

long Ticks = 0;

int OnInit()
  {
//---

//---
   return(INIT_SUCCEEDED);
  }
//+------------------------------------------------------------------+
//| Expert deinitialization function                                 |
//+------------------------------------------------------------------+
void OnDeinit(const int reason)
  { 
//---
   
  }
//+------------------------------------------------------------------+
//| Expert tick function                                             |
//+------------------------------------------------------------------+
void OnTick()
  {
//---
      Ticks++;
      if (MathMod(Ticks,100000)==0)
      {  
          string s = "NumberOfTicks: " + IntegerToString(Ticks);
          Print(CPing(s));
          Print(s);
          Print(CPing2());
          Print("GET RESULT:");
          Print(Get("https://httpbin.org/get"));
          
          Print("POST RESULT:");
          Print(Post("https://httpbin.org/post","param1=value1"));
      } 
  }
//+------------------------------------------------------------------+
