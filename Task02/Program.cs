//  Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y).

// Проверка на корректность данных, x и y должны быть больше 0

int Prompt(string message)
{
    Console.WriteLine($"{message} >");   // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());  // ввод числа
}
int NumOfQuarter = Prompt("Enter a number of Quarter");

if (NumOfQuarter == 1 ^ NumOfQuarter == 2 ^ NumOfQuarter == 3 ^ NumOfQuarter == 4)
{
    if (NumOfQuarter == 1)
    {
        Console.WriteLine("X > 0 and Y > 0");
    }
    if (NumOfQuarter == 2)
    {
        Console.WriteLine("X < 0 and Y > 0");
    }
    if (NumOfQuarter == 3)
    {
        Console.WriteLine("X < 0 and Y < 0");
    }
    if (NumOfQuarter == 4)
    {
        Console.WriteLine("X > 0 and Y < 0");
    }
}
else
{
    Console.WriteLine($"{NumOfQuarter} Not number of Quarter ");
}