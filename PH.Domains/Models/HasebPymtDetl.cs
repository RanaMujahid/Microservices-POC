using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class HasebPymtDetl
{
    public long HasebPymtDetlId { get; set; }

    public long HasebPymtId { get; set; }

    public int HasebPointNmbr { get; set; }

    public string? CashrCode { get; set; }

    public int? CashrSeqncNmbr { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
