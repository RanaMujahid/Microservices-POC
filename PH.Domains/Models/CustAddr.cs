using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CustAddr
{
    public long AddrId { get; set; }

    public long CustId { get; set; }

    public string CityId { get; set; } = null!;

    public string CntyId { get; set; } = null!;

    public string StrtAddr { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Cnty Cnty { get; set; } = null!;
}
