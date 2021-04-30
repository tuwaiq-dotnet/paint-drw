using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public class Circle : Borderable
    {
        public Circle() : base()
        {
            Start = new();
            End = new();
            type = ShapeType.Circle;
        }
        public Circle(Point start, Point end) : base()
        {
            Start = start;
            End = end;
            type = ShapeType.Circle;
        }

        public override void Draw(Graphics g)
        {
            if (isSelected)
                g.DrawRectangle(borderPen, Start.X - borderOffset, Start.Y - borderOffset, Width + borderOffset * 2, Height + borderOffset * 2);
            if (isFilled)
            {
                g.FillEllipse(new SolidBrush(Color), Start.X, Start.Y, Width, Height);
            }
            else
            {
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawEllipse(p, Start.X, Start.Y, Width, Height);
            }

        }
    }
}
