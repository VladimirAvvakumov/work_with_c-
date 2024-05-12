//Вычислить значение формулы (a*b)/(C+d)

double CalculateFormula(int a, int b, int c, int d)
{
    int numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}
double result = CalculateFormula(3, 2, 3, 3);

Console.WriteLine(result);


