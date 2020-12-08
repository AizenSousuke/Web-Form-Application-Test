using COL.Library;
using COL.NEA.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Telerik.Web.UI;
using WebApplicationTest;
using WebApplicationTest.Model;

namespace COL.NEA.FAS
{
    /// <summary>
    /// Use the CAPEX Manager for business logic.
    /// </summary>
    public partial class Capex : NEAPage
    {
        public Request request;
        public CAPEXManager _capexManager = new CAPEXManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            string requestId = Request.QueryString["requestNumber"];
            request = new Request();
            if (!IsPostBack)
            {
                // If this is a new page loaded
                // CAPEXManager.CreateRequest(request);
                //request = CAPEXManager.LoadRequest("Fu Why");

                if (!string.IsNullOrEmpty(requestId))
                {
                    // Load existing request if there's a querystring
                    //request = _capexManager.ReadRequest(requestId);

                    // If request doesn't exist
                    Logger.Warn("Request doesn't exist. Creating new request.");
                    request = new Request();
                }

                // Audit.ViewPage("CAPEX.aspx");
            }

            // If not a new page
        }

        /// <summary>
        /// Get what action is allowed by the current user and put it in the dropdown list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlActionType_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Adding possible actions to the actions drop down list");
        }

        /// <summary>
        /// Save as draft. Doesn't have validation.
        /// According to 4.4.2 it can only be done by Requestor, FDUsers and Reviewers during certain stages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSaveAsDraft_Click(object sender, EventArgs e)
        {
            //if (request.CurrentStage == null)
            //{
            //}
            switch (request.RequestCurrentStage)
            {
                case Status.Stage.Draft:
                    // Still at requestor stage
                    //_capexManager.SaveAsDraft(request);
                    break;

                case null:
                    // Still at requestor stage
                    //_capexManager.SaveAsDraft(request);
                    break;

                default:
                    // Cannot be saved as draft
                    break;
            }
        }

        /// <summary>
        /// Testing Button used to get a certain request based on its GUID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGetDraftRequest_Click(object sender, EventArgs e)
        {
            _capexManager.GetDraftRequest(tbGetDraftRequest.Text);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate the form first
            this.Validate();
            if (this.IsValid)
            {
                // Assign the form values to the request object
                request = AssignValuesToRequest(request);

                // If everything is okay, then push the object to the database based on whether it is an update or a new request
                if (request.RequestNumber == null)
                {
                    _capexManager.CreateRequest(request);
                    Redirect("Dashboard.aspx");
                }
                else
                {
                    _capexManager.UpdateRequest(request);
                    Redirect("Dashboard.aspx");
                }
            }
        }

        /// <summary>
        /// Function that assigns the values from form controls to the request object and returns it.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private Request AssignValuesToRequest(Request request)
        {
            request.ProjectTitle = tbProjectTitle.Text;
            request.FASFundType = FASFundType.CAPEX;
            request.ProjectMaster = new ProjectMaster()
            {
                ProjectDetails = reProjectDetails.Text,
                RequestApprovedInAnyForum = rbRequestApprovedInAnyForum.SelectedValue.Equals("Yes"),
            };
            return request;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Redirect("Dashboard.aspx");
        }

        /// <summary>
        /// Get workflow data here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void WorkflowHistory_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            List<WorkflowHistory> workflowHistories = new List<WorkflowHistory>() {
                new WorkflowHistory() { Id = 1, Action = Status.Action.Submission, ActionBy = Status.Party.Requestor, ActionDate = DateTime.Today, Stage = Status.Stage.Draft, Comments = "Test comment" },
                new WorkflowHistory() { Id = 2, Action = Status.Action.Submission, ActionBy = Status.Party.Requestor, ActionDate = DateTime.Today, Stage = Status.Stage.Draft, Comments = "Test comment" },
                new WorkflowHistory() { Id = 3, Action = Status.Action.Submission, ActionBy = Status.Party.Requestor, ActionDate = DateTime.Today, Stage = Status.Stage.Draft, Comments = "Test comment" },
                new WorkflowHistory() { Id = 4, Action = Status.Action.Submission, ActionBy = Status.Party.Requestor, ActionDate = DateTime.Today, Stage = Status.Stage.Draft, Comments = "Test comment" },
                new WorkflowHistory() { Id = 5, Action = Status.Action.Submission, ActionBy = Status.Party.Requestor, ActionDate = DateTime.Today, Stage = Status.Stage.Draft, Comments = "Test comment" },
            };

            request.WorkflowHistory = workflowHistories;

            // Get WorkFlowHistory from the request
            (sender as RadGrid).DataSource = request.WorkflowHistory;
        }

    }
}