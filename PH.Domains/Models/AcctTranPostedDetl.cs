using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AcctTranPostedDetl
{
    public long AcctTranPostedId { get; set; }

    public long TranTypeId { get; set; }

    public int TranTypeCode { get; set; }

    public int IsPostedToAcctStts { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
