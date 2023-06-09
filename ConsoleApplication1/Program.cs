using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            //Основные типы int float
            //целочисленные типы
            byte b; //0 255
            sbyte sb; // -128 127
            short s;
            ushort us;
            int i;
            uint ui;
            long l = long.MaxValue;
            ulong ul;
            //числа с плавующей точкой
            float f = 5.7f;
            double d = 5.7;
            //симовольный тип
            char c = ' ';
            //строковый тип
            string str = "You are my soulmate";
            //logic type
            bool bl = true;

            int age = 27;
            age = 30;
            */

            // float result;
            // int x, y;
            // x = 6;
            // y = 5;
            // Console.WriteLine(Convert.ToSingle(x)/y);

            // int timeInMinutes = 130;
            // int hour;
            // int minute;
            // hour = timeInMinutes / 60;
            // minute = timeInMinutes % 60;
            // Console.WriteLine($"{hour}{minute}");

            // int result = 5 + (12 - 5) * 3 - 1 + 5 * 2;
            // Console.WriteLine((result));

            // bool accesAge;
            // accesAge = 5!=4;
            // Console.WriteLine(accesAge);
            //
            // int age = 5;
            // Console.WriteLine(5+(5+"hello you looks like " + (age+1)));

            // int age;
            // string input = "15";
            // age = Convert.ToInt32(input);
            // Console.WriteLine(age);

            // float result;
            // int x = 5, y = 2;
            // result = Convert.ToSingle(x) / y;
            // Console.WriteLine(result);
            // int trigger = 1;
            // bool triggerInBoolean = Convert.ToBoolean(trigger);
            // Console.WriteLine(triggerInBoolean);
            // int reconvert = Convert.ToInt32(triggerInBoolean);
            // Console.WriteLine(reconvert);
            // Console.WriteLine();
            // Console.ReadLine();

            //работа с консолью

            // string name;
            // Console.Write("enter your name ");
            // name = Console.ReadLine();
            // Console.WriteLine($"Your name:{name}");
            // int age;
            // Console.Write("Enter your age");
            // age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Your age is {age}");

            // int A = 0;
            // //                   1   + 2 + 1           1 + "1"  3*2   
            // Console.WriteLine((++A) + 2 + 1 + (A++) + "1" +  (++A)*2);

            //  gameOfThrones
            /*
            float health;
            int armor;
            float demage;
            int precentConventer = 100;
            Console.Write("Enter health value: ");
            health = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter armor value: ");
            armor = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter demage value: ");
            demage = Convert.ToInt32(Console.ReadLine());
            
            // health -= demage * armor / precentConventer;
            health -= Convert.ToSingle(demage)/ precentConventer*armor;
            Console.WriteLine($"Your hit damage: {demage}, You have health: {health}, your armor is {armor}");
            */


            // store
            /*
            int money;
            int food;
            int foodUnikPrice = 10;
            bool isAbleToPay;
            Console.WriteLine("Welcome to store, Today all food on a special" + foodUnikPrice + "coins");
            Console.Write("How many money you have?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам  нужно");
            food = Convert.ToInt32(Console.ReadLine());
            isAbleToPay = money >= food * foodUnikPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnikPrice;
            Console.WriteLine($"you have{food} and coins: {money}");
            */


            //&&
            // int money = 500;
            // int level = 500;
            // if (money >= 500 || level > 9)
            // {
            //     Console.WriteLine("Welcome to our gild");
            // }
            // else
            // {
            //     Console.WriteLine("Goodbye");
            // }
            /*string dayOfWeek;
            Console.WriteLine("Enter day of week");
            dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {
                case "понедельник":
                    Console.WriteLine("go to cinema");
                    Console.WriteLine("eat popkorn");
                    break;
                case "вторник":
                    Console.WriteLine("go to cinema");
                    Console.WriteLine("eat popkorn");
                    break;
                case "среда":
                    Console.WriteLine("изучаем switch");
                    
                    break;  
                case "четверг":
                    Console.WriteLine("go to cinema");
                    Console.WriteLine("eat popkorn");
                    break;  
                case "пятница":
                    Console.WriteLine("go to cinema");
                    Console.WriteLine("eat popkorn");
                    break;  
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("go to cinema");
                    Console.WriteLine("eat popkorn");
                    break;  
                default:
                    Console.WriteLine("Я такого дня не знаю");
             break;
            }*/




            // if (dayOfWeek == "Понедельник")
            // {
            //     Console.WriteLine("Проходим курсы");
            // }
            //
            // else if (dayOfWeek == "вторник")
            // {
            //     Console.WriteLine("Делаем дз");
            // }

            // string password = "So127571";
            // string userInput;
            // Console.WriteLine("Enter your password");
            // userInput = Console.ReadLine();
            // if (userInput == password)
            // {
            //     Console.WriteLine("access");
            // }
            // else
            // {
            //     Console.WriteLine("block");
            // }


            /*
            float rublesInWallet;
            float dollarsInWallet;

            int rubToUsd = 64;
            int usdToRub = 66;

            float exchangeCurrencyCount;
            string desiredOperation;
            Console.WriteLine("Welcome в обменнк валют");
            Console.WriteLine("введите баланс рублей");
            rublesInWallet = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("введите баланс долларов");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Выберите неоходимую операцию");
            Console.WriteLine("1 - Обменять рубли на доллары");
            Console.WriteLine("2 - Обменять доллары на рубли");
            Console.WriteLine("Ваш выбор");
            desiredOperation = Console.ReadLine();
            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.WriteLine("Сколько вы хотите обменять");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей");
                    }
                   break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько вы хотите обменять");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов");
                    }
                    break;
                default:
                    Console.WriteLine("Выюрана неверная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланас {rublesInWallet} рублей  ${dollarsInWallet} долларов");
        */

            // int age;
            // Console.WriteLine("enter your age");
            // age = Convert.ToInt32(Console.ReadLine());
            // while (age-- >0)
            // {
            //     if (age == 5)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(age);
            // }

            // int age;
            // Console.WriteLine("enter your age");
            // age = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i <= age; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine($"happy birthday {i}");
            // }


            /*int tryCount =5;
            string password = "127571";
            string userInput;
            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Enter your password");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("secret");
                break;
                }
                else
                {
                    Console.WriteLine("entered never password");
                    Console.WriteLine($"У вас осталось {tryCount -i -1} попытки");
                }
            }*/


            /*int playerHealth = 10;
            int playerDemage = 10;
            int enemyHealth = 10;
            int enemyDemage = 10;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDemage;
                enemyHealth -= playerDemage;
                Console.WriteLine($"здоровье игрока: {playerHealth}");
                Console.WriteLine($"здоровье врага: {enemyHealth}");
            }

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("ничья");
            }else if (enemyHealth <= 0)
            {
                Console.WriteLine("победа игрока");
            }else if (playerHealth <= 0)
            {
                Console.WriteLine("победа врага");
            }
            {
                
            }*/


            // Random rand = new Random();
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(rand.Next(0,5));
            // }

            /*int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number+10);
            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher} ");
            Console.WriteLine($"У вас осталось {triesCount}");
            while (triesCount -->0)
            {
                Console.WriteLine("Your answer:");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine($"You are rigth it is a: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine($"error, вы неугадали число you have {triesCount} tries");
                }

            }

            if (triesCount >= 0) return;
            Console.WriteLine($" вы проиграли, это было число:{number}");*/


            /*Random rand = new Random();
            float health1  = rand.Next(90, 100);
            int demage1= rand.Next(5, 20);
            int armor1= rand.Next(25, 65);
            float health2= rand.Next(80, 150);
            int demage2= rand.Next(20, 40);
            int armor2= rand.Next(65, 100);
            Console.WriteLine($"Гладиатор1 - {health1} здоровья {demage1} наносимый урон {armor1} броня");
            Console.WriteLine($"Гладиатор2 - {health2} здоровья {demage2} наносимый урон {armor2} броня");
            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, demage2 + 1))/100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, demage1 + 1))/100 * armor1;
                Console.WriteLine($"здровье гладиатора1 {health1}");
                Console.WriteLine($"здровье гладиатора2 {health2}");
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья");
            }else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 проиграл");
            }else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 проиграл");
            }*/

            // Хитрости работы с консолью
            // Console.SetCursorPosition(5,10);
            // Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Console.BackgroundColor = ConsoleColor.DarkGray;
            // Console.Clear();
            // Console.WindowHeight = 10;
            // Console.WindowWidth = 35;
            // Console.WriteLine("Hello, Vasya\nwhere were you been yeasterday\ni went to ...]\b \b");
            // // Console.Clear();

            // int[] apples = new int [10];
            // int[] apples = {24,25,17,38,100, int.MaxValue, Int32.MinValue, };
            // int[] apples = new int [4]{27,1,6,50};
            // // Console.WriteLine(apples[0]);
            // // Console.WriteLine(apples.Length);
            // // Random rand = new Random();
            //
            // for (int i = 0; i < apples.Length; i++)
            // {
            //     // apples[i] = rand.Next(0,101);
            //     Console.WriteLine(apples[i]);
            // }


            // int[] arr = { 100, 50, 300 };
            // int sum = 0;
            // for (int i = 0; i < arr.Length;i++)
            // {
            //     sum += arr[i];
            // }
            // Console.WriteLine(sum);

            /*int[] arr = { 1, 50, 100, 55, 101, 12 };
            int maxValue = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
                
            }
            
            Console.WriteLine(maxValue);*/



            /*int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"In sectror {i+1} свободно {sectors[i]} мест");
                }
                
              
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Регистрация рейса");
                Console.WriteLine("\n\n1 - забронировать места\n\n2 - выход из программы\n\n");
                Console.Write("Введите номер команды");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine())-1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                        break;
                        }
                        Console.WriteLine("Сколько хотите мест забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверное кол-во мест");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест, отсаток {sectors[userSector]}");
                        break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine($"Бронирование прошло успешно, ваш сектор:{userSector+1} кол-во мест: {userPlaceAmount}");
                        break;
                    
                    case 2:
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }*/



            /*int[,] arr3 = new int[15, 25];
            Random rand = new Random();
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i,j] = rand.Next(0,10);
                    Console.Write(arr3[i,j]+ " ");
                }

                Console.WriteLine();
            }*/





            /*// БИБЛИОТЕКА
            string[,] books =
            {
                { "Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин" },
                { "Роберт Мартин", "Джесси Шелл", "Сергей Есенин" },
                { "Стивен Кинг", "Говард Лавкрафт", "Брем Стокер" }, 
            };
            bool isOpen = true;
            
            while (isOpen)
            {
                Console.SetCursorPosition(0,20);
                Console.WriteLine("Весь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i,j]+ " | ");
                    }

                    Console.WriteLine();
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать имя автора по индексу книги.\n\n2 - найти книгу по автору.\n\n3 -выход");
                Console.Write("\nВыберите пункт меню:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Это автор {books[line-1, column-1]}");
                        
                            
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++){
                            for (int j = 0; j < books.GetLength(1); j++)
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write($"автор {books[i, j]} находится по адресу полка:{i + 1}, место: { j + 1}");
                                    authorIsFound = true;
                                }
                        }

                        if (!authorIsFound)
                        {
                            Console.WriteLine("Такого автора нет");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nнажмите любую клавшу для продолжения...");
                }
                Console.ReadKey();
                Console.Clear();
            }*/

            // int[] arr = new int [3];
            // int[] tempArr = new int [5];
            // arr = tempArr;
            // arr[1] = 5;
            // Console.WriteLine(tempArr[1]);
            // int[] petrovich = new int [3];
            // int[] ivanovich = new int [4];
            // int[] sidorovich;
            //
            // petrovich = ivanovich;
            // petrovich[0] = 5;
            // ivanovich[1] = 3;
            // sidorovich = petrovich;
            // sidorovich[0] = 10;k
            // Console.WriteLine(petrovich[0]);
            // Console.WriteLine(petrovich[1]);
            //
            // petrovich = new int[10];

            /*int[] bag = new int [1];
            bag[0] = 12;
            int[] tempBag = new int[bag.Length+1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
                Console.WriteLine(bag[i] + "первый");
            }

            tempBag[tempBag.Length - 1] = 56;
            bag = tempBag;
            for (int i = 0; i < bag.Length; i++)
            {
                Console.WriteLine(bag[i] + " второй");
            }*/






            /*
            Console.CursorVisible = false;
            char[,] map =
            {
                { '#', '#', '#', '#', '#', '#', '#', '#','#','#','#','#','#','#','#','#' },
                { '#', ',', '#', ',', ',', ',', ',', ',',',',',',',',',',',',',',',','#' },
                { '#', ',', '#', ',', 'X', ',', ',', ',',',',',',',',',','X',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', ',',',',',',',',',',',',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', ',',',',',',',',',',',',',',',','#' },
                { '#', ',', ',', ',', ',', ',', ',', '#',',',',',',',',',',',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', '#',',',',',',',',','X',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', '#','#',',',',',',',',',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', ',','#',',',',',',',',',',',',','#' },
                { '#', ',', '#', ',', ',', ',', ',', ',','#',',',',',',',',',',',',','#' },
                { '#', '#', '#', '#', '#', '#', '#', '#','#','#','#','#','#','#','#','#' },
            };
            int x = 6, y = 6;
            char[] bag = new char[1];
            
            

                while (true)
                {
                    Console.SetCursorPosition(0,20);
                    Console.Write("Сумка");
                    for (int i = 0; i < bag.Length; i++)
                    {
                        Console.Write(bag[i] + " ");
                    }
            Console.SetCursorPosition(0,0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]+ " ");
                }
                Console.WriteLine();
                    
                }
            Console.SetCursorPosition(x,y);
            Console.Write('@');
            ConsoleKeyInfo charKey = Console.ReadKey();
            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[x - 1, y] != '#')
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[x + 1, y] != '#')
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[x, y - 1] != '#')
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[x, y + 1] != '#')
                    {
                        x++;
                    }
                    break;
            }

            if (map[x, y] == 'X')
            {
                map[x, y] = 'О';
                char[] tempBag = new char[bag.Length + 1];
                for (int i = 0; i < bag.Length; i++)
                {
                    tempBag[i] = bag[i];
                }

                tempBag[tempBag.Length - 1] = 'X';
                bag = tempBag;
            }
            
            Console.Clear();
            }
            */

            // int[] numbers = { 0, 1, 2, 3,4,5,6,7,8,9 };
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            //     
            // }
            //
            // foreach (int number in numbers)
            // {
            //     Console.Write(number + " ");
            // }



            // ФУНКЦИИ
            // string userInput = "AAAaaaaa";
            // userInput.ToLower();

            // Console.WriteLine("Привет");
            // Console.WriteLine("Ты здесь?");
            // WriteError("Нет соединения с интернетом", ConsoleColor.Green);
            // Console.WriteLine("Странно...");
            // WriteError("Интернет не оплачен", symbol:'@' );
            //


            // int x = 3, y = 11, sum;
            // Random rand = new Random();
            //
            // sum = Sum(rand.Next(0,50) ,rand.Next(50,100));
            // Console.WriteLine(sum);





            // int sum, x = 1, y = 10;
            // Add(out sum, x, y);
            // Console.WriteLine(sum);


            // int[] arr = new int[5];
            // arr =  EditArray(arr, 2, 10);
            // Console.WriteLine(arr[2]);


            // int[] arr1 = new int[5];
            // int[,] arr2 = new int[5,5];
            // arr1 = Resize(arr1, 6);
            // arr2 = Resize2(arr2, 10,10);
            // Console.WriteLine(arr1.Length);
            // Console.WriteLine(arr2.Length);


            /*int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;
            while (true)
            {
            DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|');
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1);
            
            Console.SetCursorPosition(0,5);
            Console.Write("Введите число на которое изменится жизнь");
            health += Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число на которое изменится мана");
            mana += Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();
            }*/

            // char[,] map = ReadMap("map.txt");
            // DrawMap(map);
            // Console.ReadKey();
            // while (true)
            // { 
            //     Console.Clear();
            //     DrawMap(map);
            //     Console.SetCursorPosition(1,1);
            //     Console.Write("@");
            //     Thread.Sleep(1000);
            //     
            // }


            //LIST коллекция
            /*
            List<int> numbers = new List<int>();
            
            numbers.Add(50);
            numbers.Add(5);
            numbers.Add(40);
            numbers.Add(22);
            numbers.Add(10);
            
            numbers.AddRange(new int[]{3,10,50,60});
            
            // numbers.RemoveAt(5);
            // numbers.Remove(5);
            //
            // numbers.Clear();
            // Console.WriteLine($"Число 50 находится на позиции {numbers.IndexOf(50)+1}");
            numbers.Insert(1,123);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            //Queue
            // Queue<string> pasengers = new Queue<string>();
            // pasengers.Enqueue("Василий");
            // pasengers.Enqueue("Алексей");
            // pasengers.Enqueue("Алиса");
            // pasengers.Enqueue("Мария");
            // Console.WriteLine($"Сейчас на рейс заходит {pasengers.Dequeue()}");
            // Console.WriteLine($"Следующий в очереди {pasengers.Peek()}"); 
            // foreach (var passenger in pasengers)
            // {   
            //     Console.WriteLine(passenger);
            // }


            //Stack коллекция
            /*Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            // Console.WriteLine(numbers.Peek());
            // numbers.Pop();
            foreach (var num in numbers)
            {
                Console.WriteLine(numbers);
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine($"Следующее число в стеке{numbers.Pop()}");
            }*/

            //Dictionary
            /*
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
            countriesCapitals.Add("Австралия", "Канберра");
            countriesCapitals.Add("Россия", "Турция");
            countriesCapitals.Add("Америка", "Новая Зеландия");
            countriesCapitals.Remove("Россия");
            foreach (var value in countriesCapitals.Values)
            {
                Console.WriteLine($" столица- {value}");
            }
            */


            //class 
            // Car ferrary = new Car("F40", -100, 500, 500);
            //
            // ferrary.ShowTechnicalPassport();
            
            
            /*bool isOpen = true;
            Table[] tables = { new Table(1, 4), new Table(2, 5) };
            while (isOpen)
            {
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i].ShowInfo();
            }
                Console.WriteLine("Введите номер стола для брони");
                int wishTables = Convert.ToInt32(Console.ReadLine())-1;
                Console.WriteLine("Введите кол-во столов для брони");
                int tablesValue = Convert.ToInt32(Console.ReadLine());
                bool isDesireSucces = tables[wishTables].ReserveTables(tablesValue);
                if (isDesireSucces)
                {
                    Console.WriteLine($"Бронь прошла успешно");
                }
                else
                {
                    Console.WriteLine($"Бронь не прошла");
                }
                Console.ReadKey();
                Console.Clear();
            }*/


            // Performer worker1 = new Performer("Василий");
            // Performer worker2 = new Performer("Василий2");
            //
            // Task[] tasks = { new Task(worker1, "выкопать яму"), new Task(worker2, "написать код, чтобы выкопать яму" )};
            //
            // Board schedule = new Board(tasks);
            //
            // schedule.ShowAllTasks();



            Knight war1 = new Knight(100, 500, 500);
            Pirat war2 = new Pirat(100, 1000, 100, 100);
                
            war1.TakeDamage(500);
            war2.TakeDamage(250);
            Console.Write("рыцарь: ");
            war1.ShowInfo();
            Console.Write("пират: ");
            war2.ShowInfo();
            
















        }

        /*private static void DrawMap(char[,] map)
        { 
            for (int y = 0; y < map.GetLength(0); y++)
                for (int x = 0; x < map.GetLength(1); x++)
                { 
                    Console.Write(map[y,x]);
                } 
            Console.Write("\n");
        }
        private static char[,] ReadMap(string path)
        {
            
            string []file  = File.ReadAllLines(path);
            char[,] map = new char[file.Length, GetMaxLengthOfRow(file)];

            for (int y = 0; y < map.GetLength(0); y++)
                for (int x = 0; x < map.GetLength(1); x++)
            {
                {
                    map[y, x] = file[y][x];
                }
            }
            return map;
            }

        private static int GetMaxLengthOfRow(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)
            {
                if (lines.Length > maxLength)
                    maxLength = line.Length;
            }
            return maxLength;
        }*/

        // private static void WriteError(string text, ConsoleColor color= ConsoleColor.Red, char symbol = '!')
        // {
        //     ConsoleColor defaultColor = Console.ForegroundColor;
        //     Console.ForegroundColor = color;
        //     Console.WriteLine(symbol + text);
        //     Console.ForegroundColor = defaultColor;
        // }


        // private static int Sum(int x, int y)
        // {
        //     int sum = x + y;
        //     return sum;
        // }


        // private static int[] EditArray(int [] arr, int index, int value)
        // {
        //     arr = new int[6];
        //     arr[index] = value;
        //     return arr;
        // }


        /*private static int[] Resize(int[] arr, int size)
        {
            int[] cashArray = new int[size];
            
            for (int i = 0; i < arr.Length; i++)
            {
                cashArray[i] = arr[i];
            }

            arr = cashArray;
            return arr;
        }

        private static int[,] Resize2(int[,] arr, int x, int y)
        {
            int[,] cashArray = new int[x, y];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    cashArray[i, j] = arr[i, j];
                }
            }

            arr = cashArray;
            return arr;
        }*/




        /*static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol ='_')
        {
            ConsoleColor defaultColot = Console.BackgroundColor;
            string bar = "";
        
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0,position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColot;
            bar = "";
        
            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + ']');
        }*/


    }

    /*class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpead;

        
        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            if (horsePower < 0)
            {
                HorsePower = 1;
            }
            else
            {
                HorsePower = horsePower;
            }
            Name = name;
            Age = age;
            MaxSpead = maxSpeed;
            
        }

        public Car()
        {
            Name = "LAda";
            HorsePower = 5000;
            Age = 10000;
            MaxSpead = 10000.5f;
        }
        public void ShowTechnicalPassport()
        {
            Console.WriteLine($"Название авто: {Name}\nКоличество лош сил:{HorsePower}\n" +
                              $"Возраст лет: {Age}\nМаксимальная скорость: {MaxSpead}");
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }
    }*/
    
    
    //кафе
    /*class Table 
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Стол:{Number}. Свободно мест:{FreePlaces} из {MaxPlaces}");
        }

        public bool ReserveTables(int places)
        {
            if (MaxPlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }*/
    
    
    /*class Performer
    {
        public string Name;

        public Performer(string name)
        {
            Name = name;
        }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ответсвенный: {Worker.Name}\nОписание задачи: {Description}");
        }
    }*/

    class Warrior
    {
        protected int Health;
        protected int Armor;
        protected int Demage;

        public Warrior(int health, int armor, int demage)
        {
            Health = health;
            Armor = armor;
            Demage = demage;
        }
        public void TakeDamage(int demage)
        {
            Health -= demage - Armor;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
        
    }
    class Knight:Warrior
    {
        public Knight(int health, int armor, int demage):base(health, armor, demage) { }

        public void Pray()
        {
            Armor += 2;
        }
    }

    class Pirat:Warrior
    {
        public int AttackSpead;
        public Pirat(int health, int armor, int demage, int attackSpead):base(health, 5, demage* attackSpead){}
        

        public void Slole()
        {
            Armor -= 2;
            Health += 10;
        }
    }
}