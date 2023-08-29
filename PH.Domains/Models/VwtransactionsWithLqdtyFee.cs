using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class VwtransactionsWithLqdtyFee
{
    public long Trantypeid { get; set; }

    public int? Trasactiontype { get; set; }

    public string? Walltacctnum { get; set; }

    public string? Creditaccount { get; set; }

    public string? Name { get; set; }

    public decimal? Amnt { get; set; }

    public decimal? Fee { get; set; }

    public decimal? Lqdtyfee { get; set; }

    public string Senderbrnchname { get; set; } = null!;

    public string Receiverbranchname { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string AcctType { get; set; } = null!;
}
