using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NonPlayerCharecter[] charecters = new[]
            {
                new NonPlayerCharecter(),
                new Farmer(),
                new Knight(),
                new Child()
            };
            foreach (var charecter in charecters)
            {
                charecter.ShowDescription();
                Console.WriteLine(new string('-', 30) );
            }
        }
    }

    class NonPlayerCharecter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я простой NPC, умею только гулять");
        }
    }

    class Farmer : NonPlayerCharecter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("А еще я фермер и умею работать ");
        }
    }

    class Knight : NonPlayerCharecter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, мое дело это драться");
        }
    }

    class Child : NonPlayerCharecter
    {
        
    }
   

        
    }


