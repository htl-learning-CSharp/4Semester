using System.Diagnostics.Metrics;

namespace Dublettensuche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int counter = 0;

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name Nr. {i} eingeben: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\n Eingegebene Namen: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n Folgende Namen wurden mehrfach eingegeben:");

            for (int i = 0; i < names.Length; i++)
            {
                for (int k = i + 1; k < names.Length; k++) // dot wo wir sind, wollen wir nicht von oben wieder kontrollieren,
                                                           // da sie schon vergliechen worden sind
                {
                    if (names[i] == names[k])
                    {

                        Console.WriteLine(names[i]);
                        counter++;
                    }
                }
            }
        }
    }
}
}
