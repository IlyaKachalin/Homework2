﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
Альтернативный вид комментирования
*/
Console.Clear();
Console.WriteLine ("Введите цифру");

{

int x = Convert.ToInt32(Console.ReadLine());

void Task3 ()
{
if (x>0 & x<8)
{
    if (x>0 & x<6) Console.WriteLine ("День недели, чей номер равен введенной цифре, не является выходным");
    else Console.WriteLine ("День недели, чей номер равен введенной цифре, является выходным");
}

else Console.WriteLine ("Дня недели под таким номером не существует");

}

Task3();

}

catch
{
    Console.WriteLine ("Убедитесь, что вы ввели число");
}
