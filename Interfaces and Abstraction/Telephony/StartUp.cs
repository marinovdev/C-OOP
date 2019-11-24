
namespace Telephony
{
using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var phones = Console.ReadLine()
                .Split();
            foreach (var phone in phones)
            {
                    var smarthpone = new Smartphone(phone);
                    Console.WriteLine(smarthpone.Dial());
            }

            var addresses = Console.ReadLine()
                .Split();
            foreach (var address in addresses)
            {

                    var smarthpone = new Smartphone(address);
                    Console.WriteLine(smarthpone.Browse());
            }
        }
    }

    public class Smartphone : IDiable, IBrowsable
    {
        private static string dialingPattern = @"^([0-9]*)$";
        private static string browsingPattern = @"^([^0-9]*)$";
        public Smartphone(string adress)
        {
            Adress = adress;
        }
       
        public string Browse()
        {
            var result = "";
            var match = Regex.Match(this.Adress, browsingPattern);
            if (!match.Success)
            {
               return ("Invalid URL!");
            }
            result = $"Browsing: " + this.Adress + "!";
            return result;
        }

        public string Dial()
        {
            var result = "";
            var match = Regex.Match(this.Adress, dialingPattern);
            if (!match.Success)
            {
                return ("Invalid number!");
            }
            result = $"Calling... " + this.Adress;
            return result;
        }

        public string Adress { get; set; }
    }
    public interface IDiable
    {
        string Dial();
    }

    public interface IBrowsable
    {
        string Browse();
    }
}
