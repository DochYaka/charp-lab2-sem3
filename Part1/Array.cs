using System.Linq;

public class Array
{
    public int SumFirstFiveItems { get; set; }

    public int[] array;

    public int Lenght => array.Length;

    public int this[int index]
    {
        get
        {
            if (index < 0 || index > array.Length) throw new IndexOutOfRangeException("Индекс вне диапазона массива");
            return array[index];
        }

        set
        {
            if (index < 0 || index > array.Length) throw new IndexOutOfRangeException("Индекс вне диапазона массива");
            array[index] = value;
        }
    }

    public Array(int size)
    {
        if (size <= 0) throw new ArgumentException("Размер массива должен быть положительным числом");

        array = new int[size];
    }

    public Array(int min, int max, int size)
    {
        if (size <= 0) throw new ArgumentException("Размер массива должен быть положительным числом");

        array = new int[size];

        Random rnd = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(min, max + 1);
        }
    }

    public static Array operator *(Array array1, Array array2)
    {
        Array res = new Array(array1.Lenght);

        for (int i = 0; i < array1.Lenght; i++)
        {
            res[i] = array1[i] * array2[i];
        }

        return res;
    }

    public static bool operator true(Array array)
    {
        return array.Lenght > 0 && array.HasPositiveElements();
    }

    public static bool operator false(Array array)
    {
        return array.Lenght == 0 || !array.HasPositiveElements();
    }

    public static explicit operator int(Array array)
    {
        return array.Lenght;
    }

    public static bool operator ==(Array array1, Array array2)
    {
        return array1.SumFirstFiveItems == array2.SumFirstFiveItems;
    }

    public static bool operator !=(Array array1, Array array2)
    {
        return array1.SumFirstFiveItems != array2.SumFirstFiveItems;
    }

    public static bool operator >(Array array1, Array array2)
    {
        return array1.SumFirstFiveItems > array2.SumFirstFiveItems;
    }

    public static bool operator <(Array array1, Array array2)
    {
        return array1.SumFirstFiveItems < array2.SumFirstFiveItems;
    }

    public int SumFirstFiveItemsArr()
    {
        var arr = 0;

        Console.WriteLine("\nЭлементы: ");

        for (int i = 0; i < 5; i++)
        {
            arr += array[i];
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("\nСумма: ");
        Console.WriteLine(arr);
        return arr;
    }

    public bool HasPositiveElements()
    {
        bool tr = true;

        foreach (int i in array)
        {
            if (i > 0)
            {
                tr = true;
                continue;
            }
            else
            {
                tr = false;
                break;
            }
        }
        return tr;
    }

    public void AddItem(int item)
    {
        array.Append(item);
    }

    public void ReplaceItem(int index, int newItem)
    {
        if (index < 0 || index >= Lenght) throw new IndexOutOfRangeException("Индекс вне диапазона");

        array[index] = newItem;
    }

    public void PrintAll()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }
    }

    public void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }
    }
    
}