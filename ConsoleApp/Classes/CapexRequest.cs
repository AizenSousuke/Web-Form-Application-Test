using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    class CapexRequest : Request
    {
        public string CapexProperty { get; set; }
        public void DoCAPEXRequestStuff()
        {
            Console.WriteLine("Doing capex request stuff!");
        }
    }
}
