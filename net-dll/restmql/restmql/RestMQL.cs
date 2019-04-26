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
using System.Net.Http;
using System.Runtime.InteropServices;
namespace Cyrus.Mql5
{
    public class RestMQL
    {
        [DllExport("Get", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPTStr)]
        public static string Get([In, MarshalAs(UnmanagedType.LPTStr)] string url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(url)).Result;

                return response;
            }
        }

        [DllExport("Post", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPTStr)]
        public static string Post([In, MarshalAs(UnmanagedType.LPTStr)] string url, [In, MarshalAs(UnmanagedType.LPTStr)] string data)
        {
            using (var httpClient = new HttpClient())
            {

               var response = httpClient.PostAsync(new Uri(url), new StringContent(data));

               return response.Result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
