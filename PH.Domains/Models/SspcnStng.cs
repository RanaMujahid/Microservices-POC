using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SspcnStng
{
    public int SspcnId { get; set; }

    public string? SspcnName { get; set; }

    public string? SspcnNameLocal { get; set; }

    public string? SspcnDesc { get; set; }

    public string? StatusTypeCode { get; set; }

    public int? TranId { get; set; }

    public string? CustType { get; set; }

    public string? CrcyCode { get; set; }

    public decimal? DilyTrnsLmt { get; set; }

    public decimal? MntlyTrnsLmt { get; set; }

    public int? DCmplncActnId { get; set; }

    public int? MCmplncActnId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CmplncActn? DCmplncActn { get; set; }

    public virtual CmplncActn? MCmplncActn { get; set; }

    public virtual Tran? Tran { get; set; }
}
