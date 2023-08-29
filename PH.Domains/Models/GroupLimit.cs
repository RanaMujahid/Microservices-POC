using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class GroupLimit
{
    public int LimitGroupId { get; set; }

    public string LimitName { get; set; } = null!;

    public string? LimitNameLocal { get; set; }

    public string? LimitDesc { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AgntLimtSetngDetl> AgntLimtSetngDetls { get; set; } = new List<AgntLimtSetngDetl>();

    public virtual ICollection<GroupLimitDetl> GroupLimitDetls { get; set; } = new List<GroupLimitDetl>();

    public virtual ICollection<OfflnLimtDetl> OfflnLimtDetlCustmLimts { get; set; } = new List<OfflnLimtDetl>();

    public virtual ICollection<OfflnLimtDetl> OfflnLimtDetlGnrlLimts { get; set; } = new List<OfflnLimtDetl>();

    public virtual ICollection<ProdDetl> ProdDetls { get; set; } = new List<ProdDetl>();
}
