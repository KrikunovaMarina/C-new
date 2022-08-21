Console.WriteLine("Введите число ");
double numberA = int.Parse(Console.ReadLine());
//Console.WriteLine(numberA/2);
if (numberA % 2 == 1)
{
    Console.Write(numberA);
Console.WriteLine(" - Нечетное");
}
else
{
    Console.Write(numberA);
    Console.WriteLine(" - Четное");
};