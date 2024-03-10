using System;

class Program
{
    static void Main()
    {
        // Завдання 1: Калькулятор систем обчислення
        Console.WriteLine("Виберіть напрям конвертації:");
        Console.WriteLine("1. Десяткова до Двійкова");
        Console.WriteLine("2. Двійкова до Десяткова");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть число:");

        try
        {
            string input = Console.ReadLine();
            int number;

            if (choice == 1)
            {
                number = int.Parse(input);
                Console.WriteLine("Результат: " + Convert.ToString(number, 2));
            }
            else if (choice == 2)
            {
                number = Convert.ToInt32(input, 2);
                Console.WriteLine("Результат: " + number);
            }
            else
            {
                Console.WriteLine("Невірний вибір.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Невірне введення. Будь ласка, введіть правильне число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Перевищено межі діапазону int.");
        }

        // Завдання 2: Переведення слова у цифру
        Console.WriteLine("\nВведіть слово від 0 до 9:");
        string wordInput = Console.ReadLine().ToLower();

        switch (wordInput)
        {
            case "zero":
                Console.WriteLine("Результат: 0");
                break;
            case "one":
                Console.WriteLine("Результат: 1");
                break;
            case "two":
                Console.WriteLine("Результат: 2");
                break;
            // Додайте інші варіанти від "three" до "nine"
            default:
                Console.WriteLine("Невірне введення.");
                break;
        }

        // Завдання 3: Клас "Закордонний паспорт"
        try
        {
            Passport passport = new Passport("AB123456", "John Doe", DateTime.Now);
            // Додайте інші дії з паспортом за потреби
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\nПомилка ініціалізації паспорту: " + ex.Message);
        }

        // Завдання 4: Логічний вираз
        Console.WriteLine("\nВведіть логічний вираз (наприклад, 3>2 або 7<3):");
        string logicalExpression = Console.ReadLine();

        try
        {
            bool result = EvaluateLogicalExpression(logicalExpression);
            Console.WriteLine("Результат: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Невірне введення. Будь ласка, введіть правильний вираз.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }

    // Метод для обробки логічного виразу
    static bool EvaluateLogicalExpression(string expression)
    {
        // Реалізуйте обробку логічного виразу тут і поверніть результат
        return false; // Приклад. Вам потрібно реалізувати правильний код.
    }
}

// Клас для завдання 3: Клас "Закордонний паспорт"
class Passport
{
    private string passportNumber;
    private string ownerName;
    private DateTime issueDate;

    public Passport(string number, string name, DateTime date)
    {
        if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(name) || date == DateTime.MinValue)
        {
            throw new ArgumentException("Неправильні значення для ініціалізації.");
        }

        passportNumber = number;
        ownerName = name;
        issueDate = date;
    }
}