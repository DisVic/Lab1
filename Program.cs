using System;

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
