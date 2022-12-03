// Задача 2: Напишите программу, 
// которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 
// Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Number = ");

if (number >= 100 & number < 1000)
{
    int number1 = number / 100;
    double number2 = number % 10;
    int number3 = Convert.ToInt32(number2);
    Console.Write($"{number1}");
    Console.Write($"{number3}");

}
else { Console.WriteLine("Not ThreeDigitNumber"); }