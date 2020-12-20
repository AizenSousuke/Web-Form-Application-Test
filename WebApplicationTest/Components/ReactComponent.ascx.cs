using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest.Components
{
    public class ChangeLabelEventArgs
    {
        public string Text { get; set; } = "Default Text";
    }
    public partial class ReactComponent : UserControl
    {
        public delegate void ChangeLabelEventHandler(object sender, ChangeLabelEventArgs e);
        public event ChangeLabelEventHandler ChangeLabel;

        protected void Page_Load(object sender, ChangeLabelEventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            label.Text = "Button has been clicked";
            // Send the textbox value out
            ChangeLabel?.Invoke(this, new ChangeLabelEventArgs() { Text = textbox.Text });
        }
    }
}