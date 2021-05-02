using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{


    public class Rectan: Shape
    {
        public Rectan() : base(8)
        {
            Start = new();
            End = new();
            anchors = new(8);
            type = ShapeType.Rectangle;
        }
        public Rectan(Point start, Point end) : base(8)
        {
            Start = start;
            End = end;
            type = ShapeType.Rectangle;
        }
        public override void Draw(Graphics g)
        {
            if (isSelected) DrawBorder(g);
            if (isFilled) g.FillRectangle(new SolidBrush(Color), Start.X > End.X ? End.X : Start.X, Start.Y > End.Y ? End.Y : Start.Y, Width, Height);
            else
            {
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawRectangle(p, Start.X > End.X ? End.X : Start.X, Start.Y > End.Y ? End.Y : Start.Y, Width, Height);
            }
        }
    }
}
