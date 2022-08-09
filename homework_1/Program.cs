int numberA = new Random().Next(1,25);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,25);
Console.WriteLine(numberB);
int max = numberA;
if (numberA>max) max = numberA;
if (numberB>max) max = numberB;

Console. Write("max = ");
Console.WriteLine(max);