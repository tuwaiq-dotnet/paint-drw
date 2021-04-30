using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    public class DefaultSettings
    {
        internal static Color Color = Color.Black;
        internal static float Thickness = 5;
        internal static DashStyle Style = DashStyle.Solid;


        internal static Color BorderColor = Color.Gray;
        internal static float BorderThickness = 3;
        internal static DashStyle BorderStyle = DashStyle.Dash;
    }
}