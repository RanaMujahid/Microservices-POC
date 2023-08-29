using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefAssignSite
{
    public int UauSno { get; set; }

    public int UsrNo { get; set; }

    public string UauSiteCode { get; set; } = null!;

    public DateTime UauDate { get; set; }

    public bool UauStatus { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
