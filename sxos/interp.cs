﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sxos
{
    public class interp
    {
        public void send(string[] linze)
        {
            foreach (string line in linze)
            {
                string[] vs = line.Split('.');
                if (vs[0] == "sys")
                {
                    //Console.WriteLine("sys");
                    sys(line);
                }
                else if (vs[0] == "calc")
                {
                    //Console.WriteLine("calc");
                    calc(line);
                }
                else
                {
                    Console.WriteLine("shit is broken");
                }
            }  
        }
        public void sys(string line)
        {
            string[] vs = line.Split('.');
            switch (vs[1].Split('(')[0])
            {
                case "printline":
                    string[] cs = vs[1].Split('(');
                    string[] cs2 = cs[1].Split('"');
                    //Console.WriteLine(cs2[0]);
                    if (cs2[0] == "printline")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Dump of vars below");
                        foreach (string s in cs)
                        {
                            Console.WriteLine(s);
                        }
                        foreach (string s in cs2)
                        {
                            Console.WriteLine(s);
                        }
                    } else
                    {
                        Console.WriteLine(cs2[1]); 
                    }
                    break;
                case "print":
                    string[] cs22 = vs[1].Split('(');
                    string[] cs222 = cs22[1].Split('"');
                    //Console.Write(cs222[0]);
                    if (cs222[0] == "print")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Dump of vars below");
                        foreach (string s in cs22)
                        {
                            Console.WriteLine(s);
                        }
                        foreach (string s in cs222)
                        {
                            Console.WriteLine(s);
                        }
                    } else
                    {
                        Console.Write(cs222[1]);
                    }
                    break;
                default:
                    Console.WriteLine(line);
                    break;
            }
        }
        public void calc(string line)
        {

        }
    }
}
