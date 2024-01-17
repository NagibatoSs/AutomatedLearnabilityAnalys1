using System.Collections;

namespace UIAssestment.TextReading
{
    public static class Assestment
    {
        private static string path = "wwwroot\\Files";
        public static string DoAssestment()
        {
            IEnumerable<string> files = Directory.EnumerateFiles(path);
            WindowAssestment wa = new WindowAssestment();
            string result = "";
            foreach(var file in files)
            {
                result += (wa.ReadFileAsync(file)).Result;
            }
            Assestment.DeleteAllFiles();
            return result;
        }

        private static void DeleteAllFiles()
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
        }
    }
}
