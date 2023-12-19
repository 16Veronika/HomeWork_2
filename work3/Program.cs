// 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 



 int[,] array = new int[3,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}
void FindRowWithMinSum()
    {
        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int currentSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minRow = i;
             }
             
        }
        Console.WriteLine($"Строка с индексом => {minRow}"); //return minRow;
    }




CreateArray();
PrintArray();
FindRowWithMinSum();
