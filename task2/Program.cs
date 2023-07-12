Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) {
    Console.WriteLine($"Числа {num1} и {num2} равны ");
    return;
}

if (num1 > num2) {
    Console.WriteLine($"Число {num1} больше, чем {num2} ");
} else {
    Console.WriteLine($"Число {num2} больше, чем {num1} ");
} 
