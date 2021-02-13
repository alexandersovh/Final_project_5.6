using System;

namespace Final_project_5._6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
        static (string Name, string Lastname, int Aage) EnterUser() // ФИО В, Кортеж
        {
            (string Name, string Lastname, int Age) User;

            Console.Write("Введите имя ");
            User.Name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            User.Lastname = Console.ReadLine();

            int protAge = CheckName();
            int agenum = 0;
            if (protAge > 0)
            {
                agenum = protAge;
            }
            else
            {
                protAge = CheckName();
            }
            User.Age = agenum;
            return User;

        }
        static string[] NumPat()//ЗВЕРЬКИ мас строк
        {
            Console.WriteLine("Есть ли у вас домашние животные");

            string answer = Console.ReadLine();

            int lol = 1;

            string[] pat = new string[lol];

            if (answer == "да")
            {
                Console.WriteLine("Сколько у вас домашние животныые");
                lol = CheckName();
                pat = new string[lol];
                for (int i = 0; i < lol; i++)
                {
                    Console.WriteLine("введите клички {0}-го животных", i + 1);
                    Console.Write(i + 1 + " ");
                    string patName = Console.ReadLine();
                    pat[i] = patName;
                }
            }
            else
            {
                pat[0] = "домашнх животных не имеет";
            }
            return pat;
        }
        static string[] ShowColor()//ЦВЕТА, их выбор мас строк
        {
            int numColor = CheckName();
            string[] arrColor = new string[numColor];

            for (int i = 0; i < arrColor.Length; i++)
            {
                Console.WriteLine("введите {0}-й любимый цвет ", i + 1);
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "magenta":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "white":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "gray":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is {0}!", color);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is black!");
                        break;
                }
                arrColor[i] = color;
            }
            return arrColor;
        }
        static int CheckName()//ПРОВЕРКА правельности ввода числа
        {

            int b = 0;
            string a;
            bool cycle = false;

            while (cycle != true)
            {
                a = Console.ReadLine();
                if ((int.TryParse(a, out b)) && (b > 0))
                {
                    cycle = true;
                }
                else
                {
                    cycle = false;
                    Console.WriteLine("некоррекноое число");
                }
            }
            return b;
        }
    }
}
