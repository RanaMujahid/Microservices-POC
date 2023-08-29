using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempPaymentSite
{
    public string? WrongSiteNumber { get; set; }

    public string? CorrectSiteNumber { get; set; }
}
