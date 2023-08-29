using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SupportRemtInssDetl
{
    public long RemtInssDetl { get; set; }

    public long RemtId { get; set; }

    public decimal InssAmnt { get; set; }

    public bool IsReFund { get; set; }

    public DateTime? TranDate { get; set; }

    public int AgntId { get; set; }

    public long? InssReqId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
