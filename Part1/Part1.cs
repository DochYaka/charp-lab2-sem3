public class Part1
{
    public void part1()
    {
        Array arr1 = new Array(-50, 50, 20);
        Array arr2 = new Array(50, 100, 20);

        Console.WriteLine("Определение операции умножения");

        Array array3 = arr1 * arr2;


        Console.WriteLine("\nПервый массив");
        arr1.PrintAll();

        Console.WriteLine("\nВторой массив");
        arr2.PrintAll();

        Console.WriteLine("\nМассив после умножения");
        array3.Print();


        Console.WriteLine("\nОпределение операций true и false");

        Console.WriteLine("\nВ первом массиве всегда есть отрицательные элементы -> false");
        TestArray(arr1);

        Console.WriteLine("\nВо втором массиве всегда положительные элементы -> true");
        TestArray(arr2);

        Console.WriteLine("\nДобавим отрицательный элемент -> false");

        arr2.ReplaceItem(10, -1111);
        TestArray(arr2);


        Console.WriteLine("\nInt возвращает размер массива");

        int arr = (int)arr1;
        Console.WriteLine($"Размер массива: {arr}");


        Console.WriteLine("\n>< проверка сравнения");

        TestSortArray(arr1, arr2);


        Console.WriteLine("\n== проверка на равенство");

        TestEqualArray(arr1, arr2);

        Console.WriteLine("\nЗамена значений для проверки");

        arr1.ReplaceItem(0, 100);
        arr1.ReplaceItem(1, 100);
        arr1.ReplaceItem(2, 100);
        arr1.ReplaceItem(3, 100);
        arr1.ReplaceItem(4, 100);

        arr2.ReplaceItem(0, 100);
        arr2.ReplaceItem(1, 100);
        arr2.ReplaceItem(2, 100);
        arr2.ReplaceItem(3, 100);
        arr2.ReplaceItem(4, 100);

        TestEqualArray(arr1, arr2);


        Console.WriteLine("\nПроверка метода расширения для удаления всех отрицательных чисел");

        int[] arrs = { -1, -2131, 20, 2131, 0, -321 };

        Console.WriteLine("\nМассив без отрицательных:");
        TestArrWithoutNegative(arrs);


        Console.WriteLine("\nПроверка метода расширения для нахождения определённого символа в строке");

        string testString1 = "Helao, World!";
        string testString2 = "NoSpecialChars";
        string testString3 = "Hello123!";

        TestString(testString1);
        TestString(testString2);
        TestString(testString3);
}

static void TestString(string str)
{
    Console.WriteLine($"Содержит 'a': {str.ContainsChar('a')}");
} 

static void TestArrWithoutNegative(int[] array)
{
    var newarr = array.RemoveNegatives();
    foreach (var item in newarr)
    {
        Console.WriteLine(item);
    }
}

static void TestArray(Array array)
{
    if (array)
    {
        Console.WriteLine("В массиве все положительные элементы!");
        array.PrintAll();
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine("В массиве содерится отрицательный/ые элемент/ы!");
        array.PrintAll();
        Console.WriteLine(false);
    }
}

static void TestEqualArray(Array array1, Array array2)
{
    int SumArray1 = array1.SumFirstFiveItemsArr();
    int SumArray2 = array2.SumFirstFiveItemsArr();

    bool result = SumArray1 == SumArray2;

    if (result)
    {
        Console.WriteLine($"{SumArray1} == {SumArray2}");
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine($"{SumArray1} != {SumArray2}");
        Console.WriteLine(result);
    }
}

static void TestSortArray(Array array1, Array array2)
{
    int SumArray1 = array1.SumFirstFiveItemsArr();
    int SumArray2 = array2.SumFirstFiveItemsArr();

    bool result = SumArray1 > SumArray2;

        if (result)
        {
            Console.WriteLine($"{SumArray1} > {SumArray2}");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"{SumArray1} < {SumArray2}");
            Console.WriteLine(result);
        }
    
    }

}