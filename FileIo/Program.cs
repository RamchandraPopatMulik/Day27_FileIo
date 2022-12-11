namespace FileIo
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileOperation fileOperation= new FileOperation();
            //fileOperation.CheckFile();
            //fileOperation.ReadAll();
            //fileOperation.ReadText();
            //fileOperation.Copypath();
            fileOperation.Deletepath();
        }
    }
}