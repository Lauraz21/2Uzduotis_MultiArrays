namespace _2Uzduotis_MultiArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {{ 2, 3, 5 },
                            { 5, 9, 6 },
                            { 10, 3, 6 }};
            MatchIntegers(array);
        }
        public static void MatchIntegers(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int current = matrix[i, j];
                    int nextColIndex = j + 1;

                    for (int k = i; k < matrix.GetLength(0); k++)
                    {
                        for (int l = nextColIndex; l < matrix.GetLength(1); l++)
                        {
                            if (current == matrix[k, l])
                            {
                                Console.WriteLine(matrix[k, l]);
                            }
                        }
                        nextColIndex = 0;
                    }
                }
        }
    }
}