Console.WriteLine("Добро пожаловать в игру. Отгадайте число от 1 до 50. Дается 3 попытки");
Random x = new();
int b = x.Next(1,50);
int a = Convert.ToInt32(Console.ReadLine());
int c = 1;
while (c <= 3)
{
    c++;
    if (a == b) 
    {
        Console.WriteLine($"Поздравляем, вы отгадали число c {c-1} попытки");
        break;
    }
    else
    {
        Console.WriteLine($"Вы не отгадали число, попытка номер: {c}");
        a = Convert.ToInt32(Console.ReadLine());
        if ((c == 3) && (a != b))
        {
            Console.WriteLine($"Попытки исчерпаны, игра окончена. Загаданное число: {b}");
            break;
        }
        
    }
}