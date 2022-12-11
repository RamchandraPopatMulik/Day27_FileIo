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
    }
}
