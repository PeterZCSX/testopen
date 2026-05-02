using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class UserAccount
{
    public int UserAccountId { get; set; }

    public int CompanyId { get; set; }

    public string UserEmail { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string UserPasswordSalt { get; set; } = null!;

    public DateTime UserPasswordLastUpdateOn { get; set; }

    public int UserRoleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public byte[]? FaceLogoImage { get; set; }

    public string? Title { get; set; }

    public string? Phone { get; set; }

    public string? PhoneAlt { get; set; }

    public string? Fax { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ProvinceRegion { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Notes { get; set; }

    public string? SecretQuestion { get; set; }

    public string? SecretAnswer { get; set; }

    public string? ActiveCode { get; set; }

    public DateTime? ActiveCodeExpireDatetime { get; set; }

    public bool? UserLocked { get; set; }

    public bool? RestrictAccessByIpflag { get; set; }

    public int? FailPasswordAttemptTimes { get; set; }

    public DateTime? FailPasswordAttemptStartTime { get; set; }

    public string? PinAccessNumber { get; set; }

    public DateTime? PinAccessNumberActiveTime { get; set; }

    public bool? ReceiveNotifications { get; set; }

    public bool? IsAllowAutoAssign { get; set; }

    public DateTime? UserCurrentSigninDate { get; set; }

    public bool? CompanyCmsuserFlag { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiryTime { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<IncidentReportDialogUserAccount> IncidentReportDialogUserAccounts { get; set; } = new List<IncidentReportDialogUserAccount>();

    public virtual ICollection<IncidentReportFileUserAccount> IncidentReportFileUserAccounts { get; set; } = new List<IncidentReportFileUserAccount>();

    public virtual ICollection<IncidentReportFollowUpUserAccount> IncidentReportFollowUpUserAccounts { get; set; } = new List<IncidentReportFollowUpUserAccount>();

    public virtual ICollection<IncidentReportRestrictedAccount> IncidentReportRestrictedAccounts { get; set; } = new List<IncidentReportRestrictedAccount>();

    public virtual ICollection<IncidentReportUserAccount> IncidentReportUserAccounts { get; set; } = new List<IncidentReportUserAccount>();

    public virtual ICollection<UserAccountAccessLog> UserAccountAccessLogs { get; set; } = new List<UserAccountAccessLog>();

    public virtual ICollection<UserAccountAccessPrivilege> UserAccountAccessPrivileges { get; set; } = new List<UserAccountAccessPrivilege>();

    public virtual ICollection<UserAccountAutoAssignRule> UserAccountAutoAssignRules { get; set; } = new List<UserAccountAutoAssignRule>();

    public virtual UserRole UserRole { get; set; } = null!;
}
