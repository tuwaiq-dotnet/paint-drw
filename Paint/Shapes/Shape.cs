using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public abstract class Shape
    {
        protected Anchors anchors;
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
        public int Width { get { return Math.Abs(End.X - Start.X); } }
        public int Height { get { return Math.Abs(End.Y - Start.Y); } }
        public bool IsSelected { get { return isSelected; } }
        public ShapeType Type { get { return type; } }
        public bool IsFilled { get { return isFilled; } }
        public Color Color { get { return color; } set { color = value; } }
        public float Thickness { get { return thickness; } set { thickness = value; } }
        public DashStyle Style { get { return style; } set { style = value; } }

        public Shape()
        {
            Color = Settings.GetInstance().Color;
            Thickness = Settings.GetInstance().Thickness;
            Style = Settings.GetInstance().Style;
        }

        public Shape(int anchorsCount)
        {
            Color = Settings.GetInstance().Color;
            Thickness = Settings.GetInstance().Thickness;
            Style = Settings.GetInstance().Style;
            anchors = new(anchorsCount);
        }

        public void Move(Point point)
        {
            int xDiff = End.X - Start.X;
            int yDiff = End.Y - Start.Y;
            Start = point;
            End = new(Start.X + xDiff, Start.Y + yDiff);
        }
        public void Move(int x, int y) { Move(new(x, y)); }
        public void Move(int x, int y, int xDelta, int yDelta) { Move(new(x - xDelta, y - yDelta)); }
        public void Resize(Point start, Point end)
        {
                Start = start;
                End = end;
        }
        public void Resize(int width, int height) { Resize(Start, new(Start.X + width, Start.Y + height)); }
        public void Resize(AnchorDirection direction, Point p)
        {
            switch (direction)
            {
                case AnchorDirection.North:
                    Start = new Point(Start.X, Start.Y + (p.Y - Start.Y));
                    break;
                case AnchorDirection.NorthEast:
                    Start = new(Start.X, Start.Y + (p.Y - Start.Y));
                    End = new(End.X + (p.X - End.X), End.Y);
                    break;
                case AnchorDirection.East:
                    End = new(End.X + (p.X - End.X), End.Y);
                    break;
                case AnchorDirection.SouthEast:
                    End = new(End.X + (p.X - End.X), End.Y + (p.Y - End.Y));
                    break;
                case AnchorDirection.South:
                    End = new(End.X, End.Y + (p.Y - End.Y));
                    break;
                case AnchorDirection.SouthWest:
                    Start = new(Start.X + (p.X - Start.X), Start.Y);
                    End = new(End.X, End.Y + (p.Y - End.Y));
                    break;
                case AnchorDirection.West:
                    Start = new(Start.X + (p.X - Start.X), Start.Y);
                    break;
                case AnchorDirection.NorthWest:
                    Start = new(Start.X + (p.X - Start.X), Start.Y + (p.Y - Start.Y));
                    break;
                default:
                    return;
            }
        }
        public void Select() { isSelected = true; }
        public void Fill() { isFilled = true; }
        public void Unselect() { isSelected = false; }
        public void Unfill() { isFilled = false; }
        public bool Contains(Point p) { return Contains(p.X, p.Y); }
        public bool Contains(int x, int y)
        {
            return
               x >= Math.Min(Start.X, End.X) &&
               x <= Math.Min(Start.X, End.X) + Width &&
               y >= Math.Min(Start.Y, End.Y) &&
               y <= Math.Min(Start.Y, End.Y) + Height;

        }
        public AnchorDirection OnAnchor(Point p) { return anchors.OnAnchor(p); }        
        protected void DrawBorder(Graphics g)
        {
            Pen p = new(Settings.GetInstance().BorderColor, Settings.GetInstance().BorderThickness);
            p.DashStyle = Settings.GetInstance().BorderStyle;
            g.DrawRectangle(p,
                (Start.X > End.X ? End.X : Start.X) - Settings.GetInstance().BorderOffset,
                (Start.Y > End.Y ? End.Y : Start.Y) - Settings.GetInstance().BorderOffset,
                Width + Settings.GetInstance().BorderOffset * 2,
                Height + Settings.GetInstance().BorderOffset * 2);


            Point start = new(Math.Min(Start.X, End.X), Math.Min(Start.Y, End.Y));
            Point end = new(Math.Max(Start.X, End.X), Math.Max(Start.Y, End.Y));
            anchors.Draw(start, end, g);
        }
        
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