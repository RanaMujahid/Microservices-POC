using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UpgrdeMfloosAcct
{
    public long UpgrdeMfloosAcctId { get; set; }

    public long AcctId { get; set; }

    public long OldProdId { get; set; }

    public long NewProdId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
