namespace PrimzahlenSieb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count;

            Console.Write("Bis zu welcher Zahl wollen sie Primzahlen ausgeben? "); //Teiler, 1, sich selbst
            num = Convert.ToInt32(Console.ReadLine());

            //bool erstellen
            bool[] isPrime = new bool[num + 1]; 

            //alle zahlen werden auf true gesetzt
            for (int i = 0; i <= num; i++)
            {
                isPrime[i] = true;
            }

            //stelle 0, 1- also zahl: 0,1 sind aut. false
            isPrime[0] = false;
            isPrime[1] = false;

            //6
            for (int k = 2; k* k <= num ; k++)
            {
                if (isPrime[k])
                {
                    for (int i =  k*k; i <= num ; i+= k)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int k = 2; k <= num; k++) 
            {
                if (isPrime[k])
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
