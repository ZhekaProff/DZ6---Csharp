// Показать двумерный массив размером m×n заполненный вещественными числами

void FellDouble(double [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().NextDouble(); // Заполняем  числами
        }
    
    }
}


void PrintMatrix(double [,] matrix) // функция печати матрицы
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

//
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double [m, n];

FellDouble(matrix);
PrintMatrix(matrix);