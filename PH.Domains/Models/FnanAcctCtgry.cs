using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FnanAcctCtgry
{
    public string CtgryCode { get; set; } = null!;

    public string CtgryName { get; set; } = null!;

    public string? Desc { get; set; }

    public string DaoLinkType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
