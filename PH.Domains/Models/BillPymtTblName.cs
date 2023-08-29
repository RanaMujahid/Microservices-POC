using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillPymtTblName
{
    public string TnanTypeCode { get; set; } = null!;

    public string BillTablName { get; set; } = null!;

    public string TranIdCol { get; set; } = null!;
}
