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

namespace Paint.State
{
    class AppSettings
    {
        private int thickness;
        private int dashStyleIndex;
        private Color color;

        public int Thickness
        {
            get { return thickness; }
        }

        public int DashStyleIndex
        {
            get { return dashStyleIndex; }
        }

        public Color Color
        {
            get { return color; }
        }

        public void Defaults()
        {
            thickness = 10;
            dashStyleIndex = 2;
            color = Color.White;
        }

        public AppSettings()
        {
            Defaults();
        }

        public AppSettings(int thickness, int dashStyleIndex, Color color)
        {
            this.thickness = thickness;
            this.dashStyleIndex = dashStyleIndex;
            this.color = color;
        }

        public AppSettings SetSettings(Color color, int thickness = 3, int dashStyleIndex = 2)
        {
            this.thickness = thickness;
            this.dashStyleIndex = dashStyleIndex;
            this.color = color;
            return this;
        }
    }
}
