using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class LdgrSyncJobHstry
{
    public long LdgrSyncJobHstryId { get; set; }

    public long TranTypeId { get; set; }

    public int TranTypeCode { get; set; }

    public DateTime SyncDate { get; set; }
}
