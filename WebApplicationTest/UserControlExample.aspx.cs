using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplicationTest
{
    public partial class UserControlExample : System.Web.UI.Page
    {
        public string Date { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Init
            Date = DateTime.Now.ToString();
            // Bind 
            label1.DataBind();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            //cc1.variable = "Hello " + DateTime.Now.ToString();
            //// Update function in the component
            //cc1.Update();
            //Date = DateTime.Now.ToString();
            cc1.ddlvalue = "nik";
        }

        public string SayHello()
        {
            return "Hello World";
        }

        protected void btnCallWebservice_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://localhost:44340/WebServiceExample.asmx/HelloWorld");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = 0;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            lbl.Text = responseFromServer;
        }
    }
}