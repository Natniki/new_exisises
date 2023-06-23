int GetNumber(string deskription)
{
    int number;
    Console.Write($"{deskription}=> ");
    while(true)
    {
            string temp= Console.ReadLine();
            if(int.TryParse(temp, out number))
            {
                return number;
            }
            Console.Write($"This number \"{temp}\" is not correct. Try again => ");
    }
}

int GetSUM(int number)
{
    int Sum=0;
    for (int i = 0; i <= number; i++)
    {
        Sum += i;
    }
    return Sum;
}

//int number=GetNumber("input number");
//Console.WriteLine($"sum number from 1 to {number} is {GetSUM(number)}.");

int [] arrey = {4, 3, 8, 9};

Console.WriteLine(string.Join(", ", arrey));