Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2) {
    Console.WriteLine("числа равны");
    return;
}
if (num1 > num2) {
    Console.WriteLine("Число 1 больше");
} else {
    Console.WriteLine("Число 2 больше");
}


