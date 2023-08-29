using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BsnsPrtn
{
    public int BsnsPrtnId { get; set; }

    public string BsnsPrtnName { get; set; } = null!;

    public string? BsnsPrtnNameLocal { get; set; }

    public string? BsnsPrtnDesc { get; set; }

    public string? BsnsPrtnTypeCode { get; set; }

    public string? BsnsPrtnItrnTypeCode { get; set; }

    public string? BankCode { get; set; }

    public string? AcctNo { get; set; }

    public string? SwftCode { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Bank? BankCodeNavigation { get; set; }

    public virtual BsnsPrtnItrnType? BsnsPrtnItrnTypeCodeNavigation { get; set; }

    public virtual BsnsPrtnType? BsnsPrtnTypeCodeNavigation { get; set; }

    public virtual ICollection<CmsnPrflDetl> CmsnPrflDetls { get; set; } = new List<CmsnPrflDetl>();

    public virtual RqstSttsType? StatusTypeCodeNavigation { get; set; }
}
