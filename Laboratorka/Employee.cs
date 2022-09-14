using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka2
{
     class Employee
    {
      private  string name = "";
        private string surname = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }          
        public static void  Salarry()
        {
            Console.WriteLine("Оберіть посаду Waiter або Supervisor:");
            string job = Console.ReadLine();
            Console.WriteLine("Кількість років стажу:");
            int time = int.Parse(Console.ReadLine());
            int w = 12000;
            int m = 35000;          
            switch (job)
            {
                case "Waiter":
                    {
                        Console.WriteLine("Ви обрали професію офіціанта");
                        if (time <= 2)
                        {
                            Console.WriteLine($"Зарплата {w}");
                            Console.WriteLine($"Податковий збір:{(w  / 100) * 22}");

                        }
                        else if (time > 2 && time <= 5)
                        {
                            Console.WriteLine($"Зарплата {w + 3000}");
                            Console.WriteLine($"Податковий збір:{((w + 3000) / 100) * 22}");
                        }
                        else if (time > 5 && time <= 100)
                        {
                            Console.WriteLine($"Зарплата {w + 8000}");
                            Console.WriteLine($"Податковий збір:{((w + 8000) / 100) * 22}");
                        }                       
                    }
                    break;
                case "Supervisor":
                    {
                        Console.WriteLine("Ви обрали професію адміністратора");
                        if (time <= 2)
                        {
                            Console.WriteLine($"Зарплата {m}");
                            Console.WriteLine($"Податковий збір:{(m / 100) * 22}");
                        }
                        else if (time > 2 && time <= 5)
                        {
                            Console.WriteLine($"Зарплата {m + 3000}");
                            Console.WriteLine($"Податковий збір:{((m+3000) / 100) * 22}");
                        }
                        else if (time > 5 && time <= 100)
                        {
                            Console.WriteLine($"Зарплата {m + 8000}");
                            Console.WriteLine($"Податковий збір:{((m + 8000) / 100) * 22}");
                        }                      
                    }
                    break;                   
            }                           
        }
    }
}
