using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OrgStt
{
    public string SttsCode { get; set; } = null!;

    public string? SttsName { get; set; }

    public string? SttsNameLocal { get; set; }

    public string? SttsDesc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Corp> Corps { get; set; } = new List<Corp>();

    public virtual ICollection<Org> Orgs { get; set; } = new List<Org>();
}
