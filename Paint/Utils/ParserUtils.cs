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
using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Utils
{
    static class ParserUtils
    {
        static Paint.Parser.JSON j;

        public static void intParser(string str)
        {
            j = new(str);
        }
        public static int parserCount()
        {
            return j.Root.getArray().Count;
        }
        public static Shape getShape(string str1 , int num)
        {
            Paint.Parser.JSON j = new(str1);
            // str = "x1,y1,x2,y2"
            string str = (j.Root.getArray().getItem(num).getObject().getItem("Start").getString()).ToString().Trim('"')
                + "," + (j.Root.getArray().getItem(num).getObject().getItem("End").getString()).ToString().Trim('"');

            //xy = [x1,y1,x2,y2]
            String[] xy = str.Split(",");
            int x1 = int.Parse(xy[0]);
            int y1 = int.Parse(xy[1]);
            int x2 = int.Parse(xy[2]);
            int y2 = int.Parse(xy[3]);

            int type = int.Parse(
                j.Root.getArray()
                .getItem(num)
                .getObject()
                .getItem("Type")
                .getNumber()
                .ToString()
                );

            int style = int.Parse(
                j.Root.getArray()
                .getItem(num)
                .getObject()
                .getItem("Style")
                .getNumber()
                .ToString()
                );

            Point point1 = new(x1, y1);
            Point point2 = new(x2, y2);
            
            Shape sh = type == (int)ShapeType.Circle ?
                new Circle(point1, point2) : type == (int)ShapeType.Rectangle ?
                new Rectan(point1, point2) : new Line(point1, point2);



            /*if (type == 0)
            {
                return new Circle(point1, point2);
            }
            else if (type == 1)
            {
                return new Rectan(point1, point2);

            }
            return new Line(point1, point2);*/



            sh.Color = Color.FromName(
                j.Root.getArray()
                .getItem(num)
                .getObject()
                .getItem("Color")
                .getString()
                .ToString()
                .Trim('"')
                );

            sh.Thickness = float.Parse(
                j.Root.getArray()
                .getItem(num)
                .getObject()
                .getItem("Thickness")
                .getNumber()
                .ToString()
                );


            if (style == 0)
            {
                sh.Style = DashStyle.Solid;
            }
            else if (style == 1)
            {
                sh.Style = DashStyle.Dash;
            }
            else if (style == 2)
            {
                sh.Style = DashStyle.Dot;
            }
            else if (style == 3)
            {
                sh.Style = DashStyle.DashDot;
            }
            else if (style == 4)
            {
                sh.Style = DashStyle.DashDotDot;
            }
            else
            {
                sh.Style = DashStyle.Custom;
            }

            return sh;
        }
    }
}
