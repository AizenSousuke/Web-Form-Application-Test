using ConsoleApp.Classes;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static string BaseUrl = "https://localhost:44340/";
        // the max. time to wait before timing out.
        public const int TimeOut = 30;


        static void Main(string[] args)
        {

            //var driver = new ChromeDriver("C:\\Users\\Accelerator\\.nuget\\packages\\selenium.webdriver.chromedriver\\84.0.4147.3001\\driver\\win32");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeOut);

            //driver.Navigate().GoToUrl(BaseUrl + "DataBinding.aspx");


            var capex = new CapexRequest();
            capex.CapexProperty = "CAPEX";
            capex.Id = 1;
            capex.Title = "Capex";
            var cf = new CFRequest();
            cf.CFProperty = "CF";
            cf.Id = 2;
            cf.Title = "Cf";

            var listOfRequest = new List<Request>();
            listOfRequest.Add(capex);
            listOfRequest.Add(cf);

            Console.WriteLine(JsonConvert.SerializeObject(listOfRequest));
            Manager.ChangeText<Request>(new Request());
            Manager.DoSomething<CapexRequest>(new CapexRequest());
            Manager.ChangeText<CapexRequest, CFRequest>(new CapexRequest(), new CFRequest());
            //Manager.ChangeText<object, Request>(1, "5");
            Manager.BusinessLogic<CapexRequest>(capex);

            cf.overrideMethod();

            string text = "nik";
            cf.testRefProperties(ref text);

            Request req = new Request();
            Console.WriteLine(JsonConvert.SerializeObject(req));
            req.RequestDetails.Requestor = "Nik";
            Console.WriteLine(JsonConvert.SerializeObject(req));

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("nik", 1);
            dict.Add("put", 2);
            dict.Add("nadia", 3);
            dict.Add("dimas", 4);
            Console.WriteLine(dict["nik"]);


            Console.WriteLine(req.RequestStage.Item2);

            ImmutableList<int> list;
            list = new List<int>().ToImmutableList();
            Console.WriteLine(JsonConvert.SerializeObject(list));
            list = list.Add(1);
            Console.WriteLine(JsonConvert.SerializeObject(list));
            var list2 = list.Add(2);
            Console.WriteLine(JsonConvert.SerializeObject(list));
            Console.WriteLine(JsonConvert.SerializeObject(list2));


            Console.ReadKey();

            // Switch expressions
            //Manager manager = new Manager();

            //Console.WriteLine(manager.getStage(Manager.Stage.Requestor));
            //Console.ReadKey();


        }

    }
}
