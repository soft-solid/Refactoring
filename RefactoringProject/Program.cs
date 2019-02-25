﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RefactoringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "search";//args[0];
            string param = @"D:\1dotNet\Литература";//args[1];

            if (command == "search")
            {
                Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList().ForEach(n => Console.WriteLine(n));
            }
            if (command == "cs_search")
            {
                List<string> res = Directory.GetFiles(param, "*", SearchOption.AllDirectories).ToList();
                foreach (string n in res)
                {
                    if (n.Substring(n.LastIndexOf(".") + 1) == "cs")
                    {
                        Console.WriteLine(n);
                    }
                }
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
