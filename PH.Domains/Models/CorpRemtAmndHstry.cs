using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemtAmndHstry
{
    public long CorpRemtAmndHstryId { get; set; }

    public long CorpRemtId { get; set; }

    public string? RcvrName { get; set; }

    public string? MobNmbr { get; set; }

    public string? CardNmbr { get; set; }

    public string? Cmnt { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual CorpRemt CorpRemt { get; set; } = null!;
}
