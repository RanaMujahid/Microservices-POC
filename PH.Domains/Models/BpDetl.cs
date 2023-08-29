using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BpDetl
{
    public int BpDetlId { get; set; }

    public long BpMainId { get; set; }

    public string FrstName { get; set; } = null!;

    public string? MddlName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Addr { get; set; }

    public string Phon { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Eml { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FmlyName { get; set; }

    public string? IdType { get; set; }

    public string? IdNmbr { get; set; }

    public DateTime? IdIssuDate { get; set; }

    public DateTime? IdXpirDate { get; set; }

    public string? CntyCode { get; set; }

    public string? CityCode { get; set; }

    public string? GvrnCode { get; set; }

    public string? DistCode { get; set; }

    public string? OzlaCode { get; set; }

    public string? VilgCode { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;
}
