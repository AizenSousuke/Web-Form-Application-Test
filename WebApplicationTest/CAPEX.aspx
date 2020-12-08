<%@ Page Title="Capital Expenditure Budget (CAPEX) Request" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CAPEX.aspx.cs" Inherits="COL.NEA.FAS.Capex" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register TagPrefix="nea" Namespace="COL.NEA.Common.UI.WebControls" Assembly="COL.NEA.Common.UI" %>
<%@ Register TagPrefix="fas" Namespace="COL.NEA.FAS" Assembly="COL.NEA.FAS" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:UpdatePanel runat="server" ID="UpdatePanel">
        <ContentTemplate>
            <div id="Header" class="">
                <div class="main-form-subheader">Important Note:</div>
                <br />
                <ol>
                    <li>Please fill up this template to put up a request for CAPEX budget of new CAPEX projects.
                    </li>
                    <li>CAPEX projects refer to:
                <ol>
                    <li>Replacement of existing items or acquisition of new items that are more than $5,000 per unit and will be capitalised as fixed assets.
                    </li>
                    <li>Fixed assets are tangible items that:
                        <ul>
                            <li>are held for use in the production or supply of goods or services, for rental to others, or for administrative purposes and not intended for sale in the ordinary course of NEA's operating activities: and
                            </li>
                            <li>are expected to have estimated economic useful life of more than 1 year.
                            </li>
                        </ul>
                    </li>
                    <li>Fixed assets that belong to NEA.
                    </li>
                </ol>
                    </li>
                    <li>The CAPEX request is evaluated based on department’s estimated CAPEX budget requirements and cost items. Upon actual expenditure, capital items that qualify for NEA’s capitalisation policy will be funded by NEA CAPEX Budget. Low value items (i.e. less than or equals to $5,000 per unit) and items that do not qualify for capitalisation, will be expensed off and absorbed under department’s OOE budget.
                    </li>
                </ol>
            </div>
            <div id="RequestStatus" class="grid">
                <div class="row">
                    <div class="col">
                        <h1 class="text-uppercase text-center">Status:</h1>
                    </div>
                </div>
                <div id="Status">
                    <h2 class="text-uppercase text-center">
                        <telerik:RadLabel runat="server" ID="lblRequestStatus" Text="{Stage} - Pending {Action} by {Party}"></telerik:RadLabel>
                    </h2>
                </div>
            </div>
            <br />
            <div id="RequestingDepartmentDetails" class="grid forms-container">
                <div class="row forms-header">
                    <div class="col forms-header-text">Requesting Department Details</div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">Request No.</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbRequestNumber" runat="server" Width="100%" Enabled="false"></telerik:RadTextBox>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">Requested Date</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbRequestDate" runat="server" Width="100%" Enabled="false"></telerik:RadTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%" RequiredMark="*" MarkDisplayMode="Required">Requestor</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbRequestor" runat="server" Width="100%" Enabled="false"></telerik:RadTextBox>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">2nd Requestor</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <%--<telerik:RadTextBox ID="tbSecondRequestor" runat="server" Width="100%"></telerik:RadTextBox>--%>
                        <nea:UserEditor runat="server" ID="tbSecondRequestor" SelectionMode="SingleUser" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%" RequiredMark="*" MarkDisplayMode="Required">Requesting Division</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadDropDownList ID="RequestingDivision" runat="server" Width="100%"></telerik:RadDropDownList>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">2nd Requesting Division</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadDropDownList ID="ddlSecondRequestingDivision" runat="server" Width="100%" Enabled="false"></telerik:RadDropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%" RequiredMark="*" MarkDisplayMode="Required">Requesting Department</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadDropDownList ID="ddlRequestingDepartment" runat="server" Width="100%"></telerik:RadDropDownList>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">2nd Requesting Department</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadDropDownList ID="ddlSecondRequestingDepartment" runat="server" Width="100%" Enabled="false"></telerik:RadDropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">Reviewing Officers(s)</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbReviewingOfficers" runat="server" Width="100%"></telerik:RadTextBox>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%" RequiredMark="*" MarkDisplayMode="Required">Head(s) of Department</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbHeadOfDepartments" runat="server" Width="100%"></telerik:RadTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%" RequiredMark="*" MarkDisplayMode="Required">Divisional Director(s)</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbDivisionalDirectors" runat="server" Width="100%"></telerik:RadTextBox>
                    </div>
                    <div class="col-2">
                        <telerik:RadLabel runat="server" Width="100%">User(s) to be notified</telerik:RadLabel>
                    </div>
                    <div class="col-4">
                        <telerik:RadTextBox ID="tbUsersToBeNotified" runat="server" Width="100%"></telerik:RadTextBox>
                    </div>
                </div>
            </div>
            <br />
            <div id="ProjectDetails" class="grid forms-container">
                <div class="row forms-header">
                    <div class="col forms-header-text">Project Details</div>
                </div>
                <div id="ProjectMaster">
                    <div class="row forms-subheader">
                        <div class="col forms-header-text">Project Master</div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.1 Project Title <span class="rlRequiredMark">*</span></div>
                            <telerik:RadTextBox runat="server" ID="tbProjectTitle" Width="100%" MaxLength="75"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator runat="server" ID="tbProjectTitleValidator" ControlToValidate="tbProjectTitle" ErrorMessage="The Project Title field is required. Maximum 75 characters allowed." ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.2 Project Details <span class="rlRequiredMark">*</span></div>
                            <div><i>Please provide background, description and expected commencement/completion date for the project</i></div>
                            <telerik:RadEditor runat="server" ID="reProjectDetails" Width="100%" Height="300px" AutoResizeHeight="True" EditModes="Design">
                                <Modules>
                                    <telerik:EditorModule Name="RadEditorHtmlInspector" Enabled="false" />
                                    <telerik:EditorModule Name="RadEditorNodeInspector" Enabled="false" />
                                    <telerik:EditorModule Name="RadEditorDomInspector" Enabled="false" />
                                    <telerik:EditorModule Name="RadEditorStatistics" Enabled="true" />
                                </Modules>
                                <Tools>
                                    <telerik:EditorToolGroup>
                                        <telerik:EditorTool Name="Cut" />
                                        <telerik:EditorTool Name="Copy" />
                                        <telerik:EditorTool Name="Paste" />
                                        <telerik:EditorTool Name="Bold" />
                                        <telerik:EditorTool Name="Italic" />
                                        <telerik:EditorTool Name="Underline" />
                                        <telerik:EditorTool Name="StrikeThrough" />
                                        <telerik:EditorTool Name="FontName" />
                                        <telerik:EditorTool Name="FontSize" />
                                        <telerik:EditorTool Name="ForeColor" />
                                        <telerik:EditorTool Name="BackColor" />
                                        <telerik:EditorTool Name="InsertParagraph" />
                                        <telerik:EditorTool Name="FormatBlock" />
                                        <telerik:EditorTool Name="Indent" />
                                        <telerik:EditorTool Name="Outdent" />
                                        <telerik:EditorTool Name="JustifyLeft" />
                                        <telerik:EditorTool Name="JustifyCenter" />
                                        <telerik:EditorTool Name="JustifyRight" />
                                        <telerik:EditorTool Name="JustifyFull" />
                                        <telerik:EditorTool Name="JustifyNone" />
                                        <telerik:EditorTool Name="InsertUnorderedList" />
                                        <telerik:EditorTool Name="InsertOrderedList" />
                                        <telerik:EditorTool Name="InsertHorizontalRule" />
                                        <telerik:EditorTool Name="InsertSymbol" />
                                        <telerik:EditorTool Name="InsertTable" />
                                        <telerik:EditorTool Name="ToggleTableBorder" />
                                        <telerik:EditorTool Name="Undo" />
                                        <telerik:EditorTool Name="Redo" />
                                        <telerik:EditorTool Name="Paste" />
                                        <telerik:EditorTool Name="Copy" />
                                        <telerik:EditorTool Name="Cut" />
                                        <telerik:EditorTool Name="FindAndReplace" />
                                        <telerik:EditorTool Name="RealFontSize" />
                                        <telerik:EditorTool Name="ConvertToLower" />
                                        <telerik:EditorTool Name="ConvertToUpper" />
                                        <telerik:EditorTool Name="AjaxSpellCheck" />
                                    </telerik:EditorToolGroup>
                                </Tools>
                            </telerik:RadEditor>
                            <asp:RequiredFieldValidator runat="server" ID="reProjectDetailsValidator" ControlToValidate="reProjectDetails" ErrorMessage="The Project Details field is required." ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.3 Please indicate whether this request was approved in any forum <span class="rlRequiredMark">*</span></div>
                            <div>
                                <telerik:RadRadioButtonList runat="server" ID="rbRequestApprovedInAnyForum" AutoPostBack="false">
                                    <Items>
                                        <telerik:ButtonListItem Text="Yes. Please attach the minutes and presentation slides of the forum." Value="Yes" />
                                        <telerik:ButtonListItem Text="No." Value="No" />
                                    </Items>
                                </telerik:RadRadioButtonList>
                                <asp:RequiredFieldValidator runat="server" ID="rbRequestApprovedInAnyForumValidator" ControlToValidate="rbRequestApprovedInAnyForum" ErrorMessage="The field in Project Details 1.3 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                                <%--<nea:AttachmentField runat="server" ID="afAttachments" />--%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.4 State desired outcome(s) & benefit(s) of the project <span class="rlRequiredMark">*</span></div>
                            <div>
                                <%--<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="rbRequestApprovedInAnyForum" ErrorMessage="The field in Project Details 1.4 is required." ForeColor="Red"></asp:RequiredFieldValidator>--%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.5 Has the department considered any other option, e.g. leasing, off the shelf project? Please elaborate. <span class="rlRequiredMark">*</span></div>
                            <div>
                                <telerik:RadTextBox runat="server" ID="tbOtherOptions" Width="100%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                                <asp:RequiredFieldValidator runat="server" ID="tbOtherOptionsValidator" ControlToValidate="tbOtherOptions" ErrorMessage="The field in Project Details 1.5 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.6 Has the proposed project been included in the department’s 5-year CAPEX budget projection exercise? <span class="rlRequiredMark">*</span></div>
                            <div>
                                <telerik:RadRadioButtonList runat="server" ID="rbIncludedInBudgetProjectionExercise" AutoPostBack="true">
                                    <ClientEvents OnItemClicked="IncludedInBudgetProjectionExerciseFunction" />
                                    <Items>
                                        <telerik:ButtonListItem Text="Yes." Value="Yes" />
                                        <telerik:ButtonListItem Text="No. If No, please elaborate:*" Value="No" />
                                    </Items>
                                </telerik:RadRadioButtonList>
                                <asp:RequiredFieldValidator runat="server" ID="rbIncludedInBudgetProjectionExerciseValidator" ControlToValidate="rbIncludedInBudgetProjectionExercise" ErrorMessage="The field in Project Details 1.6 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                                <!-- TODO: This text box is required if No is chosen -->
                                <telerik:RadTextBox runat="server" ID="tbBudgetProjectionExerciseElaboration" Width="100%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                                <%--<nea:AttachmentField runat="server" ID="afAttachments" />--%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>1.7 Has the proposed project considered Environmental Sustainability Requirements? <span class="rlRequiredMark">*</span></div>
                            <telerik:RadRadioButtonList runat="server" ID="rbEnvironmentSustainabilityRequirements" AutoPostBack="false" CssClass="radioWithProperWrap">
                                <Items>
                                    <telerik:ButtonListItem Text="Please select this option to declare that Sustainability Office has been informed and consulted of the project. Please indicate the environmental sustainability requirement that the project would comply with as per discussion with Sustainability Office." Value="Yes" />
                                    <telerik:ButtonListItem Text="Please select this option if this section is no applicable for your project with reasons indicated below." Value="No" />
                                </Items>
                            </telerik:RadRadioButtonList>
                            <asp:RequiredFieldValidator runat="server" ID="rbEnvironmentSustainabilityRequirementsValidator" ControlToValidate="rbEnvironmentSustainabilityRequirements" ErrorMessage="The field in Project Details 1.7 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            <div>
                                <telerik:RadTextBox runat="server" ID="tbEnvironmentSustainabilityRequirementsElaboration" Width="100%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                                <asp:RequiredFieldValidator runat="server" ID="tbEnvironmentSustainabilityRequirementsElaborationValidator" ControlToValidate="tbEnvironmentSustainabilityRequirementsElaboration" ErrorMessage="The field in Project Details 1.7 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="ProjectType">
                    <div class="row forms-subheader">
                        <div class="col forms-header-text">Project Type</div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>2.1 Type of Project <span class="rlRequiredMark">*</span></div>
                            <telerik:RadRadioButtonList runat="server" ID="rbTypeOfProject" AutoPostBack="false">
                                <Items>
                                    <telerik:ButtonListItem Text="Replacement of existing fixed asset(s)" Value="1" />
                                    <telerik:ButtonListItem Text="Acquisition of new fixed asset(s)" Value="2" />
                                    <telerik:ButtonListItem Text="Both of the above" Value="3" />
                                </Items>
                            </telerik:RadRadioButtonList>
                            <asp:RequiredFieldValidator runat="server" ID="rbTypeOfProjectValidator" ControlToValidate="rbTypeOfProject" ErrorMessage="The field in Project Type 2.1 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>2.2 Details of existing fixed asset(s) to be replaced <span class="rlRequiredMark">*</span></div>
                            <div>
                            </div>
                            <div>
                                <telerik:RadCheckBox runat="server" ID="cbDeclaration" AutoPostBack="false"></telerik:RadCheckBox>
                                <!-- Validator Causes issues -->
                                <%--<asp:RequiredFieldValidator runat="server" ID="cbDeclarationValidator" ControlToValidate="cbDeclaration" ErrorMessage="The checkbox in Section 2.2 has to be checked in order for the request to be submitted." ForeColor="Red"></asp:RequiredFieldValidator>--%>
                                We declare that the above fixed asset(s) to be replaced is/ are obsolete/ beyond economical repair and has/ have to be replaced.<span class="rlRequiredMark">*</span>
                            </div>
                            <div>Attachments of Condemnation Certificate (if any)</div>
                            <div><%--<nea:AttachmentField runat="server" ID="afAttachments" />--%></div>
                        </div>
                    </div>
                </div>
                <div id="ProjectBudgetDetails">
                    <div class="row forms-subheader">
                        <div class="col forms-header-text">Project Budget Details</div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>3.1 Project Capital Cost <span class="rlRequiredMark">*</span></div>
                            <i>Please give a breakdown of the cost components</i>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>3.2 Estimated Recurring Operating Cost for the proposed new fixed assets <span class="rlRequiredMark">*</span></div>
                            <i>Please give a breakdown of the cost components</i>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>3.3 Please indicate the proposed source of funding if additional recurrent budget is required for the new fixed assets <span class="rlRequiredMark">*</span></div>
                            <telerik:RadTextBox runat="server" ID="tbProposedSourceOfFunding" Width="100%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator runat="server" ID="tbProposedSourceOfFundingValidator" ControlToValidate="tbProposedSourceOfFunding" ErrorMessage="The field in Project Budget Details 3.3 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            <%--<nea:AttachmentField runat="server" ID="afAttachments" />--%>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>3.4 Project Capital Cost Allocation by FYs <span class="rlRequiredMark">*</span></div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>3.5 Cost recovery <span class="rlRequiredMark">*</span></div>
                            <telerik:RadTextBox runat="server" ID="tbCostRecovery" Width="100%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                            <asp:RequiredFieldValidator runat="server" ID="tbCostRecoveryValidator" ControlToValidate="tbCostRecovery" ErrorMessage="The field in Project Budget Details 3.5 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div id="AssetOwnerDetails">
                    <div class="row forms-subheader">
                        <div class="col forms-header-text">Asset Owner Details</div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>4.1 Asset Owner(s) <span class="rlRequiredMark">*</span></div>
                            <div>Will these assets be solely owned by requesting department? <span class="rlRequiredMark">*</span></div>
                            <telerik:RadRadioButtonList runat="server" ID="rbSolelyOwnedByRequestingDepartment" AutoPostBack="false">
                                <Items>
                                    <telerik:ButtonListItem Text="Yes." Value="Yes" />
                                    <telerik:ButtonListItem Text="No." Value="No" />
                                </Items>
                            </telerik:RadRadioButtonList>
                            <asp:RequiredFieldValidator runat="server" ID="rbSolelyOwnedByRequestingDepartmentValidator" ControlToValidate="rbSolelyOwnedByRequestingDepartment" ErrorMessage="The field in Asset Owner Details 4.1 is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            <div>
                                Please indicate all asset owners for this proposed CAPEX project.
                            </div>
                        </div>
                    </div>
                </div>
                <div id="RouteToAfmdOrItd">
                    <div class="row forms-subheader">
                        <div class="col forms-header-text">Route to AFMD or ITD</div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div>Route to AFMD or ITD <span class="rlRequiredMark">*</span></div>
                            <telerik:RadRadioButtonList runat="server" ID="rbRouteToAfmdOrItd" AutoPostBack="false">
                                <Items>
                                    <telerik:ButtonListItem Text="AFMD Officer (For Office-administration related projects, E.g. Puchase of Common Office Equipment, Vehicles, Renovation etc.)" Value="1" />
                                    <telerik:ButtonListItem Text="ITD Officer (For IT-related projects, E.g. Puchase of Computer Hardware, Software, Printer etc.)" Value="2" />
                                    <telerik:ButtonListItem Text="Both AFMD & ITD Officers" Value="3" />
                                    <telerik:ButtonListItem Text="Not Applicable" Value="4" />
                                </Items>
                            </telerik:RadRadioButtonList>
                            <asp:RequiredFieldValidator runat="server" ID="rbRouteToAfmdOrItdValidator" ControlToValidate="rbRouteToAfmdOrItd" ErrorMessage="The radio button in Route to AFMD or ITD is required." ForeColor="Red"></asp:RequiredFieldValidator>
                            <telerik:RadDropDownList runat="server" Width="20%" ID="ddlAfmd" DefaultMessage="Select AFMD Officer"></telerik:RadDropDownList>
                            <telerik:RadDropDownList runat="server" Width="20%" ID="ddlItd" DefaultMessage="Select ITD Officer"></telerik:RadDropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div id="Actions" class="grid forms-container">
                <div class="row forms-header">
                    <div class="col forms-header-text">Actions</div>
                </div>
                <div class="row" id="Action">
                    <div class="col-12 text-right mb-3">
                        <telerik:RadButton runat="server" ID="btnViewClarifications" Text="View Clarifications"></telerik:RadButton>
                    </div>
                    <div class="col-12 text-center mb-3">
                        Action:
                <telerik:RadDropDownList runat="server" ID="ddlActionType" OnLoad="ddlActionType_Load" DefaultMessage="Select"></telerik:RadDropDownList>
                    </div>
                    <div class="col-12 text-left mb-3">
                        Comments:
                <telerik:RadTextBox runat="server" ID="tbComments" Width="80%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                    </div>
                    <div class="col-12 text-left mb-3">
                        Attachment:
                <%--<nea:AttachmentField runat="server" ID="afAttachments" />--%>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Testing only:
                        <telerik:RadTextBox runat="server" ID="tbGetDraftRequest" DisplayText="Enter a GUID here"></telerik:RadTextBox>
                        <telerik:RadButton runat="server" ID="btnGetDraftRequest" Text="Load Draft" Width="100%" OnClick="btnGetDraftRequest_Click"></telerik:RadButton>
                    </div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="btnSaveAsDraft" Text="Save as Draft" Width="100%" OnClick="btnSaveAsDraft_Click"></telerik:RadButton>
                    </div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="btnSubmit" Text="Submit" Width="100%" OnClick="btnSubmit_Click"></telerik:RadButton>
                    </div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="btnCancel" Text="Cancel" Width="100%" OnClick="btnCancel_Click"></telerik:RadButton>
                    </div>
                    <div class="col"></div>
                </div>
                <div id="ValidationSummary" class="row validation-summary">
                    <div class="col">
                    </div>
                    <div class="col">
                        <asp:ValidationSummary runat="server" ID="vsValidationSummary"></asp:ValidationSummary>
                    </div>
                    <div class="col">
                    </div>
                </div>
            </div>
            <br />
            <!-- TODO: Think of a way to generate them via code behind's list -->
            <div id="WorkflowActionsITD" class="grid actions-container">
                <div class="row actions-header">
                    <div class="col forms-header-text">ITD</div>
                </div>
                <div class="row" id="WorkflowActionITD">
                    <div class="col-12 text-right mb-3">
                        <telerik:RadButton runat="server" ID="btnViewClarificationsITD" Text="View Clarifications"></telerik:RadButton>
                    </div>
                    <div class="col-12 text-center mb-3">
                        Action:
                        <telerik:RadDropDownList runat="server" ID="ddlActionTypeITD" OnLoad="ddlActionType_Load" DefaultMessage="Select"></telerik:RadDropDownList>
                    </div>
                    <div class="col-12 text-left mb-3">
                        Comments:
                        <telerik:RadTextBox runat="server" ID="tbCommentsITD" Width="80%" TextMode="MultiLine" Height="100px"></telerik:RadTextBox>
                    </div>
                    <div class="col-12 text-left mb-3">
                        Attachment:

                        <nea:AttachmentField runat="server" ID="afAttachments" />
                    </div>
                </div>
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="RadButton3" Text="Save as Draft" Width="100%" OnClick="btnSaveAsDraft_Click"></telerik:RadButton>
                    </div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="RadButton4" Text="Submit" Width="100%" OnClick="btnSubmit_Click"></telerik:RadButton>
                    </div>
                    <div class="col">
                        <telerik:RadButton runat="server" ID="RadButton5" Text="Cancel" Width="100%" OnClick="btnCancel_Click"></telerik:RadButton>
                    </div>
                    <div class="col"></div>
                </div>
            </div>
            <br />
            <div id="Workflows" class="grid forms-container">
                <div class="row forms-header">
                    <div class="col forms-header-text">Workflow History List</div>
                </div>
                <div class="row" id="WorkflowHistoryList">
                    <div class="col">
                        <telerik:RadGrid runat="server" ID="WorkflowHistory" OnNeedDataSource="WorkflowHistory_NeedDataSource" Width="100%">
                            <MasterTableView DataKeyNames="Id">
                            </MasterTableView>
                        </telerik:RadGrid>
                    </div>
                </div>
            </div>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <!-- Common Script -->
    <script type="text/javascript" src="js/RequestFormCommonScript.js"></script>
</asp:Content>