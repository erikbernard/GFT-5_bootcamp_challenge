// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        public static void Main()
        {
            Wizard Kire = new Wizard("Kire","Wizard", 15, 4, 10);
            WriteLine(Kire);
            Knight Cloud = new Knight("Cloud","Knight", 15, 6, 10);
            WriteLine(Cloud);

            for (int i = 0; i < 6; i++)
            {
                Random RandomAttack = new Random();
                WriteLine($"{Kire}\n{Kire.Attack(RandomAttack.Next(13))}");
                WriteLine("----------------------------------------------------------------------------------------------\n");
                WriteLine($"{Cloud}\n{Cloud.Attack(RandomAttack.Next(13))}");
                WriteLine("----------------------------------------------------------------------------------------------\n");
            }
            
        }
    }
}