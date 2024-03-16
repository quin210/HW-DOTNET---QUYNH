using System;

public class Bai1
{
	int checkPrime(int n)
    {
        for(int i = 2; i*i < n; i++)
        {
            if (n % i == 0) return 0;
        }
        return n > 1;
    }
    
    public Bai1()
	{
        //bai 1: In dãy số nguyên tố nhỏ hơn số được nhập vào từ bàn phím
        int n;
        Console.WriteLine("Enter the n: ");
        n = int.Parse(Console.ReadLine());
        for(int i = 0; i<n; i++)
        {
            if (checkPrime(i)) Console.WriteLine(i);
        }
        
    }
}
