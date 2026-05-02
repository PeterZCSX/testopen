using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentReportCompanyCustomField
{
    public int IncidentReportCustomFieldId { get; set; }

    public int? IncidentReportId { get; set; }

    public int? CustomFieldId { get; set; }

    public int? CompanyId { get; set; }

    public string? CustomFieldData { get; set; }

    public virtual Company? Company { get; set; }

    public virtual IncidentReport? IncidentReport { get; set; }
}
