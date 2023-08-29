using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Chnl
{
    public int ChnlId { get; set; }

    public string ChnlName { get; set; } = null!;

    public string? ChnlNameLocal { get; set; }

    public string? ChnlDesc { get; set; }

    public string? OutUrl { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<BillAdslPymt> BillAdslPymts { get; set; } = new List<BillAdslPymt>();

    public virtual ICollection<BillElctPymt> BillElctPymts { get; set; } = new List<BillElctPymt>();

    public virtual ICollection<BillLandLinePymt> BillLandLinePymts { get; set; } = new List<BillLandLinePymt>();

    public virtual ICollection<BillMtnPkgPymt> BillMtnPkgPymts { get; set; } = new List<BillMtnPkgPymt>();

    public virtual ICollection<BillMtnPymt> BillMtnPymts { get; set; } = new List<BillMtnPymt>();

    public virtual ICollection<BillWatrPymt> BillWatrPymts { get; set; } = new List<BillWatrPymt>();

    public virtual ICollection<BillYgsmPymt> BillYgsmPymts { get; set; } = new List<BillYgsmPymt>();

    public virtual ICollection<ChnlDtl> ChnlDtls { get; set; } = new List<ChnlDtl>();

    public virtual ICollection<FaildTran> FaildTrans { get; set; } = new List<FaildTran>();

    public virtual ICollection<FrzRqstTranMpng> FrzRqstTranMpngs { get; set; } = new List<FrzRqstTranMpng>();

    public virtual ICollection<ProdDetl> ProdDetls { get; set; } = new List<ProdDetl>();

    public virtual RqstSttsType? StatusTypeCodeNavigation { get; set; }
}
