// Задача 4: Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = Prompt("Enter a number ");
for(int i = 1; i <= N; i++)
{
    int square = i * i;
    
    Console.Write(N);
    Console.Write($" {square}");
} 

