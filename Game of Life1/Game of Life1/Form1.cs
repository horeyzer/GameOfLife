using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Game_of_Life1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool[,] M = new bool[6, 6]
            {   {false, false, false, false, false, false},
                {false, false, true, true, false, false},
                {false, false, false, false, false, false},
                {false, false, true, false, false, false},
                {false, false, false, false, false, false},
                {false, false, false, false, false, false}};
        private void button1_Click(object sender, EventArgs e)
        {
            Label[,] lb=new Label[6,6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    lb[i, j] = new Label();

                    lb[i, j].AutoSize = true;
                    lb[i, j].Location = new System.Drawing.Point(i*20+200, j*20+200);
                    lb[i, j].Name = "label1";
                    lb[i, j].Size = new System.Drawing.Size(20, 13);
                    lb[i, j].TabIndex = 1;
                    lb[i, j].Text = "🏳️‍⚧️";
                    Controls.Add(lb[i, j]);
                }
            }
        }
        int ncount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (M[i, j])
                    {
                        //count neighbors
                        ncount = M[i - 1, j - 1] = M[i-1, j]+......
                        switch (ncount)
                        {
                            case 0: case 1: M[i, j] = false; break;
                            case 2: case 3: M[i, j] = true; break;
                            default: M[i, j] = false; break;       
                        }
                    }
                    else
                    { }

                }
            }
        }
    }
}
