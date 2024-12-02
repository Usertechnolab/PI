int n = 0;
double result = 0.0;
for (n = 0; n < 150000; n++)
{
    result += ((Math.Pow(-1,n))/(2*n+1));
    Console.WriteLine(n);
    Console.WriteLine(result * 4);
}
