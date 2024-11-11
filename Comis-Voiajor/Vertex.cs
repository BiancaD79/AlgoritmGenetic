using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comis_Voiajor
{
    internal class Vertex
    {
        public PointF location;
        string name;
        public static int resX = 800, resY=600;
        public static Random rnd = new Random();
        public int idx;
        public Vertex(string name, int idx)
        {
            float x = rnd.Next(resX);
            float y = rnd.Next(resY);
            location = new PointF(x, y);
            this.name = name;
            this.idx = idx;
        }

        public Vertex(string data)
        {
            string[] t = data.Split(' ');
            this.name = t[0];
            location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
        }

        public void Draw(Graphics handler)
        {
            int size = 7;
            handler.DrawEllipse(Pens.Black, location.X - size,
                location.Y - size, 2 * size + 1, 2 * size + 1);

            handler.DrawString(name, new Font("Arial",
                25, FontStyle.Bold), new SolidBrush(Color.Red),
                new PointF(location.X - size / 2, location.Y - size / 2));
        }

        public override string ToString() 
        {
            return name + " " + location.X + " " + location.Y;
        }
    }
}
