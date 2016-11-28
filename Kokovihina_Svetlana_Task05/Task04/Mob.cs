using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    public class Mob
    {
        public double Speed { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Map Map
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Move(char axle, int from, int to)
        {

        }
    }
}