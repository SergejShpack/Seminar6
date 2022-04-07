// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.NextDouble() + rnd.Next(startEl, endEl);
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            
            Console.Write(String.Format("{0,20}", arr[i, j]));

        Console.WriteLine();
    }
    Console.WriteLine();
}


int m = 7, n = 9;   //Размер массива.
int minArrayElement = 10, maxArrayElement = 99;
double[,] array = new double[m, n];
FillArray(array, minArrayElement, maxArrayElement);
PrintArray(array);