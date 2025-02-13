using System;

class Program
{
    static void Main()
    {
        Hello.Greet();
    }
}

class Hello
{
    public static void Greet()
    {
        Console.WriteLine("Hello from the Hello class!");
    }
}