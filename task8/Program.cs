﻿Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < num + 1; i++) {
    if (i % 2 == 0) {
        Console.WriteLine(i);
    }
}