// // /Задание 2. Задайте двумерный массив. 
// // Напишите программу, которая заменяет строки 
// // на столбцы. В случае, если это невозможно, 
// // программа должна вывести сообщение для
// //  пользователя.

// //Например, задан массив:

// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //5 2 6 7

// //В итоге получается вот такой массив:

// //1 5 8 5
// //4 9 4 2
// //7 2 2 6
// //2 3 4 7

// int[,] RowsToColumns(int[,] array)
// {
//    if (array.GetLength(0) != array.GetLength(1))
//    {
//       System.Console.WriteLine("Invalid input");
//       return array;
//    }
//    else
//    {
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//          for (int j = i + 1; j < array.GetLength(1); j++)
//          {
//             int tmp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = tmp;
//          }
//       }
//    }
//    return array;
// }
// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine();
//    }
// }
// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//    int[,] array = new int[rows, colums];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < colums; j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// Console.WriteLine("Inpyt rows - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt colums - ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt minValue - ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt maxValue - ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(array);
// RowsToColumns(array);
// Console.WriteLine();
// Print2DArray(array);

//Задание 3. Из двумерного массива целых чисел удалить строку
//и столбец, на пересечении которых расположен наименьший элемент.
// то есть зануляем и строку и столбец в которой находится этот
//элемент
//Задание 1. Задайте двумерный массив. Напишите программу, которая 
//поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

void Print2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
   }
}
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
   int[,] array = new int[rows, colums];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < colums; j++)
      {
         array[i, j] = new Random().Next(minValue, maxValue);
      }
   }
   return array;
}
int[,] MinValueArray(int[,] array)
{
   int minRow = 0;
   int minColums = 0;
   // int minValue = array[0, 0];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] < array[minRow, minColums])
         {
            minRow = i;
            minColums = j;
         }
      }
   }

   for (int i = 0; i < array.GetLength(0); i++)
   {
      array[i, minRow] = 0;
   }

   for (int i = 0; i < array.GetLength(1); i++)
   {
      array[minColums, i] = 0;
   }
   return array;
}

int[,] RowsToColums(int[,] array)
{
   int tmp = 0;

   for (int j = 0; j < array.GetLength(1); j++)
   {
      tmp = array[0, j];
      array[0, j] = array[array.GetLength(0) - 1, j];
      array[array.GetLength(0) - 1, j] = tmp;
   }

   return array;
}

Console.WriteLine("Inpyt rows - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt colums - ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt minValue - ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt maxValue - ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
Print2DArray(array);

// MinValueArray(array);
Console.WriteLine();
Print2DArray(array);

Console.WriteLine();
array = RowsToColums(array);
Print2DArray(array);