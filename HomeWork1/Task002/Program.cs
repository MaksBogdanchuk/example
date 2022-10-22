Console.Clear();
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("Число А = " + A + " больше, чем число B = " + B + "!");
}
else
{
    Console.WriteLine("Число В = " + B + " больше, чем число А = " + A + "!");
}

