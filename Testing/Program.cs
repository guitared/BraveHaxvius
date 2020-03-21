using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BraveHaxvius;
using BraveHaxvius.Data;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BraveExvius
            {
                MstVersion="0",
                AppVersion= "1092"
            };
            b.Login();
            
        }
    }
}
