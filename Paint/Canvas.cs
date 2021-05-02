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
        bool isSourceView = false;

        public Canvas()
        {
            InitializeComponent();
            MinimumSize = new Size(800, 700);
            // use uiUtils NOT state!!
            state.SelectedTool = Tools.Selector;
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            state.SelectedTool = Tools.Circle;
            //Hide source text box
            textBox.Visible = false;
            openBtn.BackgroundImageLayout = ImageLayout.Center;
            moveBtn.BackgroundImageLayout = ImageLayout.Center;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (isSourceView)
            {
                textBox.Visible = true;
                textBox.Height = Height - 220;
            }
            else
            {
                foreach (var shape in state.Shapes)
                    shape.Draw(e.Graphics);

                if (uiUtils.currentDrawingShape != null)
                {
                    uiUtils.currentDrawingShape.Draw(e.Graphics);
                }

                textBox.Text = state.StringifyShapes();
            }
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
            if (uiUtils.selectShape(e.X, e.Y))
            {
                Invalidate();
                comboBox1.Enabled = true;

                return;

            }
            else
            {
                // disable all style controls
                comboBox1.Enabled = false;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (uiUtils.selectedShape != null)
            {
                uiUtils.resetDelta();
            }

            if (uiUtils.currentDrawingShape != null)
            {
                uiUtils.setAndClearCurrentShape(e.X, e.Y);
            }

            uiUtils.isHolding = false;

        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackgroundImage = new Bitmap(Properties.Resources.save_btn_hover);

        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackgroundImage = new Bitmap(Properties.Resources.save_btn);

        }

        private void openBtn_MouseHover(object sender, EventArgs e)
        {
            openBtn.BackgroundImage = new Bitmap(Properties.Resources.open_btn_hover);
        }

        private void openBtn_MouseLeave(object sender, EventArgs e)
        {
            openBtn.BackgroundImage = new Bitmap(Properties.Resources.open_btn);
        }


        private void rectangleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();

            state.SelectedTool = Tools.Rectangle;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle_active);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line);
        }

        private void circleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();


            state.SelectedTool = Tools.Circle;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle_active);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line);
        }

        private void lineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();


            state.SelectedTool = Tools.Line;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line_active);
        }

        private void moveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move_active);
        }

        private void resizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
        }

        private void drawBtn_MouseClick(object sender, MouseEventArgs e)
        {
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw_active);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            state.Save();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            state.Import();
            this.Invalidate();
        }

        private void designBtn_Click(object sender, EventArgs e)
        {
            designBtn.BackgroundImage = new Bitmap(Properties.Resources.design_active);
            sourceBtn.BackgroundImage = new Bitmap(Properties.Resources.source_inactive);
            isSourceView = false;

        }

        private void designBtn_MouseClick(object sender, MouseEventArgs e)
        {
            designBtn.BackgroundImage = new Bitmap(Properties.Resources.design_active);
            sourceBtn.BackgroundImage = new Bitmap(Properties.Resources.source_inactive);
            if(textBox.Text.Length > 2)
                state.Recompile(textBox.Text);
            isSourceView = false;
            textBox.Visible = false;
            this.Invalidate();
        }

        private void sourceBtn_MouseClick(object sender, MouseEventArgs e)
        {
            designBtn.BackgroundImage = new Bitmap(Properties.Resources.design_inactive);
            sourceBtn.BackgroundImage = new Bitmap(Properties.Resources.source_active);
            isSourceView = true;
            this.Invalidate();
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            state.SelectedTool = Tools.Selector;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiUtils.selectedShape != null)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    uiUtils.selectedShape.Style = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    uiUtils.selectedShape.Style = System.Drawing.Drawing2D.DashStyle.Dot;
                }
                else
                {
                    uiUtils.selectedShape.Style = System.Drawing.Drawing2D.DashStyle.Dash;
                }

                this.Invalidate();
            }
        }
    }
}