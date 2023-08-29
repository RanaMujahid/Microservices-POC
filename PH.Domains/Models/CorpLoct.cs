using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpLoct
{
    public long CorpLoctId { get; set; }

    public string LoctName { get; set; } = null!;

    public string? LoctNameLoc { get; set; }

    public long? BpMainId { get; set; }

    public string? GvrnCode { get; set; }

    public string? DistCode { get; set; }

    public string? OzlaCode { get; set; }

    public string? VilgCode { get; set; }

    public string? OldSiteCode { get; set; }

    public string? SiteCode { get; set; }

    public string? LoctType { get; set; }

    public string? LatiTude { get; set; }

    public string? LngiTude { get; set; }

    public int? MaleCshr { get; set; }

    public int? FmalCshr { get; set; }

    public int? MaleStaf { get; set; }

    public int? FmalStaf { get; set; }

    public long? ImagDocId { get; set; }

    public DateTime? StrtDate { get; set; }

    public DateTime? ExpirDate { get; set; }

    public string? AprvStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain? BpMain { get; set; }

    public virtual ICollection<CorpLoctActv> CorpLoctActvs { get; set; } = new List<CorpLoctActv>();

    public virtual ICollection<CorpRemt> CorpRemts { get; set; } = new List<CorpRemt>();

    public virtual Dist? DistCodeNavigation { get; set; }

    public virtual Gvrn? GvrnCodeNavigation { get; set; }

    public virtual UpldDocDetl? ImagDoc { get; set; }

    public virtual Ozla? OzlaCodeNavigation { get; set; }

    public virtual Vilg? VilgCodeNavigation { get; set; }
}
