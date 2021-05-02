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
        UIUtils ui = UIUtils.GetInstance();
        AppState state = AppState.GetInstance();
        Settings settings = Settings.GetInstance();
        public Canvas()
        {
            InitializeComponent();
            AnchorSizeComboBox.Text = settings.AnchorSize.ToString();
            AnchorColorSelectionLabel.BackColor = settings.AnchorColor;

            BorderOffsetCombobox.Text = settings.BorderOffset.ToString();
            BorderThicknessComboBox.Text = settings.BorderThickness.ToString();
            BorderStyleComboBox.Text = settings.BorderStyle.ToString();
            BorderColorSelectionLabel.BackColor = settings.BorderColor;

            StyleComboBox.Text = settings.Style.ToString();
            ThicknessComboBox.Text = settings.Thickness.ToString();
            ColorSelectionLabel.BackColor = settings.Color;
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            state.SelectedTool = Tools.Line;
        }

        private void LineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetSelection();
            if (LineRadioButton.Checked)
                state.SelectedTool = Tools.Line;
        }

        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetSelection(); 
            if (CircleRadioButton.Checked)
                state.SelectedTool = Tools.Circle;
        }

        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetSelection(); 
            if (RectangleRadioButton.Checked)
                state.SelectedTool = Tools.Rectangle;
        }

        private void SelectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetSelection(); 
            if (SelectionRadioButton.Checked)
                state.SelectedTool = Tools.Selector;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (ui.currentDrawingShape != null)
            {
                ui.currentDrawingShape.Style = DashStyle.Dot;
                ui.currentDrawingShape.Color = Color.Gray;
                ui.currentDrawingShape.Thickness=3;
                ui.currentDrawingShape.Draw(e.Graphics);
            }
            foreach (var shape in state.Shapes)
                shape.Draw(e.Graphics);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            ui.isHolding = true;
            // Draw
            switch (state.SelectedTool)
            {
                case Tools.Line:
                    ui.currentDrawingShape = new Line();
                    ui.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
                case Tools.Circle:
                    ui.currentDrawingShape = new Circle();
                    ui.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
                case Tools.Rectangle:
                    ui.currentDrawingShape = new Rectan();
                    ui.setCurrentDrawingShapeX1Y1(e.X, e.Y);
                    return;
            }

            // resize
            if (ui.selectedShape != null)
            {
                var anchor = ui.selectedShape.OnAnchor(new(e.X, e.Y));
                if (anchor != AnchorDirection.None)
                {
                    ui.selectedAnchor = anchor;
                    return;
                }

                ResetSelection();
                Invalidate();
            }

            // Select
            if (ui.selectShape(e.X, e.Y))
            {
                StyleComboBox.Enabled = true;
                StyleComboBox.Text = ui.selectedShape.Style.ToString();
                ThicknessComboBox.Enabled = true;
                ThicknessComboBox.Text = ui.selectedShape.Thickness.ToString();
                ColorSelectionLabel.Enabled = true;
                ColorSelectionLabel.BackColor = ui.selectedShape.Color;
                FillComboBox.Enabled = true;
                FillComboBox.Checked = ui.selectedShape.IsFilled;
                Invalidate();
                return;
            }
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (ui.selectedShape != null) ui.resetDelta();
            if (ui.currentDrawingShape != null) ui.setAndClearCurrentShape(e.X, e.Y);
            ui.isHolding = false;
            Invalidate();
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripMousePointLabel.Text = $"X: {e.X}, Y: {e.Y}";
            Cursor = ui.GetCursor(e.X, e.Y);
            if (ui.isHolding)
            {
                if (ui.selectedShape != null)
                {
                    if (ui.selectedAnchor != AnchorDirection.None)
                    {
                        ui.selectedShape.Resize(ui.selectedAnchor, new(e.X, e.Y));
                    }
                    else
                    {
                        ui.selectedShape.Move(e.X, e.Y, ui.deltaX, ui.deltaY);
                    }
                    Invalidate();
                }
                else if (ui.currentDrawingShape != null)
                {
                    Debug.WriteLine("Should do stuff and print and draw ... ");
                    ui.setCurrentDrawingShapeX2Y2(e.X, e.Y);
                    Invalidate();
                }

            }
        }

        private void ResetSelection()
        {
            if (ui.selectedShape != null)
            {
                StyleComboBox.Text = ui.selectedShape.Style.ToString();
                ThicknessComboBox.Text = ui.selectedShape.Thickness.ToString();
                ColorSelectionLabel.Text = ui.selectedShape.Color.ToString();
            }
            ui.resetSelection();
            Invalidate();
        }

        private void FillComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ui.selectedShape != null)
                if (FillComboBox.Checked && ui.selectedShape.Type != ShapeType.Line) ui.selectedShape.Fill();
                else ui.selectedShape.Unfill();
            Invalidate();
        }

        private void ThicknessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ui.selectedShape != null)
                try
                {
                    ui.selectedShape.Thickness = int.Parse(ThicknessComboBox.Text);
                }
                catch (Exception)
                {
                    ui.selectedShape.Thickness = settings.Thickness;
                    ThicknessComboBox.Text = settings.Thickness.ToString();
                }
            else
                try
                {
                    settings.Thickness = float.Parse(ThicknessComboBox.Text);
                }
                catch (Exception)
                {
                    ThicknessComboBox.Text=settings.Thickness.ToString();
                } 
            Invalidate();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ui.selectedShape != null)
                try
                {
                    ui.selectedShape.Style = (DashStyle)StyleComboBox.SelectedIndex;
                }
                catch (Exception)
                {
                    ui.selectedShape.Style = settings.Style;
                    StyleComboBox.SelectedIndex = (int)settings.Style;
                }
            else
                try
                {
                    settings.Style = (DashStyle)StyleComboBox.SelectedIndex;
                }
                catch (Exception)
                {
                    StyleComboBox.SelectedIndex = (int)settings.Style;
                }
            Invalidate();
        }

        private void AnchorSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                settings.AnchorSize = int.Parse(AnchorSizeComboBox.Text);
            }
            catch (Exception)
            {
                AnchorSizeComboBox.Text= settings.AnchorSize.ToString();
            }
            Invalidate();
        }

        private void BorderOffsetCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                settings.BorderOffset = int.Parse(BorderOffsetCombobox.Text);
            }
            catch (Exception)
            {
                BorderOffsetCombobox.Text = settings.BorderOffset.ToString();
            }
            Invalidate();
        }

        private void BorderThicknessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                settings.BorderThickness= int.Parse(BorderThicknessComboBox.Text);
            }
            catch (Exception)
            {
                BorderThicknessComboBox.Text = settings.BorderThickness.ToString();
            }
            Invalidate();
        }

        private void BorderStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                settings.BorderStyle = (DashStyle)BorderStyleComboBox.SelectedIndex;
            }
            catch (Exception)
            {
                BorderStyleComboBox.SelectedIndex = (int)settings.BorderStyle;
            }
            Invalidate();
        }

        private void ColorSelectionLabel_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = ColorSelectionLabel.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                if (ui.selectedShape != null)
                    try
                    {
                        ui.selectedShape.Color = MyDialog.Color;
                    }
                    catch (Exception)
                    {
                    }
                else
                    try
                    {
                        settings.Color = MyDialog.Color;
                    }
                    catch (Exception)
                    {
                    }
            }
            Invalidate();

        }

        private void BorderColorSelectionLabel_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = BorderColorSelectionLabel.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    settings.BorderColor = MyDialog.Color;
                }
                catch (Exception)
                {
                    BorderColorSelectionLabel.BackColor = settings.BorderColor;
                }
                Invalidate();
            }
            Invalidate();
            
        }

        private void AnchorColorSelectionLabel_Click(object sender, EventArgs e)
        {

            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = AnchorColorSelectionLabel.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    settings.AnchorColor = MyDialog.Color;
                    AnchorColorSelectionLabel.BackColor = settings.AnchorColor;
                }
                catch (Exception)
                {
                    AnchorColorSelectionLabel.BackColor = settings.AnchorColor;
                }
            }
            Invalidate();
        }

        /*
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
}

private void clearBtn_MouseLeave(object sender, EventArgs e)
{
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
*/
    }
}