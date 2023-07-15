Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = -1;
if (num >= 100) {
  while (num > 999) {
    num = num / 10;
   }
result = num % 10;
}
Console.WriteLine(result);