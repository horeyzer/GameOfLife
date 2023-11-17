using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            colorDialog1.ShowDialog();
            Pen p = new Pen(colorDialog1.Color, (int)numericUpDown1.Value);

            g.DrawLine(p, 100, 100, 300, 100);

            g.DrawRectangle(p, 200, 200, 500, 100);

            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillRectangle(sb, 200, 200, 100, 100);

            g.FillEllipse(sb, 300, 300, 200, 200);

            g.DrawArc(p, 400, 400, 100, 200, 90, 270);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = MousePosition.X.ToString();
            label2.Text = MousePosition.Y.ToString();
        }
    }
}
