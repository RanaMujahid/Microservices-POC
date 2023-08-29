using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CntctU
{
    public long CntctUsId { get; set; }

    public string Email { get; set; } = null!;

    public string Phon { get; set; } = null!;

    public string Msg { get; set; } = null!;

    public long UpldDocId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
