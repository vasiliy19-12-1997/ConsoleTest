﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{

    internal class Program
    {


        public static void Main(string[] args)
        {
            ComputerClub comptuterClub = new ComputerClub(20);
            comptuterClub.Work();
        }
    }

    class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();

        public ComputerClub(int computersCount)
        {
            Random rand = new Random();
            for (int i = 0; i <computersCount ; i++)
            {
                _computers.Add(new Computer(rand.Next(5,15)));
            }
            CreateNewClients(25, rand);
        }

        public void CreateNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _clients.Enqueue(new Client(random.Next(100, 250), random));
            }
        }

        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue();
                Console.WriteLine($"Баланс компьютерного клуба {_money} руб. Ждем нового клиента. ");
                Console.WriteLine($"У вас новый клиент, и он хочет купить {newClient.DesireMinutes} минут");
                ShowAllComputersState();
                Console.Write("\nВы предлагает ему компьютер под номером: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;

                    if (computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine("Вы пытаетесь посадить клиента за комп, который уже занят. Клиент разозлился и ушел");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine($"У клиента пересчитав деньги, оплатил и сел за компьютер{computerNumber+1}");
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomeTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("У клиента не хватило денег и он ушел");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы сами не знаете за какой компьютер посадить клиента. Он разозлился и ушел");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Неверный ввод! Повторите снова");
                }

                Console.WriteLine("Чтобы перейти к след. клиенту нажмите след. клавигу ");
                Console.ReadKey();
                Console.Clear();
                SpendOneMinute();
            }
        }

        private void ShowAllComputersState()
        {
            Console.WriteLine("\nСписок всех компьютеров:");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i +1 + " -");
                _computers[i].ShowState();
            }
        }

        private void SpendOneMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SpendOneMinute();
            }
        }
    }
    

    class Computer
    {
        private Client _client;
        private int _minutesRemaining;

        public bool IsTaken
        {
            get
            {
                return _minutesRemaining > 0;

            }
        }
        
        public int PricePerMinute { get; private set; }

        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }

        public void BecomeTaken(Client client)
        {
            _client = client;
            _minutesRemaining = _client.DesireMinutes;
        }
        public void BecomeEmpty()
        {
            _client = null;
        }

        public void SpendOneMinute()
        {
            _minutesRemaining--;
        }

        public void ShowState()
        {
            if (IsTaken)
            {
                Console.WriteLine($"Компьютер занят, осталось минут:{_minutesRemaining}");
            }
            else
            {
                Console.WriteLine($"Компьютер свободен, цена за минуту: {PricePerMinute}");
            }
        }
        
    }

    class Client
    {
        private int _money;
        private int _moneyToPay;
        public int DesireMinutes { get; private set; }

        public Client(int money, Random random)
        {
            _money = money;
            DesireMinutes = random.Next(10, 30);
        }

        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = DesireMinutes * computer.PricePerMinute;
            if (_money >= _moneyToPay)
            {
                return true;
            }

            else
            {
                _moneyToPay = 0;
                return false;
            }
        }

        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}

    



