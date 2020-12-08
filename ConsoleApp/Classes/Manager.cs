using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Classes;

namespace ConsoleApp.Classes
{
    class Manager
    {
        public static void ChangeText<T>(T text)
        {
            Console.WriteLine(text.GetType());
            if (text is Request)
            {
                Console.WriteLine("Type is request!");
            }
        }

        public static void ChangeText<T, U>(T text, U somethingElse)
        {
            Console.WriteLine(text.GetType());
            Console.WriteLine(somethingElse.GetType());
        }

        public static void DoSomething<T>(T request) where T : class
        {
            if (request is CapexRequest)
            {
                CapexRequest capexRequest = (CapexRequest)(object)request;
                capexRequest.DoCAPEXRequestStuff();

                List<Request> list = new List<Request>() { new Request() { } };
                
            }
        }


        public string getStage(Stage stage)
        {
            return stage switch
            {
                Stage.Requestor => Requestor(),
                Stage.ITD => "ITD",
                Stage.AFMD => throw new NotImplementedException(),
                Stage.CFO => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };
        }

        private string Requestor()
        {
            return "I'm a requestor!";
        }

        public enum Stage
        {
            Requestor,
            ITD,
            AFMD,
            CFO
        }

        public static T BusinessLogic<T>(T Request) where T : Request
        {
            if (Request is CapexRequest req)
            {
                req.DoCAPEXRequestStuff();
                return Request;
            }
            if (Request is CFRequest)
            {
                return Request;
            }

            return null;
        }


    }
}
