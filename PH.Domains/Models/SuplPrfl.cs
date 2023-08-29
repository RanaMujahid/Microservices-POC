using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SuplPrfl
{
    public long SuplPrflId { get; set; }

    public long BpMainId { get; set; }

    public string CatgCode { get; set; } = null!;

    public string PrjtName { get; set; } = null!;

    public int RfndExprDays { get; set; }

    public long EPymtPromotnId { get; set; }

    public long? LogoFileId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsRegstrId { get; set; }

    public bool IsMobNum { get; set; }

    public bool IsEml { get; set; }
}
