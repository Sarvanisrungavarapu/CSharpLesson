using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayEight
{
    class FileOperatorDemo
    {
        public static void FileWriterAllLines()
        {
            String fName = @"c:\temp\myfileA.txt";
            string[] lines =
            {
                "Chennai is the capital of city.",
                "Madurai is the Temple city.",
                "Salem is the steal city."
            };
            try
            {
                File.WriteAllLines(fName, lines);
                System.Console.WriteLine("File created");
            }
            catch(Exception err)
            {
                Console.WriteLine($"ERROR!!!!!! {err.Message}");  
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }
            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if (_logoBytes == null)
                {
                    _logoBytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                }
                return _logoBytes;
            }
        }
    }
}
