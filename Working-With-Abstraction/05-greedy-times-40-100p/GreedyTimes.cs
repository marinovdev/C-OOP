using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05_greeedy_times
{
    class Program
    {
        public static long currentBagUsage = 0;
        public static long bagCapacity = 0;
        public static void Main()
        {
            bagCapacity = long.Parse(Console.ReadLine());
            var jewelryInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (long i = 0; i < jewelryInput.Length; i += 2)
            {
                var itemName = jewelryInput[i];
                var type = "";
                var ammount = long.Parse(jewelryInput[i + 1]);
                type = itemName.WhichType();

                 Jewelry.Add(type, itemName, ammount);
            }

            var dic = new Dictionary<string, Dictionary<string, long>>();
            if(Jewelry.goldList.Count() > 0) dic.Add("Gold", Jewelry.goldList);
            if (Jewelry.gemList.Count() > 0) dic.Add("Gem", Jewelry.gemList);
            if (Jewelry.cashList.Count() > 0) dic.Add("Cash", Jewelry.cashList);
            dic.OrderByDescending(c => c.Value.Sum(x => x.Value));

            foreach (var collection in dic)
            {
                var type = collection.Key;

                Console.WriteLine($"<{type}> ${collection.Value.Sum(x => x.Value)}");
                foreach (var item in collection.Value.OrderByDescending(x => x.Key).ThenBy( x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }

        }    
    }
    static class Jewelry
    {
        public static Dictionary<string, long> goldList = 
            new Dictionary<string, long>(StringComparer.InvariantCultureIgnoreCase);
        public static Dictionary<string, long> gemList = 
            new Dictionary<string, long>(StringComparer.InvariantCultureIgnoreCase);
        public static Dictionary<string, long> cashList = 
            new Dictionary<string, long>(StringComparer.InvariantCultureIgnoreCase);

        public static void Add(string type, string item, long ammount)
        {
            if(type == "Gold" && Program.bagCapacity >= Program.currentBagUsage + ammount)
            {
               
                    if (!goldList.ContainsKey("Gold"))
                    {
                        goldList.Add("Gold", 0);
                    }
                    goldList["Gold"] += ammount;
                
            }
            else if (type == "Gem" && Program.bagCapacity >= Program.currentBagUsage + ammount)
            {
                long gemValue = 0;
                long goldValue = 0;
                if (gemList.Count() > 0)
                {
                    gemValue = gemList.Sum(g => g.Value);
                }
                if (goldList.Count() > 0)
                {
                    goldValue = goldList.Sum(g => g.Value);
                }
                if (goldValue >= gemValue + ammount)
                {
                    if (!gemList.ContainsKey(item))
                    {
                        gemList.Add(item, 0);
                    }
                    gemList[item] += ammount;
                }
            }
            else if (type == "Cash" && Program.bagCapacity >= Program.currentBagUsage + ammount)
            {
                long gemValue = 0;
                long cashValue = 0;
                if (gemList.Count() > 0)
                {
                    gemValue = gemList.Sum(g => g.Value);
                }
                if (cashList.Count() > 0)
                {
                    cashValue = cashList.Sum(g => g.Value);
                }
                if (gemValue >= cashValue + ammount)
                {
                    if (!cashList.ContainsKey(item))
                    {
                        cashList.Add(item, 0);
                    }
                    cashList[item] += ammount;
                }
            }


        }
    }

    static class JewelryValues
    {
        public static string WhichType(this string value)
        {
            string output = "Gold";
            string pattern = @"^.*(gem$)";
            var match = Regex.Match(value.ToLower(), pattern);
            if (match.Success)
            {
                output = "Gem";
            }
            else if (value.Length == 3)
            {
                output = "Cash";
            }

            return output;
        }
    }
}
