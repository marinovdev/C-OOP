
namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BorderControl
    {
        public static List<string> detained = new List<string>();
        public static List<string> birthYearList = new List<string>();
        public static List<Entity> entities = new List<Entity>();
        public static void Main()
        {
            var command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                var args = command
                    .Split();
                var name = "";
                var age = 0;
                var id = "";
                var birthdate = "";

                if(args[0] == "Citizen")
                {
                    name = args[1];
                    age = int.Parse(args[2]);
                    id = args[3];
                    birthdate = args[4];

                    var citizen = new Citizen(name, age, id, birthdate);

                    entities.Add(citizen);
                }
                else if(args[0] == "Robot")
                {
                    name = args[1];
                    id = args[2];
                    var robot = new Robot(name, id);

                    entities.Add(robot);
                }
                else if (args[0] == "Pet")
                {
                    name = args[1];
                    birthdate = args[2];

                    var pet = new Pet(name, birthdate);

                    entities.Add(pet);
                }
            }

            var suffix = Console.ReadLine();

            foreach (var item in entities)
            {
                item.SortByBirthYear(suffix);
            }

            if (birthYearList.Count > 0)
            {
                foreach (var item in birthYearList)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public interface IBorn
        {
            string Birthdate { get; set; }

            void SortByBirthYear(string year);
        }
        public class Entity : IBorn
        {
            public virtual void CheckId(string suffix)
            {
                if (this.Id.ToString().EndsWith(suffix))
                {
                    BorderControl.detained.Add(this.Id);
                }
            }

            public virtual void SortByBirthYear(string year)
            {
            }

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

            public override void SortByBirthYear(string year)
            {
                if (this.Birthdate.ToString().EndsWith(year))
                {
                    BorderControl.birthYearList.Add(this.Birthdate);
                }
            }
        }
        public class Robot : Entity, IBorn
        {
            public Robot(string name, string id)
            {
                Name = name;
                Id = id;
            }

            public override string Name { get; set; }

            public override string Id { get; set; }
            public override string Birthdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void SortByBirthYear(string year)
            {
            }
        }
        public class Citizen : Entity
        {
            public Citizen(string name, int age, string id, string birthdate)
            {
                Name = name;
                Age = age;
                Id = id;
                Birthdate = birthdate;
            }

            public override void SortByBirthYear(string year)
            {
                    if (this.Birthdate.ToString().EndsWith(year))
                    {
                        BorderControl.birthYearList.Add(this.Birthdate);
                    }
            }

            public override string Name { get; set; }

            public int Age { get; set; }

            public override string Id { get; set; }

            public override string Birthdate { get; set; }

        }
    }
}
