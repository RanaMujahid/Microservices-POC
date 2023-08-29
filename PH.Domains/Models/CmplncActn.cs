using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmplncActn
{
    public int CmplncId { get; set; }

    public string? CmplncName { get; set; }

    public string? CmplncNameLocal { get; set; }

    public string? CmplncDesc { get; set; }

    public string? StatusTypeCode { get; set; }

    public string? ActnType { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<SspcnStng> SspcnStngDCmplncActns { get; set; } = new List<SspcnStng>();

    public virtual ICollection<SspcnStng> SspcnStngMCmplncActns { get; set; } = new List<SspcnStng>();
}
