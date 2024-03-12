using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("Nhap so lieu: ");
        int n = Console.Read();
        for (int i = 1; i < n; i++)
            bool check = true;
        {
            for (int j = 2; j < sqrt(n); j++)
            {
                if (i % j == 0) check = false;
                if (j > 1 && check) Console.WriteLine(i + " " + j);
            }
        }
        Console.ReadKey();
    }
}
