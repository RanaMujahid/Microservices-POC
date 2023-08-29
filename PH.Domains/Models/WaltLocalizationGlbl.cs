using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class WaltLocalizationGlbl
{
    public long Id { get; set; }

    public string Key { get; set; } = null!;

    public string EngText { get; set; } = null!;

    public string ArbText { get; set; } = null!;

    public string? MsgType { get; set; }
}
