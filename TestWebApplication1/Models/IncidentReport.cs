using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReport
{
    public int IncidentReportId { get; set; }

    public int CompanyId { get; set; }

    public string? IncidentReportSubject { get; set; }

    public DateTime? IncidentReportSubmitDate { get; set; }

    public string? IncidentReportAssignCode { get; set; }

    public string? OriginalSubmittedBy { get; set; }

    public int? DivisionId { get; set; }

    public string? OtherDivision { get; set; }

    public int? LocationId { get; set; }

    public string? OtherLocation { get; set; }

    public int? IncidentTypeId { get; set; }

    public string? OtherIncidentType { get; set; }

    public int? CategoryId { get; set; }

    public string? OtherCategory { get; set; }

    public int? SourceId { get; set; }

    public int? RiskId { get; set; }

    public int? PriorityId { get; set; }

    public int? StatusId { get; set; }

    public bool? IsLocked { get; set; }

    public DateTime? LockedOn { get; set; }

    public string? LockedBy { get; set; }

    public int? LockedByCompanyId { get; set; }

    public string? IncidentReportLanguage { get; set; }

    public string? IncidentReportCountry { get; set; }

    public string IncidentReportComplaintDetails { get; set; } = null!;

    public bool IsConfidential { get; set; }

    public bool? IsRestricted { get; set; }

    public string? ComplainantFirstName { get; set; }

    public string? ComplainantLastName { get; set; }

    public string? ComplainantEmailAddress { get; set; }

    public string? ComplainantContactInfo { get; set; }

    public string? ComplainantPincode { get; set; }

    public string? ComplainantPincodeSalt { get; set; }

    public string? ComplainantPassword { get; set; }

    public string? ComplainantRelationshiptoCompany { get; set; }

    public string? ComplainantPhone { get; set; }

    public DateTime? ComplainantTimeZone { get; set; }

    public DateTime? ComplainantCurrentSigninDate { get; set; }

    public bool? IsComplainantRequireAnonymous { get; set; }

    public bool? IsSupervisorManagementInvolved { get; set; }

    public string? SupervisorManagementNameList { get; set; }

    public string? GeneralNatureofIncidentReport { get; set; }

    public DateTime? IncidentOccurDatetime { get; set; }

    public string? IncidentOccurExactLoction { get; set; }

    public string? HowlongIncidentHappen { get; set; }

    public string? HowdoComplainantKnow { get; set; }

    public string? WhoAttemptedToConcealNameList { get; set; }

    public string? ComplainantContactDatetime { get; set; }

    public bool? IsComplainantContactedExternalAgency { get; set; }

    public string? ComplainantContactedExternalAgency { get; set; }

    public bool? IsComplainantContactedAttorney { get; set; }

    public string? ComplainantContactedAttorney { get; set; }

    public string? ComplainantExpectOutcome { get; set; }

    public bool? IsComplainantWantShareWitness { get; set; }

    public string? ComplainantWantShareWitnessContactInfo { get; set; }

    public bool? IsComplainantWantShareVictim { get; set; }

    public string? ComplainantWantShareVictimContactInfo { get; set; }

    public bool? IsComplainantWantShareAlleged { get; set; }

    public string? ComplainantWantShareAllegedContactInfo { get; set; }

    public DateTime? IncidentReportTobeResolutionDate { get; set; }

    public string? IncidentReportResolution { get; set; }

    public string? IncidentReportApprovedby { get; set; }

    public DateTime? IncidentReportApprovedDate { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public string? DeletedNotes { get; set; }

    public bool IsActive { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Division? Division { get; set; }

    public virtual ICollection<IncidentReportActionTaken> IncidentReportActionTakens { get; set; } = new List<IncidentReportActionTaken>();

    public virtual ICollection<IncidentReportAudit> IncidentReportAudits { get; set; } = new List<IncidentReportAudit>();

    public virtual ICollection<IncidentReportCompanyCustomField> IncidentReportCompanyCustomFields { get; set; } = new List<IncidentReportCompanyCustomField>();

    public virtual ICollection<IncidentReportDialog> IncidentReportDialogs { get; set; } = new List<IncidentReportDialog>();

    public virtual ICollection<IncidentReportFile> IncidentReportFiles { get; set; } = new List<IncidentReportFile>();

    public virtual ICollection<IncidentReportFollowUp> IncidentReportFollowUps { get; set; } = new List<IncidentReportFollowUp>();

    public virtual ICollection<IncidentReportRestrictedAccount> IncidentReportRestrictedAccounts { get; set; } = new List<IncidentReportRestrictedAccount>();

    public virtual ICollection<IncidentReportUserAccount> IncidentReportUserAccounts { get; set; } = new List<IncidentReportUserAccount>();

    public virtual Location? Location { get; set; }

    public virtual Priority? Priority { get; set; }

    public virtual Risk? Risk { get; set; }

    public virtual Source? Source { get; set; }

    public virtual Status? Status { get; set; }
}
