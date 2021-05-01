/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */

using Paint.Shapes;
using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.State;
using System.Diagnostics;

namespace Paint
{
    public partial class Canvas : Form
    {
        AppState state = new AppState();

        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            // For Faisal to Generate String of Shapes
            state.AddShape(new Circle(new Point(200, 300), new Point(400, 500)));
            state.AddShape(new Rectan(new Point(500, 400), new Point(700, 900)));
            state.AddShape(new Circle(new Point(1200, 1300), new Point(1500, 1700)));
            state.AddShape(new Line(new Point(500, 300), new Point(1000, 1000)));

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in state.Shapes)
                shape.Draw(e.Graphics);
        }

        //Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            state.Save();
        }

        //Import button
        private void button2_Click(object sender, EventArgs e)
        {
            state.Import();
            Invalidate();
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var shape in state.Shapes)
                shape.Unselect();
            foreach (var shape in state.Shapes)
                if (shape.Contains(e.X, e.Y))
                {
                    shape.Select();
                    state.Shapes.Remove(shape);
                    state.Shapes.Add(shape);
                    Invalidate();
                    return;
                }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var shape in state.Shapes)
            {
                AnchorDirection dir = shape.OnAnchor(new(e.X, e.Y));
                if (dir == AnchorDirection.North || dir == AnchorDirection.South) { 
                    Cursor = Cursors.SizeNS;
                    return;
                }
                else if (dir == AnchorDirection.East || dir == AnchorDirection.West)
                {
                    Cursor = Cursors.SizeWE;
                    return;
                }
                else if (dir == AnchorDirection.NorthEast || dir == AnchorDirection.SouthWest)
                {
                    Cursor = Cursors.SizeNESW;
                    return;
                }
                else if (dir == AnchorDirection.NorthWest || dir == AnchorDirection.SouthEast)
                {
                    Cursor = Cursors.SizeNWSE;
                    return;
                }
                else if (shape.Contains(new(e.X, e.Y))) {
                    Cursor = shape.IsSelected ? Cursors.NoMove2D : Cursors.Hand;
                    return;
                } 
            }
            Cursor = Cursors.Default;
        }
    }
}