// Создаем метод (функцию) заполнения массива случайными числами
void FillArray(int[] collection)    // void - метод, который ничего не возвращает. FillArray - название метода, collection - название аргумента
{
    int length = collection.Length;  // получаем длину массива из int[] array = new int[10];
    int index = 0;                   // задаем начальную позицию в массиве
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);      //положить в collection[index] новое случайное целое число из диапазона 1-10
        index++;
    }
}

// Создаем метод (функцию) вывода массива на печать
void PrintArray(int[] col)
{
    int count = col.Length;     // получаем длину массива из int[] array = new int[10];
    int position = 0;           // задаем начальную позицию в массиве
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];      //создать новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
