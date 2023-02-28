using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class DrawVag
    {
       

        public int x;
        public int y;
        Color[] color= { Color.RoyalBlue, Color.DarkGreen, Color.Black };
        Random rand= new Random();
        public DrawVag(int x,int y)
        {

            this.x = x;
            this.y = y;


        }



        public void Draw(Graphics g)
        {   int randcolor=rand.Next(0,3);
            g.DrawRectangle(new Pen(color[randcolor]), this.x, this.y, 300, 150);
            g.DrawRectangle(new Pen(color[randcolor]), this.x + 40, this.y + 40, 50, 50);
            g.DrawRectangle(new Pen(color[randcolor]), this.x + 120, this.y + 40, 50, 50);
            g.DrawRectangle(new Pen(color[randcolor]), this.x + 200, this.y + 40, 50, 50);
            g.DrawEllipse(new Pen(color[randcolor]), this.x+20, this.y+150, 70,70);
            g.DrawEllipse(new Pen(color[randcolor]), this.x + 210, this.y + 150, 70, 70);


        }

    }
}
