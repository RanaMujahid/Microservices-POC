using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Dist
{
    public string DistCode { get; set; } = null!;

    public string? DistOldCode { get; set; }

    public string DistName { get; set; } = null!;

    public string? DistNameLocal { get; set; }

    public string GvrnCode { get; set; } = null!;

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CorpLoct> CorpLocts { get; set; } = new List<CorpLoct>();

    public virtual Gvrn GvrnCodeNavigation { get; set; } = null!;

    public virtual ICollection<Ozla> Ozlas { get; set; } = new List<Ozla>();
}
