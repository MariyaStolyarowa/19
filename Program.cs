//Задача 19 Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом. 14212 -> нет 12821 -> да
int A;
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
Link1:
A=Convert.ToInt32(Console.ReadLine());
if (A<10000 || A > 99999)
{Console.WriteLine("ОШИБКА! Введите ПЯТИЗНАЧНОЕ число: ");
goto Link1;}
else 
  {if ((A/10000==A%10) && (A/1000%10==A%100/10))
  {Console.WriteLine("Да");}
  else Console.WriteLine("Нет");}