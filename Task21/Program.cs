// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в пространстве: ");

int x1 = EnterCoordinate("Введите значение X первой точки: ");
int y1 = EnterCoordinate("Введите значение Y первой точки: ");
int z1 = EnterCoordinate("Введите значение Z первой точки: ");

int x2 = EnterCoordinate("Введите значение X второй точки: ");
int y2 = EnterCoordinate("Введите значение Y второй точки: ");
int z2 = EnterCoordinate("Введите значение Z второй точки: ");

double distance = Distance(x1, y1, z1, x2, y2, z2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками = {dRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int xDiff = x2 - x1;
    int yDiff = y2 - y1;
    int zDiff = z2 - z1;
    int sum = xDiff*xDiff + yDiff*yDiff + zDiff*zDiff;
    double result = Math.Sqrt(sum);
    
    return result;
}

int EnterCoordinate(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}