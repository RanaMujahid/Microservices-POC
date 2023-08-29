using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class QrMain
{
    public long QrMainId { get; set; }

    public string QrTypeCode { get; set; } = null!;

    public long? DocId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsExport { get; set; }

    public int? ChnlTypeCode { get; set; }

    public virtual ICollection<QrAgntDetl> QrAgntDetls { get; set; } = new List<QrAgntDetl>();

    public virtual ICollection<QrCashrDetl> QrCashrDetls { get; set; } = new List<QrCashrDetl>();

    public virtual QrType QrTypeCodeNavigation { get; set; } = null!;
}
