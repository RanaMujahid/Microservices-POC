using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntPrfilDetl
{
    public int DetlId { get; set; }

    public int AgntPrfilId { get; set; }

    public string SrvcTypeId { get; set; } = null!;

    public int LimtId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual AgntPrfil AgntPrfil { get; set; } = null!;

    public virtual Limt Limt { get; set; } = null!;

    public virtual SrvcType SrvcType { get; set; } = null!;
}
