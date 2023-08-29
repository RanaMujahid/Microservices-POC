using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class GroupFee
{
    public int FeesGroupId { get; set; }

    public string FeesName { get; set; } = null!;

    public string? FeesNameLocal { get; set; }

    public string? FeesDesc { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<GroupFeesDetl> GroupFeesDetls { get; set; } = new List<GroupFeesDetl>();

    public virtual ICollection<ProdDetl> ProdDetls { get; set; } = new List<ProdDetl>();
}
