using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class IncidentTypeDefault
{
    public int IncidentTypeDefaultId { get; set; }

    public string IncidentTypeName { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool LockIncidentTypeFromClient { get; set; }
}
