//Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

int a = 0;
int i = 2;
bool correct = false;

while(!correct)
{
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 2 )
    {
        Console.Write("Некорректное число, введите число больше 1. ");
    }
    else
    {
        correct = true;
    }
}

Console.Write("Все четные числа от 1 до " + a + ": ");
while (i <= a)

{
    Console.Write(" " + i);
    i = i + 2 ;
}

    
    

