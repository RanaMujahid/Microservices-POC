using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ProdDetl
{
    public int ProdDetlId { get; set; }

    public int ProdId { get; set; }

    public int TranId { get; set; }

    public int ChnlId { get; set; }

    public int FeeId { get; set; }

    public int LimtId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Chnl Chnl { get; set; } = null!;

    public virtual GroupFee Fee { get; set; } = null!;

    public virtual GroupLimit Limt { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;

    public virtual Tran Tran { get; set; } = null!;
}
