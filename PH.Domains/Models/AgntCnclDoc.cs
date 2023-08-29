using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntCnclDoc
{
    public long AgntCnclDocId { get; set; }

    public long UpldDocId { get; set; }

    public long AgntCnclReqId { get; set; }

    public string DocType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual AgntCnclReq AgntCnclReq { get; set; } = null!;
}
