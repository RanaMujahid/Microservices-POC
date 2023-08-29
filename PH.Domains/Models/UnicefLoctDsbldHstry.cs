using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefLoctDsbldHstry
{
    public long UnicefLoctDsbldHstryId { get; set; }

    public int CyclId { get; set; }

    public string GvrnOldCode { get; set; } = null!;

    public string DistOldCode { get; set; } = null!;

    public string OzlaOldCode { get; set; } = null!;

    public string VilgOldCode { get; set; } = null!;

    public int RemtCount { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }
}
