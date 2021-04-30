using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public abstract class Shape
    {
        protected ShapeType type;
        protected bool isSelected;
        protected Point start;
        protected Point end;
        protected bool isFilled;
        protected Color color;
        protected float thickness;
        protected DashStyle style;

        public Point Start { set { start = value; } get { return start; } }
        public Point End { set { end = value; } get { return end; } }
        public int Width { get { return End.X - Start.X; } }
        public int Height { get { return End.Y - Start.Y; } }
        public bool IsSelected { get { return isSelected; } }
        public ShapeType Type { get { return type; } }
        public bool IsFilled{ get { return isFilled; } }
        public Color Color { get { return color; } set { color = value; } }
        public float Thickness { get { return thickness; } set { thickness = value; } }
        public DashStyle Style { get { return style; } set { style = value; } }

        public Shape()
        {
            Color = DefaultSettings.Color;
            Thickness = DefaultSettings.Thickness;
            Style = DefaultSettings.Style;
        }
        public void Move(Point point)
        {
            int xDiff = End.X - Start.X;
            int yDiff = End.Y - Start.Y;
            Start = point;
            End = new(Start.X + xDiff, Start.Y + yDiff);
        }
        public void Move(int x, int y)
        {
            int xDiff = End.X - Start.X;
            int yDiff = End.Y - Start.Y;
            Start = new(x, y);
            End = new(x + xDiff, y + yDiff);
        }
        public void Resize(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public void Select() { isSelected = true; }
        public void Fill() { isFilled = true; }
        public void Unselect() { isSelected = false; }
        public void Unfill() { isFilled = false; }

        public abstract void Draw(Graphics g);
    }

    public enum ShapeType
    {
        Circle,
        Rectangle,
        Line,
        /*
            Consider adding other types, such as triangles and free-pens.
            Also, consider adding attachable shapes, such as U-T pairs.
         */
    }

    // Consider adding an enum for brush types (e.g. Solid, LinearGradiant, Hatched, etc.)
}