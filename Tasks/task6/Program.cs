// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

void PrintIndexNumber(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == num)
            {
                Console.WriteLine($"[{i},{j}] = {num}");
            }
    }
}

bool isIndexNumber(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == num)
            {
                return true;
            }
    }
    return false;
}

int m = 7, n = 9;   //Размер массива
int minArrayElement = 0, maxArrayElement = 10;
int[,] array = new int[m, n];
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "5");

FillArray(array, minArrayElement, maxArrayElement);
PrintArray(array);

if (isIndexNumber(array, number))
{
    Console.WriteLine($"Число {number} имеет следующие индексы: ");
    PrintIndexNumber(array, number);
}
else Console.WriteLine($"Число {number} отсутствует.");