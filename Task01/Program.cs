// 1. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
// Функция вывода приглашения и ввода цклого числа
int Prompt(string message)
{
    Console.WriteLine($"{message} >");   // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());  // ввод числа
}
// Проверка на корректность данных, x и y должны быть больше 0
bool ValidateQuarter(int x, int y)
{
    if (x == 0 || y == 0)  // сама проверка
    {
        // проверку не прошли
        Console.WriteLine("One of dotes = 0");
        return false;
    }
    // проверку прошли и работаем дальше
    return true;
}

// получения номера четверти по координатам
int GetQuarter(int x, int y)
{
    if (y > 0 && x > 0) // 1-ая четверть
    {
        return 1;
    }
    if (y > 0 && x < 0) // 2-ая четверть
    {
        return 2; 
    }
    if (y < 0 && x < 0)  // 3 четверть
    {
        return 3;

    }

    if (y < 0 && x > 0)  // 4 четверть
    {
        return 4;
    }
return 0; // одна из координат равна 0
}
// 
int coordx = Prompt("Enter an x ");
int coordy = Prompt("Enter an y ");

if(ValidateQuarter(coordx, coordy))
{
    int quarter = GetQuarter(coordx, coordy);
    Console.WriteLine($"Get quarter {quarter}");
}
