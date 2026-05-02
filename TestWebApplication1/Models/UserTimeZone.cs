using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class UserTimeZone
{
    public int TimeZoneId { get; set; }

    public string? TimeZoneName { get; set; }

    public int? TimeZoneUtcOffset { get; set; }
}
