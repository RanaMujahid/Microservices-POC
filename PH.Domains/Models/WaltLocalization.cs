using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class WaltLocalization
{
    public long Id { get; set; }

    public string Key { get; set; } = null!;

    public string EngText { get; set; } = null!;

    public string ArbText { get; set; } = null!;

    public int? ScrnId { get; set; }

    public virtual Scrn? Scrn { get; set; }
}
