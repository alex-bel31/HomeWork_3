// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int CoordinatesABC(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int A1 = CoordinatesABC("Введите координты отрезка А1");
int A2 = CoordinatesABC("Введите координты отрезка А2");
int B1 = CoordinatesABC("Введите координты отрезка B1");
int B2 = CoordinatesABC("Введите координты отрезка B2");
int C1 = CoordinatesABC("Введите координты отрезка C1");
int C2 = CoordinatesABC("Введите координты отрезка C2");

double result = Math.Sqrt(Math.Pow(A1 - A2,2) + Math.Pow(B1 - B2,2)+Math.Pow(C1 - C2,2));
Console.WriteLine($"A({A1},{B1},{C1}); B({A2},{B2},{C2}), -> {result}");
