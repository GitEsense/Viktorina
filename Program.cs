int start = 0;
int stop = 20;

Random rnd = new Random();
int value = rnd.Next(start, stop);
int number = 0;
int count = 1;

do
{
    Console.Write($"Угадайте число X (от {start} до {stop}) : ");
    string input = Console.ReadLine();
    while (input != "exit" && !int.TryParse(input , out number))
        {
            Console.Write("Ошибка ввода! Введите число : ");
            input = Console.ReadLine();
        }
    if (input == "exit")
        {
            Console.WriteLine($"Выходим. Кол-во попыток: {count}");
            break;
        }
    Console.WriteLine($"Вы выбрали число {number}");
    switch (number) {
        case ( > 0) when number == value: Console.WriteLine($"\nПоздравляем, Вы ответили верно c {count} попытки !"); break;
        case ( > 0) when number < 0 || number > stop: Console.WriteLine($"Введёное число не входит в диапазон\n"); count++; break;
        default: Console.WriteLine("Ответ неправильный, попробуйте снова!\n"); count++; break;
    }
} while (value != number);