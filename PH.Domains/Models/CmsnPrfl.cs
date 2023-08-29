using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnPrfl
{
    public int CmsnPrflId { get; set; }

    public string CmsnPrflName { get; set; } = null!;

    public string? CmsnPrflNameLocal { get; set; }

    public string? CmsnPrflDesc { get; set; }

    public int? CmsnId { get; set; }

    public string? CrcyTypeCode { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AgntCmsnPrfl> AgntCmsnPrfls { get; set; } = new List<AgntCmsnPrfl>();

    public virtual ICollection<ChnlDtl> ChnlDtls { get; set; } = new List<ChnlDtl>();

    public virtual ICollection<CmsnPrflDetl> CmsnPrflDetls { get; set; } = new List<CmsnPrflDetl>();

    public virtual CrcyType? CrcyTypeCodeNavigation { get; set; }

    public virtual RqstSttsType? StatusTypeCodeNavigation { get; set; }
}
