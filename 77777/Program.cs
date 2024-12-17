﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77777
{
    class Program
    {
        static void Outputnum(int a)
        {
            Console.WriteLine(a);
        }
        static void Output(List<string> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
        static void Caps(List<string> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el.ToUpper());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Array list = new ArrayList();
            List<string> list = new List<string>() { "Мария", "Людмила", "Светалана", "Наталья", "Ольга", "Елена" };
            list.Add("Екатерина");
            Output(list);
            Caps(list);
            Outputnum(list.Count);
            Console.WriteLine();
            list.Add("Ника");
            Output(list);
            list.Insert(0, "Дарья");
            Output(list);
            list.RemoveAt(3);
            Output(list);
            list.Reverse();
            Output(list);
            Console.ReadLine();
        }
    }
}
