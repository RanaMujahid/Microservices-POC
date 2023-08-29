using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillPymtRvrslErrorLog
{
    public int? ErrorNumber { get; set; }

    public int? ErrorState { get; set; }

    public int? ErrorSeverity { get; set; }

    public string? ErrorProcedure { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }
}
