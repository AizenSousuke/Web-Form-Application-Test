using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Classes;

namespace WebApplicationTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BogusDataAccessor accessor = new BogusDataAccessor();
            
            textBox.Text = accessor.GenerateFakeAutoData();
        }
    }
}