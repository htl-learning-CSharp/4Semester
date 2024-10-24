namespace _01Methode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wähle eine Methode aus!");
            Console.WriteLine("<Sterne ausgeben (1)>  <GetMaxNumber (2)>  <Potenzieren (3)>  <SubString (4)>  <IndexOf (5)>");
            int decision = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (decision == 1)
            {
                //Methode1 Sterne ausgeben
                Console.WriteLine("Methode1 Sterne ausgeben");
                Console.WriteLine("Wie viele Sterne sollen ausgegeben werden: ");
                int starsNumber = Convert.ToInt32(Console.ReadLine());
                PrintStars(starsNumber);
                Console.WriteLine();
            }

            if (decision == 2)
            {
                //Methode2 GetMaxNumber
                Console.WriteLine("Methode2 GetMaxNumber");
                Console.WriteLine("Gebe Zahl1 ein: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gebe Zahl2 ein: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Die größte Zahl: " + GetMaxNumber(number1, number2));
                Console.WriteLine();
            }

            if (decision == 3)
            {
                //Methode3 Potenzieren
                Console.WriteLine("Methode3 Potenzieren");
                Console.WriteLine("Gebe Zahl1 ein: ");
                int basis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gebe Zahl2 ein: ");
                int potenz = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Potenz: {0:f2}", Potenzieren(basis, potenz));
                Console.WriteLine();
            }

            if (decision == 4)
            {
                //Methode4 SubString
                Console.WriteLine("Methode4 Substring");
                Console.Write("Geben sie einen Text ein: ");
                string text = Console.ReadLine()!;
                Console.Write("Ab welcher Position soll begonnen werden: ");
                int startPosition = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wie viele Zeichen?: ");
                int characterCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Teil vom Text: " + SubString(text, startPosition, characterCount));
                Console.WriteLine();
            }

            if (decision == 5)
            {
                // Methode5 IndexOf
                Console.WriteLine("Methode5 IndexOf");
                Console.Write("Gebe den String1 ein: ");
                string string1 = Console.ReadLine()!;
                Console.Write("Geben den gesuchten String ein: ");
                string searchString1 = Console.ReadLine()!;
                Console.WriteLine(IndexOf(searchString1, string1));
            }

            static void PrintStars(int starsNumber)
            {
                for (int i = 0; i < starsNumber; i++)
                {
                    Console.Write("*");
                }
            }

            static int GetMaxNumber(int number1, int number2)
            {
                if (number1 > number2)
                {
                    return number1;
                }
                else
                {
                    return number2;
                }
            }

            static double Potenzieren(int basis, int potenz)
            {
                double power = 1;

                for (int i = 0; i <= potenz; i++)
                {
                    power = power * (double)basis;
                }
                return power;
            }

            static string SubString(string text, int startPostion, int characterCount)
            {
                int count = 0;
                string partText = "";

                while (count <= characterCount)
                {
                    partText = partText + text[startPostion];
                    startPostion++;
                    count++;
                }
                return partText;
            }

            static int IndexOf(string searchString1, string string1)
            {
                int position = 0;
                int startPosition = -1;

                for (int i = 0; i < string1.Length; i++)
                {

                    if (string1[i] == searchString1[position])
                    {

                        if (position == 0)
                        {
                            startPosition = i;
                        }

                        if (position < searchString1.Length - 1)
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
                        startPosition = -1;
                    }

                }
                return startPosition;
            }

        }
    }
}