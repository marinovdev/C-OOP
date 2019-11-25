
namespace BorderControl
{
    using System;
    using System.Collections.Generic;

    public class BorderControl
    {
        public static List<string> detained = new List<string>();
        public static List<Entity> entities = new List<Entity>();
        public static void Main()
        {
            var command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                var args = command
                    .Split();

                var name = "";
                var model = "";
                var age = 0;
                var id = "";

                if (args.Length == 3)
                {
                    name = args[0];
                    age = int.Parse(args[1]);
                    id = args[2];

                    var citizen = new Citizen(name, age, id);

                    entities.Add(citizen);
                }
                else
                {
                    model = args[0];
                    id = args[1];
                    var robot = new Robot(model, id);
                    entities.Add(robot);
                }

            }

            var suffix = Console.ReadLine();

            foreach (var item in entities)
            {
                item.CheckId(suffix);

            }

            if (detained.Count > 0)
            {
                foreach (var item in detained)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public class Entity
        {
            public virtual void CheckId(string suffix)
            {
                if (this.Id.ToString().EndsWith(suffix))
                {
                    BorderControl.detained.Add(this.Id);
                }
            }

            public virtual string Id { get; set; }
        }
        public class Robot : Entity
        {
            public Robot(string model, string id)
            {
                Model = model;
                Id = id;
            }

            public string Model { get; set; }

            public override string Id { get; set; }
        }
        public class Citizen : Entity
        {
            public Citizen(string name, int age, string id)
            {
                Name = name;
                Age = age;
                Id = id;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public override string Id { get; set; }
        }
    }
}
