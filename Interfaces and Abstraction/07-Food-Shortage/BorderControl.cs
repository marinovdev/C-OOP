
namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BorderControl
    {
        public static int TotalFood { get; set; } = 0;
        public static List<IBuyer> entities = new List<IBuyer>();
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var input = Console.ReadLine();

                var args = input.Split();
                var name = "";
                var age = 0;
                var id = "";
                var birthdate = "";
                var group = "";

                if(args.Length == 4)
                {
                    name = args[0];
                    age = int.Parse(args[1]);
                    id = args[2];
                    birthdate = args[3];

                    var cit = new Citizen(name, age, id, birthdate);
                    entities.Add(cit);
                }
                else if (args.Length == 3)
                {
                    name = args[0];
                    age = int.Parse(args[1]);
                    group = args[2];

                    var rebel = new Rebel(name, age, group);
                    entities.Add(rebel);
                }
                n--;
            }

            var command = "";
            while((command = Console.ReadLine()) != "End")
            {
                if(entities.Any(e => e.Name == command))
                {
                    entities.Where(e => e.Name == command).First().BuyFood();
                }
            }

            Console.WriteLine(TotalFood);
        }


        public interface IBuyer
        {
            void BuyFood();
            int Food { get; set; }

            string Name { get; set; }
        }
        public class Entity
        {
            public virtual string Name { get; set; }

            public virtual string Id { get; set; }
            public virtual string Birthdate { get; set; }
        }

        public class Pet : Entity
        {
            public Pet(string name, string birthdate)
            {
                Name = name;
                Birthdate = birthdate;
            }

            public override string Name { get; set; }
            public override string Birthdate { get; set; }

        }
        public class Robot : Entity
        {
            public Robot(string name, string id)
            {
                Name = name;
                Id = id;
            }

            public override string Name { get; set; }

            public override string Id { get; set; }

        }

        public class Rebel : Entity, IBuyer
        {

            public Rebel(string name, int age, string group)
            {
                Name = name;
                this.Age = age;
                this.Group = group;
            }

            public void BuyFood()
            {
                    this.Food += 5;
                    BorderControl.TotalFood += 5;
            }
            public int Food { get; set; }

            public int Age { get; set; }

            public string Group { get; set; }
        }

        public class Citizen : Entity, IBuyer
        {
            public Citizen(string name, int age, string id, string birthdate)
            {
                Name = name;
                Age = age;
                Id = id;
                Birthdate = birthdate;
            }

            public void BuyFood()
            {
                    this.Food += 10;
                    BorderControl.TotalFood += 10;
            }

            public override string Name { get; set; }

            public int Age { get; set; }

            public override string Id { get; set; }

            public override string Birthdate { get; set; }
            public int Food { get; set; }
        }
    }
}
