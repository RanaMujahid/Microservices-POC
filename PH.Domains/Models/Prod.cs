using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Prod
{
    public int ProdId { get; set; }

    public string ProdName { get; set; } = null!;

    public string? ProdNameLocal { get; set; }

    public string ProdStts { get; set; } = null!;

    public string CrcyTypeCode { get; set; } = null!;

    public string ProdTypeCode { get; set; } = null!;

    public int KycSetId { get; set; }

    public decimal ActMin { get; set; }

    public decimal ActMax { get; set; }

    public string? ProdDesc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsVisible { get; set; }

    public virtual ICollection<Acct> Accts { get; set; } = new List<Acct>();

    public virtual CrcyType CrcyTypeCodeNavigation { get; set; } = null!;

    public virtual KycSet KycSet { get; set; } = null!;

    public virtual ICollection<ProdDetl> ProdDetls { get; set; } = new List<ProdDetl>();

    public virtual RqstSttsType ProdSttsNavigation { get; set; } = null!;

    public virtual ClntRoleType ProdTypeCodeNavigation { get; set; } = null!;
}
