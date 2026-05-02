using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class CompanyCustomField
{
    public int CompanyCustomFieldId { get; set; }

    public int? CompanyId { get; set; }

    public string? FieldLabelText { get; set; }

    public string? FieldToolTipText { get; set; }

    public bool? IsActive { get; set; }

    public int? FieldPositionOrder { get; set; }

    public string? FieldType { get; set; }

    public int? FieldLength { get; set; }

    public string? FieldListValues { get; set; }

    public string? FieldRangeFrom { get; set; }

    public string? FieldRangeTo { get; set; }

    public bool? FieldRequired { get; set; }

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
}
