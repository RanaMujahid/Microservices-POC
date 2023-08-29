using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PosetMessage
{
    public int PmNo { get; set; }

    public string PmName { get; set; } = null!;

    public string PmBranch { get; set; } = null!;

    public bool PmPosted { get; set; }

    public long PmExpress { get; set; }

    public int PmType { get; set; }

    public DateTime? PmDate { get; set; }

    public string? PmComment { get; set; }

    public long Sno { get; set; }

    public string? PmGetType { get; set; }

    public string? PmRepId { get; set; }

    public DateTime? PmDatePosted { get; set; }

    public DateTime? PmDatePostedEnd { get; set; }

    public short PmMessageSent { get; set; }
}
