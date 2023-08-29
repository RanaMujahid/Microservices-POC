using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AuditLog
{
    public int Id { get; set; }

    public string? Level { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Url { get; set; }

    public string? Rqst { get; set; }

    public string? Rspns { get; set; }

    public DateTime? RqstTime { get; set; }

    public DateTime? RspnsTime { get; set; }

    public int? StatusCode { get; set; }

    public string? ClientIp { get; set; }
}
