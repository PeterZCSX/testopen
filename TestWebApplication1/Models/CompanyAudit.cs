using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class CompanyAudit
{
    public int CompanyAuditId { get; set; }

    public int? CompanyId { get; set; }

    public string? FieldName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? ChangedOn { get; set; }

    public string? ChangedBy { get; set; }

    public int? ChangedByUserAccountId { get; set; }

    public int? ChangedByCompanyId { get; set; }

    public string? ChangedByUserFromType { get; set; }

    public virtual Company? Company { get; set; }
}
