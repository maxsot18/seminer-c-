// Задача 3: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. . 
// Не 
// использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write($"{message} ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Number = ");
int number2 = 0;
if (number >= 100)
{
    
   while(number >= 1000)
   {
    number = number / 10;

    }
   
   double thrdn = Convert.ToInt32(number);
   double thirddignum = thrdn % 10;
   Console.WriteLine(thirddignum); 
    
}
else
Console.WriteLine("Not Three dig num");