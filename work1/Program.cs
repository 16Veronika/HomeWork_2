// 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
//  
//  4 3 1     (1,2) => 9  
//  2 6 9 





int[,] array = new int[6,3];
Console.Write("Введите номер строки: ");
 int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int rowCount = array.GetLength(0);  
int columnCount = array.GetLength(1);


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

//int rowCount = array.GetLength(0);       Где правильнее, здесь или вначале?
//int columnCount = array.GetLength(1);   
void FindElementArray()
{
    
            if (row >= 0 && row < rowCount && column >= 0 && column < columnCount)
              {
               int elementValue = array[row, column];
               Console.WriteLine($"Значение элемента в позиции ({row}, {column})=> {elementValue}");
              }
            else
              {
                Console.WriteLine($" ({row}, {column}) => элемент отсутствует.");
              }
}
        System.Console.WriteLine();
    
CreateArray();
PrintArray();
FindElementArray();
