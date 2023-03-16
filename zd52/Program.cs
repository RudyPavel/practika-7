int[] GenerateArray(int length)
{
    int[] a = new int[length];

    Random rand = new Random();    

    for (int i = 0; i < length; i++)
    {
        a[i] = rand.Next(0, 20);
    }

    return a;
}

Console.WriteLine("введите M x N для массива...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[][] matrix = new int[m][];

for (int i = 0; i < m; i++)
{
    matrix[i] = GenerateArray(n);
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i][j]} ");
    }
    Console.WriteLine();
}

float[] median = new float[n];

for (int i = 0; i < n; i++)
{
    int med = 0;

    for (int j = 0; j < m; j++)
    {
        med += matrix[j][i];
    }
    
    median[i] = (float)med / m;
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.Write(median[i].ToString("0.0"));
    Console.Write(" ");
}