// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillMatrix( int[,] matrix)
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(1,10); // Заполняем рандомными числами
        }
    
    }


}

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

void ReplacementMatrix(int [,] matrix) // функция замены чисел
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            if ( (i % 2 == 0) && (j % 2 == 0))
              matrix[i, j] = matrix[i, j] * matrix[i, j];  
        }
    
    }
}
//============================Решение================================
Console.Clear();
Console.Write("Введите колличество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите колличество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];

Console.WriteLine("Вводный массив:");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Измененный массив:");
ReplacementMatrix(matrix);
PrintMatrix(matrix);
