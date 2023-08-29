using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempAcctPrddAgntHasib
{
    public int UserId { get; set; }

    public long BpMainId { get; set; }

    public long AcctId { get; set; }

    public string? UserRoleTypeCode { get; set; }
}
