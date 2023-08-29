using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpAgentRemtTemp
{
    public long RemtId { get; set; }

    public string? FinaNumb { get; set; }

    public string? CardNumb { get; set; }

    public int BpMainId { get; set; }

    public int? BpSecdId { get; set; }

    public int CyclId { get; set; }

    public int CorpId { get; set; }
}
