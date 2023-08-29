using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class NewsAdnc
{
    public long NewsAdncId { get; set; }

    public long NewsSetupId { get; set; }

    public string WaltAcctNmbr { get; set; } = null!;

    public bool IsRead { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual NewsSetup NewsSetup { get; set; } = null!;
}
