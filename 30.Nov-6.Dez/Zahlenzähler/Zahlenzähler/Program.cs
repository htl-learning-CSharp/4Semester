namespace Zahlenzähler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] numbers = new int[100];
            int count = 0;
            int counter = 0;


            do
            {
                Console.Write($"Geben Sie bitte die {count}. Zahl ein <-1 für Ende>: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number != -1)
                {

                    numbers[count] = number;
                    count++;
                }


            } while (number != -1 && count < 100);


            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < count; i++) // bis coutn weeil wir ja ganu nur so viel ezahlen haben unf nciht 100.
                {
                    if (k == numbers[i])
                    {
                        counter++;
                    }

                }
                Console.WriteLine($"Die Zahl {k} gibt es {counter}x.");
                counter = 0;
            }
        }
    }

}
