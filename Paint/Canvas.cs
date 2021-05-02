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
using System.Drawing.Drawing2D;

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
            MinimumSize = new Size(1237, 700);
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            //defaults
            state.SelectedTool = Tools.Line;
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw_active);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line_active);
            currentColorBtn.BackColor = state.Settings.Color;
            borderColorBtn.BackColor = state.Settings.BorderColor;
            anchorColorBtn.BackColor = state.Settings.AnchorColor;
            thicknessBox.SelectedIndex = 0;
            styleBox.SelectedIndex = 0;
            borderThicknessBox.SelectedIndex = 0;
            borderStyleBox.SelectedIndex = 0;
            borderOffsetBox.SelectedIndex = 0;
            anchorSizeBox.SelectedIndex = 0;
            filledCheckBox.Checked = false;




            textBox.Visible = false;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (isSourceView)
            {
                textBox.Visible = true;
                textBox.Height = Height - 250;
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

            //Always rerender controls
            designBtn.FlatAppearance.MouseOverBackColor = designBtn.BackColor;
            sourceBtn.FlatAppearance.MouseOverBackColor = sourceBtn.BackColor;
            currentColorBtn.BackColor = state.Settings.Color;
            state.Settings.Thickness = Int32.Parse(thicknessBox.SelectedItem.ToString());
            switch (styleBox.SelectedItem.ToString())
            {
                case "Solid":
                    state.Settings.Style = DashStyle.Solid;
                    break;
                case "Dot":
                    state.Settings.Style = DashStyle.Dot;
                    break;
                case "Dash":
                    state.Settings.Style = DashStyle.Dash;
                    break;
                case "DashDot":
                    state.Settings.Style = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    state.Settings.Style = DashStyle.DashDotDot;
                    break;
                default:
                    state.Settings.Style = DashStyle.Solid;
                    break;
            }
            state.Settings.BorderThickness = Int32.Parse(borderThicknessBox.SelectedItem.ToString());
            switch (borderStyleBox.SelectedItem.ToString())
            {
                case "Solid":
                    state.Settings.BorderStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    state.Settings.BorderStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    state.Settings.BorderStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    state.Settings.BorderStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    state.Settings.BorderStyle = DashStyle.DashDotDot;
                    break;
                default:
                    state.Settings.BorderStyle = DashStyle.Solid;
                    break;
            }
            state.Settings.BorderOffset = Int32.Parse(borderOffsetBox.SelectedItem.ToString());
            borderColorBtn.BackColor = state.Settings.BorderColor;
            state.Settings.AnchorSize = Int32.Parse(anchorSizeBox.SelectedItem.ToString());
            anchorColorBtn.BackColor = state.Settings.AnchorColor;




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
                thicknessBox.Enabled = true;

                return;

            }
            else
            {
                // disable all style controls
                thicknessBox.Enabled = false;
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
            saveBtn.BackColor = Color.Teal;
            saveBtn.FlatAppearance.MouseOverBackColor = saveBtn.BackColor;
            saveBtn.ForeColor = Color.White;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = Color.White;
            saveBtn.FlatAppearance.BorderColor = Color.Teal;
            saveBtn.ForeColor = Color.Teal;
        }

        private void openBtn_MouseHover(object sender, EventArgs e)
        {
            openBtn.BackColor = Color.Teal;
            openBtn.ForeColor = Color.White;
            openBtn.FlatAppearance.MouseOverBackColor = openBtn.BackColor;
        }

        private void openBtn_MouseLeave(object sender, EventArgs e)
        {
            openBtn.BackColor = Color.White;
            openBtn.FlatAppearance.BorderColor = Color.Teal;
            openBtn.ForeColor = Color.Teal;
        }


        private void rectangleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();
            state.SelectedTool = Tools.Rectangle;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle_active);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line);
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw_active);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
        }

        private void circleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();
            state.SelectedTool = Tools.Circle;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle_active);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line);
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw_active);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
        }

        private void lineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();
            state.SelectedTool = Tools.Line;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line_active);
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw_active);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move);
        }

        private void moveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();
            state.SelectedTool = Tools.Selector;
            drawBtn.BackgroundImage = new Bitmap(Properties.Resources.draw);
            moveBtn.BackgroundImage = new Bitmap(Properties.Resources.move_active);
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line);
        }

        private void drawBtn_MouseClick(object sender, MouseEventArgs e)
        {
            uiUtils.resetSelection();
            state.SelectedTool = Tools.Line;
            rectangleBtn.BackgroundImage = new Bitmap(Properties.Resources.rectangle);
            circleBtn.BackgroundImage = new Bitmap(Properties.Resources.circle);
            lineBtn.BackgroundImage = new Bitmap(Properties.Resources.line_active);
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

        private void designBtn_MouseClick(object sender, MouseEventArgs e)
        {
            sourceBtn.BackColor = Color.White;
            sourceBtn.FlatAppearance.BorderColor = Color.Teal;
            sourceBtn.ForeColor = Color.Teal;
            designBtn.BackColor = Color.Teal;
            designBtn.ForeColor = Color.White;

            if (textBox.Text.Length > 2)
                state.Recompile(textBox.Text);
            else
                state.Clear();
            isSourceView = false;
            textBox.Visible = false;
            this.Invalidate();
        }

        private void sourceBtn_MouseClick(object sender, MouseEventArgs e)
        {
            designBtn.BackColor = Color.White;
            designBtn.FlatAppearance.BorderColor = Color.Teal;
            designBtn.ForeColor = Color.Teal;
            sourceBtn.BackColor = Color.Teal;
            sourceBtn.ForeColor = Color.White;
            isSourceView = true;
            this.Invalidate();
        }

        private void whiteBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.White;
        }

        private void blackBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.Black;
        }

        private void grayBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.Gray;
        }

        private void redBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.Red;
        }

        private void greenBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.Green;
        }

        private void blueBtn_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Color = Color.Blue;
        }

        private void currentColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
               state.Settings.Color = MyDialog.Color;
            this.Invalidate();
        }

        private void thicknessBox_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.Thickness = Int32.Parse(thicknessBox.SelectedItem.ToString());
            this.Invalidate();
        }

        private void styleBox_MouseClick(object sender, MouseEventArgs e)
        {
            switch(styleBox.SelectedItem.ToString())
            {
                case "Solid":
                    state.Settings.Style = DashStyle.Solid;
                    break;
                case "Dot":
                    state.Settings.Style = DashStyle.Dot;
                    break;
                case "Dash":
                    state.Settings.Style = DashStyle.Dash;
                    break;
                case "DashDot":
                    state.Settings.Style = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    state.Settings.Style = DashStyle.DashDotDot;
                    break;
                default:
                    state.Settings.Style = DashStyle.Solid;
                    break;
            }
            this.Invalidate();
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            drawBtn_MouseClick(sender, e);
            state.Clear();
            this.Invalidate();
        }

        private void clearBtn_MouseHover(object sender, EventArgs e)
        {
            clearBtn.BackgroundImage = new Bitmap(Properties.Resources.clear_active);
        }

        private void clearBtn_MouseLeave(object sender, EventArgs e)
        {
            clearBtn.BackgroundImage = new Bitmap(Properties.Resources.clear);
        }

        private void borderThicknessBox_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.BorderThickness = Int32.Parse(borderThicknessBox.SelectedItem.ToString());
            this.Invalidate();
        }

        private void borderStyleBox_MouseClick(object sender, MouseEventArgs e)
        {
            switch (borderStyleBox.SelectedItem.ToString())
            {
                case "Solid":
                    state.Settings.BorderStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    state.Settings.BorderStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    state.Settings.BorderStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    state.Settings.BorderStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    state.Settings.BorderStyle = DashStyle.DashDotDot;
                    break;
                default:
                    state.Settings.BorderStyle = DashStyle.Solid;
                    break;
            }
            this.Invalidate();
        }

        private void borderOffsetBox_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.BorderOffset = Int32.Parse(borderOffsetBox.SelectedItem.ToString());
            this.Invalidate();
        }

        private void borderColorBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                state.Settings.BorderColor = MyDialog.Color;
            this.Invalidate();
        }

        private void anchorSizeBox_MouseClick(object sender, MouseEventArgs e)
        {
            state.Settings.AnchorSize = Int32.Parse(anchorSizeBox.SelectedItem.ToString());
            this.Invalidate();
        }

        private void anchorColorBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                state.Settings.AnchorColor = MyDialog.Color;
            this.Invalidate();
        }
    }
}