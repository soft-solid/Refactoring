using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RefactoringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "cs_search";//args[0];
            string param = @"D:\1dotNet\Литература";//args[1];

            if (command == "search")
            {
                Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList().ForEach(n => Console.WriteLine(n));
            }
            if (command == "cs_search")
            {
                Directory.GetFiles(param, "*.cs", SearchOption.AllDirectories).ToList().ForEach(n => Console.WriteLine(n));                
            }
            if (command == "create_txt")
            {
                File.Create(param + "\\test.txt");
            }
            if (command == "remove_txt")
            {
                File.Delete(param + "\\test.txt");
            }

            Console.ReadLine();
        }
    }
}
