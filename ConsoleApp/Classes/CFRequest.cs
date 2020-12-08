using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    class CFRequest : Request
    {
        public string CFProperty { get; set; }
        public void DoCFRequestStuff()
        {
            Console.WriteLine("Doing cf request stuff!");
        }

        public override void overrideMethod()
        {
            base.overrideMethod();
            Console.WriteLine("CF override method.");
        }
    }
}
