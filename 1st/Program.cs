//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine(GetArrayAsString(GetArray(15,100,999)));
Console.WriteLine(Voleven(GetArray(15,100,999)));

int[] GetArray(int length, int minValue, int maxValue) //Создаёт массив
{
	int[] array = new int[length];
	Random random = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue);
	}
	return array;
}

string GetArrayAsString(int[] array) // Переводит массив в строку
{
	string s = string.Empty;
	foreach (var item in array)
	{
		s += $"{item}, ";
	}
	return s;
}

int Voleven(int[] array)
{
int vol = 0;
for(int i = 0; i < array.Length; i++)
  { 
    if (array[i] % 2 == 0 )
    {
        vol++;
    }
  } 
  return vol;
}