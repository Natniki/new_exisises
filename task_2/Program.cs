// Программа принимает на вход число и выдает количество цифр в числе.
// 453->7, 78-*78->2


/*using System;
using System.Collections.Generic;
using System.Text;*/


int GetNumber(string deskription)
{
    int number;
    Console.Write($"{deskription}=> ");
    while(true)
    {
            string temp = Console.ReadLine();
            if(int.TryParse(temp, out number))
            {
                return number;
            }
            Console.Write($"This number \"{temp}\" is not correct. Try again => ");
    }
}

int number = GetNumber("input number: ");

int CountNumber(int number)
{
    int count = 0;
    while(number>0)
    {
        number /=10;
        count++;
    }
    return count;

}
Console.WriteLine(CountNumber(number));



