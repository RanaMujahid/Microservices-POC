using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Cust
{
    public long CustId { get; set; }

    public string FrstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string CustTypeId { get; set; } = null!;

    public string CertTypeId { get; set; } = null!;

    public string JobFildTypeId { get; set; } = null!;

    public string GndrId { get; set; } = null!;

    public string MrtlSttsId { get; set; } = null!;

    public DateTime DateOfBrth { get; set; }

    public string? JobTitl { get; set; }

    public string? PhonNmbr { get; set; }

    public string? WhtsAppNmbr { get; set; }

    public bool? AmcnNtly { get; set; }

    public string? Cmnt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CertType CertType { get; set; } = null!;

    public virtual CustType CustType { get; set; } = null!;

    public virtual GndrType Gndr { get; set; } = null!;

    public virtual JobFildType JobFildType { get; set; } = null!;

    public virtual MrtlSttsType MrtlStts { get; set; } = null!;
}
