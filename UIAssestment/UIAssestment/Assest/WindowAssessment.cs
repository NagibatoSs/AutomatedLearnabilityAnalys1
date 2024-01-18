using System.IO;

namespace UIAssestment.TextReading
{
    public class WindowAssessment
    {
        public async Task<string> ReadFileAsync(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string text = await reader.ReadToEndAsync();
                return text;
            }
        }
    }
}
