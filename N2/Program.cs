//Number2
Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
if ( numberA > max) max = numberA;
if (numberB > max) max = numberB;
 Console.Write("max = ");
Console.WriteLine(max);
