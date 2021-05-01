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

using Paint.Utils;

namespace Paint
{
    public partial class Canvas : Form
    {
        UIUtils uiUtils = UIUtils.GetInstance();
        AppState state = AppState.GetInstance();

        public Canvas()
        {
            InitializeComponent();

            // use uiUtils NOT state!!
            state.SelectedTool = Tools.Rectangle;
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

            if(uiUtils.currentDrawingShape != null)
            {
                uiUtils.currentDrawingShape.Draw(e.Graphics);
            }
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
            /*
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
            */
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = uiUtils.GetCursor(e.X, e.Y);

            if (uiUtils.isHolding)
            {
                if (uiUtils.selectedShape != null)
                {
                    if (uiUtils.selectedAnchor != AnchorDirection.None)
                    {
                        uiUtils.selectedShape.Resize(uiUtils.selectedAnchor, new(e.X, e.Y));
                    }
                    else
                    {
                        uiUtils.selectedShape.Move(e.X, e.Y, uiUtils.deltaX, uiUtils.deltaY);
                    }
                    Invalidate();
                }
                else if (uiUtils.currentDrawingShape != null)
                {
                    uiUtils.setCurrentDrawingShapeX2Y2(e.X, e.Y);
                    Invalidate();
                }

            }

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {

            uiUtils.isHolding = true;

            // Draw
            switch (state.SelectedTool)
            {
                case Tools.Line:
                    uiUtils.currentDrawingShape = new Line();
                    uiUtils.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
                case Tools.Circle:
                    uiUtils.currentDrawingShape = new Circle();
                    uiUtils.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
                case Tools.Rectangle:
                    uiUtils.currentDrawingShape = new Rectan();
                    uiUtils.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
            }

            // resize
            if (uiUtils.selectedShape != null)
            {
                var anchor = uiUtils.selectedShape.OnAnchor(new(e.X, e.Y));
                if (anchor != AnchorDirection.None)
                {
                    uiUtils.selectedAnchor = anchor;
                    return;
                }

                uiUtils.resetSelection();
                Invalidate();
            }

            // Select
            if (uiUtils.selectShape(e.X, e.Y)) {
                Invalidate();
                return;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (uiUtils.selectedShape != null)
            {
                uiUtils.resetDelta();
            }

            if(uiUtils.currentDrawingShape != null)
            {
                uiUtils.setAndClearCurrentShape(e.X, e.Y);
            }

            uiUtils.isHolding = false;

        }
    }
}