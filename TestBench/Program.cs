using System;
using NameGeneratorLib;

namespace TestBench
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**FULL NAMES");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(NameGen.GetName(NameGen.NAME_OPTION.FULL_NAME, NameGen.NAME_GENDER.OTHER));
            }

            Console.WriteLine("\n**MALE FIRST NAMES");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(NameGen.GetName(NameGen.NAME_OPTION.FIRST_NAME, NameGen.NAME_GENDER.MALE));
            }

            Console.WriteLine("\n**FEMALE FIRST NAMES");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(NameGen.GetName(NameGen.NAME_OPTION.FIRST_NAME, NameGen.NAME_GENDER.FEMALE));
            }

            Console.WriteLine("\n**SURNAMES NAMES");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(NameGen.GetName(NameGen.NAME_OPTION.SURNAME, NameGen.NAME_GENDER.MALE));
            }
        }
    }
}
