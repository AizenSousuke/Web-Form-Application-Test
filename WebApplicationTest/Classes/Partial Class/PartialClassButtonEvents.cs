using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class PartialClassTest : System.Web.UI.Page
    {
        // Put button events here
        public string TestString = "Test string lorem ipsum";


        protected void btnTest_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "I've been clicked.";
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            Debug.Write(sender.GetType().ToString());
            DoSomething(sender);
        }

        public void DoSomething(object sender)
        {
            Debug.WriteLine((sender as Button).Text);
        }
    }
}