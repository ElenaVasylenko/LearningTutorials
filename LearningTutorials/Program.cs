using LearningTutorials.dataTypes;

public class Program
{
    static void Swap(ref int x, ref int y)
    {
        x = 5;
        int temp = x;
        x = y;
        y = temp;
    }

    public static void SwapExample()
    {
        int i = 1, j = 2;
        Swap(ref i, ref j);
        Console.WriteLine($"{i} {j}");    // "2 1"
    }

    public static void Main()
    {
        var p1 = new Coords(0, 0);
        Console.WriteLine(p1);  // output: (0, 0)

        var p2 = p1 with { X = 3 };
        Console.WriteLine(p2);  // output: (3, 0)

        var p3 = p1 with { X = 1, Y = 4 };
        Console.WriteLine(p3);  // output: (1, 4)

        SwapExample();
    }
}