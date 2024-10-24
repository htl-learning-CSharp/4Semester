namespace Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int method;
            Console.Write("Welche Methode willst du ausführen: ");
            method = Convert.ToInt32(Console.ReadLine());

            if (method == 1)
            {
                Console.WriteLine("1. Wie viele Sterne: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Sterne(s);
            }
            if (method == 2)
            {
                Console.Write("Zahl 1.: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zahl 2.: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"MaxNum ist {GetMaxNumber(a, b)}");

            }
            if (method == 3)
            {
                Console.Write("Exponent: ");
                int expo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Potenz: ");
                int potenz = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ergebnis ist {Potenzieren(expo, potenz)}");
            }
            if (method == 4)
            {
                Console.Write("SubString: ");
                string text = Console.ReadLine();
                Console.Write("Start: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("End: ");
                int end = Convert.ToInt32(Console.ReadLine());
                SubString(start, end, text);
            }
            if(method == 5){
                Console.Write("IndexOf: ");
                string myText = Console.ReadLine();
                Console.Write("Gessuchter String: ");
                string gesucht = Console.ReadLine();
                Console.WriteLine( IndexOf(myText, gesucht));
            }

        }



        static int IndexOf(string t, string g)
        {
            int position = 0;
            int startpos = -1;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == g[position])
                {
                    if (position == 0)
                    {
                        startpos = i;
                    }
                    if(position < g.Length - 1)
                    {
                        position++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    position = 0;
                    startpos = -1;
                }
            }
            return startpos;
        }

        static string SubString(int s, int e, string t)
        {
            for (int i = s; i <= e; i++)
            {
                 Console.WriteLine(t[i]);
            }
            return t;
        }

        static double Potenzieren(int e, int p)
        {

            return Math.Pow(e, p);

        }

        static int GetMaxNumber(int a, int b)
        {
            int maxNum;
            if (a > b)
            {
                maxNum = a;
            }
            else
            {
                maxNum = b;
            }
            return maxNum;
        }

        static void Sterne(int s)
        {
            for (int i = 0; i < s; i++)
            {
                Console.Write("*");
            }
        }



    }
}
