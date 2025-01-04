namespace CSharpDSA.DataStructures
{
    public static class ArrayExample
    {
        static ArrayExample()
        {
            Console.WriteLine("Welcome to Array Section");
        }
        public static void Run()
        {
            Console.WriteLine("Press Program No...[Press1 for normal array implementation]");
            int program = int.Parse(Console.ReadLine());
            switch (program)
            {
                case 1:
                    A1_NormalArray();
                    break;
                case 2:
                    A2_MultiDimentionalArray();
                    break;
                case 3:
                    A3_JaggedArray();
                    break;

            }
        }

        private static void A1_NormalArray()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Elements are:");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        private static void A2_MultiDimentionalArray()
        {
            int[,] twoDArray = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine("Array Elements are:");

            for (int row = 0; row < twoDArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDArray.GetLength(1); col++)
                {
                    Console.Write(twoDArray[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static void A3_JaggedArray()
        {
            int[][] jaggedArray =
            [
               [1, 2],
               [3, 4],
               [5, 6]
            ];

            foreach (var row in jaggedArray)
            {
                foreach (var col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}