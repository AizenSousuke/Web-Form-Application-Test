using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest.WebControls
{
    [DefaultProperty("ServerControls")]
    [ToolboxData("<{0}:ServerControls runat=server></{0}:ServerControls>")]
    public class ServerControls : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        public int Age
        {
            get; set;
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(Age);
        }

    }
}
