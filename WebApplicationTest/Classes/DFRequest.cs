using COL.NEA.Common;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Web.UI;

namespace COL.NEA.FAS
{
    [Serializable]
    public class DFRequest : Request
    {
        #region Common
        // Project Request Number is the same as RequestNumber in base
        // Paper Request Number is in base Request class
        // Hardcopy number is in base Request class
        #endregion Common

        #region Form Items
        public ProjectDetails ProjectDetails { get; set; }
        public RequestingDepartmentDetails RequestingDepartmentDetails { get; set; }
        public PaperMaster PaperMaster { get; set; }
        public BudgetDetails BudgetDetails { get; set; }
        public AssetsToBeWrittenOff AssetsToBeWrittenOff { get; set; }
        public OtherRelevantInformation OtherRelevantInformation { get; set; }
        public ContactPersonsForQueries ContactPersonsForQueries { get; set; }
        public PreparationForSubmission PreparationForSubmission { get; set; }
        public new FDFinalizationStageDF FDFinalizationStage { get; set; }
        #endregion Form Items

    }

    #region Enums
    [Serializable]
    public enum Project
    {
        NewProject,
        ExistingProject
    }

    [Serializable]
    public enum TypeOfProjectDF
    {
        InfrastructureProject,
        NonInfrastructureProject,
        ProjectWithEquityInjection,
        Others
    }
    #endregion Enums

    #region Workflow
    #endregion Workflow

    #region Classes

    #region Base Classes
    [Serializable]
    public class ProjectDetails
    {
        public Project ProjectRequest { get; set; }
        // Project Request Number is in common as Request Number 
        // (should hold the full request number and only show without 
        // the paper request number on the frontend)
        // Project Title is in common as Project Title
        public List<ApprovedPapersTable> ApprovedPapers { get; set; }
    }

    [Serializable]
    public class RequestingDepartmentDetails
    {
        public TypeOfProjectDF TypeOfProject { get; set; }
        public string TypeOfProjectDetails { get; set; }
        public bool SeekingApprovalFromDPC { get; set; }
        public bool SeekingApprovalForHawkerCentre { get; set; }
        // Paper Request Number, Users, div and dept, date are in base\common 
    }

    [Serializable]
    public class PaperMaster
    {
        // Hardcopy reference number is in base request
        // Paper title is in base request
        public string Aim { get; set; }
        public string PaperSummary { get; set; }
        public List<Attachment> PaperSummaryAttachments { get; set; }
        public string PaperObjectives { get; set; }
        public string BenefitsOfProject { get; set; }
        public List<Attachment> BenefitsOfProjectAttachments { get; set; }
        public string ApprovalFromOtherRelevantAuthorities { get; set; }
        public List<Attachment> ApprovalFromOtherRelevantAuthoritiesAttachments { get; set; }
        public List<KeyPerformanceIndicatorTable> KeyPerformanceIndicatorTable { get; set; }
        public List<ProposedScheduleForDevelopmentTable> ProposedScheduleForDevelopmentTable { get; set; }
        public string AnticipatedPublicResponse { get; set; }
        public string PublicPrivatePartnership { get; set; }
        public bool ConsideredESR { get; set; }
        public string ESRReason { get; set; }
    }

    [Serializable]
    public class BudgetDetails
    {
        public List<EstimatedTotalProjectCostsTable> EstimatedTotalProjectCostsTable { get; set; }
        public bool NeedSpecificApproval { get; set; }
        public string EstimatedTotalProjectCostsTableTitle { get; set; }
        public List<EstimatedTotalProjectCostsTable> EstimatedTotalProjectCostsTableWithTitle { get; set; }
        public bool AnyEstimatedRecurringCosts { get; set; }
        public List<AnyEstimatedRecurringCostsTable> AnyEstimatedRecurringCostsTable { get; set; }
        public string FundingArrangement { get; set; }
        public List<CashflowPhasing> CashflowPhasing { get; set; }
        public string CashflowPhasingTitle { get; set; }
        public List<CashflowPhasing> CashflowPhasingWithTitle { get; set; }
        public List<AccountCodesAndProjectCostBreakdownTable> AccountCodesAndProjectCostBreakdownTable { get; set; }
        public string NPV { get; set; }
        public List<Attachment> NPVAttachments { get; set; }
    }

    [Serializable]
    public class AssetsToBeWrittenOff
    {
        public bool AnyExistingAssetsToBeWrittenOff { get; set; }
        public List<AssetsToBeCondemnedTable> AssetsToBeCondemnedTable { get; set; }
    }

    [Serializable]
    public class OtherRelevantInformation
    {
        public string SpecifyAnyOtherInformation { get; set; }
        public List<Attachment> SpecifyAnyOtherInformationAttachments { get; set; }
        public string EconomicLifespan { get; set; }
        public string OwnershipOfCentreAndManagementModel { get; set; }
    }

    [Serializable]
    public class ContactPersonsForQueries
    {
        public List<ContactPersonsForQueriesTable> ContactPersonsForQueriesTable { get; set; }
    }

    [Serializable]
    public class PreparationForSubmission
    {
        /// <summary>
        /// Used for email. Generated at the CEO Stage.
        /// </summary>
        public DateTime EndorsementDate { get; set; }
        public List<Attachment> PreparationForSubmissionAttachments { get; set; }
    }

    [Serializable]
    public class FDFinalizationStageDF
    {
        public List<Attachment> ClarificationAttachments { get; set; }
        public List<ApprovalMinuteFromMEWRTable> ApprovalMinuteFromMEWRTable { get; set; }
        public List<string> TypeOfApproval { get; set; }
        public decimal IPAApprovedAmount { get; set; }
        public decimal FundingApprovedAmount { get; set; }
        public decimal MEWRIAAApprovedAmount { get; set; }
        public string BreakdownOfBudgetApprovalTableTitle { get; set; }
        public List<BreakdownOfBudgetApprovalTable> BreakdownOfBudgetApprovalTable { get; set; }
        public string BreakdownOfBudgetApprovalTableWithFurtherBreakdownTitle { get; set; }
        public List<BreakdownOfBudgetApprovalTable> BreakdownOfBudgetApprovalTableWithFurtherBreakdown { get; set; }
    }

    [Serializable]
    public class ApprovalMinuteFromMEWRTable
    {
        public DateTime DateOfApproval { get; set; }
        public List<Attachment> ApprovalMinuteAttachments { get; set; }
        public string Remarks { get; set; }
    }

    [Serializable]
    public class BreakdownOfBudgetApprovalTable
    {
        public string Description { get; set; }
        public decimal NEAProposedAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public string Remarks { get; set; }
        // Total
    }

    [Serializable]
    public class ContactPersonsForQueriesTable
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
    }

    [Serializable]
    public class AssetsToBeCondemnedTable
    {
        public string AssetsToBeCondemned { get; set; }
        public string AssetId { get; set; }
        public string AssetCategory { get; set; }
        public int UsefulLifeOfAsset { get; set; }
        public decimal NBV { get; set; }
        public string ReasonsForCondemnation { get; set; }
    }

    [Serializable]
    public class AccountCodesAndProjectCostBreakdownTable
    {
        public string AccountCode { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        // Total
    }

    // Title to be used outside of the table
    [Serializable]
    [Obsolete]
    public class CashflowPhasingWithTitle : CashflowPhasing
    {
        public string Title { get; set; }
    }

    [Serializable]
    public class CashflowPhasing
    {
        public int FY { get; set; }
        public decimal Cashflow { get; set; }
        public string Remarks { get; set; }
        // Total
    }

    [Serializable]
    public class AnyEstimatedRecurringCostsTable
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal EstimatedAnnualRecurringCost { get; set; }
        public string SourceOfFunding { get; set; }
        public string BasisOfEstimatedCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
        // Total
    }

    // Title to be used outside of the table
    [Serializable]
    [Obsolete]
    public class EstimatedTotalProjectCostsTableWithTitle : EstimatedTotalProjectCostsTable
    {
        public string TitleOfTable { get; set; }
    }

    [Serializable]
    public class EstimatedTotalProjectCostsTable
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal EstimatedCost { get; set; }
        public string BasisOfEstimatedCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
        // Total
    }

    [Serializable]
    public class ProposedScheduleForDevelopmentTable
    {
        public string ProjectMilestones { get; set; }
        public int IndicativeTimelineQuarter { get; set; }
        public int IndicativeTimelineYear { get; set; }
        public int CompletedIndicativeTimelineQuarter { get; set; }
        public int CompletedIndicativeTimelineYear { get; set; }
    }

    [Serializable]
    public class KeyPerformanceIndicatorTable
    {
        public string DesiredOutcomes { get; set; }
        public string OutcomeIndicators { get; set; }
        public string ProposedTargets { get; set; }
        public string PrimeImpactOfProposedTargets { get; set; }
    }

    [Serializable]
    public class ApprovedPapersTable
    {
        public Guid Id { get; set; }
        public string PaperRequestNo { get; set; }
        public string HardCopyReferenceNo { get; set; }
        public string PaperTitle { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string SelectLink { get; set; }
    }
    #endregion Base Classes

    #region Amendment Classes
    [Serializable]
    public class AmendmentAnyEstimatedRecurringCostsTable
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal OriginalEstimatedAnnualRecurringCost { get; set; }
        public decimal RevisedEstimatedAnnualRecurringCost { get; set; }
        public string SourceOfFunding { get; set; }
        public string BasisOfEstimatedCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
        // Total
    }

    // Title to be used outside of the table
    [Serializable]
    [Obsolete]
    public class AmendmentEstimatedTotalProjectCostsTableWithTitle : AmendmentEstimatedTotalProjectCostsTable
    {
        public string TitleOfTable { get; set; }
    }

    [Serializable]
    public class AmendmentEstimatedTotalProjectCostsTable
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public decimal OriginalEstimatedCost { get; set; }
        public decimal RevisedEstimatedCost { get; set; }
        public string BasisOfEstimatedCost { get; set; }
        public string Remarks { get; set; }
        public List<Attachment> Attachments { get; set; }
        // Total
    }

    [Serializable]
    public class AmendmentProposedScheduleForDevelopmentTable
    {
        public string OriginalProjectMilestones { get; set; }
        public string RevisedProjectMilestones { get; set; }
        public int OriginalIndicativeTimelineYear { get; set; }
        public int OriginalIndicativeTimelineQuarter { get; set; }
        public int CompletedOriginalIndicativeTimelineYear { get; set; }
        public int CompletedOriginalIndicativeTimelineQuarter { get; set; }
        public int RevisedIndicativeTimelineYear { get; set; }
        public int RevisedIndicativeTimelineQuarter { get; set; }
        public int CompletedRevisedIndicativeTimelineYear { get; set; }
        public int CompletedRevisedIndicativeTimelineQuarter { get; set; }
    }

    [Serializable]
    public class AmendmentKeyPerformanceIndicatorTable
    {
        public string DesiredOutcomes { get; set; }
        public string OutcomeIndicators { get; set; }
        public string OriginalProposedTargets { get; set; }
        public string RevisedProposedTargets { get; set; }
        public string PrimeImpactOfRevisedProposedTargets { get; set; }
    }
    #endregion Amendment Classes

    #endregion Classes
}