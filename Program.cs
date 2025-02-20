using System;
using System.Linq;

interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class Array : ICalc, IOutput2, ICalc2
{
    private int[] data;

    public Array(int[] data)
    {
        this.data = data;
    }

    public int Less(int valueToCompare)
    {
        return data.Count(x => x < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return data.Count(x => x > valueToCompare);
    }

    public void ShowEven()
    {
        Console.WriteLine("Even numbers: " + string.Join(", ", data.Where(x => x % 2 == 0)));
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers: " + string.Join(", ", data.Where(x => x % 2 != 0)));
    }


    public int CountDistinct()
    {
        return data.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return data.Count(x => x == valueToCompare);
    }
}


class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 3, 2, 5, 7 };
        Array array = new Array(numbers);

        Console.WriteLine("Less than 4: " + array.Less(4));
        Console.WriteLine("Greater than 4: " + array.Greater(4));

        array.ShowEven();
        array.ShowOdd();

        Console.WriteLine("Distinct count: " + array.CountDistinct());
        Console.WriteLine("Equal to 3: " + array.EqualToValue(3));

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
