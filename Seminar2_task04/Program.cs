// Задача 4: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. 
// Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write($"{message}");
    int asnwer = Convert.ToInt32(Console.ReadLine());
    return asnwer;
}

int number = Prompt("Enter a week's day ");

int Days = number;
if(Days >= 1 & Days <= 7)
{
    if(Days >= 1 & Days <= 5) 
{
    Console.WriteLine("Not a weekend" );
}
else 
{
    Console.WriteLine("A weekend");
}

}
else{Console.WriteLine("Not a number of week days");}