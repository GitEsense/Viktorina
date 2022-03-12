Random rnd = new Random();
int value = rnd.Next(0, 100);
int number;
int count = 0;

do
{
    Console.Write("Система загадала число, введите Ваш вариант : ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Вы ввели не число, введите целое число : ");
    }
    Console.WriteLine($"Вы выбрали число {number}");
    if (number == 999)
    {
        Console.WriteLine("Будет произведён выход ! Всего доброго!");
        break;
    }
    if (value == number)
    {
        Console.WriteLine("Поздравляем, Вы ответили верно!");
    }
    else
    {
        Console.WriteLine("Ответ неправильный, попробуйте снова!");
    }
    Console.WriteLine("");
} while (value != number);