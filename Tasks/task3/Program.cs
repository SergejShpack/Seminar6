// Показать двумерный массив размером m×n заполненный целыми числами

void FillArray(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(startEl, endEl + 1);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int m = 7, n = 9;    //Размер массива.
int minArrayElement = 10, maxArrayElement = 99;
int[,] array = new int[m, n];
FillArray(array, minArrayElement, maxArrayElement);
PrintArray(array);