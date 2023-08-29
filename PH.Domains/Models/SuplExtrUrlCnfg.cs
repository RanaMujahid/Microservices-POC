using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SuplExtrUrlCnfg
{
    public int SuplExtrUrlCnfgId { get; set; }

    public long SuplBpMainId { get; set; }

    public string BaseUrl { get; set; } = null!;

    public int? Port { get; set; }

    public string EndPoint { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Pswd { get; set; }

    public string? Envr { get; set; }

    public string? AuthTokn { get; set; }

    public string CommType { get; set; } = null!;

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
