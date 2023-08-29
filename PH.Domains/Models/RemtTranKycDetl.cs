using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RemtTranKycDetl
{
    public long RemtTranId { get; set; }

    public int KycSetId { get; set; }

    public int KycAttrId { get; set; }

    public string KycAttrName { get; set; } = null!;

    public string? KycAttrVal { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual KycAttr KycAttr { get; set; } = null!;

    public virtual KycSet KycSet { get; set; } = null!;
}
