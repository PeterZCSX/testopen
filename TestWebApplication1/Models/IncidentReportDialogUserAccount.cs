using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReportDialogUserAccount
{
    public int IncidentReportDialogUserAccountId { get; set; }

    public int IncidentReportDialogId { get; set; }

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

    public virtual IncidentReportDialog IncidentReportDialog { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
