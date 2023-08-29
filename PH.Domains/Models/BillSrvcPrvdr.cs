using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillSrvcPrvdr
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public decimal TaxCnfg { get; set; }

    public decimal AdvcTax { get; set; }

    public decimal HighLqdtyExtraFeePcnt { get; set; }

    public decimal MidLqdtyExtraFeePcnt { get; set; }

    public decimal LowLqdtyExtraFeePcnt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
