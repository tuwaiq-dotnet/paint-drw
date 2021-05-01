using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public class Circle : Shape
    {
        public Circle() : base(8)
        {
            Start = new();
            End = new();
            anchors = new(8);
            type = ShapeType.Circle;
        }
        public Circle(Point start, Point end) : base(8)
        {
            Start = start;
            End = end;
            anchors = new(8);
            type = ShapeType.Circle;
        }

        public override void Draw(Graphics g)
        {
            if (isSelected) DrawBorder(g);
            if (isFilled) g.FillEllipse(new SolidBrush(Color), Start.X, Start.Y, Width, Height);
            else
            {
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawEllipse(p, Start.X, Start.Y, Width, Height);
            }
        }
    }
}
