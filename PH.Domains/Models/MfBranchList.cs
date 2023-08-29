using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfBranchList
{
    public string OldBrchCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int T24Code { get; set; }

    public string T24Name { get; set; } = null!;

    public string? Comment { get; set; }

    public string? NameLocal { get; set; }

    public string? BrchAdrs { get; set; }

    public string? Status { get; set; }

    public int? RegnId { get; set; }

    public string? RegnName { get; set; }

    public int? OnyxBrchGrpId { get; set; }

    public int? Wrkqstts { get; set; }

    public int? LqdtyCode { get; set; }

    public string? MfloosSpclstName { get; set; }
}
