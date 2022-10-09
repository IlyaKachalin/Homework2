// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine ("Введите число: ");

try
{

int x = Convert.ToInt32(Console.ReadLine());

void NewTask2()
{
string xText = Convert.ToString(x);

if (xText.Length > 2)
{
  Console.WriteLine("третья цифра равна " + xText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

}
NewTask2();
}

catch
{
    Console.WriteLine ("Убедитесь, что вы ввели число");
}