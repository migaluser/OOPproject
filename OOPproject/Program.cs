using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Обов'язковий текстовий вивід за вимогами завдання
            Console.WriteLine("==================================================");
            Console.WriteLine("Любка Михайло, курс 1, група ІПЗ-11");
            Console.WriteLine("варіант завдання - 13");
            Console.WriteLine("Версія 1");
            Console.WriteLine("Старт імітації");
            Console.WriteLine("==================================================");

            // 2. Створення об'єктів університетів
            University university = new University
            {
                Name = "Київський національний університет імені Тараса Шевченка",
                Location = "Київ, Україна",
                Ranking = 1,
                Tuition = 5000.00,
                IsPublic = true
            };

            University university2 = new University
            {
                Name = "Національний університет 'Львівська політехніка'",
                Location = "Львів, Україна",
                Ranking = 2,
                Tuition = 4500.00,
                IsPublic = true
            };

            University university3 = new University
            {
                Name = "Харківський національний університет імені В. Н. Каразіна",
                Location = "Харків, Україна",
                Ranking = 3,
                Tuition = 4000.00,
                IsPublic = true
            };

            // 3. Створення ІТ-компанії
            ITCompany iTCompany = new ITCompany
            {
                Name = "NAVI",
                Budget = 1000000.00,
                Location = "Київ, Україна",
                IsOperational = true,
                Specialists = new List<Specialist>(),
                University = university
            };

            // 4. Створення ІТ-спеціаліста
            Specialist specialist = new Specialist
            {
                Name = "Іваненко Іван",
                Position = "Програміст",
                Salary = 3000.00,
                Department = "Розробка",
                IsEmployed = true
            };

            // Додаємо створеного спеціаліста в компанію NAVI
            iTCompany.Specialists.Add(specialist);

            // 5. Створення ІТ-кластера та об'єднання всіх елементів
            ITCluster iTClusterz = new ITCluster
            {
                ITCompanies = new List<ITCompany> { iTCompany },
                Universities = new List<University> { university, university2, university3 },
                AnnualHackathon = new Event
                {
                    Title = "Щорічний Хакатон"
                }
            };

            // 6. Фініш програми
            Console.WriteLine("==================================================");
            Console.WriteLine("Фініш імітації");
            Console.ReadLine(); 
        }
    }
}