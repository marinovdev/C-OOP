using System;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);

        }
    }
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Id = id;
        }

        public string Name { get ; set ; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
    }

    public interface IIdentifiable
    {
        string Id { get; set; }
    }

    public interface IBirthable
    {
        string Birthdate { get; set; }
    }
    public interface IPerson
    {
         string Name { get; set; }

         int Age { get; set; }
    }
}
