using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ErrorLog
{
    public int Id { get; set; }

    public string? Level { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Exception { get; set; }

    public string? Url { get; set; }

    public int? StatusCode { get; set; }
}
