using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class DpstFileUpldDoc
{
    public int DpstFileUpldDocId { get; set; }

    public long UpldDocId { get; set; }

    public string AprvStts { get; set; } = null!;

    public long PrfmrId { get; set; }

    public decimal Fee { get; set; }

    public bool IsPrcnt { get; set; }

    public bool IsFeeDedctd { get; set; }

    public int TotlWallets { get; set; }

    public decimal TotlAmnt { get; set; }

    public decimal TotlFee { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UpldDocDetl UpldDoc { get; set; } = null!;
}
