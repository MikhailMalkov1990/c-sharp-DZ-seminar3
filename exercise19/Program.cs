// Console.WriteLine("add first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("add second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("add third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("add fourth number: ");
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("add fifth number: ");
// int num5 = Convert.ToInt32(Console.ReadLine());
//     if (num1 == num5 && num2 ==  num4)
//     {
//         Console.WriteLine("yes");
//     }
//     else 
//     Console.WriteLine("no");

Console.WriteLine("five digit number:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
int num2 = (num / 1000) % 10;
int num3 = (num / 100) % 10;
int num4 = (num / 10) % 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4)
{
Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine("No");
}
