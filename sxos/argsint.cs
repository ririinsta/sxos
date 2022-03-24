using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sxos
{
    public class argsint
    {
        public void inter(string[] args)
        {
            switch (args[0])
            {
                case "-c":
                    string[] lines = File.ReadAllLines(args[1]);
                    interp inter = new interp();
                    inter.send(lines);
                    break;
            }
        }
        public void help()
        {

        }
    }
}
