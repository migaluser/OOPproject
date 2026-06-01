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
            // ==================================================
            // ВЕРСІЯ 4: Тестування перевантаження операторів
            // ==================================================
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Версія 4: Перевантаження операторів");
            Console.WriteLine("==================================================");

            // 1. Тестуємо унарний оператор ++ (Підвищення зарплати)
            Console.WriteLine($"[Оператор ++] Зарплата спеціаліста {specialist.Name} до підвищення: {specialist.Salary}");
            specialist++;
            Console.WriteLine($"[Оператор ++] Зарплата після застосування 'specialist++': {specialist.Salary}");

            // 2. Створюємо другу компанію
            ITCompany gameCompany = new ITCompany(
                "GSC Game World",
                 800000.00,
                 "Київ, Україна",
                 true
            );

            // 3. Тестуємо бінарний оператор + (Злиття компаній)
            ITCompany mergedCorp = iTCompany + gameCompany;
            Console.WriteLine($"\n[Оператор +] Злиття компаній: {iTCompany.Name} та {gameCompany.Name}");
            Console.WriteLine($"Результат злиття: {mergedCorp.Name}, Об'єднаний бюджет: {mergedCorp.Budget}");

            // 4. Тестуємо оператори порівняння (==, !=, >, <)
            Console.WriteLine($"\n[Оператор ==] Чи {iTCompany.Name} та {gameCompany.Name} це одна компанія? {iTCompany == gameCompany}");

            if (iTCompany > gameCompany)
            {
                Console.WriteLine($"[Оператор >] Бюджет {iTCompany.Name} ({iTCompany.Budget}) БІЛЬШИЙ ніж у {gameCompany.Name} ({gameCompany.Budget})");
            }
            else
            {
                Console.WriteLine($"[Оператор <] Бюджет {iTCompany.Name} МЕНШИЙ або рівний {gameCompany.Name}");
            }
            // ==================================================
            // ВЕРСІЯ 5: Успадкування, Абстракція та Інтерфейси
            // ==================================================
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Версія 5: Успадкування та Поліморфізм");
            Console.WriteLine("==================================================");

            // 1. Тестуємо абстрактний метод ConductActivity (через базовий клас Organization)
            // Ми не можемо створити Organization, але можемо покласти компанію в змінну типу Organization!
            Organization orgCompany = iTCompany;
            Organization orgUniversity = university;

            Console.WriteLine("[Абстрактний метод з базового класу]:");
            orgCompany.ConductActivity("Розробка нового веб-сервісу");
            orgUniversity.ConductActivity("Проведення лекції з архітектури ПЗ");

            // 2. Створюємо стартап
            StartupProject myStartup = new StartupProject(
                "Eco-Tech AI",
                "Green Energy",
                15000.00,
                5,
                false
            );

            // 3. Тестуємо Інтерфейс IFundable (Поліморфізм)
            // Створюємо список з інтерфейсів і кладемо туди абсолютно РІЗНІ класи!
            List<IFundable> fundableProjects = new List<IFundable>
            {
                university, // Це Університет
                myStartup   // А це Стартап
            };

            Console.WriteLine("\n[Робота через Інтерфейс IFundable]:");
            foreach (IFundable item in fundableProjects)
            {
                // Програма сама розбереться, чий саме метод викликати
                item.ApplyForFunding(50000.00);
            }
            // 6. Фініш програми
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Фініш імітації ");
            Console.ReadLine();
        }
    }
}