using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Vilg
{
    public string VilgCode { get; set; } = null!;

    public string? VilgOldCode { get; set; }

    public string VilgName { get; set; } = null!;

    public string? VilgNameLocal { get; set; }

    public string OzlaCode { get; set; } = null!;

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

    public virtual Ozla OzlaCodeNavigation { get; set; } = null!;
}
