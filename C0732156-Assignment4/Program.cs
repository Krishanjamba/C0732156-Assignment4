using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace C0732156_Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();

        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/732156/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                    {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                counter = File.ReadLines("").Count();
                Console.WriteLine("Number of lines are " + counter);
            }
        }
        
    }
}


   

