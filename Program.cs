namespace _5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            ReturnDigits(1234);
            Console.WriteLine();
            ReturnDigits(4321);
            Console.WriteLine();
            Console.WriteLine();
            //2
            int[,] matrix = new int[,]{ {1, 2 },
                                        {3, 4 } };

            int[,] randomMatrix = MatrixInitializer(3);
            DisplayMatrix(randomMatrix);

            Console.WriteLine(SumDiagonal(randomMatrix)); 
        }
        public static void ReturnDigits(int n)
        {
            //base case
            //if single digit then print
            if (n < 10) 
            {
                Console.Write($"{n} ");
                return;
            }

            //truncates num until base case
            ReturnDigits(n / 10);
            Console.Write($"{n % 10} ");
        }

        //2 O(n)
        public static int SumDiagonal(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int sum = 0;

            //(1,1) ,(2,2), (3,3) etc..
            for (int i = 0; i < row ; i++)
            {
                sum = sum + matrix[i, i];
            }
            return sum;
        }


        //helper
        public static int[,] MatrixInitializer(int size) 
        {
            int[,] matrix = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) ; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
