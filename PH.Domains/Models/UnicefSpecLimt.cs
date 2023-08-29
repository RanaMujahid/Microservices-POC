using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefSpecLimt
{
    public int UnicefSpecLimtId { get; set; }

    public long AgntBpMainId { get; set; }

    public int TranCount { get; set; }

    public int LoctId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
