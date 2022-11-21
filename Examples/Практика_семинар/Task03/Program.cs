// Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.

Console.Write("Введите число:  ");
int X = Convert.ToInt32(Console.ReadLine());

string GetDvoich(int X)
{
    string rez = "";
    int Num = 0;
    while(X != 0)
    {
        X = X / 2;
        Num = X % 2;
        rez = Num.ToString() + rez;
    
    }
    return rez;

}
string rez = GetDvoich(X);

Console.WriteLine(rez);
