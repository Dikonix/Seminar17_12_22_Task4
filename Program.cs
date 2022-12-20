int firstNumber;
int secondNumber;
int thirdNumber;

try
{
    Console.Write("Введите первое число: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите третье число: ");
    thirdNumber = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число");
    return;
}

int max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
}

if (thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine($"Максимальное число: {max}");