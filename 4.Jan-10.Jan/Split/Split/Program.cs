namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text;
            string trenn;
            char leer = ' ';

            Console.Write("Text: ");
            text = Console.ReadLine();
            Console.Write("Trennzeichen: ");
            trenn = Console.ReadLine();
            

            if(trenn.Length == 1)
            {
                 leer = trenn[0];
            }
            

            Console.WriteLine();
            Console.WriteLine("Textteile: ");

            for (int i = 0; i < text.Length; i++)
            {
                 char c = text[i];
              
                if (c == leer)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
