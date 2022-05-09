Console.WriteLine();
Console.WriteLine("Итоговая проверочная работа!");
Console.WriteLine("Задача. Из имеющегося массива строк сформировать новый из элементов длинна которых меннее 3х символов");
Console.WriteLine();

string[] array=new string[] {"Hello", "2", "world", ":D", "1234", "1567", "-2", "3x"};
int j=0, lenArray=0;

for (int i=0; i<array.GetLength(0); i++) // Определяем кол-во элементов с длинной меньше 3х символов и заодно длинну итогового массива
    {
        if (array[i].Length<4) lenArray++;
        Console.Write($"[{array[i]}]  ");
    }
Console.WriteLine("         <<<<< Исходный массив");
Console.WriteLine();

string[] secondArray=new string[lenArray];
for (int i=0; i<array.GetLength(0); i++) // Заполняем итоговый массив
    {
        if (array[i].Length<4) 
        {
            secondArray[0+j]=array[i];
            j++;
        }
    }

for (int i=0; i<secondArray.GetLength(0); i++) // Вывод итогового массива на экран
{
    Console.Write($"[{secondArray[i]}]  ");
}
Console.WriteLine("         <<<<< Итоговый массив");