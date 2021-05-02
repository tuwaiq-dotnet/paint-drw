using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Shapes;
using Paint.State;

namespace Paint.Utils
{
    public class UIUtils
    {
        private static UIUtils _instance;
        private AppState state = AppState.GetInstance();
        private Settings settings = Settings.GetInstance();
        private UIUtils()
        {

        }

        public static UIUtils GetInstance()
        {
            if (_instance == null)
                _instance = new();

            return _instance;
        }

        public void resetSelection()
        {
            selectedShape?.Unselect();
            selectedAnchor = AnchorDirection.None;
            selectedShape = null;
            resetDelta();
        }
    
        public void resetDelta()
        {
            deltaX = 0;
            deltaY = 0;
        }
        public bool selectShape(int x, int y) {

            foreach (var shape in state.Shapes)
            {
                if (shape.Contains(new(x, y)))
                {
                    selectedShape = shape;
                    shape.Select();
                    setDelta(x, y);
                    state.Shapes.Remove(shape);
                    state.Shapes.Add(shape);
                    return true;
                }
            }
            return false;
        }

        private void setDelta(int x, int y)
        {
            deltaX = x - selectedShape.Start.X;
            deltaY = y - selectedShape.Start.Y;
        }

        public Cursor GetCursor(int X, int Y)
        {
            foreach (var shape in state.Shapes)
            {
                AnchorDirection dir = shape.OnAnchor(new(X, Y));
                if (dir == AnchorDirection.North || dir == AnchorDirection.South) return Cursors.SizeNS;
                else if (dir == AnchorDirection.East || dir == AnchorDirection.West) return Cursors.SizeWE;
                else if (dir == AnchorDirection.NorthEast || dir == AnchorDirection.SouthWest) return Cursors.SizeNESW;
                else if (dir == AnchorDirection.NorthWest || dir == AnchorDirection.SouthEast) return Cursors.SizeNWSE;
                else if (shape.Contains(new(X, Y))) return shape.IsSelected ? Cursors.NoMove2D : Cursors.Hand;
            }
           return Cursors.Default;
        }
        public bool isHolding;
        public Shape selectedShape;
        public AnchorDirection selectedAnchor;
        public int deltaX = 0;
        public int deltaY = 0;

        // temp prop for drawing
        public Shape currentDrawingShape { get; set; }

        public void setCurrentDrawingShapeX1Y1(int x, int y)
        {
            currentDrawingShape.Start = new(x, y);
        }
        public void setCurrentDrawingShapeX2Y2(int x, int y)
        {
            currentDrawingShape.End = new(x, y);
        }

        public void setAndClearCurrentShape(int x, int y)
        {
            setCurrentDrawingShapeX2Y2(x, y);
            currentDrawingShape.Color = settings.Color;
            currentDrawingShape.Thickness = settings.Thickness;
            currentDrawingShape.Style = settings.Style;
            state.AddShape(currentDrawingShape);

            currentDrawingShape = null;
        }
    }
}
