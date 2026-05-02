using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReportAudit
{
    public int IncidentReportAuditId { get; set; }

    public int CompanyId { get; set; }

    public int? IncidentReportId { get; set; }

    public string? FieldName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? ChangedOn { get; set; }

    public string? ChangedBy { get; set; }

    public int? ChangedByCompanyId { get; set; }

    public string? ChangedByUserFromType { get; set; }

    public virtual IncidentReport? IncidentReport { get; set; }
}
