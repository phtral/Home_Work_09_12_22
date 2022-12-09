//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = {1.5, 2.9, 3.8, 12.5, 2.1};
double Max(double[] array)
{  
   double max = 0;
   for(int i = 0; i < array.Length; i++)
   { 
     if(max < array[i])
     {
        max = array[i];
     }
   }
   return max;
}

double Min(double[] array)
{  int i = 0;
   double min = array[i];
   for(i = 1; i < array.Length; i++)
   { 
     if(min > array[i])
     {
        min = array[i];
     }
   }
   return min;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом составляет {Max(array)-Min(array)}");