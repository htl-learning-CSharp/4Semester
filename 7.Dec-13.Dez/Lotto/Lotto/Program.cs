namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tipp = new int[5];
            Random randomTipp = new Random();
            int[] random = new int[5];
            int myTipp;
            int counter;
            int richtig = 0;


            for (int i = 0; i < tipp.Length; i++)
            {
                Console.Write($"LottoTipp{i + 1}: ");
                myTipp = Convert.ToInt32(Console.ReadLine());
                if (myTipp < 0 || myTipp > 45)
                {
                    Console.Write($"AGAIN:LottoTipp{i + 1}: ");
                    myTipp = Convert.ToInt32(Console.ReadLine());
                }
                tipp[i] = myTipp;
            }
            Console.Write("Wie viele Ziehungen sollen simuliert werden? : ");
            counter = Convert.ToInt32(Console.ReadLine());

            int[] countRight = new int[counter];



            //simulation
            for (int c = 0; c < counter; c++)
            {

                Console.Write($"Ziehung Nr.{c + 1}:      ");

                for (int i = 0; i < random.Length; i++)
                {
                    random[i] = randomTipp.Next(1, 46);

                    Console.Write($"{random[i],-5}");

                    for (int k = 0; k < tipp.Length; k++)
                    {

                        if (random[i] == tipp[k])
                        {
                            richtig++;
                        }
                    }

                }



                Console.WriteLine($"Ergebnis: {richtig} Richtige");
                countRight[c] = richtig;



            }

            int wieViele = 0;

            Console.WriteLine("Gesamtergebnis");

            for (int i = 0; i < counter; i++)
            {
                if (countRight[i] == i)
                {
                    wieViele++;
                }
                Console.WriteLine($"{i}. Richtige: {wieViele}");
            }

        }
    }
}
