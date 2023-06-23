// Программа, которая выводит массив из 8 элементов , 
// заполненный нулями и единицами в случайном порядке [1, 0, 0, 1, 1, 1, 0, 0]



/*int GetNumber(string deskription)
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
int number = GetNumber("input number: ");*/

void FiillArrey(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index]=new Random().Next(0, 2);
        index++;
    }
    Console.WriteLine($"{string.Join(", ", collection)}");
}

int [] arr = new int[8];
FiillArrey(arr);