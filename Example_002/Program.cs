// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

internal class Program
{
    private static void Main(string[] args)
    {
        double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            double Result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            return Result;
        }


        int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string valueFromConsole = Console.ReadLine();

                if (int.TryParse(valueFromConsole, out int number))
                {
                    if (number != 0)
                        return number;
                    else
                    {
                        Console.WriteLine("Число должно отличаться от 0. Введите другое число");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
                }
            }
        }

        string MessageX1 = "Введите x1 : ";
        string MessageX2 = "Введите x2 : ";
        string MessageY1 = "Введите y1 : ";
        string MessageY2 = "Введите y2 : ";
        string MessageZ1 = "Введите z1 : ";
        string MessageZ2 = "Введите z2 : ";

        int x1 = GetNumber(MessageX1);
        int x2 = GetNumber(MessageX2);
        int y1 = GetNumber(MessageY1);
        int y2 = GetNumber(MessageY2);
        int z1 = GetNumber(MessageZ1);
        int z2 = GetNumber(MessageZ2);

        double FinalResult = GetDistance(x1, x2, y1, y2, z1, z2);

        Console.WriteLine(FinalResult);
    }
}