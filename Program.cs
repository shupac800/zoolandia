using System;

namespace zoolandia
{
    class Zoolandia
    {
        static void Main(string[] args)
        {
            Animal firstAnimal = new Animal(args[0]);
            firstAnimal.species = new TenoderaAngustipennis();

            Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species.commonName);
        }
    }

}

