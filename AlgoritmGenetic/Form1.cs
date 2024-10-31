using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmGenetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyGraphics grp;
        MyGraphics grp2;
        MyGraphics grp3;

        private void Form1_Load(object sender, EventArgs e)
        {
            AG.Innit();
            grp = new MyGraphics(pictureBox1);
            grp2 = new MyGraphics(pictureBox2);
            grp3 = new MyGraphics(pictureBox3);
            Population pop = new Population();

            pop.Sort();
            pop.Selection();

            pop.par[0].Draw(grp.grp);
            pop.par[1].Draw(grp2.grp);

            Solution test = pop.Crossover(pop.par[0], pop.par[1]);
            test.Mutate(200);
            test.Draw(grp3.grp);

            grp.Refresh();
            grp2.Refresh();
            grp3.Refresh();

            textBox1.Text = pop.par[0].Fadec().ToString("0.000");
            textBox2.Text = pop.par[1].Fadec().ToString("0.000");
            textBox3.Text = test.Fadec().ToString("0.000");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
