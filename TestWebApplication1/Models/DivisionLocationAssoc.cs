using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class DivisionLocationAssoc
{
    public int DivisionLocationAssocId { get; set; }

    public int? CompanyId { get; set; }

    public int DivisionId { get; set; }

    public int LocationId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Division Division { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;
}
