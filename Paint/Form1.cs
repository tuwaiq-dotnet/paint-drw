using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Random r = new(56797);
        Shape[] x = new Shape[2];
        public Form1()
        {
            x[0] = new Circle();
            x[1] = new Shapes.Rectan();
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in x)
            {
                shape.Select();
                shape.Start = new(r.Next(100, 500), r.Next(100, 1500));
                shape.End = new(r.Next(100, 500), r.Next(100, 1500));
                shape.Draw(e.Graphics);
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Invalidate();
        }
    }
}
