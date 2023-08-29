using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntPrftRvsl
{
    public int AgntPrftRvslId { get; set; }

    public string WaltAcctNmbr { get; set; } = null!;

    public decimal MoneyDeduct { get; set; }

    public decimal AvblBlnc { get; set; }

    public long TranTypeId { get; set; }

    public int TranTypeCode { get; set; }

    public bool IsRvrsd { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
