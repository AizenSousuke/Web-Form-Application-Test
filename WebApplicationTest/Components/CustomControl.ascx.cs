using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest.Components
{
    public partial class CustomControl : System.Web.UI.UserControl
    {
        public string variable { get; set; }
        public string ddlvalue
        {
            get { return ddl.SelectedValue; }
            set { ddl.SelectedValue = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl.DataSource = new ListItem[] {
                new ListItem
                {
                    Text = "test",
                    Value = "test"
                },
                new ListItem
                {
                    Text = "nik",
                    Value = "nik"
                }
            };
            ddl.DataValueField = "Value";
            ddl.DataBind();

            Update();
        }

        public void Update()
        {
            var.Text = variable;
            ddl.SelectedValue = "nik";
            ddl.DataBind();
        }
    }
}