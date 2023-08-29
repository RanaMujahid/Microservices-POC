using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Tran
{
    public int TranId { get; set; }

    public string TranName { get; set; } = null!;

    public string? TranNameLocal { get; set; }

    public string TranStts { get; set; } = null!;

    public string SrvcTypeCode { get; set; } = null!;

    public string SubSrvcTypeCode { get; set; } = null!;

    public string? TranDesc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? TranFor { get; set; }

    public virtual ICollection<AgntLimtSetngDetl> AgntLimtSetngDetls { get; set; } = new List<AgntLimtSetngDetl>();

    public virtual ICollection<BillAdslPymt> BillAdslPymts { get; set; } = new List<BillAdslPymt>();

    public virtual ICollection<BillElctPymt> BillElctPymts { get; set; } = new List<BillElctPymt>();

    public virtual ICollection<BillLandLinePymt> BillLandLinePymts { get; set; } = new List<BillLandLinePymt>();

    public virtual ICollection<BillMtnPkgPymt> BillMtnPkgPymts { get; set; } = new List<BillMtnPkgPymt>();

    public virtual ICollection<BillMtnPymt> BillMtnPymts { get; set; } = new List<BillMtnPymt>();

    public virtual ICollection<BillWatrPymt> BillWatrPymts { get; set; } = new List<BillWatrPymt>();

    public virtual ICollection<BillYgsmPymt> BillYgsmPymts { get; set; } = new List<BillYgsmPymt>();

    public virtual ICollection<CmsnPrflDetl> CmsnPrflDetls { get; set; } = new List<CmsnPrflDetl>();

    public virtual ICollection<FaildTran> FaildTrans { get; set; } = new List<FaildTran>();

    public virtual ICollection<OfflnLimtDetl> OfflnLimtDetls { get; set; } = new List<OfflnLimtDetl>();

    public virtual ICollection<OnyxAcctCnfg> OnyxAcctCnfgs { get; set; } = new List<OnyxAcctCnfg>();

    public virtual ICollection<ProdDetl> ProdDetls { get; set; } = new List<ProdDetl>();

    public virtual SrvcType SrvcTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<SspcnStng> SspcnStngs { get; set; } = new List<SspcnStng>();

    public virtual SubSrvcType SubSrvcTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<TranInptSetng> TranInptSetngs { get; set; } = new List<TranInptSetng>();

    public virtual RqstSttsType TranSttsNavigation { get; set; } = null!;
}
