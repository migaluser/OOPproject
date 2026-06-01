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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("==================================================");
            Console.WriteLine("Любка Михайло, курс 1, група ІПЗ-11");
            Console.WriteLine("варіант завдання - 13");
            Console.WriteLine("Версія 1 та 2");
            Console.WriteLine("Старт імітації");
            Console.WriteLine("==================================================");

            // 2. Створення об'єктів університетів
            University university = new University
            (
                "Київський національний університет імені Тараса Шевченка",
                 "Київ, Україна",
                 1,
                 5000.00,
                 true
            );

            University university2 = new University
            (
                "Національний університет 'Львівська політехніка'",
                 "Львів, Україна",
                 2,
                4500.00,
                true
            );

            University university3 = new University
            (
                "Харківський національний університет імені В. Н. Каразіна",
                 "Харків, Україна",
                 3,
                4000.00,
               true
            );

            // 3. Створення ІТ-компанії
            ITCompany iTCompany = new ITCompany(
                "NAVI",
                 1000000.00,
                 "Київ, Україна",
                 true
            );
            iTCompany.University = university;

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

            Console.WriteLine($"Чи має спеціаліст навичку 'C#'? {specialist.HasSkill("C#")}");
            Console.WriteLine($"Створено ІТ-кластер з компанією {iTCompany.Name} та університетами: {string.Join(", ", iTClusterz.Universities.Select(u => u.Name))}");
            Console.WriteLine($"Створено компанію: {iTCompany.Name} з бюджетом {iTCompany.Budget}");
            Console.WriteLine($"Створено університет: {university.Name} з рейтингом {university.Ranking}");

            // ==================================================
            // ВЕРСІЯ 3: Тестування бізнес-процесів та взаємодії
            // ==================================================
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Версія 3: Бізнес-процеси та взаємодія об'єктів");
            Console.WriteLine("==================================================");

            // 1. Модернізація навчальної програми
            university.ModernizeCurriculum("Основи бекенд-розробки на C# та .NET");

            // 2. Фінансова підтримка від компанії (успішна, бюджету вистачає)
            iTCompany.ProvideFinancialSupport(university, 150000);

            // 3. Фінансова підтримка (неуспішна, перевищує наявний бюджет компанії)
            iTCompany.ProvideFinancialSupport(university, 2000000);

            // 4. Організація олімпіади кластером (всередині методу NAVI виділить ще кошти)
            iTClusterz.OrganizeOlimpiad(university, iTCompany, 50000);

            // 6. Фініш програми
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Фініш імітації Версії 3");
            Console.ReadLine();
        }
    }
}