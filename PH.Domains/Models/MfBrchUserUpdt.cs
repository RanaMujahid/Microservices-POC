using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfBrchUserUpdt
{
    public int BpDetlId { get; set; }

    public int BpMainId { get; set; }

    public string? FrstName { get; set; }

    public string? MddlName { get; set; }

    public string? LastName { get; set; }

    public string OldBrchCode { get; set; } = null!;

    public string Addr { get; set; } = null!;

    public double Phon { get; set; }

    public string Dob { get; set; } = null!;

    public string? Eml { get; set; }

    public string NewBrchCode { get; set; } = null!;
}
