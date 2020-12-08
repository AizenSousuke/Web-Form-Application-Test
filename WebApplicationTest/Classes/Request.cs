using COL.NEA.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COL.NEA.FAS
{
    /// <summary>
    /// Base Request Class (Currently for CAPEX)
    /// </summary>
    [Serializable]
    public class Request
    {
        #region Business Logic Properties
        // Properties for business logic in Manager
        /// <summary>
        /// The request ID for draft business logic
        /// </summary>
        public Guid? Id { get; set; }
        /// <summary>
        /// The current stage of the request.
        /// Affects who can perform actions on the current request.
        /// Is nullable.
        /// </summary>
        public Status.Stage? RequestCurrentStage { get; set; }
        /// <summary>
        /// The current action of the request.
        /// Affects who can perform actions on the current request.
        /// Is nullable.
        /// </summary>
        public Status.Action? RequestCurrentAction { get; set; }
        /// <summary>
        /// The current party of the request.
        /// Affects who can perform actions on the current request.
        /// Is nullable.
        /// </summary>
        public Status.Party? RequestCurrentParty { get; set; }
        /// <summary>
        /// The highest stage that the request hits (for rework\reroute use).
        /// Use this so that you don't have to go through the workflow for supported stages again.
        /// </summary>
        public Status.Stage? RequestHighestStage { get; set; }
        /// <summary>
        /// The status of the request in string form. Get by combining the 3 seperate properties
        /// 4.3.1.	The statuses will be a combination of 3 sets of information and presented in the following format, {Stage} - Pending {Action} by {Party} where:
        /// a)	Stage: Current stage in the workflow
        /// b)	Action: Pending action in the stage
        /// c)	Party: Officer/ Group of officers performing the action
        /// Currently using the Request[xxxx] properties above and combining them with this.
        /// </summary>
        public string RequestStatus { get; set; }
        /// <summary>
        /// A flag showing whether the request is in Rework mode (since there is no stage to check with)
        /// </summary>
        public bool isRework { get; set; } = false;
        /// <summary>
        /// A flag showing that the request is awaiting clarification.
        /// Only the user who requested the clarification are allowed to act
        /// on the request.
        /// </summary>
        public bool isAwaitingClarification { get; set; }
        /// <summary>
        /// The user who raised the clarification
        /// </summary>
        public User UserWhoRaisedClarification { get; set; }
        /// <summary>
        /// The user who requested the rework.
        /// FS 4.4.7
        /// </summary>
        public User UserWhoRequestedRework { get; set; }
        /// <summary>
        /// The user above the FD Rev user (CFO+) who requested the rework.
        /// For use when a CFO or above level requested a rework.
        /// FS 4.4.7, 4.4.12
        /// </summary>
        public User CFOAndAboveUserWhoRequestedRework { get; set; }
        /// <summary>
        /// Based on 22nd Skype Meeting this is the User Task List that 
        /// states the pending action at which stage of the request
        /// the user is at and whether the user has completed the action or not.
        /// To calculate whether to move to the next stage, can check the task list
        /// </summary>
        public List<UserTask> UserTaskList { get; set; }
        /// <summary>
        /// The current action officer selected for reroute
        /// </summary>
        public User CurrentActionOfficer { get; set; }
        /// <summary>
        /// The new action officer for reroute
        /// </summary>
        public User NewActionOfficer { get; set; }
        /// <summary>
        /// The last user skipped (for tracking)
        /// </summary>
        public User LastUserSkipped { get; set; }
        /// <summary>
        /// The fund type
        /// </summary>
        public FASFundType FASFundType { get; set; }
        /// <summary>
        /// The financial year that the request is created in
        /// </summary>
        public int FY { get; set; }
        /// <summary>
        /// What is the final stage of the request calculated at CFO Stage.
        /// I.e, the stage before FD Finalization stage
        /// </summary>
        public Status.Stage FinalStage { get; set; }
        /// <summary>
        /// Whether the request is a draft
        /// </summary>
        public bool isDraft { get; set; }
        /// <summary>
        /// The type of project for each module based on their specific enums.
        /// TypeOfProjectDF for DF etc.
        /// </summary>
        public string TypeOfProject { get; set; }
        /// <summary>
        /// Used for Reminder Emails
        /// </summary>
        public int NoOfReminder { get; set; } = 0;
        #endregion

        #region Actions To Be Saved
        /// <summary>
        /// Used to save and load draft for the all other stages actions container
        /// </summary>
        public Action AllOtherStagesContainer { get; set; }
        #endregion Actions To Be Saved

        #region Common
        /// <summary>
        /// For DF, take from the Paper Request Number (to put in DB column)
        /// </summary>
        public string RequestNumber { get; set; }
        /// <summary>
        /// For DF Only
        /// </summary>
        public string ProjectRequestNumber { get; set; }
        /// <summary>
        /// The paper request number NEA/DF/FYXXXX/YYYY-## 
        /// that you should load from instead 
        /// of the request number NEA/DF/FYXXXX/YYYY.
        /// Used for DF only.
        /// </summary>
        public string PaperRequestNumber { get; set; }
        /// <summary>
        /// Hardcopy reference no for DF
        /// </summary>
        public string HardCopyReferenceNo { get; set; }
        public string ProjectTitle { get; set; }
        public string PaperTitle { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public User Requestor { get; set; }
        public OrganizationUnit RequestingDivision { get; set; }
        public OrganizationUnit RequestingDepartment { get; set; }
        public User SecondRequestor { get; set; }
        public OrganizationUnit SecondRequestingDivision { get; set; }
        public OrganizationUnit SecondRequestingDepartment { get; set; }
        /// <summary>
        /// Only CAPEX and CF. Can be placed in the inherited class 
        /// </summary>
        public List<User> HeadsOfDepartment { get; set; }
        public List<User> DivisionalDirectors { get; set; }
        public List<User> GroupDirectors { get; set; }
        public List<User> UsersToBeNotified { get; set; }
        /// <summary>
        /// Only for CAPEX and CF
        /// </summary>
        public User AFMD { get; set; }
        /// <summary>
        /// Only for CAPEX and CF
        /// </summary>
        public User ITD { get; set; }
        /// <summary>
        /// Only for DF
        /// </summary>
        public List<User> OtherUsersInput { get; set; }
        // Dashboard
        /// <summary>
        /// Approved amount from the extracted section 7.1 
        /// “Approved Amount” of previously approved Capex/Amendment to Capex requests
        /// </summary>
        public decimal ApprovedAmount { get; set; }
        /// <summary>
        /// This is requested amount from extracted section 6.6 
        /// “Amount Requested by Dept (for current request)” of previously 
        /// approved Capex/ Amendment to Capex requests
        /// </summary>
        public decimal RequestedAmount { get; set; }
        public List<decimal> ProjectCapitalCostTotal { get; set; }
        #endregion

        #region Form Items
        public ProjectMaster ProjectMaster { get; set; }
        public ProjectType ProjectType { get; set; }
        public ProjectBudgetDetails ProjectBudgetDetails { get; set; }
        public AssetOwnerDetails AssetOwnerDetails { get; set; }
        public RouteToAfmdOrItd RouteToAfmdOrItd { get; set; }
        #endregion

        #region Workflow
        public FDEvaluationAndReview FDEvaluationAndReview { get; set; }
        public FDFinalizationStage FDFinalizationStage { get; set; }
        /// <summary>
        /// The readonly view of the Actions that are done by the users
        /// </summary>
        public List<Action> Actions { get; set; }
        /// <summary>
        /// Don't have to use a seperate table. Just add on to it. Will surely have orphan data in the case 
        /// that the users keep rerouting\rework etc
        /// </summary>
        public List<WorkflowHistory> WorkflowHistory { get; set; }
        #endregion Workflow
    }


    #region Workflow
    [Serializable]
    public class FDFinalizationStage
    {
        // Approved amount in Common
        public string ChangeInScopeText { get; set; }
        public List<Attachment> Attachments { get; set; }
        public ApprovedProjectCapitalCostAllocationByFY ApprovedProjectCapitalCostAllocationByFY { get; set; }
    }
    [Serializable]
    public class FDEvaluationAndReview
    {
        public string Evaluation { get; set; }
        public List<Attachment> AttachmentsForEvaluation { get; set; }
        public string Recommendation { get; set; }
        public List<Attachment> AttachmentsForRecommendation { get; set; }
        public string CAPEXStatus { get; set; }
        public List<Attachment> AttachmentsForCAPEXStatus { get; set; }
        public Question QuestionLabel { get; set; }
        public enum Question
        {
            FundsAre,
            ChangeInScopeRequestIs,
        }
        public FundsAre FundsAre { get; set; }
        public ChangeInScopeRequestIs ChangeInScopeRequestIs { get; set; }
        public decimal Amount { get; set; }
        public List<ItemisedProjectCapitalCost> ItemisedProjectCapitalCost { get; set; }
        // Get from ItemisedProjectCapitalCost
        public List<decimal> ItemisedProjectCapitalCostTotal { get; set; }
        public CumulativeProjectCapitalCost CumulativeProjectCapitalCost { get; set; }
        public User DCEO { get; set; }
    }

    [Serializable]
    public class ItemisedProjectCapitalCost
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal CumulativeRequestedCapitalCost { get; set; }
        public decimal CumulativeSupportedCapitalCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    [Serializable]
    public class CumulativeProjectCapitalCost
    {
        public decimal AmountRequestedByDept { get; set; }
        public decimal AmountSupportedByFD { get; set; }
        public decimal CumulativeAmountRequestedByDept { get; set; }
        public decimal CumulativeAmountSupportedByFD { get; set; }
    }

    [Serializable]
    public class WorkflowHistory
    {
        // Used for both the interface UI after a user has submitted an action and the Actions Form
        public int Id { get; set; }
        public string Stage { get; set; }
        public string ActionBy { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public DateTime ActionDate { get; set; }
    }

    /// <summary>
    /// This class is used for the All Other Stages Container
    /// </summary>
    [Serializable]
    public class Action
    {
        public string Header { get; set; }
        public string ViewClarifications { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        /// <summary>
        /// Used for checking validation using the dropdownlist in code behind
        /// </summary>
        public ActionType.MasterEnum? ActionType { get; set; }
        /// <summary>
        /// Using for clarification's ddl save as draft
        /// </summary>
        public Status.Stage? SelectedStage { get; set; }
        /// <summary>
        /// Using save as draft as user list in string form
        /// </summary>
        public string UserList { get; set; }
        /// <summary>
        /// Using for storing the user list for clarification
        /// </summary>
        public List<User> UserToListForClarification { get; set; }
        /// <summary>
        /// Using for Reason too
        /// </summary>
        public string Comments { get; set; }
        public List<Attachment> Attachments { get; set; }
        // Only for ChairmanBoardDPC
        public string ApprovedBy { get; set; }
        // Only for ChairmanBoardDPC
        public List<Attachment> AttachmentsForChairmanBoardDPCAction { get; set; }
    }

    /// <summary>
    /// The ActionType is the action that a user can take
    /// </summary>
    [Serializable]
    public class ActionType
    {
        #region MasterEnum
        /// <summary>
        /// Combine the actions for the users as required and use .hasFlags() method to see whether they
        /// have the required permissions or not when checking.
        /// </summary>
        [Flags]
        public enum MasterEnum
        {
            Clarifications = 2,
            EquipmentNotUnderOurDepartmentPurview = 4,
            NotSupport = 8,
            Rework = 16,
            Support = 32,
            Reroute = 64,
            MajorRework = 128,
            Reject = 256,
            Approve = 512,
            Finalise = 1024,
            Evaluate = 2048,
            Review = 4096,
            Submit = 8192,
            Skip = 16384,
            SaveAsDraft = 32768,
            Endorse = 65536,
            // CAPEX
            AFMD = Clarifications + EquipmentNotUnderOurDepartmentPurview + NotSupport + Rework + Support,
            ITD = Clarifications + EquipmentNotUnderOurDepartmentPurview + NotSupport + Rework + Support,
            ReviewingOfficer = Clarifications + Reject + Rework + Support,
            HeadOfDepartment = Clarifications + Reject + Rework + Support,
            DivisionalDirector = Clarifications + Reject + Rework + Support,
            GroupDirector = Clarifications + Reject + Rework + Support,
            CAPEXFDUser = Clarifications + Reject + Rework + MajorRework + Evaluate,
            CAPEXFDReviewer = Clarifications + Reject + Rework + MajorRework + Review,
            CFO = Clarifications + Reject + Rework + Support,
            GDCS_NotFinalStage = Clarifications + Reject + Rework + Support,
            GDCS_FinalStage = Clarifications + Reject + Rework + Approve,
            DCEO_NotFinalStage = Clarifications + Reject + Rework + Support,
            DCEO_FinalStage = Clarifications + Reject + Rework + Approve,
            CEO_NotFinalStage = Clarifications + Reject + Rework + Support,
            CEO_FinalStage = Clarifications + Reject + Rework + Approve,
            ChairmanBoardDPC = Clarifications + Reject + Rework + Approve,
            CapexFDUserFinalization = Reject + Finalise,
            CAPEXFDUserRework = Rework + MajorRework + Submit,
            // DF
            OtherUsers = Reject + Clarifications + Submit,
            FASAdministrator_DF = Reroute + Skip,
            DFFDUser_OtherStages = Reroute + Skip,
            HeadOfDepartment_DF = Clarifications + Reject + Rework + Review,
            DFFDUser = Clarifications + Reject + Rework + MajorRework + Submit,
            CFO_DF = Clarifications + Reject + Rework + Support,
            DivisionalDirector_DF = Clarifications + Reject + Rework + Support,
            GDCS_DF = Clarifications + Reject + Rework + Support,
            CEO_DF = Clarifications + Reject + Rework + Endorse,
            PreparationForSubmission = Submit,
            DFFDFinalisation = Reject + Finalise
        }
        #endregion

        #region Users
        public enum FASAdminAndCAPEXFDUser
        {
            Reroute,
        }
        public enum AFMD
        {
            Clarifications,
            EquipmentNotUnderOurDepartmentPurview,
            NotSupport,
            Rework,
            Support,
        }
        public enum ITD
        {
            Clarifications,
            EquipmentNotUnderOurDepartmentPurview,
            NotSupport,
            Rework,
            Support,
        }
        public enum ReviewingOfficer
        {
            Clarifications,
            Reject,
            Rework,
            Support,
        }
        public enum HeadOfDepartment
        {
            Clarifications,
            Reject,
            Rework,
            Support,
        }
        public enum DivisionalDirector
        {
            Clarifications,
            Reject,
            Rework,
            Support,
        }
        public enum GroupDirector
        {
            Clarifications,
            Reject,
            Rework,
            Support,
        }
        /// <summary>
        /// Use this for FD User and Reviewer stage and combine with the user's specific enum types accordingly
        /// </summary>
        public enum CAPEXFDUserAndReviewer
        {
            Clarifications,
            Reject,
            Rework,
            MajorRework,
        }
        public enum CAPEXFDUser
        {
            Evaluate,
        }
        public enum CAPEXFDReviewer
        {
            Review,
        }
        public enum CFO
        {
            Clarifications,
            Reject,
            Rework,
            Support,
        }
        #region Can be merged later if possible
        // TODO: Merge if possible - Merged in MasterEnum
        public enum GDCS_NotFinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Support
        }
        public enum GDCS_FinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Approve
        }
        public enum DCEO_NotFinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Support
        }
        public enum DCEO_FinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Approve
        }
        public enum CEO_NotFinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Support
        }
        public enum CEO_FinalStage
        {
            Clarifications,
            Reject,
            Rework,
            Approve
        }
        /// <summary>
        /// FD Users is acting on behalf of ChairmanBoardDPC
        /// </summary>
        public enum ChairmanBoardDPC
        {
            Clarifications,
            Reject,
            Rework,
            Approve
        }
        public enum CapexFDUserFinalization
        {
            Reject,
            Finalise
        }
        #endregion
        #endregion
    }

    /// <summary>
    /// 4.3.1.	The statuses will be a combination of 3 sets of information and 
    /// presented in the following format, {Stage} - Pending {Action} by {Party} where:
    /// a)	Stage: Current stage in the workflow
    /// b)	Action: Pending action in the stage
    /// c)	Party: Officer/ Group of officers performing the action
    /// </summary>
    [Serializable]
    public class Status
    {
        public enum Stage
        {
            Draft,
            Requestor,
            MajorRework,
            AFMD,
            ITD,
            ReviewingOfficer,
            OtherUsersInput,
            HOD,
            FDUsersInput,
            DivisionalDirector,
            GroupDirector,
            FDUsers,
            FDReviewers,
            CFO,
            DivisionalDirectorDF,
            GDCS,
            DCEO,
            CEO,
            ChairmanBoardDPC,
            PreparationForSubmission,
            FDFinalisation,
            Rejected,
            Approved
        }
        public enum Action
        {
            Submission,
            Approval,
            Clarifications,
            Evaluation,
            Review,
            Rework,
            Support,
            Finalisation,
            Endorse,
        }
        public enum Party
        {
            Requestor,
            AFMD,
            ITD,
            ReviewingOfficer,
            HOD,
            DivisionalDirector,
            GroupDirector,
            FDUsers,
            FDReviewers,
            CFO,
            GDCS,
            DCEO,
            CEO,
            Users
        }
    }

    #endregion Workflow

    #region Form Items
    [Serializable]
    public class RouteToAfmdOrItd
    {
        public RouteTo RouteTo { get; set; }
    }

    [Serializable]
    public class AssetOwnerDetails
    {
        public bool SolelyOwnedByRequestingDepartment { get; set; }
        public List<AssetDetails> AssetDetails { get; set; }
    }

    [Serializable]
    public class ProjectBudgetDetails
    {
        public List<ProjectCapitalCost> ProjectCapitalCost { get; set; }
        public List<EstimatedRecurringOperatingCost> EstimatedRecurringOperatingCost { get; set; }
        public string ProposedSourceOfFunding { get; set; }
        public List<Attachment> Attachments { get; set; }
        public BudgetAllocation BudgetAllocation { get; set; }
        public string CostRecovery { get; set; }
    }

    [Serializable]
    public class ProjectType
    {
        public TypeOfProject TypeOfProject { get; set; }
        public List<ExistingFixedAssets> DetailsOfExistingFixedAssets { get; set; }
        /// <summary>
        /// Formulae to sum the “Original Purchase Price” and “Net Book Value” columns, not editable.
        /// </summary>
        /// 
        [Obsolete]
        public decimal OriginalPurchasePriceTotal { get; set; }
        [Obsolete]
        public decimal NetBookValueTotal { get; set; }
        public bool Declaration { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    [Serializable]
    public class ProjectMaster
    {
        public string ProjectDetails { get; set; }
        public List<Attachment> AttachmentsForProjectDetails { get; set; }
        public bool RequestApprovedInAnyForum { get; set; }
        public List<Attachment> AttachmentsForRequestApprovedInAnyForum { get; set; }
        public List<DesiredOutcomeTable> DesiredOutcome { get; set; }
        public string OtherOptions { get; set; }
        public bool IncludedInBudgetProjectionExercise { get; set; }
        public string BudgetProjectionExerciseElaboration { get; set; }
        public List<Attachment> AttachmentsForBudgetProjection { get; set; }
        public bool EnvironmentSustainabilityRequirements { get; set; }
        public string EnvironmentSustainabilityRequirementsElaboration { get; set; }

    }

    #endregion

    #region Enums
    public enum FundsAre
    {
        FullySupported,
        PartiallySupported,
        NotSupported
    }
    public enum ChangeInScopeRequestIs
    {
        Supported,
        NotSupported
    }

    public enum TypeOfProject
    {
        ReplacementOfExistingFixedAssets,
        AcquisitionOfNewFixedAssets,
        Both
    }
    public enum RouteTo
    {
        AFMDOfficer,
        ITDOfficer,
        Both,
        NotApplicable
    }
    public enum FASFundType
    {
        CAPEX,
        AmendmentToCAPEX,
        CF,
        AmendmentToCF,
        DF,
        AmendmentToDF
    }
    #endregion

    #region Classes
    [Serializable]
    public class AssetDetails
    {
        public int Id { get; set; }
        public OrganizationUnit Department { get; set; }
        public string GeneralDescriptionOfItem { get; set; }
        public string RemarksOfHodsEndorsement { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    [Serializable]
    public class BudgetAllocation
    {
        public string StartFY { get; set; }
        public decimal FirstFY { get; set; }
        public decimal SecondFY { get; set; }
        public decimal ThirdFY { get; set; }
        public decimal FourthFY { get; set; }
        public decimal FifthFY { get; set; }
        public decimal Total { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    [Serializable]
    public class EstimatedRecurringOperatingCost
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public string BasisOfEstimatedRecurringCost { get; set; }
        public string FirstFYDropdown { get; set; }
        public decimal FirstFY { get; set; }
        public decimal SecondFY { get; set; }
        public decimal ThirdFY { get; set; }
        public decimal FourthFY { get; set; }
        public decimal FifthFY { get; set; }
        public decimal ExistingAnnualRecurringCost { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    [Serializable]
    public class ProjectCapitalCost
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal ProposedUnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ProposedCapitalCost { get; set; }
        public string BasisOfProposedCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
        /// <summary>
        /// Formulae to sum up the “Proposed Capital Cost” column, not editable. 
        /// The value is calculated based on Proposed Unit Price * Quantity, not editable,
        /// TIMES the number of rows
        /// </summary>
        public decimal Total { get; set; }
    }
    [Serializable]
    public class ExistingFixedAssets
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public string AssetId { get; set; }
        public DateTime? AcquisitionDate { get; set; }
        public decimal OriginalPurchasePrice { get; set; }
        public decimal NetBookValue { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
    [Serializable]
    public class DesiredOutcomeTable
    {
        public int Id { get; set; }
        public string DesiredOutcome { get; set; }
        public string OutcomeIndicator { get; set; }
        public DateTime TargetCompletionDateOfProject { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
    [Serializable]
    public class ApprovedProjectCapitalCostAllocationByFY
    {
        public string StartFY { get; set; }
        public decimal FirstFY { get; set; }
        public decimal SecondFY { get; set; }
        public decimal ThirdFY { get; set; }
        public decimal FourthFY { get; set; }
        public decimal FifthFY { get; set; }
        public decimal Total { get; set; }
    }
    [Serializable]
    public class UserTask
    {
        // Stage of the request
        public Status.Stage RequestStage { get; set; }
        // User that did the task
        public User User { get; set; }
        // Date where the action is assigned
        public DateTime DateAssigned { get; set; }
        // Date where the user completed the action. Start off as null and will populate when the user has done something.
        public DateTime? DateCompleted { get; set; }
        // TODO: Status for CANCELLED status? 
    }
    #endregion

}