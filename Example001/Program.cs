// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string x = Console.ReadLine();

void searhPolindrome(string x){
 if (x[0]==x[4] || x[1]==x[3]){
 Console.WriteLine($"Число {x} - палиндром");
  }
 else Console.WriteLine($"Число {x} - не палиндром");
}

if (x.Length == 5){
 searhPolindrome(x);
}
else Console.WriteLine($"Введите положительное целое пятизначное число");
