using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefFileFlag
{
    public int FlagCode { get; set; }

    public string FlagName { get; set; } = null!;

    public string? FlagDesc { get; set; }

    public int? OrgId { get; set; }

    public virtual ICollection<UnicefCyclFlag> UnicefCyclFlags { get; set; } = new List<UnicefCyclFlag>();
}
