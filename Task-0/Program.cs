/*---------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
---------------------------------------------------------------------------------------------------------------------*/

int FindSum(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
        sum+= i;
    return sum;
}

Console.Write("Input positive integer number: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of numbers from 1 to {a} is {FindSum(a)}");