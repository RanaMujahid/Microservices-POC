using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefMmbr
{
    public long MmbrId { get; set; }

    public string? FmlyCode { get; set; }

    public string? MmbrCode { get; set; }

    public string? MmbrName { get; set; }

    public string? MmbrGndrCode { get; set; }

    public string? IdNum { get; set; }

    public string? OldIdNo { get; set; }

    public string? ElectrolIdNo { get; set; }

    public string? PsprtNo { get; set; }

    public string? BrthCrtfctNo { get; set; }

    public string? StdntSeatNo { get; set; }

    public string? MargContNo { get; set; }

    public string? FmlyCardNo { get; set; }

    public string? CviFormNo { get; set; }

    public int? CycleId { get; set; }

    public string? DisabledCariedNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CmCode { get; set; }
}
