using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class WorkQueHsty
{
    public long WorkQueHstyId { get; set; }

    public long WorkQueId { get; set; }

    public int UserId { get; set; }

    public string Actn { get; set; } = null!;

    public DateTime? Date { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpSysUser User { get; set; } = null!;

    public virtual WorkQue WorkQue { get; set; } = null!;
}
