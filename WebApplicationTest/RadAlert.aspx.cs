using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Classes;

namespace WebApplicationTest
{
    public partial class RadAlert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //rwmRadWindowManager.RadAlert("Test", null, null, "Test Alert", "callbackfn(\'Hello\')");
            // rwmRadWindowManager.RadConfirm("Test", "callbackfn(\'Hello\')", null, null, null, "Test Alert");
            ExtensionMethod method = new ExtensionMethod();
            method.Write();
        }
    }
}