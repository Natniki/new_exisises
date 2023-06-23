// Программа , которая на вход принимает число N и выдает произведение чисел от 1 до N.
// 4->24, 5->120

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

int ProductOfNumber(int number)
{
    int multiplication=1;
    for(int i = 1; i <=number; i++)
    {
        multiplication *=i;
    }    
    return multiplication;
}

Console.WriteLine(ProductOfNumber(number));


