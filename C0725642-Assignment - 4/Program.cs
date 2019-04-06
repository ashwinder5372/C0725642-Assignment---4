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
                p.ReadTextFiles();
                
        }
            public void Run() { this.ReadTextFiles(); }

            public void ReadTextFiles()
            {
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(@"U:\Users\725642\report1.txt"))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                       counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter } lines.");
                Console.WriteLine($"File has {counter*5 } Words.");

            }
            }

            public int FindNumberOfBlankSpaces(string line)
            {
                
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


    
