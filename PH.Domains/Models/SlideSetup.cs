using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SlideSetup
{
    public long SlideSetupId { get; set; }

    public string Title { get; set; } = null!;

    public string FrbseNodeId { get; set; } = null!;

    public string ImgFileName { get; set; } = null!;

    public string ImgFileLink { get; set; } = null!;

    public string? Txt { get; set; }

    public string Chnl { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<SlideDoc> SlideDocs { get; set; } = new List<SlideDoc>();
}
