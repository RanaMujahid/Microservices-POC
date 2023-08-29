using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RestrPrice
{
    public int RestrPriceId { get; set; }

    public string RestrPriceName { get; set; } = null!;

    public string? RestrPriceNameLocal { get; set; }

    public string? AcctCurrCode { get; set; }

    public string? RemtCurrCode { get; set; }

    public string? TransType { get; set; }

    public decimal? Price { get; set; }

    public string? Desc { get; set; }

    public string? WrkqStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CrcyType? AcctCurrCodeNavigation { get; set; }

    public virtual ICollection<AgntRestrPrice> AgntRestrPrices { get; set; } = new List<AgntRestrPrice>();

    public virtual CrcyType? RemtCurrCodeNavigation { get; set; }
}
