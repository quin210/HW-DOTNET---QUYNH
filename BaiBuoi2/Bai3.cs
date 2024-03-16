using System;

public class Class1
{
	public Class1()
	{
		string chuoiKyTu; 
		chuoiKyTu = Console.ReadLine();
		char[1000] check = {0};
		for(int i = 0; i < chuoiKyTu.Lenght(); i++)
		{
			if (check[chuoiKyTu[i]] == 1)
			{
				continue;
			}
			else
			{
				check[chuoiKyTu[i]] = 1;
				int count = 0;
                for (int j = i + 1; j < chuoiKyTu.Length; j++)
                {
                    if (chuoiKyTu[j] == chuoiKyTu[i]) count++;
                }
            }
		}
	}
}
