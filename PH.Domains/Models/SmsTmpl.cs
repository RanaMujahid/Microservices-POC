using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SmsTmpl
{
    public int SmsTmplId { get; set; }

    public string? OprtTypeCode { get; set; }

    public string? CustSms { get; set; }

    public string? CustSmsLocal { get; set; }

    public string? SendSms { get; set; }

    public string? SendSmsLocal { get; set; }

    public string? RecvSms { get; set; }

    public string? RecvSmsLocal { get; set; }

    public string? AgntSms { get; set; }

    public string? AgntSmsLocal { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CustSmsTmplType { get; set; }

    public string? SendSmsTmplType { get; set; }

    public string? RecvSmsTmplType { get; set; }

    public string? AgntSmsTmplType { get; set; }

    public virtual SmsOprtType? OprtTypeCodeNavigation { get; set; }
}
