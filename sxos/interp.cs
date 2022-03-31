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
                    calc(line, linrer);
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
                case "store":
                    string[] xcs = { };
                    string[] xcs2 = { };
                    try
                    {
                        xcs = vs[1].Split('(');
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
                        xcs2 = xcs[1].Split('"');
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("--- ERROR ---");
                        Console.ResetColor();
                        Console.WriteLine("Parsing failed! Check your code!");
                        Console.WriteLine("Error on line " + (linen + 1) + " " + line);
                    }
                    foreach (string c in xcs)
                    {
                        Console.WriteLine(c);
                    }
                    foreach(string c in xcs2)
                    {
                        Console.WriteLine(c);
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
        public void calc(string line, int linen)
        {
            List<string> vs = new List<String>();
            vs = line.Split('.').ToList();
            vs.RemoveAt(0);
            vs = vs[0].Split('(').ToList();
            vs[1] = vs[1].Remove(vs[1].Length - 1, 1);
            switch (vs[0])
            {
                case "parse":
                    vs.RemoveAt(0);
                    vs = vs[0].Split(',').ToList();
                    vs[1] = vs[1].Remove(0, 1);
                    vs[0] = vs[0].Remove(0, 1);
                    vs[0] = vs[0].Remove(vs[0].Length - 1, 1);
                    switch (vs[1])
                    {
                        case "add":
                            List<string> numbors = new List<string>();
                            List<int> numbor = new List<int>();
                            int all = 0 ;
                            numbors = vs[0].Split('+').ToList();
                            foreach(string num in numbors)
                            {
                                numbor.Add(Int32.Parse(num));
                            }
                            foreach(int numb in numbor)
                            {
                                all = all + numb;
                            }
                            Console.WriteLine("paddc " + all);
                            break;
                        case "sub":
                            List<string> _numbors = new List<string>();
                            List<int> _numbor = new List<int>();
                            int _all = 0;
                            numbors = vs[0].Split('-').ToList();
                            foreach (string num in numbors)
                            {
                                //Console.WriteLine(num);
                                _numbor.Add(Int32.Parse(num));
                            }
                            _all = _numbor[0];
                            _numbor.RemoveAt(0);
                            foreach (int numb in _numbor)
                            {
                                //Console.WriteLine("all = " + _all + " numb = " + numb);
                                _all = _all - numb;
                            }
                            Console.WriteLine("psubc " + _all);
                            break;
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
    }
}
