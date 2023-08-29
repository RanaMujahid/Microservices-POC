using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class T24Branch
{
    public string OldBrchCode { get; set; } = null!;

    public int Dao { get; set; }

    public string Name { get; set; } = null!;

    public string ZoneCode { get; set; } = null!;

    public int DeptParent { get; set; }
}
