using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpUserAgntReviewMap
{
    public int CorpUserAgntReviewMapId { get; set; }

    public int UserId { get; set; }

    public long BpMainId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CorpId { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;

    public virtual BpSysUser User { get; set; } = null!;
}
