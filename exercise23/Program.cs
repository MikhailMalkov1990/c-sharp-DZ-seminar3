// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = 1;

while (number3 <= number)
{
    Console.WriteLine(number3 * number3 * number3);
    number3++;
}
return (number);