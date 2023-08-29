using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntLoct
{
    public long LoctId { get; set; }

    public string LoctName { get; set; } = null!;

    public int AgntId { get; set; }

    public string GvrnCode { get; set; } = null!;

    public string DistCode { get; set; } = null!;

    public string OzlaCode { get; set; } = null!;

    public string VilgCode { get; set; } = null!;

    public string? OldSiteCode { get; set; }

    public string? SiteCode { get; set; }

    public string LoctType { get; set; } = null!;

    public string LoctStts { get; set; } = null!;

    public string LatiTude { get; set; } = null!;

    public string LngiTude { get; set; } = null!;

    public string? StfMaleCshr { get; set; }

    public string? StfFmalCshr { get; set; }

    public string? StfMaleScrOfic { get; set; }

    public string? StfFmalScrOfic { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LoctStrtDate { get; set; }

    public DateTime? LoctXpirDate { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SchlName { get; set; }

    public int? AllwdSubuserCnt { get; set; }

    public virtual ICollection<AgntAsgnLoct> AgntAsgnLocts { get; set; } = new List<AgntAsgnLoct>();

    public virtual ICollection<AgntLoctDoc> AgntLoctDocs { get; set; } = new List<AgntLoctDoc>();
}
