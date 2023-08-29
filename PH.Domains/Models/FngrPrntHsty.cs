using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FngrPrntHsty
{
    public long FngrPrntId { get; set; }

    public long BpMainId { get; set; }

    public string DvceId { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
