int[] array = { 15, 27, 33, 42, 55, 69, 71, 83, 55, 90 };
int n = array.Length;                                   // присваиваем кол-во элементов массива
int find = 55;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Индекс: " + index);
        Console.WriteLine("Число в нем: " + array[index]);
        break;                          // прервать выполнение (найдено первое совпадение)
    }
    index++;            // index = index + 1
}