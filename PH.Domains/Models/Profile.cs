using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Profile
{
    public string ProNameAr { get; set; } = null!;

    public string ProNameEn { get; set; } = null!;

    public string ProAdrsAr { get; set; } = null!;

    public string ProAdrsEn { get; set; } = null!;

    public string ProCode { get; set; } = null!;

    public int? GrpNo { get; set; }

    public string? AdrsCode { get; set; }

    public string? ProInTimeMin1 { get; set; }

    public string? ProInTimeHrs1 { get; set; }

    public string? ProOutTimeMin1 { get; set; }

    public string? ProOutTimeHrs1 { get; set; }

    public string? ProInTimeMin2 { get; set; }

    public string? ProInTimeHrs2 { get; set; }

    public string? ProOutTimeMin2 { get; set; }

    public string? ProOutTimeHrs2 { get; set; }

    public DateTime ProDate { get; set; }

    public int? ProState { get; set; }

    public double? ProTel1 { get; set; }

    public double? ProTel2 { get; set; }

    public double? ProFax { get; set; }

    public string? ProBobox { get; set; }

    public string? ProEmail { get; set; }

    public int ProType { get; set; }

    public string? ProMainCode { get; set; }

    public string? ProWebSite { get; set; }

    public string? ProPassword { get; set; }

    public string? ProPasswordEnc { get; set; }

    public string? ProLoginState { get; set; }

    public double? ProAmount { get; set; }

    public string? ProUsername { get; set; }

    public string? ProUsernameEnc { get; set; }

    public int ProTypeComm { get; set; }

    public decimal? ProAmountComm { get; set; }

    public string? ProConfPass { get; set; }

    public string? ProConfPassEnc { get; set; }

    public string? ProCheckPass { get; set; }

    public string? ProGroupAcc { get; set; }

    public int? ProTyepIn { get; set; }

    public int? ProAgentType { get; set; }

    public int? ProLocation { get; set; }

    public int? ProUserType { get; set; }

    public int ProDownload { get; set; }

    public int? ProServiceSp { get; set; }

    public int GeneralComm { get; set; }

    public DateTime? ProPasswordFinsh { get; set; }

    public int ProMultiCurr { get; set; }

    public bool ProUserState { get; set; }

    public int ProPerYr { get; set; }

    public decimal ProPerCurr { get; set; }

    public string ProIpadress { get; set; } = null!;

    public bool ProChange { get; set; }

    public int ProUser { get; set; }

    public int Dbused { get; set; }

    public int ProGover { get; set; }

    public int ProNo { get; set; }

    public string? UseVersion { get; set; }

    public string? ProComment { get; set; }

    public int ProCurrRate { get; set; }

    public int ProCityNo { get; set; }

    public int ProCostCenterNo { get; set; }

    public decimal ProPremium { get; set; }

    public decimal ProAmountTransFer { get; set; }

    public string? L { get; set; }

    public short ProChangeCurrablity { get; set; }

    public short ProTypePrinter { get; set; }

    public short ProChangeCurrablitySale { get; set; }

    public decimal ProAllowAmount { get; set; }

    public short ProRistrictSell { get; set; }

    public short ProPrintCurBill { get; set; }

    public short ProCollectAmountExchange { get; set; }

    public int ProOfficeType { get; set; }

    public short? ProSysUsing { get; set; }

    public short TransSaveState { get; set; }

    public short? ProReportHeader { get; set; }

    public short ProFinger { get; set; }

    public decimal ProMaxExchangAmount { get; set; }

    public decimal ProAllowBuy { get; set; }

    public short ProCity { get; set; }

    public short ProPrintAfter { get; set; }

    public DateTime ProFinishContract { get; set; }

    public short ProCountUsers { get; set; }

    public short ProGrpDeposit { get; set; }

    public decimal ProAmountDeposit { get; set; }

    public short ProPeriodSell { get; set; }

    public string? ProCord { get; set; }

    public short ProCurrRec { get; set; }

    public short ProGrpPriv { get; set; }

    public short ProFluidityType { get; set; }

    public short ProClass { get; set; }

    public short ProOpertype { get; set; }

    public short ProPayUnicef { get; set; }

    public short ProAllowExt { get; set; }

    public string? FlgEnglishName { get; set; }
}
