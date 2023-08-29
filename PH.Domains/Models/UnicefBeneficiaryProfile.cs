using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefBeneficiaryProfile
{
    public int UbpSno { get; set; }

    public string UbpBenName { get; set; } = null!;

    public long UbpBenUniqueNo { get; set; }

    public DateTime UbpBenDob { get; set; }

    public int UbpAttNo { get; set; }

    public string UbpBranchAgentEntry { get; set; } = null!;

    public bool UbpStatus { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? UbpBenRegCode { get; set; }

    public string? UbpBenNameAsId { get; set; }
}
