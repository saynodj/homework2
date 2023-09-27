//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Задача № 15 ");
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
    Console.WriteLine("(это выходной день) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7)
  {
    Console.WriteLine("в неделе всего 7 дней, введите цифру от 1 до 7");
  }
  else Console.WriteLine("(это не выходной день) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);