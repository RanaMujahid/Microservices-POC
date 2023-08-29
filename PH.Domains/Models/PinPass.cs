using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PinPass
{
    public int PinPassId { get; set; }

    public string PinPass1 { get; set; } = null!;

    public long BpMainId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsOfln { get; set; }
}
