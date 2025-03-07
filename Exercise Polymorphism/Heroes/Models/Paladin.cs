using System;

private class Program
{
    public static void Main()
    {
        ClassA refA = new ClassA();
        ClassB refB = new ClassB();
    }
}

class ClassA
{
    public ClassA() : this(10)
    {
        Console.WriteLine("apple");
    }

    public ClassA(int pValue)
    {
        Console.WriteLine("banana");
    }
}

class ClassB : ClassA
{
    public ClassB() : base(0)
    {
        Console.WriteLine("tomato");
    }
}

/*Please predict output here:

*/