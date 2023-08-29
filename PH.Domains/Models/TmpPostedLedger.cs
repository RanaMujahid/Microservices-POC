using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TmpPostedLedger
{
    public long TranTypeId { get; set; }

    public DateTime? TranDate { get; set; }
}
