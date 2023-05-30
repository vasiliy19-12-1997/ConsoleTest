using System;
using System.Security.Cryptography;
using System.Security.Policy;

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

            string dayOfWeek;
            Console.WriteLine("Enter day of week");
            dayOfWeek = Console.ReadLine();
            if (dayOfWeek == "Понедельник")
            {
                Console.WriteLine("Проходим курсы");
            }

            else if (dayOfWeek == "вторник")
            {
                Console.WriteLine("Делаем дз");
            }

        }   
    }
}