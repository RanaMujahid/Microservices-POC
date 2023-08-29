using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserDesgType
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

    public virtual ICollection<ChldPrntDesgMap> ChldPrntDesgMapChldDesgNavigations { get; set; } = new List<ChldPrntDesgMap>();

    public virtual ICollection<ChldPrntDesgMap> ChldPrntDesgMapPrntDesgNavigations { get; set; } = new List<ChldPrntDesgMap>();

    public virtual ICollection<RqstAprvDesg> RqstAprvDesgs { get; set; } = new List<RqstAprvDesg>();

    public virtual ICollection<UserDesgDetl> UserDesgDetls { get; set; } = new List<UserDesgDetl>();

    public virtual ICollection<UserDesgHrcy> UserDesgHrcyChldDesgCodeNavigations { get; set; } = new List<UserDesgHrcy>();

    public virtual ICollection<UserDesgHrcy> UserDesgHrcyPrntDesgCodeNavigations { get; set; } = new List<UserDesgHrcy>();
}
