namespace NumberExtractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            char ch;
            Console.Write("Eingabe: ");
            text = Console.ReadLine();
            string digit = "";
            int num;
           

            for (int i = 0; i < text.Length; i++)
            {
               ch =  text[i];
                if (ch <= '9' && ch >= '0')
                {
                    digit += ch;
                }
            }

            Console.WriteLine(digit);
            num = Convert.ToInt32(digit);

            Console.WriteLine(num);

            Console.WriteLine($"Die enthaltene Zahl lautet {num}. Das Doppelte der Zahl lautet {num*2}");


        }
    }
}
