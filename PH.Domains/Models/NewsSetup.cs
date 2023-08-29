using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class NewsSetup
{
    public long NewsSetupId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public string NewsLink { get; set; } = null!;

    public string Chnl { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<NewsAdnc> NewsAdncs { get; set; } = new List<NewsAdnc>();

    public virtual ICollection<NewsDoc> NewsDocs { get; set; } = new List<NewsDoc>();
}
