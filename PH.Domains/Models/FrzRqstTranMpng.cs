using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FrzRqstTranMpng
{
    public long FrzRqstTranMpngId { get; set; }

    public string FrzReqTypeCode { get; set; } = null!;

    public int TranTypeCode { get; set; }

    public int ChnlId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Chnl Chnl { get; set; } = null!;

    public virtual FrzReqType FrzReqTypeCodeNavigation { get; set; } = null!;
}
