using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CpnyStng
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string FileSrvr { get; set; } = null!;

    public DateTime ProcDate { get; set; }
}
