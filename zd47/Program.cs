float[] GenerateArray(int length)
{
    float[] a = new float[length];

    Random rand = new Random();    

    for (int i = 0; i < length; i++)
    {        
        int sample = rand.Next(-100, 100);
        a[i] = (float)sample / 10;
    }

    return a;
}

Console.WriteLine("введите M x N для массива...");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

float[][] matrix = new float[m][];

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