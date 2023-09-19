// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] array = new int[n, n];

        int value = 1;
        int row = 0;
        int col = 0;

        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        string direction = "right";

        while (value <= n * n)
        {
            array[row, col] = value;

            if (direction == "right")
            {
                if (col == right)
                {
                    direction = "down";
                    top++;
                    row++;
                }
                else
                {
                    col++;
                }
            }
            else if (direction == "down")
            {
                if (row == bottom)
                {
                    direction = "left";
                    right--;
                    col--;
                }
                else
                {
                    row++;
                }
            }
            else if (direction == "left")
            {
                if (col == left)
                {
                    direction = "up";
                    bottom--;
                    row--;
                }
                else
                {
                    col--;
                }
            }
            else if (direction == "up")
            {
                if (row == top)
                {
                    direction = "right";
                    left++;
                    col++;
                }
                else
                {
                    row--;
                }
            }

            value++;
        }

        Console.WriteLine("Результат:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}