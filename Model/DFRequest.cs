namespace WebApplicationTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEA_FAS.DFRequest")]
    public partial class DFRequest
    {
        public Guid? ProjectRequestID { get; set; }

        public Guid? ID { get; set; }

        [StringLength(50)]
        public string RequestNo { get; set; }

        [StringLength(4)]
        public string FY { get; set; }

        public int? RequestCounter { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RequestDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AssignedDate { get; set; }

        public string TypeOfProject { get; set; }

        public int? PaperSeekingDPC { get; set; }

        public int? Hawker { get; set; }

        public Guid? Requestor { get; set; }

        public Guid? SecRequestor { get; set; }

        [StringLength(255)]
        public string RequestDivision { get; set; }

        [StringLength(255)]
        public string SecRequestDivision { get; set; }

        [StringLength(255)]
        public string RequestDepartment { get; set; }

        [StringLength(255)]
        public string SecRequestDepartment { get; set; }

        public string UserInputList { get; set; }

        public string HODsList { get; set; }

        public string DDsList { get; set; }

        public string CCsList { get; set; }

        [StringLength(50)]
        public string HardCopyReferenceNo { get; set; }

        public string PaperTitle { get; set; }

        public string Aim { get; set; }

        public string PaperSummary { get; set; }

        public string PaperObjectives { get; set; }

        public string BenefitsOfProject { get; set; }

        public string ReleventAuthorities { get; set; }

        public string KPI { get; set; }

        public string ProposedSchedule { get; set; }

        public string APR { get; set; }

        public string PPP { get; set; }

        public string EnvironmentSustain { get; set; }

        public string EstCost { get; set; }

        public string EstRecurrCost { get; set; }

        public string FundingArrangement { get; set; }

        public string CashflowPhasing { get; set; }

        public string AccountCode { get; set; }

        public string NPV { get; set; }

        public string AssetsToBeWrittenOff { get; set; }

        public string OtherImportantInfo { get; set; }

        public string Attachments { get; set; }

        public string EconomicLifeSpan { get; set; }

        public string OwnershipOfCentre { get; set; }

        public string ContactPerson { get; set; }

        [Key]
        [Column(Order = 0)]
        public string UserInputStage { get; set; }

        [Key]
        [Column(Order = 1)]
        public string HODStage { get; set; }

        public string FDUserInputStage { get; set; }

        public string CFOStage { get; set; }

        public string DDStage { get; set; }

        public string GDCSStage { get; set; }

        public string CEOStage { get; set; }

        public string MEWRMOFStage { get; set; }

        public string FinalisationStage { get; set; }

        [StringLength(50)]
        public string PreviousStatusStage { get; set; }

        [StringLength(50)]
        public string PreviousStatusAction { get; set; }

        [StringLength(50)]
        public string CurrentStatusStage { get; set; }

        [StringLength(50)]
        public string CurrentStatusAction { get; set; }

        [StringLength(50)]
        public string CurrentStatusParty { get; set; }

        [StringLength(100)]
        public string CurrentStatus { get; set; }
    }
}
