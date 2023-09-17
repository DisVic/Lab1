![титульник (1)](https://github.com/DisVic/Lab1/assets/124364123/74eafb0c-3178-430b-a9f7-94f3f9061fff)

Лабораторная работа №1 
«Создание программы с использованием классов» 

Цель: получить практические навыки в создании программ, содержащих определения классов и использующих объекты на языке программирования C#.
Листинг:
```
﻿using System;

namespace Лабораторная__1
{
    internal class Program
    {
        public class Convertation//класс для конвертации из рублей в различные валюты
        {
            private double value = 0.0;
            public Convertation(double rubles) //конструкт для присваивания в валюту рублей
            {
            this.value = rubles ;
            }

            public void ConvetToAnotherCurrency()//конструкт для конвертации рублей в другие валюты на 16.09.23
            {
                Console.WriteLine("В рублях: " + value);
                Console.WriteLine("В долларах: " + value * 0.010348);
                Console.WriteLine("В юанях: " + value * 0.075374);
                Console.WriteLine("В евро: " + value * 0.009705);
                Console.WriteLine("В тенге: " + value * 4.82);
                Console.WriteLine("В лирах: " + value * 0.278694);
                Console.WriteLine("В йенах: " + value * 1.53);
            }
        }

        public static void Main(string[] args)
        {
            Convertation currency = new Convertation(double.Parse(Console.ReadLine()));//создание переменной класса Convertation
            currency.ConvetToAnotherCurrency();//вызов конструкта для конвертации валют
        }
    }
}
```
Результат программы:

![2023-09-16_23-48-29](https://github.com/DisVic/Lab1/assets/124364123/26960c34-e447-4635-b24c-e4902133cf72)

В данной программе я создал класс Convertation с полем для валюты, которую пользователь будет вводить в консоль. Также в классе присутствует конструкт, благодаря которому в переменную value, отвечающую за хранение рублей, присваивается введённое значение. Ещё был создан метод, который переводит рубли в другие мировые валюты и выводит результат в консоли.

В методе Main я создаю переменную класса Convertation, после чего результат программы выводится в консоль.
