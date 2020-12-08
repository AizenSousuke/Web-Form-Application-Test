using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplicationTest
{
    /// <summary>
    /// Summary description for WebServiceExample
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceExample : System.Web.Services.WebService
    {
        public class Hello {
            public string Name { get; set; } = "Nik";
        }

        [WebMethod]
        public string HelloWorld()
        {
            Hello hello = new Hello() { Name = "Midori" };
            return JsonConvert.SerializeObject(hello);
        }
    }
}
