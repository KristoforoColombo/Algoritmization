using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chzh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void houseDraw(Graphics g, int x, int y, int size)
        {
            // Рисуем стены дома
            Brush wallBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(wallBrush, x, y, size, size); // Квадрат для стен

            // Рисуем крышу
            Point[] roofPoints = {
            new Point(x, y), // Левый нижний угол
            new Point(x + size / 2, y - size / 2), // Вершина крыши
            new Point(x + size, y) // Правый нижний угол
        };

            Brush roofBrush = new SolidBrush(Color.Red);
            g.FillPolygon(roofBrush, roofPoints); // Треугольник для крыши

            // Рисуем дверь
            Brush doorBrush = new SolidBrush(Color.Plum);
            g.FillRectangle(doorBrush, x + size / 4, y + size - size / 2, size / 2, size / 2); // Прямоугольник для двери

            // Рисуем окна
            Brush windowBrush = new SolidBrush(Color.White);
            g.FillRectangle(windowBrush, x + size / 8, y + size / 8, size / 4, size / 4); // Левое окно
            g.FillRectangle(windowBrush, x + size - size / 4 - size / 8, y + size / 8, size / 4, size / 4); // Правое окно
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            houseDraw(g, 325, 200, 100);
        }
    }
}
