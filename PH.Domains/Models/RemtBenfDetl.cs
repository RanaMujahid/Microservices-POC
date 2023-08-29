using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RemtBenfDetl
{
    public long RemtBenfDeltId { get; set; }

    public long RemtId { get; set; }

    public string? FrstName { get; set; }

    public string? MidlName { get; set; }

    public string? LastName { get; set; }

    public string? FmlyName { get; set; }

    public string? MoblNo { get; set; }

    public string? IdTypeCode { get; set; }

    public string? IdNo { get; set; }

    public DateTime? IdIsueDate { get; set; }

    public DateTime? IdExpDate { get; set; }

    public string? PlacOfIsue { get; set; }

    public virtual Remt Remt { get; set; } = null!;
}
