using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Triangle : Shape
    {
        public override char DisplayChar => '#';

        public override void SetShapeSize()
        {
            Width = Util.GetRandomNumber(3, 10);
            Length = Width;
        }
        public override void SetLocations()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Location tempLocation = new Location();
                    tempLocation.Top = InitalLocation.Top + i;
                    tempLocation.Left = InitalLocation.Left + j;
                    locations.Add(tempLocation);
                }
            }
        }

    }
}
