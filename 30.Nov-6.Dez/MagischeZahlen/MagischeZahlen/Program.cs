namespace MagischeZahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int originalNum = i;  // Die Originalzahl wird gespeichert
                int magicNum = 0;

                // Ziffern extrahieren und Potenzen berechnen
                while (originalNum > 0)
                {
                    int digit = originalNum % 10;  // Letzte Ziffer extrahieren
                    magicNum += digit * digit * digit;  // Potenz berechnen und hinzufügen
                    originalNum /= 10;  // Zur nächsten Ziffer übergehen
                }

                // Wenn die Summe der dritten Potenzen gleich der Zahl ist
                if (magicNum == i)
                {
                    Console.WriteLine($"Eine magische Zahl lautet: {i}");
                }
            }
        }

    }
}


