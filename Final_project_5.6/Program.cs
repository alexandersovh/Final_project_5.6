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
        /// <summary>
        /// ФИО В, Кортеж
        /// </summary>
        /// <returns></returns>
        static (string Name, string Lastname, int Age) EnterUser()
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
        /// <summary>
        /// ЗВЕРЬКИ мас строк
        /// </summary>
        /// <returns></returns>
        static string[] NumPat()
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
                for (int i = 1; i <= lol; i++)
                {
                    Console.WriteLine("введите клички {0}-го животных", i);

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
        /// <summary>
        /// ЦВЕТА, их выбор мас строк
        /// </summary>
        /// <returns></returns>
        static string[] ShowColor()
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
                        break;
                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "синий":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "голубой ":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "желтый":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "пурпурный":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "белый":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "сервй":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }
                arrColor[i] = color;
            }
            return arrColor;
        }
        /// <summary>
        /// ПРОВЕРКА правельности ввода числа
        /// </summary>
        /// <returns></returns>
        static int CheckName()
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
