using System;
using System.Globalization;

namespace Laboratorka2
{
   
    class Program

    {

        static void Main(string[] args)
        {
            Adress adressa = new();
            adressa.Index = 01101;
            adressa.Country = "Ukraine";
            adressa.House = 140;
            adressa.Apartament = 22;

            Console.WriteLine("Повний адрес:");
            Console.WriteLine($"Індекс:{adressa.Index}");
            Console.WriteLine($"Країна:{adressa.Country}");
            Console.WriteLine($"Дім:{adressa.House}");
            Console.WriteLine($"Квартира:{adressa.Apartament}");



            Console.WriteLine("Уведіть валюту, яку потрібно первести у гривні,або гривні у доллари : USD=1,EUR=2,RUB=3,UAH=4");

            var currencyFrom = (Converter.Currency)int.Parse(Console.ReadLine());
            Console.WriteLine("Сума,яку потрібно перевести:");
            var amountToConvert = double.Parse(Console.ReadLine());
            var convertedAmount = $"{Converter.Convert(amountToConvert, currencyFrom)}";
            Console.WriteLine($"Переведена сума:{convertedAmount}");

            Console.WriteLine("Оберіть ім'я та фамілію співробітника");
            Employee worker = new Employee();
            Console.WriteLine("Ім'я:");
            worker.Name = Console.ReadLine();
            Console.WriteLine("Фамілія:");
            worker.Surname = Console.ReadLine();
            Employee.Salarry();


            Console.WriteLine("Анкета:");
            User user1 = new();
            Console.WriteLine("Введіть логін:");
            user1.Login = Console.ReadLine();
            Console.WriteLine("Введіть ім'я:");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Введіть прізвище:");
            user1.Surname = Console.ReadLine();
            Console.WriteLine($"Логін:{user1.Login}\n Ім'я:{user1.Name} \n Прізвище:{user1.Surname}\n {user1.date} ");




        }

    }
}