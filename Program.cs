﻿using System;
using System.Threading;
namespace Cronometro
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundos => 10s = 1 segundo");
            Console.WriteLine("M = Minuto => 1m => 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar? ");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1,1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;
            if(type == 'm');
                multiplier = 60;
            if (time == 0 );
                System.Environment.Exit(0);
            Start(time * multiplier);
        }
           
        static void Start(int time)
        {
            Console.Clear();
            int currentTime = 0;
            while(currentTime != time)
            {
                currentTime++;     
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();    
            Console.WriteLine("cronometro finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
} 
