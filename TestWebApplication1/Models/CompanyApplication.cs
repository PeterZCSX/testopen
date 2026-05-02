using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class CompanyApplication
{
    public int CompanyApplicationId { get; set; }

    public bool? IsActive { get; set; }

    public int CompanyId { get; set; }

    public int ApplicationId { get; set; }

    public bool? PaymentStatus { get; set; }

    public DateTime? PaymentDeadline { get; set; }

    public decimal? PaymentAmount { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;
}
