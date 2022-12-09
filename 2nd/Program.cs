//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array =  {18, 52, 89, 66, 75, 57, 98, 79, 55};

int SumOddPosition(int[] array)
{ int sum = 0;
for(int i = 0; i < array.Length; i++)
 {  if(i % 2 != 0 && i > 0)
    {
      sum = sum + array[i];
    }
 }
return sum;
}

Console.WriteLine(SumOddPosition(array));