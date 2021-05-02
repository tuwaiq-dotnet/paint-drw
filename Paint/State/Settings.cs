using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    public class Settings
    {
        private static Settings _instance;
        private Settings() { }
        public static Settings GetInstance()
        {
            if (_instance == null) _instance = new Settings();
            return _instance;
        }

        private Color color = Color.Black;
        private float thickness = 5;
        private DashStyle style = DashStyle.Solid;
        private Color borderColor = Color.Gray;
        private float borderThickness = 3;
        private DashStyle borderStyle = DashStyle.Dash;
        private int borderOffset = 20;
        private Color anchorColor = Color.Red;
        private int anchorSize = 16;

        public Color Color { get { return color; } set { color = value; } }
        public float Thickness { get { return thickness; } set { thickness = value; } }
        public DashStyle Style { get { return style; } set { style = value; } }
        public Color BorderColor { get { return borderColor; } set { borderColor = value; } }
        public float BorderThickness { get { return borderThickness; } set { borderThickness = value; } }
        public DashStyle BorderStyle { get { return borderStyle; } set { borderStyle = value; } }
        public int BorderOffset { get { return borderOffset; } set { borderOffset = value * 2; } }
        public Color AnchorColor { get { return anchorColor; } set { anchorColor = value; } }
        public int AnchorSize { get { return anchorSize; } set { anchorSize = value * 2; } }


        /*
         * It is preferred to have the following values be even numbers.
         * Enforcing this on the user would be great!
         */

    }
}