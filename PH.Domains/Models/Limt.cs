using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Limt
{
    public int LimtId { get; set; }

    public string LimtName { get; set; } = null!;

    public string? LimtNameLocl { get; set; }

    public string? LimtDesc { get; set; }

    public string? LimtTypeCode { get; set; }

    public string? LimtStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AgntPrfilDetl> AgntPrfilDetls { get; set; } = new List<AgntPrfilDetl>();

    public virtual ICollection<GroupLimitDetl> GroupLimitDetls { get; set; } = new List<GroupLimitDetl>();

    public virtual ICollection<LimtDetl> LimtDetls { get; set; } = new List<LimtDetl>();

    public virtual LimtType? LimtTypeCodeNavigation { get; set; }
}
