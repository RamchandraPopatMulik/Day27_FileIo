using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    class File
    {
        public void StreamWriterOperation()
        {
            
            string filePath = @"E:\Basic Core Program\FileIo\Day27_FileIo\FileIo\WordFile.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Hello I am writing this using Stream Writer Operation");
                sw.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
