using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Scrn
{
    public int ScrnId { get; set; }

    public string ScrnName { get; set; } = null!;

    public string? ScrnDesc { get; set; }

    public string AppCode { get; set; } = null!;

    public virtual ICollection<WaltLocalization> WaltLocalizations { get; set; } = new List<WaltLocalization>();
}
