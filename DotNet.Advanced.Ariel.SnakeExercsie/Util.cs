using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public static class Util
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random numRandom = new Random();
            return numRandom.Next(min, max);
        }
    }
}
