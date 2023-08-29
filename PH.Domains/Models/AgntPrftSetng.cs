using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntPrftSetng
{
    public int AgntPrftSetngId { get; set; }

    public string PrftSetngName { get; set; } = null!;

    public string? PrftSetngNameLocal { get; set; }

    public string? PrftSetngDesc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AgntTypeCode { get; set; }
}
