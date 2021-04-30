using System.Drawing;
using Paint;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public abstract class Borderable : Shape
    {
        protected Pen borderPen;
        protected Color BorderColor
        {
            set
            {
                borderPen.Color = value;
            }
            get
            {
                return borderPen.Color;
            }
        }
        protected float BorderThickness
        {
            set
            {
                borderPen.Width = value;
            }
            get
            {
                return borderPen.Width;
            }
        }
        protected DashStyle BorderStyle
        {
            set
            {
                borderPen.DashStyle = value;
            }
            get
            {
                return borderPen.DashStyle;
            }
        }
        protected int borderOffset = 10;
        protected int BorderOffset
        {
            get
            {
                return borderOffset;
            }
            set
            {
                borderOffset = value;
            }
        }

        public Borderable()
        {
            borderPen = new(DefaultSettings.BorderColor, DefaultSettings.BorderThickness);
            BorderStyle = DefaultSettings.BorderDashStyle;
        }
        public bool Contains(Point p)
        {
            return
               p.X >= Start.X &&
               p.X <= End.X &&
               p.Y >= Start.Y &&
               p.Y <= End.Y;
        }
        public void Inflate(int width, int height)
        {
            End = new(Start.X + width, Start.Y + height);
        }
        public void Resize(BorderDirection direction, int offset)
        {
            switch (direction)
            {
                case BorderDirection.Up:
                    Start = new(Start.X, Start.Y + offset);
                    return;
                case BorderDirection.Down:
                    End = new(End.X, End.Y + offset);
                    return;
                case BorderDirection.Right:
                    End = new(End.X + offset, End.Y);
                    return;
                case BorderDirection.Left:
                    Start = new(Start.X + offset, Start.Y);
                    return;
            }
        }
        public BorderDirection OnBorder(Point p)
        {
            int penDiff = (int)(borderPen.Width / 2);

            Rectangle topRect = new(
                Start.X - borderOffset - penDiff,
                Start.Y - borderOffset - penDiff,
                End.X + borderOffset + penDiff,
                Start.Y - borderOffset + penDiff);
            if (topRect.Contains(p)) return BorderDirection.Up;

            Rectangle bottomRect = new(
                Start.X - borderOffset - penDiff,
                End.Y + borderOffset - penDiff,
                End.X + borderOffset + penDiff,
                End.Y + borderOffset + penDiff);
            if (bottomRect.Contains(p)) return BorderDirection.Down;

            Rectangle rightRect = new(
                End.X + borderOffset - penDiff,
                Start.Y - borderOffset - penDiff,
                End.X + borderOffset + penDiff,
                End.Y + borderOffset + penDiff);
            if (rightRect.Contains(p)) return BorderDirection.Right;

            Rectangle leftRect = new(
                Start.X - borderOffset - penDiff,
                Start.Y - borderOffset - penDiff,
                Start.X - borderOffset + penDiff,
                End.Y + borderOffset + penDiff);
            if (leftRect.Contains(p)) return BorderDirection.Left;
            return BorderDirection.None;

        }
    }

    public enum BorderDirection
    {
        None = -1,
        Up,
        Down,
        Right,
        Left
    }
}

