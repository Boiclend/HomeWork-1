Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) {
  Console.WriteLine("1 число больше");
}
if (num2 > num1 && num2 > num3) {
  Console.WriteLine("2 число больше");
}
if (num3 > num2 && num3 > num1) {
  Console.WriteLine("3 число больше");
}