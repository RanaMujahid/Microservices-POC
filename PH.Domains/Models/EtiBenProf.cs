using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EtiBenProf
{
    public long BenProfId { get; set; }

    public string? FrstName { get; set; }

    public string? MidlName { get; set; }

    public string? LastName { get; set; }

    public string? FmlyName { get; set; }

    public string? PhonNumb { get; set; }

    public string BenVeriCode { get; set; } = null!;

    public DateTime? BenDob { get; set; }

    public string? BenPlceOfBrth { get; set; }

    public string? BenAdrs { get; set; }

    public string? BenIdType { get; set; }

    public string? BenIdNumb { get; set; }

    public DateTime? BenIdIssueDate { get; set; }

    public DateTime? BenIdExpiryDate { get; set; }

    public int? LastUpdtCycleId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cycl? LastUpdtCycle { get; set; }
}
