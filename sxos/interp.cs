using System;
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
            int linrer = 0;
            foreach (string line in linze)
            {
                string[] vs = line.Split('.');
                if (vs[0] == "sys")
                {
                    //Console.WriteLine("sys");
                    sys(line, linrer);
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
                linrer++;
            }  
        }
        public void sys(string line, int linen)
        {
            string[] vs = line.Split('.');
            switch (vs[1].Split('(')[0])
            {
                case "printline":
                    string[] cs = { };
                    string[] cs2 = { };
                    try
                    {
                        cs = vs[1].Split('(');
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Parsing failed! Check your code!");
                        Console.WriteLine("Error on line " + (linen + 1) + " " + line);
                        return;
                    }

                    try
                    {
                        cs2 = cs[1].Split('"');
                    } 
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Parsing failed! Check your code!");
                        Console.WriteLine("Error on line " + (linen + 1) + " " + line);
                        return;
                    }
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
                    string[] cs22 = {};
                    string[] cs222 = {};
                    try
                    {
                        cs22 = vs[1].Split('(');
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Parsing failed! Check your code!");
                        Console.WriteLine("Error on line " + (linen + 1) + " " + line);
                        return;
                    }

                    try
                    {
                        cs222 = cs22[1].Split('"');
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Parsing failed! Check your code!");
                        Console.WriteLine("Error on line " + (linen + 1) + " " + line);
                        return;
                    }
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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("--- ERROR ---");
                    Console.ResetColor();
                    Console.WriteLine("Function " + vs[1].Split('(')[0] + " doesn't exist in the sys class!");
                    Console.WriteLine("Line " + (linen + 1) + " " + line);
                    break;
            }
        }
        public void calc(string line)
        {

        }
    }
}
