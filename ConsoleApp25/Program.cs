int[,] matrix = new int[4, 4];
int number = 1;

for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    {
        matrix[row, col] = number;
        number++;
    }
}

Console.WriteLine("Matrix 4x4:");
for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    {
        Console.Write($"{matrix[row, col],3} ");
    }
    Console.WriteLine();
}
