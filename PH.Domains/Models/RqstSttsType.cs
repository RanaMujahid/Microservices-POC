using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RqstSttsType
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Acct> Accts { get; set; } = new List<Acct>();

    public virtual ICollection<BsnsPrtn> BsnsPrtns { get; set; } = new List<BsnsPrtn>();

    public virtual ICollection<Chnl> Chnls { get; set; } = new List<Chnl>();

    public virtual ICollection<CmsnPrfl> CmsnPrfls { get; set; } = new List<CmsnPrfl>();

    public virtual ICollection<Cycl> Cycls { get; set; } = new List<Cycl>();

    public virtual ICollection<Fee> Fees { get; set; } = new List<Fee>();

    public virtual ICollection<KycAttr> KycAttrs { get; set; } = new List<KycAttr>();

    public virtual ICollection<KycSet> KycSets { get; set; } = new List<KycSet>();

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    public virtual ICollection<Tran> Trans { get; set; } = new List<Tran>();

    public virtual ICollection<WorkQue> WorkQues { get; set; } = new List<WorkQue>();
}
