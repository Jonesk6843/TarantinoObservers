﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class LoadFiles
    {
        public static void loadFile()
        {
            try
            {
                //declar variables
                string userName;
                string userPass;
                bool transfer = false;

                //read file
                StreamReader inputfile;

                //tokenize
                

                File.OpenText($"Observer_Cirtificate.txt");

                // ask for password
                //while (transfer == false)
                //{
                //    Console.WriteLine("What is thou's name?");
                //    Console.Write("> ");
                //    string userName = Console.ReadLine();
                //    Console.WriteLine("What is thou's password?");
                //    Console.Write("> ");
                //    string userPass = Console.ReadLine();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
