
namespace ReadOnly_Collection
{
using System;
    using System.Collections.Generic;   
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection();
            collection.AddName("Ivo");
            collection.AddName("Petar");
            collection.AddName("ivan");

            //collection.Names.Add("Timo") <== Greshka

            foreach (var item in collection.Names)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Collection
    {
        private List<string> names;

        public void AddName(string name)
        {
            if(names.Count < 40)
            {
                this.names.Add(name);
            }
        }
        public IReadOnlyCollection<string> Names
        {
            get
            {
                return this.names.AsReadOnly();
            }
        }

    }
}
