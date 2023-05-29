
int n = 5;
int[,] a = new int[,]
{
               {0, 1, 1, 0, 0},
               {0, 0, 0, 1, 0},
               {0, 1, 0, 0, 1},
               {0, 0, 1, 0, 0},
               {0, 0, 0, 1, 0}
};

for (int k = 0; k < n; k++)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a[i, k] == a[k, j])
            {
                a[i, j] = 1;
            }
        }
    }
}
Console.Write("Матрица достижимости:\n");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j]);
    }
    Console.WriteLine();
}
