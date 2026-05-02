using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReportUserAccount
{
    public int IncidentReportUserAccountId { get; set; }

    public int IncidentReportId { get; set; }

    public int UserAccountId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public bool? AutoAssign { get; set; }

    public virtual IncidentReport IncidentReport { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
