using System;
using System.IO;

namespace read
{
    class Program
    {
        const string fileName = "Untitled.drw";

        static void Main()
        {
            ReadDRWFile();
        }

        public static void ReadDRWFile()
        {
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    /*
                    * DRW - string
                    * Version - string
                    * Appsetings - string
                    * number of drawn shapes - int
                    * all shapes props - string
                    */
                    Console.Clear();
                    int magicNumber = reader.ReadInt32();
                    if (magicNumber != 4477527) throw new Exception("fuck!");
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadInt32());
                    string shapes = reader.ReadString();
                    Console.WriteLine(shapes);

                }
            }

        }
    }
}
