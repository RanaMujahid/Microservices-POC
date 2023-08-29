using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class DbLog
{
    public string? DbErrorLine { get; set; }

    public string? DbErrorMessage { get; set; }

    public string? DbErrorNumber { get; set; }

    public string? DbErrorProcedure { get; set; }

    public string? DbErrorSeverity { get; set; }

    public string? DbErrorState { get; set; }

    public string? Comments { get; set; }

    public int Dblogid { get; set; }

    public DateTime? Createdate { get; set; }
}
