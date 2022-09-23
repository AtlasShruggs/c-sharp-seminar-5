int[] massiveRandomizer(int k, int min, int max)
    {
        int[] col = new int[k];
        for (int i = 0; i < k; i++)
        {
            col[i] = new Random().Next(min, max);
        }
        return col;
    }


Console.WriteLine("Введите номер задачи");
int exNum = int.Parse(Console.ReadLine());
if (exNum ==  34)
{
    

    Console.WriteLine("Введите размер генерируемого массива");
    try
    {
        int size = int.Parse(Console.ReadLine());
        int[] array = massiveRandomizer(size, 100, 1000);

        int evens = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            if (array[i] % 2 == 0) evens++;
        }
        Console.WriteLine($"Кол-во четных элементов: {evens}");
    }
    catch
    {
        Console.WriteLine("Введенные данные некорректны. Повторите попытку позже");
    }
}
else if (exNum == 36)
{
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine());

    int[] arrayTwo = massiveRandomizer(size, 1, 100);

    int summ = 0;
    for (int i = 0; i < arrayTwo.Length; i++)
    {   
        Console.Write(arrayTwo[i] + " ");
        if (i % 2 != 0)
        {
            summ += arrayTwo[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов с нечетным индексом: {summ}");
}

else if (exNum == 37)
{
    Console.WriteLine("Задайте элементы массивы (введите числа через пробел)");
    string[] str = Console.ReadLine().Split(" ");
    double[] array = new double[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = double.Parse(str[i].ToString());
    } 

    for(int i = 0, k = array.Length - 1; i < array.Length / 2; i++, k-=1)
    {
        Console.Write(array[i] * array[k] + " ");
    }
    if (array.Length % 2 != 0) Console.Write(array[array.Length / 2]);

}

else if (exNum == 38)
{
    Console.WriteLine("Задайте массив - введите значения через пробел");
    string[] str = Console.ReadLine().Split(" ");
    double[] array = new double[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = double.Parse(str[i].ToString());
    } 

    Console.WriteLine($"Максимальное значение массива: {array.Max()}");
    Console.WriteLine($"Минимальное значение массива: {array.Min()}");

}