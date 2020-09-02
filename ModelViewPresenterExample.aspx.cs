using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Presenter;

namespace WebApplicationTest
{
    public partial class ModelViewPresenterExample : System.Web.UI.Page, IPresenterView
    {
        public double price { get; set; }
        public CashierPresenter _cashierPresenter;
        public ModelViewPresenterExample()
        {
            _cashierPresenter = new CashierPresenter();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = _cashierPresenter.GetBalance().ToString();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtField.Text, out double result);
            _cashierPresenter.Withdraw(result);
            ViewState["price"] = _cashierPresenter.GetBalance();
            lbl.Text = ViewState["price"].ToString();
        }
    }
}