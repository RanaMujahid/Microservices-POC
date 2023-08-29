using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AaCpyProd
{
    public long YmnNo { get; set; }

    public string YmnPackageSent { get; set; } = null!;

    public DateTime YmnDateSent { get; set; }

    public string? YmnPackageReceive { get; set; }

    public DateTime? YmnDateReceive { get; set; }

    public short YmnPackageType { get; set; }

    public bool YmnPackageState { get; set; }

    public string YmnBranchCode { get; set; } = null!;

    public long? YmnUserNo { get; set; }

    public decimal YmnAmountPaid { get; set; }

    public int YmnMobileNo { get; set; }

    public bool YmnSuccess { get; set; }

    public short YmnType { get; set; }

    public int YmnAcc { get; set; }

    public string? YmnCustName { get; set; }

    public DateTime? YmnTimestamp { get; set; }

    public int? YmnTaskId { get; set; }

    public decimal? YmnAmountPaidAll { get; set; }

    public string? YmnPackageSentXml { get; set; }

    public string? YmnPackageReceiveXml { get; set; }

    public string? YmnId { get; set; }

    public short? YmnResulteState { get; set; }

    public string? YmnNetworkType { get; set; }

    public short? YmnTypeEntry { get; set; }

    public string? ProEnterd { get; set; }

    public short? EmpEnterd { get; set; }

    public short? YmnExport { get; set; }

    public long? YmnCustAcc { get; set; }

    public int? YmnAttNo { get; set; }

    public long? YmnRef { get; set; }

    public short? YmnUserConf { get; set; }

    public string? SenderAccBrch { get; set; }

    public string? SenderAccNo { get; set; }

    public decimal? YmnCommission { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDescription { get; set; }

    public int? IsTimeOut { get; set; }

    public string? YmnOfferCode { get; set; }
}
