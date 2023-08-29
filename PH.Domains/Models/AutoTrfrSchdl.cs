using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AutoTrfrSchdl
{
    public long AutoTrfrSchdlId { get; set; }

    public long AgntBpMainId { get; set; }

    public DateTime SchdlDate { get; set; }

    public TimeSpan SchdlTime { get; set; }

    public DateTime? NextPrcsDate { get; set; }

    public string ReptSttsCode { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
