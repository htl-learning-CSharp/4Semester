namespace BigInt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Gebe eine Zahl ein: ");
            string input = Console.ReadLine();

            ReadBigNumber(input);

        }

        static int ReadBigNumber(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] <= 'A' || input[i] >= 'Z')
                {
                    Console.WriteLine("falsch");
                }
                else
                {
                   for (int j = 0; j < input.Length; j++)
                    {
                       result += Convert.ToInt32(input[j]);
                    }
                }
            
            }
            return result;
        }
    }
}
