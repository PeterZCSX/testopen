using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReportFile
{
    public int IncidentReportFileId { get; set; }

    public int? CompanyId { get; set; }

    public int IncidentReportId { get; set; }

    public string FileName { get; set; } = null!;

    public int FileLength { get; set; }

    public string? Notes { get; set; }

    public bool? ViewableByComplainantFlag { get; set; }

    public bool? ViewableByCompanyFlag { get; set; }

    public bool? ViewableByCmsproviderFlag { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedByUserFromType { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedByUserFromType { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? DeletedByUserFromType { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public string? FileDynamicRandomName { get; set; }

    public virtual Company? Company { get; set; }

    public virtual IncidentReport IncidentReport { get; set; } = null!;

    public virtual ICollection<IncidentReportFileUserAccount> IncidentReportFileUserAccounts { get; set; } = new List<IncidentReportFileUserAccount>();
}
