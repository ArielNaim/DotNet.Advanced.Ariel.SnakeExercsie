using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Rectangle : Shape
    {
        public override char DisplayChar => '$';


        public override void SetShapeSize()
        {
            Width = Util.GetRandomNumber(2, 11); // רוחב המלבן בין 2 ל 10 
            Length = Util.GetRandomNumber(3, 11);// אורך המלבן בין 3 ל 10 
        }

        public override void SetLocations() 
        {

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
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
