using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;                                                                                  
using System.Text;
using System.Threading.Tasks;

namespace C0725642_Assignment___4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Wordskipper();
            Console.ReadLine();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("report1.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            {
                foreach (char c in line)
                {
                    if (char.IsLetter(c)) { countletters++; }
                    if (char.IsWhiteSpace(c)) { countSpaces++; }
                }
                return countSpaces;
            }
        }
        public void CountLinesReader()
        {
            long lineCounter = 0;
            using (StreamReader fil = new StreamReader("report1.txt"))
            {
                while (fil.ReadLine() != null)
                {
                    lineCounter++;
                }
                Console.WriteLine(lineCounter);
            }
        }
        public void WordCounter()
        {
            StreamReader reader = new StreamReader("report1.txt");
            string script = reader.ReadToEnd();
            var text = script.Trim();
            int wordCount = 0, index = 0;
            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;
                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine(wordCount);
        }
        public void Wordfinder()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("report1.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    f++;
                }
            }
            Console.WriteLine(f);
        }
        public void Wordskipper()
        {
            int f = 0;
            int m = 0;
            int n = 0;
            foreach (var line in File.ReadAllLines("report1.txt"))
            {
                if (line.Contains("fare"))
                {
                    f++;
                }
            }
            foreach (var line in File.ReadAllLines("report1.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    m++;
                }
            }
            n = f - m;
            Console.WriteLine(n);
        }
    }
}