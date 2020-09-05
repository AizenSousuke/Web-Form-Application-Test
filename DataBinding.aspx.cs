using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Model;

namespace WebApplicationTest
{
    public partial class DataBinding : System.Web.UI.Page
    {
        public SampleDataBindingModel request { get; set; }
        protected SampleDataBindingModel model { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Page.Request.QueryString["Id"], out int Idq);
            if (!Page.IsPostBack)
            {
                // New Page
                DbContext context = new DbContext();
                request = context.SampleDataBindingModels.Where(x => x.Id == Idq).FirstOrDefault();
                if (request != null)
                {
                    Id.Text = request.Id.ToString();
                    RequestNumber.Text = request.RequestNumber.ToString();
                    RequestNumber.ReadOnly = true;
                    RequestTitle.Text = request.RequestTitle;
                    // To make sure this works --> <%# request.RequestTitle %>
                    DataBind();
                }
                RequestNumber.ReadOnly = false;
            }
        }

        private void _binddataObject()
        {
            SampleDataBindingModel request = new SampleDataBindingModel();
            if (TryUpdateModel(request, new FormValueProvider(ModelBindingExecutionContext)))
            {
                DbContext context = new DbContext();
                // Find existing if any
                var existing = context.SampleDataBindingModels.Where(x => x.RequestNumber == request.RequestNumber).FirstOrDefault();
                SampleDataBindingModel newObj;
                if (existing != null)
                {
                    existing.RequestNumber = request.RequestNumber;
                    existing.RequestTitle = request.RequestTitle;
                } else
                {
                    newObj = context.SampleDataBindingModels.Add(request);
                }
                context.SaveChanges();
                newObj = context.SampleDataBindingModels.Where(x => x.RequestNumber == request.RequestNumber).FirstOrDefault();
                DataText.Text = String.Format("Data: {0}", JsonConvert.SerializeObject(newObj));
                //Page.Response.Redirect(Page.Request.Url.ToString() + "?RequestNumber=" + newObj.RequestNumber.ToString(), true);
            };
        }

        private void Refresh()
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            _binddataObject();
        }

        protected void Validator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int.TryParse(args.Value, out int value);
            if (value < 1 || value > 10)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DbContext context = new DbContext();
            request = context.SampleDataBindingModels.FirstOrDefault();
            context.SampleDataBindingModels.Remove(request);
            context.SaveChanges();
            Refresh();
        }
    }
}