using System.Collections;

namespace UIAssestment.TextReading
{
    public abstract class Assessment
    {
        public int Rate { get; protected set; }
        public string RateMessage { get; protected set; }
        protected string xamlText;

        private static string path = "wwwroot\\Files";

        public void Process()
        {
            xamlText = ReadFiles();
            DoAssessment(xamlText);
            Assessment.DeleteAllFiles();
        }
        public abstract void DoAssessment(string xamlText);

        private string ReadFiles()
        {
            IEnumerable<string> files = Directory.EnumerateFiles(path);
            WindowAssessment wa = new WindowAssessment();
            string xamlText = "";
            foreach (var file in files)
            {
                xamlText += (wa.ReadFileAsync(file)).Result;
            }
            return xamlText;
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
