double CalculateFormula(int a, int b, int c, int d)
{
   double int numenator =  a * b;
   int denamenator = c + d;
   double result = numenator / denomenator;
   return result;
}

double result = CalculateFormula(1,2,3,4);
Console.WriteLine(result);
