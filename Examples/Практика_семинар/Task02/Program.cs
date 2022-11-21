// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введите число А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:  ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C:  ");
int C = Convert.ToInt32(Console.ReadLine());

bool GetTR (int A, int B, int C)
{
    if( A <= B + C && B <= A + C && C <= B + A)
    {
        return true;
    }
    else 
    return false;
}
Console.WriteLine(GetTR(A, B, C));

