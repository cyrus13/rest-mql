/** 
Copyright(c) <2019> <https://github.com/cyrus13>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE. 
**/

using System;
using System.Runtime.InteropServices;
using System.Text;
namespace Cyrus.Mql5
{
    public class RestMQLTest
    {

        [DllExport("CPing", CallingConvention = CallingConvention.StdCall)]
        public static int CPing([In, Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder str)
        {
            int value = str.Length;
            // This is an example of how to change the String value passed by reference from MQL
            str.Clear();
            str.Append("CPong");
            return value;
        }

        [DllExport("CPing2", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPTStr)]
        public static string CPing2()
        {
            return "CPong2";
        }
    }
}
