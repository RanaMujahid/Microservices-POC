using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefBlkdRemi
{
    public long UnicefBlkdRemiId { get; set; }

    public long? BpMainId { get; set; }

    public long? BpSecdId { get; set; }

    public long? RemtId { get; set; }

    public bool? IsDownloaded { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
