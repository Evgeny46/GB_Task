/* Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


Console.Clear();

/* Console.WriteLine("Введите цифру от 1 до 7 ");
string weekday = Console.ReadLine(); */
Random rand = new Random();
int weekday = rand.Next(1,8);
string result = weekday.ToString();

System.Console.WriteLine("Сформированное число " + result);


switch(result)
{
    case "1":
        System.Console.WriteLine("Ошибка! Понедельник рабочий день");
        break;
    case "2":
        System.Console.WriteLine("Ошибка! Вторник рабочий день");
        break;
    case "3":
        System.Console.WriteLine("Ошибка! Среда рабочий день");
        break;
    case "4":
        System.Console.WriteLine("Ошибка! Четверг рабочий день");
        break;
    case "5":
        System.Console.WriteLine("Ошибка! Пятница последний рабочий день");
        break;
    case "6":
        System.Console.WriteLine("Ура, выходной! - Суббота");
        break;
    case "7":
        System.Console.WriteLine("Ура, выходной! - Воскресенье");
        break;
    
    default:
        System.Console.WriteLine("Ошибка! Неизвестное действие");
        break;
}  