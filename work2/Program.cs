// 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива
// 4 3 1      4 6 2
// 2 6 9  =>  2 6 9
// 4 6 2      4 3 1



int[,] array = new int[5,5];

void CreateArray()                                      //Заполняем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10,20);
        }
          Console.WriteLine();                    //
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)           //
    {
        for (int j = 0; j < array.GetLength(1); j++)                
        {
            Console.Write(array[i, j] + " ");               
        }
         Console.WriteLine();                       //Выводим массив
    }
}
void ChangeLinesArray()
{
        int tmp = 0;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < array.GetLength(1); i++)
        {
            tmp = array[rows - 1, i];
            array[rows - 1, i] = array[0, i];
            array[0, i] = tmp;
        }
           Console.WriteLine();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
           Console.WriteLine();
        }
      
    }


CreateArray();
PrintArray();  
ChangeLinesArray();
