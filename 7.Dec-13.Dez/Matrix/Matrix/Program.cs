using System.Collections.Concurrent;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[9, 9];
            Random random = new Random();

            //GetLentgh weil, mehrdim. Array
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int k = 0; k < matrix.GetLength(1); k++)
                {

                    matrix[i, k] = random.Next(1, 10);
                }
            }

            /*
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int k = 0; k < matrix.GetLength(1); k++)
                            {
                                Console.Write(matrix[i, k]);
                                if (k < matrix.GetLength(1) - 1)
                                {
                                    if (matrix[i, k] == matrix[i, k + 1])
                                    {
                                        Console.Write(" = ");
                                    }
                                    else if (matrix[i, k] > matrix[i, k + 1])
                                    {
                                        Console.Write(" > ");
                                    }
                                    else if (matrix[i, k] < matrix[i, k + 1])
                                    {
                                        Console.Write(" < ");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }

                        */
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]);
                    if (k < matrix.GetLength(1) - 1)
                    {
                        if (matrix[i, k] == matrix[i, k + 1])
                        {
                            Console.Write(" = ");
                        }
                        else if (matrix[i, k] > matrix[i, k + 1])
                        {
                            Console.Write(" > ");
                        }
                        else if (matrix[i, k] < matrix[i, k + 1])
                        {
                            Console.Write(" < ");
                        }
                    }
                }
                Console.WriteLine();
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int s = 0; s < matrix.GetLength(1)-1; s++)
                    {
                        if (i > 0)
                        {
                            if (matrix[r, s] == matrix[r, s+1])
                            {
                                Console.Write("=   ");
                            }
                            else if (matrix[r, s] > matrix[r, s + 1])
                            {
                                Console.Write("V   ");
                            }
                            else if (matrix[r, s] < matrix[r, s + 1])
                            {
                                Console.Write("A   ");
                            }
                        }

                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

