﻿// Необходимо найти периметр прямоугольника

int Perimetr (int x, int y) // описываем функцию "периметр"
{
    return 2*(x + y);
}

int a = 10, b = 20; // обозначаем стороны прямоугольника

Console.WriteLine(Perimetr(a, b)); // вызываем подпрограмму Perimetr c переменными a и b, 
                                    // то есть a = x, b = y, результат выводится на экран
