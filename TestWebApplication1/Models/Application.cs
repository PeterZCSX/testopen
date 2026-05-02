using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public int? DisplayOrder { get; set; }

    public decimal? PriceByMonthByCompany { get; set; }

    public decimal? PriceDiscountRateByMonthByCompnay { get; set; }

    public decimal? PriceByYearByCompany { get; set; }

    public decimal? PriceDiscountRateByYearByCompnay { get; set; }

    public decimal? PriceByMonthByUser { get; set; }

    public decimal? PriceDiscountRateByMonthByUser { get; set; }

    public decimal? PriceByYearByUser { get; set; }

    public decimal? PriceDiscountRateByYearByUser { get; set; }

    public DateTime? PriceDiscountRateStartDate { get; set; }

    public DateTime? PriceDiscountRateEndDate { get; set; }

    public DateTime? PaymentDeadline { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual ICollection<CompanyApplication> CompanyApplications { get; set; } = new List<CompanyApplication>();
}
