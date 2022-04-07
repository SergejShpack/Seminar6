// В двумерном массиве n×k заменить четные элементы на противоположные

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

void ChangeSignEvenNumberArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] % 2 == 0) arr[i, j] = -arr[i, j];
    }

}


int m = 7, n = 9;   //Размер массива
int minArrayElement = 10, maxArrayElement = 99;
int[,] array = new int[m, n];
FillArray(array, minArrayElement, maxArrayElement);
PrintArray(array);
ChangeSignEvenNumberArray(array);
PrintArray(array);