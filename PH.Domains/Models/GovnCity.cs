using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class GovnCity
{
    public int? AgntId { get; set; }

    public string? OldAgntCode { get; set; }

    public string? AgntNameLocal { get; set; }

    public string? BranchName { get; set; }

    public string? AgentCityAr { get; set; }

    public string? AgentCityEng { get; set; }

    public string? AgentGovernateAr { get; set; }

    public string? AgentGovernateEng { get; set; }

    public string? CityStatus { get; set; }

    public string? GvnStatus { get; set; }
}
