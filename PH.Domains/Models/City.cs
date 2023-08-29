using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class City
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public string CntyId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cnty Cnty { get; set; } = null!;

    public virtual ICollection<CustAddr> CustAddrs { get; set; } = new List<CustAddr>();

    public virtual ICollection<RegnCity> RegnCities { get; set; } = new List<RegnCity>();
}
