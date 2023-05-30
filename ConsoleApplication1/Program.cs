using System;
using System.Security.Cryptography;

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
            int trigger = 1;
            bool triggerInBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerInBoolean);
            int reconvert = Convert.ToInt32(triggerInBoolean);
            Console.WriteLine(reconvert);
            
        }   
    }
}