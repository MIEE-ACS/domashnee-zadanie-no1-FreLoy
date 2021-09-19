using System;

public class Class1
{
	public Class1()
	{
        int a, b, c;
        Console.Write("Enter A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("AC = {0}\nBC = {1}\nAC+BC = {2}", c - a, c - b, (c - a) + (c - b));
    }
}
