using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemt
{
    public long CorpRemtId { get; set; }

    public int CorpId { get; set; }

    public int CorpCyclId { get; set; }

    public string? CardNmbr { get; set; }

    public string? FinaNmbr { get; set; }

    public string? RcvrName { get; set; }

    public string? SndrName { get; set; }

    public decimal? Amnt { get; set; }

    public string? Cmnt { get; set; }

    public string? MobNumb { get; set; }

    public long? PaydBpmainId { get; set; }

    public long? PaydLoctId { get; set; }

    public int? PayedChnl { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public bool? IsPayedOffline { get; set; }

    public DateTime? PayedOfflineDate { get; set; }

    public string? PrpdBrchCode { get; set; }

    public long? PrpdAgntBpMainId { get; set; }

    public string? PaidBrchCode { get; set; }

    public string? SendLqdty { get; set; }

    public string? RecvLqdty { get; set; }

    public string? CalcLqdty { get; set; }

    public string? T24RefNo { get; set; }

    public string? T24UserId { get; set; }

    public string? SerlNo { get; set; }

    public string? IdType { get; set; }

    public string? PrjtNme { get; set; }

    public string? Ref { get; set; }

    public string? Addr { get; set; }

    public string? TrsfrCndtn { get; set; }

    public string? AltName { get; set; }

    public string? AltIdType { get; set; }

    public string? AltIdNum { get; set; }

    public string? SmsMsg { get; set; }

    public string? ExtraClmn1 { get; set; }

    public string? ExtraClmn2 { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Corp Corp { get; set; } = null!;

    public virtual CorpCycl CorpCycl { get; set; } = null!;

    public virtual ICollection<CorpDoc> CorpDocs { get; set; } = new List<CorpDoc>();

    public virtual ICollection<CorpRemtAmndHstry> CorpRemtAmndHstries { get; set; } = new List<CorpRemtAmndHstry>();

    public virtual ICollection<CorpRemtDetl> CorpRemtDetls { get; set; } = new List<CorpRemtDetl>();

    public virtual ICollection<CorpRemtHstry> CorpRemtHstries { get; set; } = new List<CorpRemtHstry>();

    public virtual ICollection<CorpRemtInssDetl> CorpRemtInssDetls { get; set; } = new List<CorpRemtInssDetl>();

    public virtual BpSysUser? CreatedByNavigation { get; set; }

    public virtual BpMain? PaydBpmain { get; set; }

    public virtual CorpLoct? PaydLoct { get; set; }

    public virtual BpSysUser? UpdatedByNavigation { get; set; }
}
