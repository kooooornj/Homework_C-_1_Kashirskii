/* Zadacha №2
int n1, n2, max, min;

Console.Write("Введите первое число");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число");
n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    max = n1;
    min = n2;
    Console.WriteLine("Максимальное число = " + max);
    Console.WriteLine("Минимальное число = " + min);
}
else if (n1 < n2)
{
    max = n2;
    min = n1;
    Console.WriteLine("Максимальное число = " + max);
    Console.WriteLine("Минимальное число = " + min);
}
else 
{
    Console.WriteLine("Числа одинаковые");
}
*/
/* Zadacha 4
int n1, n2, n3, max;
Console.Write("Введите первое число");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число");
n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число");
n3 = Convert.ToInt32(Console.ReadLine());
max = n1;
if (max > n2 && max > n3)
{
    Console.WriteLine("Максимальное число первое и  = " + max);
}
else if (n2 > max && n2 > n3)
{
    max = n2;
    Console.WriteLine("Максимальное число второе и  = " + max);
}
else if ( n3 > max && n3 > n2)
{
    max = n3;
    Console.WriteLine("Максимальное число третье и  = " + max);
}
else 
Console.WriteLine("Числа одинаковые");
*/
/* Zadacha 6
int n;
Console.Write("Введите число");
n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
   Console.WriteLine("Число четное"); 
}
else 
{
 Console.WriteLine("Число нечетное");   
}
*/
/* Zadacha 8
int i, N;
Console.Write("Введите число");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа диапазона от 1 до N: ");
for (i = 1; i <= N; i++)
{
    if (i % 2 ==0)
    {
      Console.Write(i + " "); 
    }
    if (N == 1)
    {
        Console.WriteLine("Нет четных чисел в данном диапазоне");
    }
}    
*/