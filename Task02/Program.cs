// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintMatrix(int [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
PrintMatrix(matrix);
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);