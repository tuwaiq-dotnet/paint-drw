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
        private static AppState _instance;
        const string FILE_NAME = "Untitled.drw";
        const int MAGIC_NUMBER = 0;

        private Settings settings;
        private List<Shape> shapes;
        private Shape currentShape;
        private int shapesCount;
        private Tools selectedTool;

        public List<Shape> Shapes { get { return shapes; } }
        public Settings Settings { get { return settings; } }
        public Shape CurrentShape { get { return currentShape; } set { currentShape = value; } }
        public Tools SelectedTool { get { return selectedTool; } set { selectedTool = value; } }
        public int ShapesCount { get { return shapesCount; } }
        private AppState()
        {
            shapes = new List<Shape>();
            settings = Settings.GetInstance();
            currentShape = null;
            shapesCount = 0;
            selectedTool = Tools.Line;
        }

        public static AppState GetInstance()
        {
            if (_instance == null) _instance = new();
            return _instance;
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
    public enum Tools
    {
        Circle,
        Rectangle,
        Line,
        Selector
    }
}

