Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int firstOp = num / 10;
int SecondOp = firstOp % 10;
Console.WriteLine(SecondOp);