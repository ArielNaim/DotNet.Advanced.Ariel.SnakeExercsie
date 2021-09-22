using System;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Managament managment = new Managament();
            managment.Init();
            Console.ReadLine();
        }
    }
}
