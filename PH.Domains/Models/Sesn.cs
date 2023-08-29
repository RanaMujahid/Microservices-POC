using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Sesn
{
    public long SessionId { get; set; }

    public string? SessionCde { get; set; }

    public string? SessionIp { get; set; }

    public string? DnsNme { get; set; }

    public DateTime? LogOnDte { get; set; }

    public DateTime? LogOffDte { get; set; }

    public long? UserId { get; set; }

    public long BpId { get; set; }

    public long BpScndryId { get; set; }

    public string? LangCode { get; set; }

    public bool? IsActive { get; set; }
}
