using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IndustryHierarchy
{
    public int IndustryHierarchyId { get; set; }

    public int IndustryId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public int? DisplayOrder { get; set; }

    public virtual Industry Industry { get; set; } = null!;
}
