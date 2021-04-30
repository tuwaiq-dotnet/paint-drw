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
            Circle circle = new Circle(new Point(20, 30), new Point(40, 50));
            Rectan rectangle = new Rectan(new Point(20, 30), new Point(40, 50));
            state.AddShape(circle);
            state.AddShape(rectangle) ;

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // here just paint state.Shapes
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
        }
    }
}