using System;

public class Class1
{
	public Class1()
	{
        var rand = new Random();
        Console.WriteLine("One random integer:");
        int ramNum = rand.Next(1, 100);
        Console.WriteLine(ramNum);

        Console.WriteLine("Enter your number: ");
        int num = int.Parse(Console.ReadLine());

        if (num == ramNum) Console.WriteLine("The same numeber!!");
        else Console.WriteLine("It's wrong.");
    }
}
