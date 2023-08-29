using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Ozla
{
    public string OzlaCode { get; set; } = null!;

    public string? OzlaOldCode { get; set; }

    public string OzlaName { get; set; } = null!;

    public string? OzlaNameLocal { get; set; }

    public string DistCode { get; set; } = null!;

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

    public virtual Dist DistCodeNavigation { get; set; } = null!;

    public virtual ICollection<Vilg> Vilgs { get; set; } = new List<Vilg>();
}
