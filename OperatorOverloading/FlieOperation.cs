using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class FileOperation
    {
        public static int FileCount { get; set; }

        public static void UploadToDatabase()
        {
            Console.WriteLine($"{FileCount}  {(FileCount > 1 ? "files are" : " file is")} uploaded to database");
        }

        public static void DownloadFromDatabase()
        {
            Console.WriteLine($"{FileCount}  {(FileCount > 1 ? "files are" : " file is")} downloaded from database");
        }

        public static bool operator >>(FileOperation fileOperation, int fileCount)
        {
            FileCount = fileCount;
            UploadToDatabase();
            return true;
        }

        public static bool operator<<(FileOperation fileOperation, int fileCount)
        {
            FileCount = fileCount;
            DownloadFromDatabase();
            return true;
        }
    }
}
