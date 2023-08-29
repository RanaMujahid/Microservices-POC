using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtRvsl
{
    public int EPymtRvslId { get; set; }

    public int? EPymtId { get; set; }

    public string SuplRefNo { get; set; } = null!;

    public long SuplBpMainId { get; set; }

    public string SuplCustId { get; set; } = null!;

    public string? TranStts { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? RtryCount { get; set; }

    public bool? T24RqstStts { get; set; }

    public string? RjctnResn { get; set; }
}
