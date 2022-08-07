Console.Clear();
Console.Write("Введите число для расчета его факториала: ");
double a = Convert.ToDouble(Console.ReadLine());
double number = 1;
double factorial = 1;
if (a == 0)
{
    Console.WriteLine("Факториалом данного числа является 1");
}
else
{
    if (a < 0)
    {
        Console.WriteLine("Факториал для отрицательных чисел не считается!");
    }
    else
    {
        if (a % 1 > 0)
        {
            Console.WriteLine("Факториал считается только для целых чисел!");
        }
        else
        {
            while (number <= a) 
            {
                factorial = factorial * number;
                number += 1;
            }  
        Console.WriteLine("Факториалом данного числа является " + factorial);
        }
    }
}