using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725642_Assignment___4
{
    class Program
    {
       
         ArrayList Beowulf;

            static void main(string[] args)
            {
                Program p = new Program();
                p.Beowulf = new ArrayList();
            }
            public void Run() { this.ReadTextFiles(); }

            public void ReadTextFiles()
            {
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(""))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter } lines.");

                }
            }

            public int FindNumberOfBlankSpaces(string line)
            {
                // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
                int countletters = 0;
                int countSpaces = 0;

                foreach (char c in line)
                {
                    if (char.IsLetter(c)) { countletters++; }
                    if (char.IsWhiteSpace(c)) { countSpaces++; }
                }
                return countSpaces;
            }
        }
    }
}
    
