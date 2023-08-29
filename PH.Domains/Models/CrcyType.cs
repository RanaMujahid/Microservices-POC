using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CrcyType
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public string? Symb { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CmsnPrfl> CmsnPrfls { get; set; } = new List<CmsnPrfl>();

    public virtual ICollection<Cmsn> Cmsns { get; set; } = new List<Cmsn>();

    public virtual ICollection<Fee> Fees { get; set; } = new List<Fee>();

    public virtual ICollection<LimtDetl> LimtDetls { get; set; } = new List<LimtDetl>();

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    public virtual ICollection<RestrPrice> RestrPriceAcctCurrCodeNavigations { get; set; } = new List<RestrPrice>();

    public virtual ICollection<RestrPrice> RestrPriceRemtCurrCodeNavigations { get; set; } = new List<RestrPrice>();
}
