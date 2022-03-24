using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sxos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                //Console.WriteLine("yes");
                argsint argsint = new argsint();
                argsint.inter(args);
            } 
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
