using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Enter the numeber: ");
		int n = int.Parse(Console.ReadLine());
		int ans = 1,  i = 1 ;
		do
		{
			ans *= n;
			n--;
		}
		while (n > 0);

		Console.WriteLine($"Answer is {ans}.");
		Cosole.ReadKey();
	}
}
