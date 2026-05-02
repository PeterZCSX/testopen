using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class UserAccountAutoAssignRule
{
    public int UserAccountAutoAssignRuleId { get; set; }

    public int CompanyId { get; set; }

    public int UserAccountId { get; set; }

    public bool? IsActive { get; set; }

    public bool? AllowUserAutoAssignToReportFlag { get; set; }

    public bool? AllowRerunAutoAssignbyChangeFlag { get; set; }

    public bool? AutoAssignToAllComingReportsFlag { get; set; }

    public bool? AutoAssignToAllPreviousReportsFlag { get; set; }

    public bool? AllDivisionIncludedFlag { get; set; }

    public bool? AllLocationIncludedFlag { get; set; }

    public bool? AllIncidentTypeIncludedFalg { get; set; }

    public bool? AllSubmittedByIncludedFlag { get; set; }

    public string? DivisionIdassignedList { get; set; }

    public string? LocationIdassignedList { get; set; }

    public string? IncidentTypeIdassignedList { get; set; }

    public string? SubmittedByAssignedList { get; set; }

    public bool? NewDivisionIncludedFlag { get; set; }

    public bool? NewLocationIncludedFlag { get; set; }

    public bool? NewIncidentTypeIncludedFalg { get; set; }

    public bool? AutoAssignToAllReportsFlag { get; set; }

    public bool? AllRiskIncludedFlag { get; set; }

    public string? RiskIdassignedList { get; set; }

    public bool? AllSourceIncludedFlag { get; set; }

    public string? SourceIdassignedList { get; set; }

    public bool? AllPriorityIncludedFlag { get; set; }

    public string? PriorityIdassignedList { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
