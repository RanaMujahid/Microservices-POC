using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefRemtFlg
{
    public long RetmFlgId { get; set; }

    public long RemtId { get; set; }

    public int? CycleId { get; set; }

    public int? OrgId { get; set; }

    public bool? FlgNoPymt { get; set; }

    public bool? FlgReqCm { get; set; }

    public bool? ElectrncPymtFlg { get; set; }

    public bool? FlgOutReach { get; set; }
}
