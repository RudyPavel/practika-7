int[] GenerateArray(int length)
{
    int[] a = new int[length];

    Random rand = new Random();    

    for (int i = 0; i < length; i++)
    {
        a[i] = rand.Next(-100, 100);
    }

    return a;
}

Console.WriteLine("введите позиции элемента в двумерном массиве...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[][] matrix = new int[3][];

for (int i = 0; i < 3; i++)
{
    matrix[i] = GenerateArray(4);
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i][j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

if(m < 1 || n < 1 || m > 3 || n > 4)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine(matrix[m - 1][n - 1]);
}