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

using System.Drawing;

namespace Paint.Drawing
{
    public class Line : Shape
    {
        public Line(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.type = ShapeType.Line;

        }

        public override void Draw(Graphics g, bool preview = false)
        {
            if (preview)
                g.DrawLine(new Pen(Color.DarkGray, 3), x1, y1, x2, y2);
            else
                g.DrawLine(new Pen(Color.DarkGray, 3), x1, y1, x2, y2);

        }
    }
}
