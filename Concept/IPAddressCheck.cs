using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.Concept
{
    internal class IPAddressCheck
    {
        static void Main(string[] args)
        {
            var httpclient = new HttpClient();
            var ip = httpclient.GetStringAsync("https://api.ipify.org");
            Console.WriteLine($"My public IP address is: {ip}");
        }
    }
}
