/*--------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
--------------------------------------------------------------------------------------------------------------------*/

int NumberLength(int num)
{
    int cnt=0;
    while(num > 0)
    {
        num/=10;
        cnt++;
    }
    return cnt;
}


Console.Write("Please enter number to check digits quantity: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {num} has {NumberLength(num)} digits");

