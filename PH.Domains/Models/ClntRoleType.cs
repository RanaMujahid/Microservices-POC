using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ClntRoleType
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Acct> Accts { get; set; } = new List<Acct>();

    public virtual ICollection<BpMain> BpMains { get; set; } = new List<BpMain>();

    public virtual ICollection<KycSet> KycSets { get; set; } = new List<KycSet>();

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
}
