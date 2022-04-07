// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
            
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if ((i % 2 == 0) && (j % 2 == 0)) arr[i, j] = arr[i, j] * arr[i, j];
    }

}

int m = 6, n = 8;   //Размер массива
int minArrayElement = 10, maxArrayElement = 99;
int[,] array = new int[m, n];
FillArray(array, minArrayElement, maxArrayElement);
PrintArray(array);
ChangeArray(array);
PrintArray(array);