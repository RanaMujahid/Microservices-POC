using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Flag
{
    public int FlgNo { get; set; }

    public string FlgName { get; set; } = null!;

    public string FlgEname { get; set; } = null!;

    public decimal FlgTypeValue { get; set; }

    public string FlgDesc { get; set; } = null!;

    public int FlgUser { get; set; }

    public bool FlgChange { get; set; }

    public short FlgType { get; set; }
}
