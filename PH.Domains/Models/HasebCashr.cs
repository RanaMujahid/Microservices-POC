using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class HasebCashr
{
    public long CashrId { get; set; }

    public long AgntBpMainId { get; set; }

    public string CashrCode { get; set; } = null!;

    public int SeqncNmbr { get; set; }

    public long BpMainId { get; set; }

    public string RqstSttsCode { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
