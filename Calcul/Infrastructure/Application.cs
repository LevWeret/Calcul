using Domain;
using System;
using CalculatorOperations;

namespace Infrastructure
{
    public class Application
    {
        private readonly IMenu<IOperation> menu;

        public Application(IMenu<IOperation> menu)
        {
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                var operation = menu.Show().ItemSelector.Select();
                if (operation == null) break;

                double result;
                try
                {
                    if (operation is Sin || operation is Cos || operation is Tan || operation is Cotan || operation is NaturalLogarithm || operation is DecimalLogarithm)
                    {
                        result = operation.Run(GetInput("Введите число: "));
                    }
                    else
                    {
                        result = operation.Run(GetInput("Введите первое число: "), GetInput("Введите второе число: "));
                    }

                    Console.WriteLine($"Результат: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Неверный формат числа.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        private double GetInput(string prompt)
        {
            Console.Write(prompt);
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка: Неверный формат числа. Пожалуйста, введите число снова.");
                Console.Write(prompt);
            }
            return input;
        }
    }
}
