using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, operation;
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.WriteLine("Введите первое число...");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число...");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции между первым и вторым числом:");
                Console.WriteLine("     1 - сложение");
                Console.WriteLine("     2 - вычитание");
                Console.WriteLine("     3 - умножение");
                Console.WriteLine("     4 - деление");
                operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вы ввели {0}", operation);
                switch (operation)
                {
                        case 1:
                            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                            break;
                        case 2:
                            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
                            break;
                        case 3:
                            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
                            break;
                        case 4:
                            try
                            {
                            int answer = firstNumber / secondNumber;
                                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, (double)firstNumber / secondNumber);
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Нет операции с указанным номером!");
                            break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Перезапустите приложение");
            }

          
            
            Console.ReadLine();
        }
    }
}
