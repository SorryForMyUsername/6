﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.
            //Используя двузначное случайное число,
            //вывести на экран информацию о четности или нечетности этого числа
            //с использованием тернарной операции.
            //Random rnd = new Random();
            //int twoDigitNumber = rnd.Next(10, 99);
            //Console.WriteLine($"Случайное число - {twoDigitNumber}");
            //string isEven = twoDigitNumber % 2 == 0 
            //    ? $"Число чётное" 
            //    : $"Число нечётное";
            //Console.WriteLine(isEven);

            //Задача 2.
            //Дано целое число n, указывающее номер дня недели от 1 до 7.
            //По указанному номеру n вывести название соответствующего дня недели.
            //Console.Write("Введите число от 1 до 7: ");
            //int weekNumber = Convert.ToInt32(Console.ReadLine());
            //switch (weekNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //    default:
            //        Console.WriteLine("Неподходящее число!");
            //        break;
            //}

            //Задача 3.
            //Используя случайное число в диапазоне от 1 до 7,
            //вывести на экран название дня недели.
            //Random rnd = new Random();
            //int randWeekNumber = rnd.Next(1, 7);
            //Console.WriteLine($"Случайное число: {randWeekNumber}");
            //switch (randWeekNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //}

            //Задача 4.
            //По номеру месяца вывести название времени года.
            //Console.Write("Введите номер месяца: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:
            //    case 2:
            //    case 12:
            //        Console.WriteLine("Зима");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Весна");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Лето");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Осень");
            //        break;
            //    default:
            //        Console.WriteLine("Неподходящий номер!");
            //        break;
            //}

            //Задача 5.
            //Дан признак транспортного средства: a – автомобиль, в – велосипед,
            //м - мотоцикл, с – самолет, п – поезд.
            //Вывести на экран максимальную скорость транспортного средства
            //в зависимости от введенного признака.
            //Console.Write($"Введите признак транспортного средства: ");
            //char sign = Convert.ToChar(Console.Read());
            //switch (sign)
            //{
            //    case 'а':
            //        Console.WriteLine("Максимальная скорость автомобиля: 200 км/ч");
            //        break;
            //    case 'в':
            //        Console.WriteLine("Максимальная скорость велосипеда: 30 км/ч");
            //        break;
            //    case 'м':
            //        Console.WriteLine("Максимальная скорость мотоцикла: 150 км/ч");
            //        break;
            //    case 'с':
            //        Console.WriteLine("Максимальная скорость самолёта: 1000 км/ч");
            //        break;
            //    case 'п':
            //        Console.WriteLine("Максимальная скорость поезда: 400 км/ч");
            //        break;
            //    default:
            //        Console.WriteLine("Несуществующий признак!");
            //        break;
            //}

            //Задача 6.
            //Вывести название предмета по введенной первой букве: ф – физика,
            //м – математика, и – история, г – география, б – биология.
            //Console.Write($"Введите название предмета: ");
            //char subject = Convert.ToChar(Console.Read());
            //switch (subject)
            //{
            //    case 'ф':
            //        Console.WriteLine("Физика");
            //        break;
            //    case 'м':
            //        Console.WriteLine("Математика");
            //        break;
            //    case 'и':
            //        Console.WriteLine("История");
            //        break;
            //    case 'г':
            //        Console.WriteLine("География");
            //        break;
            //    case 'б':
            //        Console.WriteLine("Биология");
            //        break;
            //    default:
            //        Console.WriteLine("Несуществующий предмет!");
            //        break;
            //}

            //Дополнительная задача
            //Дан признак геометрической фигуры на плоскости: 
            //К - это круг
            //П - прямоугольник
            //Т - треугольник
            //Вывести на экран периметр и площаль заданной фигуры с учётом, что данные необходимые для расчётов спрашивают у пользователя.
            //Console.Write("Введите признак геометрической фигуры: ");
            //char sign = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //double square;
            //double perimeter;

            //switch (sign)
            //{
            //    case 'К':
            //    case 'к':
            //        Console.WriteLine("Вы выбрали круг");
            //        Console.Write("Введите радиус: ");
            //        int r = int.Parse(Console.ReadLine());

            //        square = Math.PI * Math.Pow(r, 2);
            //        perimeter = 2 * Math.PI * r;

            //        Console.WriteLine($"Периметр: {perimeter:N2}\nПлощадь: {square:N2}");
            //        break;

            //    case 'П':
            //    case 'п':
            //        Console.WriteLine("Вы выбрали прямоугольник");
            //        Console.Write("Введите высоту: ");
            //        int heigth = int.Parse(Console.ReadLine());
            //        Console.Write("Введите ширину: ");
            //        int width = int.Parse(Console.ReadLine());

            //        square = width * heigth;
            //        perimeter = 2 * (width + heigth);

            //        Console.WriteLine($"Периметр: {perimeter:N2}\nПлощадь: {square:N2}");
            //        break;

            //    case 'Т':
            //    case 'т':
            //        Console.WriteLine("Вы выбрали треугольник");
            //        Console.Write("Введите первую сторону: ");
            //        int a = int.Parse(Console.ReadLine());
            //        Console.Write("Введите вторую сторону: ");
            //        int b = int.Parse(Console.ReadLine());
            //        Console.Write("Введите первую сторону: ");
            //        int c = int.Parse(Console.ReadLine());

            //        if (a < b + c && b < a + c && c < a + b)
            //        {
            //            double p = (a + b + c) / 2.0;
            //            square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //            perimeter = a + b + c;

            //            Console.WriteLine($"Периметр: {perimeter:N2}\nПлощадь: {square:N2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Такого треугольника не существует");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Неправильный признак!");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
