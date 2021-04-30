using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{


    public class Rectan: Borderable
    {
        public Rectan() : base()
        {
            Start = new();
            End = new();
            pen = new(DefaultSettings.Color, DefaultSettings.Thickness);
            pen.DashStyle = DefaultSettings.DashStyle;
            type = ShapeType.Rectangle;
        }
        public Rectan(Point start, Point end) : base()
        {
            Start = start;
            End = end;
            pen = new(DefaultSettings.Color, DefaultSettings.Thickness);
            pen.DashStyle = DefaultSettings.DashStyle;
            type = ShapeType.Rectangle;
        }
        public override void Draw(Graphics g)
        {
            if (isSelected)
                g.DrawRectangle(borderPen, Start.X - borderOffset, Start.Y - borderOffset, Width + borderOffset * 2, Height + borderOffset * 2);
            if (isFilled)
            {
                g.FillRectangle(new SolidBrush(Color), Start.X, Start.Y, Width, Height);
            }
            else
            {
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawRectangle(p, Start.X, Start.Y, Width, Height);
            }
        }
    }
}
