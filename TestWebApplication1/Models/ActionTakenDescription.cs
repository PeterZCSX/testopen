using System;
using System.Collections.Generic;

namespace TestWebApplication1.Models;

public partial class ActionTakenDescription
{
    public int ActionTakenDescriptionId { get; set; }

    public string? Description { get; set; }

    public string? PrepopulatedToCompanyInvestigator { get; set; }

    public string? PrepopulatedToCompanyCommittee { get; set; }

    public string? PrepopulatedToCmsprovider { get; set; }
}
