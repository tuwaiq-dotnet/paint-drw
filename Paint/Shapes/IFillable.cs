using System;
using System.Drawing;

namespace Paint.Shapes
{
    public interface IFillable
    {
        protected Brush Brush { get; set; }
    }
}
