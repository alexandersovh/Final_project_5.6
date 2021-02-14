using System;

namespace Final_project_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите с маленькой буквы на русской раскладке");
            GetCortej();
            Console.ReadKey();
        }
        static (string Name, string Lastname, int Age) EnterUser() // ФИО В, Кортеж
        {
            (string Name, string Lastname, int Age) User;

            Console.Write("Введите имя ");
            User.Name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            User.Lastname = Console.ReadLine();
            Console.Write("Введите возрост ");
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
            Console.Write("сколько у вас любимых цветов ");
            int numColor = CheckName();
            string[] arrColor = new string[numColor];

            for (int i = 0; i < arrColor.Length; i++)
            {
                Console.Write("введите {0}-й любимый цвет на русском с маленькой буквы:", i + 1);
                string color = Console.ReadLine();
                switch (color)
                {
                    case "красный":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "синий":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "голубой ":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "желтый":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "пурпурный":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "белый":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
                        break;
                    case "сервй":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.WriteLine("Your color is {0}!", color);
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
        static void GetCortej()
        {
            var setUs = EnterUser();
            var dataCortej = (pat: NumPat(), color: ShowColor());
            Console.WriteLine("Ваше имя: {0} \nВаша фамилия: {1} \nВаш возрост: {2}",setUs.Name, setUs.Lastname, setUs.Age);
            Console.WriteLine("Ваши домашние животные: ");
            foreach (string p in dataCortej.pat)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Любимые цвета:");
            foreach (string p in dataCortej.color)
            {
                Console.WriteLine(p);
            }
        }
    }
}
