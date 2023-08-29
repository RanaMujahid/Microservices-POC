using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class NotifyAdncLog
{
    public long NotifyAdncLogId { get; set; }

    public long NotifySetupId { get; set; }

    public int? SucessCount { get; set; }

    public int? FailedCount { get; set; }

    public string? NotifyFailedResp { get; set; }

    public DateTime Logged { get; set; }
}
