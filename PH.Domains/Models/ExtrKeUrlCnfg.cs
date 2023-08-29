using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ExtrKeUrlCnfg
{
    public int ExtrKeUrlCnfgId { get; set; }

    public string UrlCode { get; set; } = null!;

    public string BaseUrl { get; set; } = null!;

    public int Port { get; set; }

    public string EndPoint { get; set; } = null!;

    public string ProjName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Pswd { get; set; } = null!;

    public string RfrshTkn { get; set; } = null!;

    public string GrntType { get; set; } = null!;

    public string ClntId { get; set; } = null!;

    public string ClntScrt { get; set; } = null!;

    public string AppCode { get; set; } = null!;

    public string AppVrsn { get; set; } = null!;

    public string? Envr { get; set; }

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
