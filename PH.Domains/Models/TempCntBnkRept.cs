using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempCntBnkRept
{
    public long AcctTransactionId { get; set; }

    public string? Time { get; set; }

    public string AccountType { get; set; } = null!;

    public string? TransactionType { get; set; }

    public decimal Amount { get; set; }

    public string? Currency { get; set; }

    public DateTime? Date { get; set; }

    public string? SenderName { get; set; }

    public string SenderAccount { get; set; } = null!;

    public string RecieverName { get; set; } = null!;

    public string RecieverAccount { get; set; } = null!;

    public string? RelatedBranchToSender { get; set; }

    public string RelatedBranchToReciever { get; set; } = null!;
}
