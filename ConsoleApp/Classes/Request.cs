using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    class Request
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public void DoRequestStuff()
        {
            Console.WriteLine("Doing request stuff!");
        }


        public Tuple<string, string, int> RequestStage = new Tuple<string, string, int>("stage", "name", 1);

        public RequestDetails RequestDetails { get; set; } = new RequestDetails();

        public string getTitle()
        {
            return Title;
        }

        public virtual void overrideMethod()
        {
            Console.WriteLine("Base method.");
        }

        public void testRefProperties(ref string text)
        {
            Console.WriteLine(text);
        }
    }

    public class RequestDetails
    {
        public string Requestor { get; set; } = "current user";
    }
}
