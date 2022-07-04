// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Функция на получение и проверку числа с консоли
int GetNumber()
{
    while (true)
    {
        Console.WriteLine ("Введите пятизначное число:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (100000 > num & num > 9999)
        {
            return num;
        }
        else
        {
            Console.WriteLine ("Введено неверное число.");
        }
    }
}


// Функция на проверку (палиндром)

void GetCheck(int CheckNum)
{
    string StrNum = Convert.ToString(CheckNum);
    bool result = true;
    for (int i = 0; i < 2; i++)
        if (StrNum[i] != StrNum[StrNum.Length - i - 1])
            result = false;
    if (result) Console.WriteLine(CheckNum + " является палиндромом");
    else Console.WriteLine(CheckNum + " не является палиндромом");
}

int CheckNum = GetNumber();
GetCheck(CheckNum);


