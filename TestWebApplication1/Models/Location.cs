using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int CompanyId { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? LockLocationFromClient { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ProvinceRegion { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Notes { get; set; }

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

    public virtual ICollection<DivisionLocationAssoc> DivisionLocationAssocs { get; set; } = new List<DivisionLocationAssoc>();

    public virtual ICollection<IncidentReport> IncidentReports { get; set; } = new List<IncidentReport>();
}
