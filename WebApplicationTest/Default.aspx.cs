using COL.NEA.FAS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Classes;
using WebApplicationTest.Components;

namespace WebApplicationTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BogusDataAccessor accessor = new BogusDataAccessor();

            //textBox.Text = accessor.GenerateFakeAutoData();
            //textBox.Text = JsonConvert.SerializeObject(new DFRequest());
        }

        protected void React_ChangeLabel(object sender, ChangeLabelEventArgs e)
        {
            Debug.WriteLine("Change Label Event has ran.");
            ReactLabel.Text = e.Text;
        }
    }
}