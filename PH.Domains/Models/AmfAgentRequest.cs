using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AmfAgentRequest
{
    public int ReqNo { get; set; }

    public DateTime ReqDate { get; set; }

    public int CustNo { get; set; }

    public int AccNo { get; set; }

    public int AmfCustNo { get; set; }

    public long ReqAgentTel { get; set; }

    public long ReqAgentMobile { get; set; }

    public string? ReqRCNo { get; set; }

    public short ReqHasActivity { get; set; }

    public short ReqShopType { get; set; }

    public short ReqShopCustDaily { get; set; }

    public short ReqAgentPossibilities { get; set; }

    public string? ReqActivityName { get; set; }

    public short? ReqActivityType { get; set; }

    public short? ReqActivityAge { get; set; }

    public short ReqAgentType { get; set; }

    public string ReqPointService { get; set; } = null!;

    public short ReqPaidInsurance { get; set; }

    public decimal ReqAmountInsurance { get; set; }

    public short? ReqActivityPlace { get; set; }

    public short ReqGover { get; set; }

    public short ReqModereyah { get; set; }

    public short ReqOzlah { get; set; }

    public string ReqIdentfireFst { get; set; } = null!;

    public short ReqIdentfireFstEpithet { get; set; }

    public long ReqIdentfireFstMobile { get; set; }

    public string? ReqIdentfire2nd { get; set; }

    public short? ReqIdentfire2ndEpithet { get; set; }

    public long? ReqIdentfire2ndMobile { get; set; }

    public string? ReqIdentfire3rd { get; set; }

    public short? ReqIdentfire3rdEpithet { get; set; }

    public long? ReqIdentfire3rdMobile { get; set; }

    public DateTime ReqDateTimeEntry { get; set; }

    public int? ReqUsrEntry { get; set; }

    public int ReqUsrConf { get; set; }

    public string? ReqBranchEntry { get; set; }

    public int? ReqAtt { get; set; }

    public string ReqComments { get; set; } = null!;

    public string ReqAgentName { get; set; } = null!;

    public short AmfState { get; set; }

    public string? ReqAgentAdd { get; set; }

    public short ReqCountUsr { get; set; }

    public short ReqType { get; set; }

    public string ReqBranchJoin { get; set; } = null!;

    public short ReqFee { get; set; }

    public string ReqMarkInStreet { get; set; } = null!;

    public string ReqMarkInVillage { get; set; } = null!;

    public string ReqStreet { get; set; } = null!;

    public string ReqQuarter { get; set; } = null!;

    public string ReqCity { get; set; } = null!;

    public short ReqCustSeat { get; set; }

    public DateTime ReqConfDate { get; set; }

    public short AmfCasheir { get; set; }

    public string ReqAddress { get; set; } = null!;

    public short ReqHaseb { get; set; }

    public int ReqGamConf { get; set; }

    public int ReqAttCan { get; set; }

    public int ReqUsrCancel { get; set; }

    public int ReqUsrConfCancel { get; set; }

    public DateTime ReqConfdateCancel { get; set; }

    public int ReqUsrUpd { get; set; }

    public int ReqUsrConfUpd { get; set; }

    public int AccNoNew { get; set; }

    public int CustNoNew { get; set; }

    public short ReqWasHaseb { get; set; }

    public int ReqAgentAccount { get; set; }

    public short ReqActiveGroup { get; set; }

    public short ReqShopType1 { get; set; }

    public int? ReqUsrChange { get; set; }

    public DateTime ReqUsrDatechange { get; set; }

    public short AmfUnicefPrint { get; set; }
}
