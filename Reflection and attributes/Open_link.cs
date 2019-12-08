using System;
using System.Diagnostics;

namespace Open_link
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = "https://csharp-source.net/";
            //Opens the webpage link with the browser
            Process.Start("cmd", $"/c start {link}");
        }
    }
}
