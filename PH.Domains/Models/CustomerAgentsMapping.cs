using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CustomerAgentsMapping
{
    public int WalltAccountNumber { get; set; }

    public int? CustomerUserId { get; set; }

    public string? CustomerName { get; set; }

    public int OldAgentCode { get; set; }

    public string? AgentUsername { get; set; }

    public int? AgentUserid { get; set; }
}
