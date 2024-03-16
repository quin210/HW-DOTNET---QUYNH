using System;

public class Class1
{
	public Class1()
	{
        string s;
        Console.WriteLine("Enter: ");
        s = Console.ReadLine();
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        s = new string(array);
        Console.WriteLine($"Anwser: {s} ");
        Console.ReadKey();


    }
}
