namespace prakticheskaya_s_metodami_________________
{
    internal class Program
    {
        static void Main()
        {
            int nomerigri = 0;
            do
            {
                Console.WriteLine("Чтобы выбрать программу, введите число, указанное перед ней.");
                Console.WriteLine("1 - 'Угадай число' \n2 - 'Таблица умножения'\n3 - 'Вывод делителей числа'\n4 - 'Время года' \n5 - Выбор цвета текста \n6 - Выйти из программы");
                string strnomerigri = (Console.ReadLine());
                if (strnomerigri.Length > 1)
                    Console.WriteLine("Вы ввели больше 1 символа в строку");
                else if (strnomerigri.Length == 0)
                    Console.WriteLine("Вы не ввели в строку символ");
                else
                {
                    int a;
                    bool sucsess = int.TryParse(strnomerigri, out a);
                    if (sucsess)
                        nomerigri = a;
                    else
                        Console.WriteLine("Вы не ввели в строку цифру");
                }
                if (nomerigri == 1)
                    igra1();
                if (nomerigri == 2)
                    igra2();
                if (nomerigri == 3)
                    igra3();
                if (nomerigri == 4)
                    igra4();
                if (nomerigri == 5)
                    colorchose();
            } while (nomerigri != 6);
            static void igra1()
            {
                Console.Clear();
                Console.WriteLine("1 - 'угадай число)'");
                Console.WriteLine("Попробуйте угадать число от 1 до 100 ^_^ )))))))");
                int users_chislo = 0;
                int stop = 1;
                do
                {
                    Random rnd = new Random();
                    int random_chislo = rnd.Next(1, 100);
                    do
                    {

                        Console.WriteLine("Введите ваше число: ");
                        string strusers_chislo = (Console.ReadLine());
                        if (strusers_chislo.Length == 0)
                            Console.WriteLine("Вы не ввели в строку символ");
                        else
                        {
                            int a;
                            bool sucsess = int.TryParse(strusers_chislo, out a);
                            if (sucsess)
                            {
                                if ((a >= 101) || (a < 1))
                                    Console.WriteLine("Я же сказал от 1 до 100((");
                                else
                                {
                                    users_chislo = a;
                                    if (users_chislo != random_chislo)
                                    {
                                        if (users_chislo > random_chislo)
                                            Console.WriteLine("Вы не угадали, попробуйте число поменьше");
                                        else
                                            Console.WriteLine("Вы не угадали, попробуйте число побольше");
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Вы ввели в строку не только цифры");
                        }
                    }
                    while (users_chislo != random_chislo);
                    Console.WriteLine("ОГО КРАСАВА УГАДАЛ ЧИСЛО!!");
                    Console.WriteLine("Чтобы вернуться в меню, введите Escape");
                    if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                    {
                        Console.WriteLine("Вы не нажали Escape, сейчас программа начнется заново через: ");

                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(250);
                        }
                        Console.Clear();
                    }
                    else
                        stop = 0;
                    Console.Clear();
                } while (stop != 0);
            }
            static void igra2()
            {
                int stop = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("2 - 'Таблица умножения'");
                    int[,] tab = new int[11, 11];
                    for (int a = 1; a != tab.GetLength(0); a++)
                    {
                        for (int b = 1; b != tab.GetLength(1); b++)
                            tab[a, b] = a * b;
                    };
                    for (int a = 1; a != tab.GetLength(0); a++)
                    {
                        for (int b = 1; b != tab.GetLength(1); b++)
                        {
                            if ((a < 10) && (b < 10))
                            {
                                if (a * b < 10)
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + "    ");
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + "   ");
                                    Console.Write(" ");
                                }
                            }
                            else if ((a < 10) || (b < 10))
                            {
                                if (a * b < 10)
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + "   ");
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + "  ");
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                if (a * b < 10)
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + "  ");
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write(a + " * " + b + " = " + tab[a, b] + " " + " ");
                                    Console.Write(" ");
                                }

                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Чтобы вернуться в меню, введите Escape");
                    if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                    {
                        Console.WriteLine("Вы не нажали Escape, сейчас программа начнется заново через: ");

                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(250);
                        }
                        Console.Clear();
                    }
                    else
                        stop = 0;
                    Console.Clear();
                } while (stop != 0);
            }
            static void igra3()
            {
                Console.WriteLine(" 3 - 'Вывод делителей числа'");
                int stop = 1;
                Console.Clear();
                do
                {
                    List<int> deliteli = new List<int>();
                    Console.WriteLine("Введите число, для которого будут выведены делители:");
                    string strch_igr3 = (Console.ReadLine());
                    int ch_igr3 = 0;
                    if (strch_igr3.Length == 0)
                        Console.WriteLine("Вы не ввели в строку символ");
                    else
                    {
                        bool sucsess = int.TryParse(strch_igr3, out ch_igr3);
                        if (sucsess)
                        {
                            if (ch_igr3 > 0)
                            {
                                for (int i = 1; i <= ch_igr3; i++)
                                {
                                    if (ch_igr3 % i == 0)
                                    {
                                        deliteli.Add(i);
                                    }

                                }
                                Console.WriteLine("Все делители числа " + ch_igr3 + ": ");
                                foreach (int delitel in deliteli)
                                {
                                    Console.Write(delitel + ", ");
                                }
                                Console.WriteLine("Чтобы вернуться в меню, введите Escape");
                                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                                {
                                    Console.WriteLine("Вы не нажали Escape, сейчас программа начнется заново через: ");

                                    for (int i = 5; i > 0; i--)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(250);
                                    }
                                    Console.Clear();
                                }
                                else
                                {
                                    stop = 0;
                                    Console.Clear();
                                }
                            }
                            else Console.WriteLine("Введите число больше 0");

                        }
                        else
                            Console.WriteLine("Вы не ввели в строку не только цифры");
                    }

                } while (stop != 0);
            }
            static void igra4()
            {
                Console.Clear();
                Console.WriteLine("4 -  Время года ");
                int nomer;
                int stop = 1;
                do
                {
                    Console.WriteLine("Введите номер месяца: ");
                    string strnomer = Console.ReadLine();
                    if (strnomer.Length == 0)
                        Console.WriteLine("Вы не ввели в строку символ");
                    else
                    {
                        bool sucsess = int.TryParse(strnomer, out nomer);
                        if (sucsess)
                        {
                            if ((nomer > 12) || (nomer < 1))
                                Console.WriteLine("В году всего 12 месяцев....");
                            else
                            {
                                if ((nomer == 12) || (nomer == 1) || (nomer == 2))
                                    Console.WriteLine("Зима(");
                                else if ((nomer == 3) || (nomer == 4) || (nomer == 5))
                                    Console.WriteLine("Весна)");
                                else if ((nomer == 6) || (nomer == 7) || (nomer == 8))
                                    Console.WriteLine("Лето))))))))");
                                else if ((nomer == 9) || (nomer == 10) || (nomer == 11))
                                    Console.WriteLine("Осень(");
                                Console.WriteLine("Чтобы вернуться в меню, введите Escape");
                                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                                {
                                    Console.WriteLine("Вы не нажали Escape, сейчас программа начнется заново через: ");
                                    for (int i = 5; i > 0; i--)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(250);
                                    }
                                    Console.Clear();
                                }
                                else
                                {
                                    stop = 0;
                                    Console.Clear();
                                }
                            }

                        }
                        else
                            Console.WriteLine("Вы ввели в строку не только цифры");
                    }
                } while (stop != 0);
            }
            static void colorchose()
            {
                int stop = 1;
                Console.Clear();     
                do
                { 
                Console.WriteLine("Выберете цвет текста");
                Console.WriteLine("1 - Синий \n2 - Серый \n3 - Зеленый \n4 - Пурпурный \n5 - Красный \n6 - Белый \n7 - Желтый \n8 - Голубой (сине-зеленый)");
                Console.WriteLine("9 - Темно-синий \n10 - Темный сине-зеленый\n11 - Темно-серый\n12 - Темно-зеленый \n13 - Темно-пурпурный\n14 - Темно-красный\n15 - Темно-желтый");
                string color = Console.ReadLine();
                    if (color.Length == 0)
                    { 
                        Console.WriteLine("Вы не ввели в строку символ\nПрограмма перезапутится через:");
                        for (int i = 4; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(550);
                        }
                        Console.Clear();
                    }
                    else 
                    {
                        int c;
                        bool sucsess = int.TryParse(color, out c);
                        if (sucsess)
                        {
                            if ((c < 1) || (c > 15))
                            {
                                Console.WriteLine("Вы ввели число не из предложенного диапазона\nПрограмма перезапустится через: ");
                                for (int i = 4; i > 0; i--)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(550);
                                }
                                Console.Clear();
                            }
                            else
                            {
                                switch (c)
                                {
                                    case 1:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            break;
                                        }
                                    case 10:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            break;
                                        }
                                    case 11:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            break;
                                        }
                                    case 12:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            break;
                                        }
                                    case 13:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            break;
                                        }
                                    case 14:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            break;
                                        }
                                    case 15:
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            break;
                                        }

                                }
                                Console.WriteLine("Чтобы вернуться в меню, введите Escape");
                                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                                {
                                    Console.WriteLine("Вы не нажали Escape, сейчас программа начнется заново через: ");
                                    for (int i = 5; i > 0; i--)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(250);
                                    }
                                    Console.Clear();
                                }
                                else
                                {
                                    stop = 0;
                                    Console.Clear();
                                }
                            }
                        }
                        else
                        { 
                            Console.WriteLine("Вы ввели в строку не только цифры \n Программа перезапустится через:"); 
                            for (int i = 4; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(550);
                            }
                            Console.Clear();

                        }
                        }
                } while (stop != 0);
            }
        }
    }
}