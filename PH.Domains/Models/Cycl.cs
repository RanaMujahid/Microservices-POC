using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Cycl
{
    public int CyclId { get; set; }

    public string CyclName { get; set; } = null!;

    public string? CyclNameLocal { get; set; }

    public string? CyclDesc { get; set; }

    public string? Status { get; set; }

    public string? OrgCode { get; set; }

    public DateTime? StrtDate { get; set; }

    public DateTime? ExpDate { get; set; }

    public decimal? CommBlckPerc { get; set; }

    public decimal? TotAmnt { get; set; }

    public int? TotFee { get; set; }

    public int? TotMainFile { get; set; }

    public int? TotMembFile { get; set; }

    public int? TotRemi { get; set; }

    public decimal? FixdLocFee { get; set; }

    public decimal? FixdLocComi { get; set; }

    public decimal? MoblLocFee { get; set; }

    public decimal? MoblLocComi { get; set; }

    public string? CyclProcStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? OutReachEndDate { get; set; }

    public virtual ICollection<EtiBenProf> EtiBenProfs { get; set; } = new List<EtiBenProf>();

    public virtual RqstSttsType? StatusNavigation { get; set; }

    public virtual ICollection<UnicefBenPstd> UnicefBenPstds { get; set; } = new List<UnicefBenPstd>();

    public virtual ICollection<UnicefBenToPost> UnicefBenToPosts { get; set; } = new List<UnicefBenToPost>();

    public virtual ICollection<UnicefCyclFlag> UnicefCyclFlags { get; set; } = new List<UnicefCyclFlag>();
}
