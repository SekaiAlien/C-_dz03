// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите Xa:");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Ya:");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Za:");
int Za = int.Parse(Console.ReadLine());


Console.WriteLine("Введите Xb:");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Yb:");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Zb:");
int Zb = int.Parse(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
Console.WriteLine(ab);