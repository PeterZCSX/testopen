using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string Name { get; set; } = null!;

    public string? Notes { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? CreatedByCompanyId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? UpdatedByCompanyId { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public int? DeletedByCompanyId { get; set; }

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
