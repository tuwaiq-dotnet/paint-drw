using System;
using System.Drawing;

namespace Paint.Shapes
{
    public class Line : Shape
    {
        public Line()
        {
            Start = new();
            End = new();
            type = ShapeType.Line;
        }
        public Line(Point start, Point end) : base()
        {
            Start = start;
            End = end;
            type = ShapeType.Line;
        }
        public override void Draw(Graphics g)
        {
            if (isSelected)
                ;
                // Show the two dots that allow for a resize, and possibly increase the
                // thickness while selected (may need to override Select and Unselect for this to happen)
                //g.DrawRectangle(borderPen, Start.X - borderOffset, Start.Y - borderOffset, Width + borderOffset * 2, Height + borderOffset * 2);
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawLine(p, Start, End);
        }
    }
}
