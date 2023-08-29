using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class VuchrTran
{
    public long VuchrTranId { get; set; }

    public string VuchrSeqno { get; set; } = null!;

    public long BpMainId { get; set; }

    public long TranTypeId { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public DateTime TranDate { get; set; }
}
