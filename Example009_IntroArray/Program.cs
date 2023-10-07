int[] array = { 15, 27, 33, 42, 55, 69, 71, 83, 90 };


int Max(int arg1, int arg2, int arg3)  // функция Max с аргументами arg1 arg2 arg3
{
    int result = arg1;                  // тело функции - производимые действия
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int max = Max(                      // Вариант при небольшом кол-ве вх.данных. Вызов действия из функции Max, внутри аргумента передана функция Max
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);