/*--------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
--------------------------------------------------------------------------------------------------------------------*/

int Fact(int x)
{
    int fact=1;
    for(int i=1; i<=x; i++)
        fact*=i;
    return fact;
}

Console.Write("Please enter number to find factorial: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial of {num} is {Fact(num)}");
