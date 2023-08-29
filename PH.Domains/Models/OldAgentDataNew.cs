using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OldAgentDataNew
{
    public int UsrNo { get; set; }

    public string UsrPassword { get; set; } = null!;

    public string UsrSalt { get; set; } = null!;

    public long? UsrAgent { get; set; }

    public int UsrGroup { get; set; }

    public int UsrState { get; set; }

    public decimal UsrAmount { get; set; }

    public DateTime? UsrPasswordFinish { get; set; }

    public int UsrUserActive { get; set; }

    public int UsrTryLogin { get; set; }

    public bool Usr1stTime { get; set; }

    public DateTime UsrStopTime { get; set; }

    public DateTime? UsrAddDatetime { get; set; }

    public string UsrName { get; set; } = null!;

    public long UsrUser { get; set; }

    public int UsrChange { get; set; }

    public string UsrLoginhash { get; set; } = null!;

    public string? DeviceId { get; set; }

    public bool IsMobileActive { get; set; }
}
