using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class Program
    {
        int[] input = {};
        static void Main(string[] args)
        {
            //String filename = "samples.txt";
            //if (File.Exists(filename))
            //{
            //    Console.WriteLine("The filename: {0}", filename);
            //    Console.WriteLine("Attributes: {0}", File.GetAttributes(filename));
            //    Console.WriteLine("Created: {0}", File.GetCreationTime(filename));

            //    //Using foreach loop
            //    DirectoryInfo dir = new DirectoryInfo(".");
            //    foreach (FileInfo nfo in dir.GetFiles("*.*"))
            //    {
            //        Console.WriteLine(nfo.Name);
            //    }
            //    //Using for Loop
            //    FileInfo[] allTheFiles = dir.GetFiles("*.*");
            //    int numFiles = allTheFiles.Length;
            //    for (int i = 0; i < numFiles; i++)
            //    {
            //        Console.WriteLine(allTheFiles[i].Name);
            //    }
            //}


            List<int> values = W3Assignment.RunAssignments();
            Console.WriteLine("Min: " + W3Assignment.minVal(values.ToArray()));
            Console.WriteLine("Max: " + W3Assignment.maxVal(values.ToArray()));
            Console.ReadLine();
        }
    }
}


