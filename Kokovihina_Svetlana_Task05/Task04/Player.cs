using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    public class Player
    {
        public double Speed { get; set; }
        public int Strenght { get; set; }
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

        public Mob Mob
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Move(string way)
        {
            if(way == "up")
            {
                //увеличивать PosX, пока не встетится гриница поля, моб или препятствие
            }
            else if (way == "left")
            {
                //уменьшать PosY, пока...
            }
            //...
        }


    }
}