Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) {
    Console.WriteLine($"число {num1} больше чем {num2} и {num3}");
}
if (num2 > num1 && num2 > num3) {
    Console.WriteLine($"число {num2} больше чем {num1} и {num3}");
}
if (num3 > num2 && num3 > num1) {
    Console.WriteLine($"число {num3} больше чем {num1} и {num2}");
}