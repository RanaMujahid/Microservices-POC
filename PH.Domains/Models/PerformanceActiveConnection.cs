using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PerformanceActiveConnection
{
    public string? Dbname { get; set; }

    public int? NumberOfConnections { get; set; }

    public string Loginame { get; set; } = null!;

    public DateTime TimeOfReading { get; set; }
}
