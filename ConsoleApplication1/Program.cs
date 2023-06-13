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
            Behaviour[] behaviours =
            {
                new Behaviour.Walker(),
                new Behaviour.Jumper(),

            };
            while (true)
            {
                foreach (var behaviour in behaviours)
                {
                    behaviour.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }

        class Behaviour
        {
            public virtual void Update()
            {

            }

            internal class Walker : Behaviour
            {
                public override void Update()
                {
                    Console.WriteLine("Иду");
                }
            }

            internal class Jumper : Behaviour
            {
                public override void Update()
                {
                    Console.WriteLine("Прыгаю");

                }
            }
        }
    }

    
}


