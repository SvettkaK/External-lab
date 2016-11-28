using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    public class Map
    {
        public int[,] hindrance;
        public int[,] bonus;
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(int w, int h)
        {
            Width = w;
            Height = h;
            hindrance = new int[w * h/50, w * h/50];
            bonus = new int[w * h/50, w * h/50];
        }

        public void SetBonus()
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            bonus[rand.Next(Width)/50, rand.Next(Height)/50] = rand.Next(10);
        }

        public void Sethindrance()
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            hindrance[rand.Next(Width)/50, rand.Next(Height)/50] = rand.Next(10);
        }

    }
}