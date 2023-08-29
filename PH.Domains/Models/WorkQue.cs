using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class WorkQue
{
    public long WorkQueId { get; set; }

    public string? RqstTypeCode { get; set; }

    public long? RqstId { get; set; }

    public string? RqstSttsTypeCode { get; set; }

    public int? MakrId { get; set; }

    public DateTime? MakrLastUpdtDate { get; set; }

    public string? MakrCmnt { get; set; }

    public int? ChkrId { get; set; }

    public DateTime? ChkrLastUpdtDate { get; set; }

    public string? RjctResnTypeCode { get; set; }

    public string? ChkrCmnt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpSysUser? Chkr { get; set; }

    public virtual BpSysUser? Makr { get; set; }

    public virtual RjctResnType? RjctResnTypeCodeNavigation { get; set; }

    public virtual RqstSttsType? RqstSttsTypeCodeNavigation { get; set; }

    public virtual RqstType? RqstTypeCodeNavigation { get; set; }

    public virtual ICollection<WorkQueHsty> WorkQueHsties { get; set; } = new List<WorkQueHsty>();
}
