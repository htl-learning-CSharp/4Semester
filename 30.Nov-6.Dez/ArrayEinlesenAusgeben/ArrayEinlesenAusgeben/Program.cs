namespace ArrayEinlesenAusgeben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int place;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i+1}. Zahl eingeben: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Die wievielte Zahl wollen Sie ausgeben <e für Ende>? ");
            place = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Die Zahal lautet: {numbers[place-1]}");
        }
    }
}
