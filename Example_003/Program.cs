// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber ()
{
    while(true)
    {
        Console.WriteLine ("Введите положительное число");
        bool IsSucces = int.TryParse(Console.ReadLine(), out int Number);
            if (IsSucces && Number > 0)
                return Number;
    }
}
        
void GetResult (int NumberCheck)
{
    for (int i = 1; i <= NumberCheck; i++)
        {
            Console.WriteLine (i*i*i);
        }

}


int NumberCheck = GetNumber ();
GetResult (NumberCheck);
