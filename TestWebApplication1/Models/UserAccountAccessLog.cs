using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class UserAccountAccessLog
{
    public int UserAccountAccessLogId { get; set; }

    public int CompanyId { get; set; }

    public int UserAccountId { get; set; }

    public string IpaddressFrom { get; set; } = null!;

    public DateTime SignOnDate { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
