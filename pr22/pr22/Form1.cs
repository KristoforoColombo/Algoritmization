using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr22
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Point[] points = new Point[50];
        Pen pen  = new Pen(Color.Black, 2);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLines(pen, points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int xPos;
                if (i % 2 == 0)
                {
                    xPos = 20;
                }
                else
                {
                    xPos = 450;
                }
                points[i] = new Point(xPos, 10 * i);
            }
        }
    }
}
