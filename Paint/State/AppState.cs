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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Paint.Shapes;

namespace Paint.State
{
    class AppState
    {
        const string FILE_NAME = "Untitled.drw";
        const int MAGIC_NUMBER = 0;

        private DefaultSettings settings;
        private List<Shape> shapes;
        private Shape currentShape;
        private int shapesCount;
        private ShapeType selectedShape;

        public List<Shape> Shapes
        {
            get { return shapes; }
        }

        public DefaultSettings Settings
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

        public int ShapesCount
        {
            get { return shapesCount; }
        }

        public AppState()
        {
            shapes = new List<Shape>();
            settings = new DefaultSettings();
            currentShape = null;
            shapesCount = 0;
            selectedShape = ShapeType.Line;
        }

        public void ClearCurrentShape()
        {
            this.currentShape = null;
        }

        public void SetCurrentShape(Shape currentShape)
        {
            this.currentShape = currentShape;
        }

        public void SetSelectedShape(ShapeType selectedShape)
        {
            this.selectedShape = selectedShape;
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
            return JsonConvert.SerializeObject(Shapes, Formatting.Indented);
        }

        public string StringifySettings()
        {
            return JsonConvert.SerializeObject(Settings, Formatting.Indented);
        }

        public void Import()
        {
            if (File.Exists(FILE_NAME))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FILE_NAME, FileMode.Open)))
                {
                    // Faisal Section
                    // Run the app
                    // add a few shapes
                    // Add Tokenizer
                    // Add Parser
                    // return new shapes
                    string stringOfShapes = reader.ReadString();
                    Debug.WriteLine(stringOfShapes);

                    /* OUTPUT STRING
                     [
                          {
                            "Start": "20, 30",
                            "End": "40, 50",
                            "Width": 20,
                            "Height": 20,
                            "IsSelected": false,
                            "Type": 0
                          },
                          {
                            "Start": "20, 30",
                            "End": "40, 50",
                            "Width": 20,
                            "Height": 20,
                            "IsSelected": false,
                            "Type": 2
                          }
                      ]
                     */
                }
            }
        }

        public void Save()
        {

            using (BinaryWriter binWriter = new BinaryWriter(File.Open(FILE_NAME, FileMode.Create)))
            {
                binWriter.Write(StringifyShapes());
            }

            Process.Start("explorer.exe", "/select, " + Directory.GetCurrentDirectory() + "\\" + FILE_NAME);
        }

        public void Recompile()
        {
            // Younes section
            //TODO
        }

        // Anas Section
        // Add all Shapes classes implementation here
        // update shapes from here
        // add any method you need like GetCurrentShape() or setCurrentShape();
    }
}

