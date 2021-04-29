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

using Newtonsoft.Json;
using Paint.Drawing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace Paint.State
{
    class AppState
    {
        const string FILE_NAME = "Untitled.drw";

        private AppSettings settings;
        private List<Shape> shapes;
        private Shape currentShape;
        private int shapesCount;
        private ShapeType selectedShape;
        private ToolType selectedTool;

        public List<Shape> Shapes
        {
            get { return shapes; }
        }

        public AppSettings Settings
        {
            get { return settings; }
        }

        public Shape CurrentShape
        {
            get { return currentShape; }
        }

        public ShapeType SelectedShape
        {
            get { return selectedShape; }
        }

        public ToolType SelectedTool
        {
            get { return selectedTool; }
        }

        public int ShapesCount
        {
            get { return shapesCount; }
        }

        public AppState()
        {
            shapes = new List<Shape>();
            settings = new AppSettings();
            currentShape = null;
            selectedShape = ShapeType.Line;
            selectedTool = ToolType.Rectangler;
        }

        public void SetThickness(int thickness)
        {
            settings.SetSettings(Settings.Color, thickness, Settings.DashStyleIndex);
        }

        public void SetDashStyle(int dashStyleIndex)
        {
            settings.SetSettings(settings.Color, settings.Thickness, dashStyleIndex);
        }

        public void SetColor(Color color)
        {
            settings.SetSettings(color, settings.Thickness, settings.DashStyleIndex);
        }

        public void ClearCurrentShape()
        {
            this.currentShape = null;
        }

        public void SetCurrentShape(Shape currentShape)
        {
            this.currentShape = currentShape;
        }

        public void SetCurrentShapeX1Y1(int x, int y)
        {
            this.currentShape.x1 = x;
            this.currentShape.y1 = y;
        }

        public void SetCurrentShapeX2Y2(int x, int y)
        {
            this.currentShape.x2 = x;
            this.currentShape.y2 = y;
        }

        public void SetSelectedShape(ShapeType selectedShape)
        {
            this.selectedShape = selectedShape;
        }

        public void SetSelectedTool(ToolType selectedTool)
        {
            this.selectedTool = selectedTool;
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            shapesCount++;
        }

        public void RemoveShape(Shape shape)
        {
            shapes.Remove(shape);
            shapesCount--;
        }

        public string StringifyShapes()
        {
            return "\n" + JsonConvert.SerializeObject(Shapes, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }) + "\n";
        }

        public string StringifySettings()
        {
            return "\n" + JsonConvert.SerializeObject(Settings, Formatting.Indented) + "\n";
        }

        public void import()
        {
            if (File.Exists(FILE_NAME))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FILE_NAME, FileMode.Open)))
                {
                    /*
                    * DRW - string
                    * Version - string
                    * Appsetings - string
                    * number of drawn shapes - int
                    * all shapes props - string
                    */

                    if (!reader.ReadString().Equals("DRW")) Debug.WriteLine("ERROR");

                    // skip version
                    reader.ReadString();

                    string parsedSettings = reader.ReadString();
                    Debug.WriteLine("THICKNESS READ FROM FILE: " + parsedSettings[19]);
                }
            }
        }

        public void save()
        {

            using (BinaryWriter binWriter = new BinaryWriter(File.Open(FILE_NAME, FileMode.Create)))
            {
                Random rnd = new Random();
                int randomThickness = rnd.Next(1, 13);
                this.SetThickness(randomThickness);
                binWriter.Write("DRW\n");
                binWriter.Write("Paint Version 1.0.0(1)-alpha");
                binWriter.Write(StringifySettings());
                binWriter.Write(ShapesCount);
                binWriter.Write(StringifyShapes());
            }

            Process.Start("explorer.exe", "/select, " + Directory.GetCurrentDirectory() + "\\" + FILE_NAME);
        }
    }
}
