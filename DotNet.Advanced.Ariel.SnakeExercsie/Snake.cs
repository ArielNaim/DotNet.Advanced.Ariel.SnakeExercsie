using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Snake : Square
    {
        public override char DisplayChar => '*';
        public ConsoleKeyInfo key { get; private set; }
        public Location NewSnakeLocation { get; set; }
        public override void SetShapeSize()
        {
            Width = 1;
            Length = 1;
        }
        public void DrawOldSnake()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    

    }

}




