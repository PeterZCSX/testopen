using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool? IsCompanyLocked { get; set; }

    public int? CompanyNumber { get; set; }

    public string? Subsidiary { get; set; }

    public string? CompanyAccessCode { get; set; }

    public string? CompanyAuthenLevel { get; set; }

    public int? CompanySizeId { get; set; }

    public int? CompanyEmployeeSize { get; set; }

    public int? IndustryId { get; set; }

    public byte[]? LogoImage { get; set; }

    public string? LogoImageName { get; set; }

    public string? LogoImageLocation { get; set; }

    public string? MainAddress1 { get; set; }

    public string? MainAddress2 { get; set; }

    public string? MainCity { get; set; }

    public string? MainState { get; set; }

    public string? MainZipCode { get; set; }

    public string? MainCountry { get; set; }

    public decimal? MainAddressLatitude { get; set; }

    public decimal? MainAddressLongitude { get; set; }

    public string? CompanyMainWebSite { get; set; }

    public string? CompanyMainContactEmail { get; set; }

    public string? CompanyMainContactPersonDetail { get; set; }

    public string? Notes { get; set; }

    public bool? RestrictAccessByIpflag { get; set; }

    public bool? EnforceLockoutOnFailLoginFlag { get; set; }

    public bool? PinauthenticationRequiredFlag { get; set; }

    public int PasswordLength { get; set; }

    public bool PasswordSymbolsIncludeFlag { get; set; }

    public bool PasswordNumbersIncludeFlag { get; set; }

    public bool PasswordLowerCaseIncludeFlag { get; set; }

    public bool PasswordUpperCaseIncludeFlag { get; set; }

    public int PasswordAgingDays { get; set; }

    public int TwoFactorPinlength { get; set; }

    public bool TwoFacttorPinsymbolsIncludeFlag { get; set; }

    public bool TwoFacttorPinnumbersIncludeFlag { get; set; }

    public bool TwoFacttorPinlowerCaseIncludeFlag { get; set; }

    public bool TwoFacttorPinupperCaseIncludeFlag { get; set; }

    public int EmailLinkCreatePasswordExpirationHours { get; set; }

    public int EmailLinkForgotPasswordExpirationHours { get; set; }

    public int EmailLinkPincodeExpirationHours { get; set; }

    public int? SessionTimeout { get; set; }

    public int? SessionTimeoutWarning { get; set; }

    public string? WebApikey { get; set; }

    public string? WebApipassword { get; set; }

    public bool? WebApiactiveFlag { get; set; }

    public int? WebApirequestTimes { get; set; }

    public DateTime? WebApirequestDatetime { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual ICollection<CompanyApplication> CompanyApplications { get; set; } = new List<CompanyApplication>();

    public virtual ICollection<CompanyAudit> CompanyAudits { get; set; } = new List<CompanyAudit>();

    public virtual ICollection<CompanyCustomField> CompanyCustomFields { get; set; } = new List<CompanyCustomField>();

    public virtual ICollection<CompanyProcessingMessage> CompanyProcessingMessages { get; set; } = new List<CompanyProcessingMessage>();

    public virtual ICollection<DivisionLocationAssoc> DivisionLocationAssocs { get; set; } = new List<DivisionLocationAssoc>();

    public virtual ICollection<Division> Divisions { get; set; } = new List<Division>();

    public virtual ICollection<IncidentReportCompanyCustomField> IncidentReportCompanyCustomFields { get; set; } = new List<IncidentReportCompanyCustomField>();

    public virtual ICollection<IncidentReportFile> IncidentReportFiles { get; set; } = new List<IncidentReportFile>();

    public virtual ICollection<IncidentReportFollowUp> IncidentReportFollowUps { get; set; } = new List<IncidentReportFollowUp>();

    public virtual ICollection<IncidentReport> IncidentReports { get; set; } = new List<IncidentReport>();

    public virtual ICollection<IncidentType> IncidentTypes { get; set; } = new List<IncidentType>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<UserAccountAccessLog> UserAccountAccessLogs { get; set; } = new List<UserAccountAccessLog>();

    public virtual ICollection<UserAccountAutoAssignRule> UserAccountAutoAssignRules { get; set; } = new List<UserAccountAutoAssignRule>();

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
