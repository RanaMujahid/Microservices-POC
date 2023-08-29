using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtZoneToZone
{
    public long EPymtZoneToZoneId { get; set; }

    public long SuplBpMainId { get; set; }

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal LqdtyFee { get; set; }

    public int FrmZoneId { get; set; }

    public string? FrmLqdty { get; set; }

    public int ToZoneId { get; set; }

    public string? ToLqdty { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }
}
