// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.


using System.Reflection;

int Ack(int n, int m)
{
    if (n = 0)
    {
        return m + 1;
    }
    else
    if (m = 0)
    {
        return Ack(n - 1, 1);
        // return Ack(n - 1,Ack(n,m - 1));
    }
    return Ack(n - 1, Ack(n, m - 1));
}
int result = Ack(2, 3);
Console.WriteLine(result);