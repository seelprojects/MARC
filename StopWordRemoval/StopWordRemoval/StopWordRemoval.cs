using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWordRemoval
{
    public class StopWordRemoval
    {

        public string output { get; set; }
        /// <summary>
        /// Input String Sentence
        /// </summary>
        /// <param name="sentence"></param>
        public StopWordRemoval(string sentence, string directoryName)
        {
            //var directoryName = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString());
            //var directoryName = Application.StartupPath.ToString();


            string[] lines = System.IO.File.ReadAllLines(directoryName + "\\InputData\\stopwords_en.txt");
            
            //StringBuilder input = new StringBuilder(sentence);
            output = string.Join(
    " ",
    sentence
        .ToLower()
        .Split(new[] { ' ', '\t', '\n', '\r' /* etc... */ })
        .Where(word => !lines.Contains(word))
);
        }
    }
}
