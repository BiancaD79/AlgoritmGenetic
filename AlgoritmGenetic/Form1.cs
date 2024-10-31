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
        Population pop;

        int et;

        private void Form1_Load(object sender, EventArgs e)
        {
            AG.Innit();
            grp = new MyGraphics(pictureBox1);
            grp2 = new MyGraphics(pictureBox2);
            grp3 = new MyGraphics(pictureBox3);
            pop = new Population();

            et = 1000;


            grp.Refresh();
            grp2.Refresh();
            grp3.Refresh();

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            et--;
            pop.Do(et/3 + 1);
            grp.Clear();
            pop.par[0].Draw(grp.grp);
            grp.Refresh();
            textBox1.Text = pop.par[0].Fadec().ToString();
            textBox2.Text = et.ToString();
            if(et == 20)
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
