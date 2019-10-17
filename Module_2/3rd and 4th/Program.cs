using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_and_4th
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop();
        }


        static void Loop()
        {
            Console.Clear();
            Console.WriteLine("For task 1 => press 1 ");
            Console.WriteLine("For task 2 => press 2 ");


            var line = Console.ReadLine();
            int choice;
            if (int.TryParse(line, out choice) == false)
            {
                Console.Clear();
                Console.WriteLine("wrong data input, try again input only digits");
                Loop();
            }
            else
            {
                Tasks(choice);
            }
        }

        static void Tasks(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine(string.Format("you choosed Task :{0}", choice));
                        Task1();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine(string.Format("you choosed Task :{0}", choice));
                        Task2();
                        var line = Console.ReadLine();
                        Loop();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("something wrong...");
                        var line = Console.ReadLine();
                        Loop();
                    }
                    break;
            }
        }

        static void Task1()
        {
            /*Очень часто нам необходимо поменять местами два числовых значения.
             * Программа просит пользователя ввести 2 числовые переменные.
             * А после она меняет их местами и выводит результат на экран.
             * Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например,
             * букву или строку, а так же учесть, что число может быть дробным,
             * и для выделения её дробной части одни используют точку, другие – запятую.*/
            Console.Clear();
            int a = 0, b = 0;
            bool ba = false, bb = false, ba1 = false, bb1 = false;
            double a1 = 0, b1 = 0;

            Console.WriteLine("Task1 enter two digits");
            Console.WriteLine("");
            Console.Write("Enter first digit=> ");
            string firstdigit = Console.ReadLine();

            if (firstdigit != null && firstdigit.Contains(",") || firstdigit != null && firstdigit.Contains(".")) // дроби
            {
                if (firstdigit.Contains("."))
                {
                    firstdigit = firstdigit.Replace(',', '.');
                }
                if (double.TryParse(firstdigit, out a1))// дробь
                {
                    a1 = Convert.ToDouble(firstdigit);

                    Console.WriteLine(string.Format("first number you enterd is : {0}", a1));

                    ba1 = true;
                }
                else
                {
                    Console.WriteLine("Wrong data input!!! try again");
                    Console.Write("press any key...");
                    Console.ReadLine();
                    Task1();
                }
            }
            else// простые числа
            {
                if (int.TryParse(firstdigit, out a))//простое число
                {
                    Console.WriteLine(string.Format("first number you enterd is : {0}", a));
                    ba = true;
                }
                else// это не простое число
                {
                    Console.WriteLine("Wrong data input!!! try again");
                    Console.Write("press any key...");
                    Console.ReadLine();
                    Task1();
                }
            }


            Console.Write("Enter second digit=> ");
            string secondigit = Console.ReadLine();

            if (secondigit != null && secondigit.Contains(",") || secondigit != null && secondigit.Contains(".")) // дроби
            {
                if (secondigit.Contains("."))
                {
                    secondigit = secondigit.Replace(',', '.');
                }
                if (double.TryParse(secondigit, out b1))// дробь
                {
                    b1 = Convert.ToDouble(secondigit);
                    Console.WriteLine(string.Format("first number you enterd is :  {0}", b1));
                    bb1 = true;
                }
                else
                {
                    Console.WriteLine("Wrong data input!!! try again");
                    Console.Write("press any key...");
                    Console.ReadLine();
                    Task1();
                }
            }
            else// простые числа
            {
                if (int.TryParse(secondigit, out b))//простое число
                {
                    Console.WriteLine(string.Format("first number you enterd is : {0}", b));
                    bb = true;
                }
                else// это не простое число
                {
                    Console.WriteLine("Wrong data input!!! try again");
                    Console.Write("press any key...");
                    Console.ReadLine();
                    Task1();
                }
            }
            if (ba && bb)
            {
                Console.WriteLine(string.Format("Result : {0} {1}", b, a));
            }
            if (ba1 && bb1)
            {
                Console.WriteLine(string.Format("Result : {0} {1}", b1, a1));
            }
            if (ba && bb1)
            {
                Console.WriteLine(string.Format("Result : {0} {1}", b1, a));
            }
            if (ba1 && bb)
            {
                Console.WriteLine(string.Format("Result : {0} {1}", b, a1));
            }

            Console.WriteLine("if you want to enter numbers again => press 1 ");
            Console.WriteLine("return to main => press 2 ");
            var line = Console.ReadLine();
            int choice;
            if (int.TryParse(line, out choice) == false)
            {
                Console.Clear();
                Console.WriteLine("wrong data input, try again input only digits");
                Loop();
            }
            else
            {
                if (choice == 1)
                {
                    Task1();
                }
                else
                {
                    Loop();
                }
            }
        }

        static void Task2()
        {
            /*Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг).
             * Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр. 
             * Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать, 
             * какими могли бы быть периметры или площади остальных фигур.*/
            Console.WriteLine("Task2 choose a figure for calculations");
            Console.WriteLine("");
            Console.WriteLine("for a triangle 1 => press 1 ");
            Console.WriteLine("for circle 2 => press 2 ");
            Console.WriteLine("for for quadrangle 3 => press 3 ");

            var line = Console.ReadLine();
            int choice2;
            if (int.TryParse(line, out choice2) == false)
            {
                Console.Clear();
                Console.WriteLine("wrong data input, try again input only digits");
                Loop();
            }
            else
            {
                switch (choice2)
                {
                    case 1://тригольник
                        {
                            Console.WriteLine("you choosed triangle ");
                            Console.WriteLine("");

                            Console.WriteLine("to calculate the area => press 1 ");
                            Console.WriteLine("to count the perimeter => press 2 ");

                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("wrong data input, try again input only digits");
                                Task2();
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Area=1/2*a*h");
                                        Console.Write("enter a=> ");
                                        var a = Console.ReadLine();
                                        Console.Write("enter h=> ");
                                        var h = Console.ReadLine();
                                        double result = 0.5 * Convert.ToDouble(a) * Convert.ToDouble(h);

                                        Console.WriteLine(string.Format("Area=1/2*{0}*{1}={2}", a, h, result));
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("perimetr=a+b+c");
                                        Console.Write("enter a=> ");
                                        var a = Console.ReadLine();
                                        Console.Write("enter b=> ");
                                        var b = Console.ReadLine();
                                        Console.Write("enter c=> ");
                                        var c = Console.ReadLine();

                                        double result = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);

                                        Console.WriteLine(string.Format("Perimetr={0}+{1}+{2}={3}", a, b, c, result));
                                    }
                                    break;
                            }

                        }
                        break;
                    case 2://круг
                        {
                            Console.WriteLine("you choosed circle ");
                            Console.WriteLine("");

                            Console.WriteLine("to calculate the area => press 1 ");
                            Console.WriteLine("to count the perimeter => press 2 ");

                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("wrong data input, try again input only digits");
                                Task2();
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Area=Pir^2");
                                        Console.Write("enter Radius=> ");
                                        var R = Console.ReadLine();

                                        double result = Math.PI * Math.Pow(Convert.ToDouble(R), 2);

                                        Console.WriteLine(string.Format("Perimetr=3.14*{0}^2={1}", R, result));
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("perimetr=2PiR");
                                        Console.Write("enter Radius=> ");
                                        var R = Console.ReadLine();

                                        double result = 2 * Math.PI * Convert.ToDouble(R);

                                        Console.WriteLine(string.Format("Perimetr=2*3.14*{0}={1}", R, result));
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3://четырехугольник
                        {
                            Console.WriteLine("you choosed quadrangle ");
                            Console.WriteLine("");

                            Console.WriteLine("to calculate the area => press 1 ");
                            Console.WriteLine("to count the perimeter => press 2 ");
                            line = Console.ReadLine();
                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("wrong data input, try again input only digits");
                                Task2();
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter length of the side");
                                        var a = Console.ReadLine();
                                        double result = Convert.ToDouble(a) * Convert.ToDouble(a);
                                        Console.WriteLine($"The square is : {result}");
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Enter length of the side");
                                        var a = Console.ReadLine();
                                        double result = Convert.ToDouble(a)  * 4;
                                        Console.WriteLine($"Perimeter is : {result}");
                                        Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("something wrong...");
                            Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}