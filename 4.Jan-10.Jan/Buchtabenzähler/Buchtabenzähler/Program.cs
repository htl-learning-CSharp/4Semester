namespace Buchtabenzähler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            int[] count = new int[26];
            char ch;

            Console.Write("Eingabetext: ");
            text = Console.ReadLine();

            Console.WriteLine("Anzahl der Buchstaben");

            //jeder index soll in c als großbuchtsabe stehen
            //jeder c wird in einem char gespeichert und diese erhöht den index der jeweiligen stelle
           foreach(char c in text)
            {
                char textGross = Char.ToUpper(c);

                if(textGross >= 'A' && textGross <= 'Z')
                {
                    count[textGross - 'A']++; // wert wird minus 67 gerechnet, und and der stelle wird sie erhöht
                    //H -A = 7
                }
            }

           //A bis M wird durchgegangen
           //es wird die entsprechende buchstabe calculiert
           //strings bekommen einen output
           //in dem if wird ab N weiter gerechent
           //am ende werden beide strings nebeneinander ausgegeben
           for(int i = 0; i < 13; i++)
            {
                char buchstabe = (char)(i + 'A'); //0 + A = A //5+A= E, weil char
                string atob = $"{buchstabe}: {count[i]:D3}";
                string ntoz = "";

                if (i+13 <= 26)
                {
                    char buchstaberechts = (char)((i +13)+ 'A'); //0 + A = A //5+A= E, weil char
                    ntoz = $"{buchstaberechts}: {count[i+13]:D3}";

                }
                Console.WriteLine($"{atob, -20} {ntoz}");
            }

        }
    }
}
