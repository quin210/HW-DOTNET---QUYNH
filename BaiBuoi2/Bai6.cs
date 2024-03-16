using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Enter your password: ");
		string passWord = Console.ReadLine();
		int PwdLenght = passWord.Length;
		var check1 = 0;
		if (PwdLenght >= 6 && PwdLenght <= 12)
			check1 = 1;
		int i = PwdLenght - 1;
        do
		{
			if (passWord[i] == '@')
				break;
			i--;
		}
		while (i >= 0);
	}
}
