using System;

class SimpleCalculator
{
    static void Main()
    {
        double memoryStorage = 0; // Для операций с памятью

        while (true)
        {
            Console.WriteLine("=== Калькулятор ===");
            Console.WriteLine("Выберите операцию: + - * / % 1/x x^2 √ M+ M- MR Q(выход)");
            Console.Write("Ввод: ");
            string operation = Console.ReadLine();

            if (operation.Equals("Q", StringComparison.OrdinalIgnoreCase))
                break; // Выход из программы

            if (operation == "MR")
            {
                Console.WriteLine("Текущее значение в памяти: " + memoryStorage);
                continue;
            }

            Console.Write("Введите число: ");
            if (!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
                continue;
            }

            double secondNumber = 0;
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
            {
                Console.Write("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Ошибка! Введите корректное число.");
                    continue;
                }
            }

            switch (operation)
            {
                case "+": 
                    Console.WriteLine("Результат: " + (firstNumber + secondNumber)); 
                    break;
                case "-": 
                    Console.WriteLine("Результат: " + (firstNumber - secondNumber)); 
                    break;
                case "*": 
                    Console.WriteLine("Результат: " + (firstNumber * secondNumber)); 
                    break;
                case "/": 
                    if (secondNumber != 0) 
                        Console.WriteLine("Результат: " + (firstNumber / secondNumber));
                    else 
                        Console.WriteLine("Ошибка: Деление на ноль!");
                    break;
                case "%": 
                    if (secondNumber != 0) 
                        Console.WriteLine("Результат: " + (firstNumber % secondNumber));
                    else 
                        Console.WriteLine("Ошибка: Деление на ноль!");
                    break;
                case "1/x": 
                    if (firstNumber != 0) 
                        Console.WriteLine("Результат: " + (1 / firstNumber));
                    else 
                        Console.WriteLine("Ошибка: Деление на ноль!");
                    break;
                case "x^2": 
                    Console.WriteLine("Результат: " + Math.Pow(firstNumber, 2)); 
                    break;
                case "√": 
                    if (firstNumber >= 0) 
                        Console.WriteLine("Результат: " + Math.Sqrt(firstNumber));
                    else 
                        Console.WriteLine("Ошибка: Невозможно извлечь корень из отрицательного числа");
                    break;
                case "M+": 
                    memoryStorage += firstNumber; 
                    Console.WriteLine("Память: " + memoryStorage); 
                    break;
                case "M-": 
                    memoryStorage -= firstNumber; 
                    Console.WriteLine("Память: " + memoryStorage); 
                    break;
                default: 
                    Console.WriteLine("Неизвестная операция."); 
                    break;
            }

            Console.WriteLine(); // Пустая строка для удобства
        }
    }
}
