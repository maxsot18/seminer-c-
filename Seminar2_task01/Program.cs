// // Задача 1: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Не использовать строки

// // 456 -> 5
// // 782 -> 8

int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Number = ");


if (number >= 100 & number < 1000)
{
    double number1 = number % 100;
    int number2 = Convert.ToInt32(number1);
    int number3 = number2 / 10;
    Console.WriteLine($"{number3}");
}
else { Console.WriteLine("Not ThreeDigitNumber"); }

