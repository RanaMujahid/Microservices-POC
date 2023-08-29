using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Gvrn
{
    public string GvrnCode { get; set; } = null!;

    public string? GvrnOldCode { get; set; }

    public string GvrnName { get; set; } = null!;

    public string? GvrnNameLocal { get; set; }

    public string CntyCode { get; set; } = null!;

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cnty CntyCodeNavigation { get; set; } = null!;

    public virtual ICollection<CorpLoct> CorpLocts { get; set; } = new List<CorpLoct>();

    public virtual ICollection<Dist> Dists { get; set; } = new List<Dist>();
}
