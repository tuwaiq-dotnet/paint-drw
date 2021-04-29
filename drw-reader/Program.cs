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
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadString());
                }
            }

        }
    }
}
