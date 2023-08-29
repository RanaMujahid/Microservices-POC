using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefRemt
{
    public long RemtId { get; set; }

    public string? PrimryMmbrCode { get; set; }

    public string? FmlyCode { get; set; }

    public decimal? Amnt { get; set; }

    public string? CmCode { get; set; }

    public int? CycleId { get; set; }

    public int? OrgId { get; set; }

    public int? PayedBy { get; set; }

    public string? SttsTypeCode { get; set; }

    public decimal? Fee { get; set; }

    public long? PaydLoctId { get; set; }

    public long? PaydMmbrId { get; set; }

    public string? AcctOfBenf { get; set; }

    public string? BenfGovrnt { get; set; }

    public string? BenfDistrct { get; set; }

    public string? BenfOzla { get; set; }

    public bool? IsPayedOffline { get; set; }

    public string? BenfVillg { get; set; }

    public int? PayedChnl { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Region { get; set; }

    public decimal? AmntSouth { get; set; }

    public virtual ICollection<UnicefRemtDocRevw> UnicefRemtDocRevws { get; set; } = new List<UnicefRemtDocRevw>();

    public virtual ICollection<UnicefRemtFlgOutReach> UnicefRemtFlgOutReaches { get; set; } = new List<UnicefRemtFlgOutReach>();

    public virtual ICollection<UnicefRemtOffLine> UnicefRemtOffLines { get; set; } = new List<UnicefRemtOffLine>();
}
