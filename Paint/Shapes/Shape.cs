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
        
        public Point Start { set { start = value; } get { return start; } }
        public Point End { set { end = value; } get { return end; } }
        public int Width { get { return End.X - Start.X; } }
        public int Height { get { return End.Y - Start.Y; } }
        public bool IsSelected { get { return isSelected; } }
        public ShapeType Type { get { return type; } }

        protected abstract Color Color { set; get; }
        protected abstract float Thickness { set; get; }
        protected abstract DashStyle Style { set; get; }

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
        public void Select()
        {
            isSelected = true;
        }
        public void Unselect()
        {
            isSelected = false;
        }
        public void Resize(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public abstract void Draw(Graphics g);

    }

    public enum ShapeType
    {
        Circle,
        FilledCircle,
        Rectangle,
        FilledRectangle,
        Line,
        /*
            Consider adding other types, such as triangles and free-pens.
            Also, consider adding attachable shapes, such as U-T pairs.
         */
    }
}