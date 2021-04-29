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

using Paint.Drawing;
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
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (state.CurrentShape != null)
            {
                state.SetCurrentShapeX2Y2(e.X, e.Y);
                this.Invalidate();
            }
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (state.SelectedTool == ToolType.Resizer)
            {
                Shape s = getSelectedItem(e.X, e.Y);
                if (s != null)
                {

                    state.SetCurrentShape(getShape(s.x1, s.y1, s.type));
                    state.RemoveShape(s);
                    state.SetSelectedTool(ToolType.Liner);
                    state.SetSelectedShape(ShapeType.Line);
                    LineButton.Checked = true;
                    foreach (var item in PaintToolsStrip.Items)
                        if (item.GetType().Equals(typeof(ToolStripButton)))
                            ((ToolStripButton)item).Checked = false;

                    this.Invalidate();
                }
            }
            else if (state.SelectedTool == ToolType.ColorPicker)
            {
                // TYPE COLOR PICKER LOGIC HERE
                Shape s = getSelectedItem(e.X, e.Y);
                if (s != null)
                {
                    this.colorDialog1.ShowDialog();
                    //s.Color = this.colorDialog1.Color;
                    this.Invalidate();
                }
            }
            else if (state.CurrentShape == null)
            {
                state.SetCurrentShape(getShape(e.X, e.Y, state.SelectedShape));
            }
            else
            {
                state.AddShape(state.CurrentShape);
                state.ClearCurrentShape();
                this.Invalidate();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            comboBox1.SelectedIndex = state.Settings.Thickness;
            Graphics g = e.Graphics;
            foreach (var shape in state.Shapes)
                shape.Draw(g);
            if (state.CurrentShape != null)
                state.CurrentShape.Draw(g, true);

        }

        private void PaintToolsStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (var item in PaintToolsStrip.Items)
                if (item.GetType().Equals(typeof(ToolStripButton)))
                    ((ToolStripButton)item).Checked = false;


            switch (e.ClickedItem.Text)
            {
                case "Circle":
                    state.SetSelectedShape(ShapeType.Ellipse);
                    state.SetSelectedTool(ToolType.Ellipser);
                    return;
                case "Rectangle":
                    state.SetSelectedShape(ShapeType.Rectangle);
                    state.SetSelectedTool(ToolType.Rectangler);
                    return;
                case "Line":
                    state.SetSelectedShape(ShapeType.Line);
                    state.SetSelectedTool(ToolType.Liner);
                    return;
                case "Resize":
                    state.SetSelectedTool(ToolType.Resizer);
                    return;
                case "Relocate":
                    state.SetSelectedTool(ToolType.Relocator);
                    return;
                case "ColorPicker":
                    state.SetSelectedTool(ToolType.ColorPicker);
                    return;
                default:
                    state.SetSelectedShape(ShapeType.Line);
                    return;
            }
        }

        private Shape getShape(int x1, int y1, ShapeType type)
        {
            if (type == ShapeType.Ellipse) return new Circle(x1, y1);
            else if (type == ShapeType.Rectangle) return new Rectan(x1, y1);
            else return new Line(x1, y1);
        }

        private Shape getSelectedItem(int x, int y)
        {
            foreach (var item in state.Shapes)
            {
                if (PointInShape(x, y, item))
                    return item;
            }
            return null;
        }

        private bool PointInShape(int x, int y, Shape s)
        {
            return (x > s.x1 && x < s.x2 && y > s.y1 && y < s.y2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state.save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state.import();
        }
    }
}