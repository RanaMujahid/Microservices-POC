using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempTableToAdjustDatum
{
    public decimal? TotalRemittanceAmount { get; set; }

    public int? NumberOfRemittanceForTheAccount { get; set; }

    public decimal? AmountForAgentAfterDeductingInsuranace { get; set; }

    public decimal? CurrentAvailbaleBalanceInAgentAccount { get; set; }

    public decimal? TransferredAmount { get; set; }

    public decimal? AmountToBeAdjusted { get; set; }

    public string? AccountNumber { get; set; }
}
