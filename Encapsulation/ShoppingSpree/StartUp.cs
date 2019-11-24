
namespace ShoppingSpree
{
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static List<Person> peopleDic = new List<Person>();
        public static List<Product> productDic = new List<Product>();
        public static void Main(string[] args)
        {
            var peopleInput = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < peopleInput.Length; i += 2)
            {
                Person person = null;
                try
                {
                    person = new Person(peopleInput[i], int.Parse(peopleInput[i + 1]));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                peopleDic.Add(person);
            }
            //
            var productsInput = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsInput.Length; i += 2)
            {
                Product product = null;
                try
                {
                    product = new Product(productsInput[i], int.Parse(productsInput[i + 1]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                productDic.Add(product);
            }

            var command = "";
            while((command = Console.ReadLine()) != "END")
            {
                var arr = command.Split();
                var name = arr[0];
                var nameProduct = arr[1];

                var person = peopleDic.Where(p => p.Name == name)
                    .FirstOrDefault();
                var product = productDic.Where(p => p.Name == nameProduct)
                    .FirstOrDefault();
                
                if(person.Money - product.Cost >= 0)
                {
                    person.Money -= product.Cost;
                    person.AddToBag(product);
                    Console.WriteLine($"{name} bought {nameProduct}");
                }
                else
                {
                    Console.WriteLine($"{name} can't afford {nameProduct}");
                }
            }

            foreach (var person in peopleDic)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        private string name;
        private int money;
        private List<Product> Bag;

        public Person( string name, int money)
        {
            Money = money;
            Name = name;
            Bag = new List<Product>();
        }

        public void AddToBag(Product product)
        {
            Bag.Add(product);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Name + " - ");
            if(this.Bag.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                var temp = Bag.Select(b => b.Name).ToList();
                sb.Append(string.Join(", ", temp));
            }
            return sb.ToString().TrimEnd();
        }

        public int Money
        {
            get { return money; }
            set 
            {
                if (value < 0 )
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value; 
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))//value == null || value == ""
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value; 
            }
        }

    }

    public class Product
    {
        private string name;
        private int cost;

        public Product( string name, int cost)
        {
            Cost = cost;
            Name = name;
        }

        public int Cost
        {
            get { return cost; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                cost = value; 
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value)) // value == null || value == ""
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value; 
            }
        }


    }
}
