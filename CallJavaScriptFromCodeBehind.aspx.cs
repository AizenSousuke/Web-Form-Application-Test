using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplicationTest
{
    public partial class CallJavaScriptFromCodeBehind : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallJS_Click(object sender, EventArgs e)
        {
            // Call javascript function someFunction()
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Function", String.Format("someFunction('Welcome to year {0}');", DateTime.Today.Year), true);
            // Change the label text
            radLabel.Text = DateTime.Now.ToString();            
        }
    }
}