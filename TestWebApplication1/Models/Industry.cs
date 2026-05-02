using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class Industry
{
    public int IndustryId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public int? DisplayOrder { get; set; }

    public virtual ICollection<IndustryHierarchy> IndustryHierarchies { get; set; } = new List<IndustryHierarchy>();
}
