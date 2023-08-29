using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntLimtSetngDetl
{
    public int AgntLimtSetngDetlId { get; set; }

    public int AgntLimtSetngId { get; set; }

    public int? GroupLimtId { get; set; }

    public int? TranId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual AgntLimtSetng AgntLimtSetng { get; set; } = null!;

    public virtual GroupLimit? GroupLimt { get; set; }

    public virtual Tran? Tran { get; set; }
}
