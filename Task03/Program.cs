// Задача 3: Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    int coords = Convert.ToInt32(Console.ReadLine());
    return coords;
}
int x1 = Prompt("Enter x1");
int x2 = Prompt("Enter x2");
int y1 = Prompt("Enter y1");
int y2 = Prompt("Enter y2");

int deltax = x1 - x2;
int deltay = y1 - y2;
double result = Math.Sqrt(deltax * deltax + deltay * deltay);
Console.WriteLine($"{result:f2}");





