using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sxos
{
    public class interp
    {
        public void send(string line)
        {
            string[] vs = line.Split('.');
            if (vs[0] == "sys")
            {
                sys(line);
            }
            else if (vs[0] == "calc")
            {
                calc(line);
            }
        }
        public void sys(string line)
        {
            string[] vs = line.Split('.');
            switch (vs[1].Split('(')[0])
            {
                case "printline":
                    Console.WriteLine("tets");
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
