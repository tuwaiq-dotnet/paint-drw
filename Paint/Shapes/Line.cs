using System;
using System.Drawing;

namespace Paint.Shapes
{
    public class Line : Shape
    {
        public Line():base(2)
        {
            Start = new();
            End = new();
            type = ShapeType.Line;
        }
        public Line(Point start, Point end) : base(2)
        {
            Start = start;
            End = end;
            type = ShapeType.Line;
        }
        public override void Draw(Graphics g)
        {
            if (isSelected) anchors.Draw(Start, End, g);
                // Show the two dots that allow for a resize, and possibly increase the
                // thickness while selected (may need to override Select and Unselect for this to happen)
                //g.DrawRectangle(borderPen, Start.X - borderOffset, Start.Y - borderOffset, Width + borderOffset * 2, Height + borderOffset * 2);
                Pen p = new Pen(Color, Thickness);
                p.DashStyle = Style;
                g.DrawLine(p, Start, End);
        }

        public override void Resize(AnchorDirection direction, Point p)
        {
            switch (direction)
            {
                case AnchorDirection.North:
                    Start = new Point(p.X, p.Y);
                    break;
                case AnchorDirection.End:
                    End = new(p.X, p.Y);
                    break;
            }
        }
    }
}
