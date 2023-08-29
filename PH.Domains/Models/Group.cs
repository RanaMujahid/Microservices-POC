using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Group
{
    public int GrpNo { get; set; }

    public string? GrpNameAr { get; set; }

    public string GrpNameEn { get; set; } = null!;

    public string? GrpAccount { get; set; }

    public int GrpType { get; set; }

    public int GrpPower { get; set; }

    public short GrpState { get; set; }
}
