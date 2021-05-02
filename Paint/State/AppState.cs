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
using Paint.Utils;
using System.Windows.Forms;

namespace Paint.State
{
    class AppState
    {
        private static AppState _instance;
        const string FILE_NAME = "Untitled.drw";
        const int MAGIC_NUMBER = 0x7fffffff;

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

        public void Clear()
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
            shapes = new List<Shape>();
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "drw files (*.drw)|*.drw";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                    {
                        string stringOfShapes = reader.ReadString();
                        if (stringOfShapes.Length > 2)
                        {
                            ParserUtils.intParser(stringOfShapes);
                            for (int i = 0; i < ParserUtils.parserCount(); i++)
                            {
                                AddShape(ParserUtils.getShape(stringOfShapes, i));
                            }
                        }
                    }
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

        public void Recompile(string updateSource)
        {
            shapes = new List<Shape>();
            ParserUtils.intParser(updateSource);
            for (int i = 0; i < ParserUtils.parserCount(); i++)
            {
                AddShape(ParserUtils.getShape(updateSource, i));
            }

            Debug.WriteLine("RECOMPILE SUCCESS!");
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

