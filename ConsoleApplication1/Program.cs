using System;

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
        }   
    }
}