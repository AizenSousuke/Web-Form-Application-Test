using COL.NEA.FAS;
using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationTest.Classes;
using WebApplicationTest.Classes.Validators;

namespace WebApplicationTest
{
    public partial class FluentValidator : System.Web.UI.Page
    {
        public Request request { get; set; }
        RequestValidator validator = new RequestValidator();

        protected void Page_Load(object sender, EventArgs e)
        {
            Request req = new Request();
            req.ProjectTitle = "TEST";
            ExcelCreator ec = new ExcelCreator();
            ec.CreateNewFile(req);
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            request.RequestNumber = RequestNumber.Text;
            ValidationResult result = validator.Validate(request);
            
            var errorMessages = "";
            foreach (var error in result.Errors)
            {
                if (error.PropertyName.Equals("RequestNumber"))
                {
                    CustomValidator.ErrorMessage = error.ErrorMessage;
                    CustomValidator.IsValid = false;
                }

                Debug.WriteLine(error.PropertyName);
                errorMessages += " " + error.ErrorMessage;
            }
            ValidationMessage.Text = errorMessages;
        }

        protected void RequestNumber_TextChanged(object sender, EventArgs e)
        {
            TryUpdateModel(request);
        }
    }
}