using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    public class FileOperation
    {
        public void CheckFile()
        {
            string filepath = @"E:\Basic Core Program\FileIo\FileIo\WordFile.txt";
            if(File.Exists(filepath))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }
        }
        public void ReadAll()
        {
            string filepath1 = @"E:\Basic Core Program\FileIo\Day27_FileIo\FileIo\WordFile.txt";
            string[] lines;
            lines = File.ReadAllLines(filepath1);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public void ReadText()
        {
            string filepath1 = @"E:\Basic Core Program\FileIo\Day27_FileIo\FileIo\WordFile.txt";
            string Text = File.ReadAllText(filepath1);
            Console.WriteLine(Text);
        }
    }
}
