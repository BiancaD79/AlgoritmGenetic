using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comis_Voiajor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyGraphics grp;
        Graf test;
        private void Form1_Load(object sender, EventArgs e)
        {
            grp = new MyGraphics(pictureBox1);
            test = new Graf();
            test.Load(@"..\..\testdemo.txt");
            test.Draw(grp.grp);
            grp.Refresh();

            Population pop = new Population(10,test);
            foreach(string s in pop.View())
            {
                listBox1.Items.Add(s);
            }
            //test.SaveToFile(@"..\..\testdemo.txt");
            
        }
    }
}
