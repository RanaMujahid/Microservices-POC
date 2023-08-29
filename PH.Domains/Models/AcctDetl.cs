using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AcctDetl
{
    public long AcctDetlId { get; set; }

    public long AcctId { get; set; }

    public string FrstName { get; set; } = null!;

    public string MidlName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FmlyName { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string PhonNmbr { get; set; } = null!;

    public string Addr { get; set; } = null!;

    public string IdType { get; set; } = null!;

    public string IdNmbr { get; set; } = null!;

    public DateTime IdIssuDate { get; set; }

    public DateTime IdXpirDate { get; set; }

    public string CntyCode { get; set; } = null!;

    public string CityCode { get; set; } = null!;

    public string? GvrnCode { get; set; }

    public string? DistCode { get; set; }

    public string? OzlaCode { get; set; }

    public string? VilgCode { get; set; }

    public string Eml { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Acct Acct { get; set; } = null!;

    public virtual Cnty CntyCodeNavigation { get; set; } = null!;
}
