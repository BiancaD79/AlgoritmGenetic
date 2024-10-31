using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoritmGenetic
{
    public class Vertex
    {
        public static Random rnd = new Random();
        public static int ResX = 400, ResY = 400;

        public PointF loc;
        string name;
        public Vertex(string name)
        {
            this.name = name;
            loc =  new PointF(rnd.Next(ResX), rnd.Next(ResY));
        }
     
        public void Draw(Graphics handler)
        {
            int size = 7;
            handler.DrawEllipse(Pens.Black, loc.X - size,
                loc.Y - size, 2 * size + 1, 2 * size + 1);

            handler.DrawString(name, new Font("Arial",
                25, FontStyle.Bold), new SolidBrush(Color.Red),
                new PointF(loc.X - size / 2, loc.Y - size / 2));
        }
    }
}
