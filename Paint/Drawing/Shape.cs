/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Drawing
{
    public abstract class Shape
    {
        public int x1, x2, y1, y2;
        public ShapeType type;
        public bool isSelected;
        //public Pen pen;
        public ShapeType Type { get; }
        public int Height { get { return this.y2 - this.y1; } }
        public int Width { get { return this.x2 - this.x1; } }
        public bool IsSelected { get; }
        public Color Color
        {
            get
            {
                return Color.White;
            }
        }
        public DashStyle DashStyle
        {
            get
            {
                return DashStyle.Dot;
            }
        }
        public float Thickness
        {
            get
            {
                return 20;
            }
        }
        public abstract void Draw(Graphics g, bool preview = false);

        public void Relocate()
        {
            //TODO: implement me
            throw new Exception("Implement me");
        }

        public void Resize()
        {
            //TODO: implement me
            throw new Exception("Implement me");
        }
    }

    public enum ShapeType
    {
        Line,
        Ellipse,
        Rectangle
    }
}
