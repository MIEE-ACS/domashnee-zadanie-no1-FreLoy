using System;

namespace LAB1C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приглашение пользователю ввести значение точки A
            Console.Write("Введите значение точки A и нажмите клавишу Enter: ");

            //Получение первой строки
            double A = Double.Parse(Console.ReadLine());

            //Приглашение пользователю ввести значение точки С
            Console.Write("Введите значение точки C и нажмите клавишу Enter: ");

            //Получение второй строки
            double C = Double.Parse(Console.ReadLine());

            //Приглашение пользователю ввести значение точки В
            Console.Write("Введите значение точки B и нажмите клавишу Enter: ");

            //Получение третьей строки
            double B = Double.Parse(Console.ReadLine());

            //Нахождение длины отрезка АС
            double AC = Math.Abs(A - C);

            //При выводе количество знаков после запятой не больше 3
            AC = Math.Round(AC, 3); 

            //Вывод результата длины AC на экран
            Console.WriteLine($"Длина отрезка AC равна: {AC}");
            
            //Нахождение длины отрезка BC
            double BC = Math.Abs(B - C);

            //При выводе количество знаков после запятой не больше 3
            BC = Math.Round(BC, 3);

            //Вывод результата длины BC на экран
            Console.WriteLine($"Длина отрезка BC равна: {BC}");

            // Сумма длин отрезков AC и BC
            double ACBC = AC + BC;

            //При выводе количество знаков после запятой не больше 3
            ACBC = Math.Round(ACBC, 3);

            //Вывод результата суммы длин AC и BC на экран
            Console.WriteLine($"Сумма длин отрезков АС и BC равна: {ACBC}");

        }
    }
}
