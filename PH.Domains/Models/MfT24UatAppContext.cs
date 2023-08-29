using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PH.Domains.Models;

public partial class MfT24UatAppContext : DbContext
{
    public MfT24UatAppContext()
    {
    }

    public MfT24UatAppContext(DbContextOptions<MfT24UatAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AaCpyProd> AaCpyProds { get; set; }

    public virtual DbSet<AaYemennet> AaYemennets { get; set; }

    public virtual DbSet<Acct> Accts { get; set; }

    public virtual DbSet<Acct31122021> Acct31122021s { get; set; }

    public virtual DbSet<AcctBeforeVip> AcctBeforeVips { get; set; }

    public virtual DbSet<AcctDetl> AcctDetls { get; set; }

    public virtual DbSet<AcctDoc> AcctDocs { get; set; }

    public virtual DbSet<AcctKycDetl> AcctKycDetls { get; set; }

    public virtual DbSet<AcctLvl> AcctLvls { get; set; }

    public virtual DbSet<AcctOpngBlnc> AcctOpngBlncs { get; set; }

    public virtual DbSet<AcctSubType> AcctSubTypes { get; set; }

    public virtual DbSet<AcctTran> AcctTrans { get; set; }

    public virtual DbSet<AcctTranPostedDetl> AcctTranPostedDetls { get; set; }

    public virtual DbSet<AcctType> AcctTypes { get; set; }

    public virtual DbSet<AcmdType> AcmdTypes { get; set; }

    public virtual DbSet<Agnt> Agnts { get; set; }

    public virtual DbSet<Agnt31122021> Agnt31122021s { get; set; }

    public virtual DbSet<AgntActv> AgntActvs { get; set; }

    public virtual DbSet<AgntActvDetl> AgntActvDetls { get; set; }

    public virtual DbSet<AgntActvType> AgntActvTypes { get; set; }

    public virtual DbSet<AgntAlwdCrcy> AgntAlwdCrcies { get; set; }

    public virtual DbSet<AgntAsgnLoct> AgntAsgnLocts { get; set; }

    public virtual DbSet<AgntCmsnPrfl> AgntCmsnPrfls { get; set; }

    public virtual DbSet<AgntCnclDoc> AgntCnclDocs { get; set; }

    public virtual DbSet<AgntCnclReq> AgntCnclReqs { get; set; }

    public virtual DbSet<AgntDoc> AgntDocs { get; set; }

    public virtual DbSet<AgntLimt> AgntLimts { get; set; }

    public virtual DbSet<AgntLimtSetng> AgntLimtSetngs { get; set; }

    public virtual DbSet<AgntLimtSetngDetl> AgntLimtSetngDetls { get; set; }

    public virtual DbSet<AgntLoct> AgntLocts { get; set; }

    public virtual DbSet<AgntLoctDoc> AgntLoctDocs { get; set; }

    public virtual DbSet<AgntNmnl> AgntNmnls { get; set; }

    public virtual DbSet<AgntPrfil> AgntPrfils { get; set; }

    public virtual DbSet<AgntPrfilDetl> AgntPrfilDetls { get; set; }

    public virtual DbSet<AgntPrftRvsl> AgntPrftRvsls { get; set; }

    public virtual DbSet<AgntPrftSetng> AgntPrftSetngs { get; set; }

    public virtual DbSet<AgntPrftSetngDetl> AgntPrftSetngDetls { get; set; }

    public virtual DbSet<AgntRefndInss> AgntRefndInsses { get; set; }

    public virtual DbSet<AgntRestrPrice> AgntRestrPrices { get; set; }

    public virtual DbSet<AgntType> AgntTypes { get; set; }

    public virtual DbSet<AlhubanUser> AlhubanUsers { get; set; }

    public virtual DbSet<AmfAccount> AmfAccounts { get; set; }

    public virtual DbSet<AmfAgentRequest> AmfAgentRequests { get; set; }

    public virtual DbSet<AmntType> AmntTypes { get; set; }

    public virtual DbSet<AsgnBrchRevwr> AsgnBrchRevwrs { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AutoTrfrSchdl> AutoTrfrSchdls { get; set; }

    public virtual DbSet<BalanceDiff> BalanceDiffs { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BenProfDoc> BenProfDocs { get; set; }

    public virtual DbSet<BillAdenNetPymt> BillAdenNetPymts { get; set; }

    public virtual DbSet<BillAdslPymt> BillAdslPymts { get; set; }

    public virtual DbSet<BillElctPymt> BillElctPymts { get; set; }

    public virtual DbSet<BillExtrUrlCnfg> BillExtrUrlCnfgs { get; set; }

    public virtual DbSet<BillLandLinePymt> BillLandLinePymts { get; set; }

    public virtual DbSet<BillMtnPkgPymt> BillMtnPkgPymts { get; set; }

    public virtual DbSet<BillMtnPymt> BillMtnPymts { get; set; }

    public virtual DbSet<BillPymtRvrsl> BillPymtRvrsls { get; set; }

    public virtual DbSet<BillPymtRvrslErrorLog> BillPymtRvrslErrorLogs { get; set; }

    public virtual DbSet<BillPymtTblName> BillPymtTblNames { get; set; }

    public virtual DbSet<BillRegn> BillRegns { get; set; }

    public virtual DbSet<BillSabaFonePymt> BillSabaFonePymts { get; set; }

    public virtual DbSet<BillSrvcPrvdr> BillSrvcPrvdrs { get; set; }

    public virtual DbSet<BillWatrPymt> BillWatrPymts { get; set; }

    public virtual DbSet<BillYemnMblPkgPymt> BillYemnMblPkgPymts { get; set; }

    public virtual DbSet<BillYemnMblPymt> BillYemnMblPymts { get; set; }

    public virtual DbSet<BillYgsmPymt> BillYgsmPymts { get; set; }

    public virtual DbSet<BkToMf> BkToMfs { get; set; }

    public virtual DbSet<BlckListStpdOprn> BlckListStpdOprns { get; set; }

    public virtual DbSet<BpDetl> BpDetls { get; set; }

    public virtual DbSet<BpDetl09May> BpDetl09Mays { get; set; }

    public virtual DbSet<BpDetlPra> BpDetlPras { get; set; }

    public virtual DbSet<BpMain> BpMains { get; set; }

    public virtual DbSet<BpSysUser> BpSysUsers { get; set; }

    public virtual DbSet<Brch> Brches { get; set; }

    public virtual DbSet<BrchDr> BrchDrs { get; set; }

    public virtual DbSet<BrchLqdty> BrchLqdties { get; set; }

    public virtual DbSet<BsnsAcctType> BsnsAcctTypes { get; set; }

    public virtual DbSet<BsnsPrtn> BsnsPrtns { get; set; }

    public virtual DbSet<BsnsPrtnItrnType> BsnsPrtnItrnTypes { get; set; }

    public virtual DbSet<BsnsPrtnType> BsnsPrtnTypes { get; set; }

    public virtual DbSet<CashWdrl> CashWdrls { get; set; }

    public virtual DbSet<CashWdrlDetl> CashWdrlDetls { get; set; }

    public virtual DbSet<CashWdrlMain> CashWdrlMains { get; set; }

    public virtual DbSet<CashWdrlMainT24DaoCorrection> CashWdrlMainT24DaoCorrections { get; set; }

    public virtual DbSet<CatgType> CatgTypes { get; set; }

    public virtual DbSet<CbtApril21> CbtApril21s { get; set; }

    public virtual DbSet<CbtFebCycle> CbtFebCycles { get; set; }

    public virtual DbSet<CbtFebCycle1> CbtFebCycle1s { get; set; }

    public virtual DbSet<CbtJune21> CbtJune21s { get; set; }

    public virtual DbSet<CbtMarch> CbtMarches { get; set; }

    public virtual DbSet<CbtMarch1> CbtMarch1s { get; set; }

    public virtual DbSet<CbtMay21> CbtMay21s { get; set; }

    public virtual DbSet<CertType> CertTypes { get; set; }

    public virtual DbSet<ChkrBrchMngr> ChkrBrchMngrs { get; set; }

    public virtual DbSet<ChkrMfloosDev> ChkrMfloosDevs { get; set; }

    public virtual DbSet<ChkrRegnMngr> ChkrRegnMngrs { get; set; }

    public virtual DbSet<ChldPrntDesgMap> ChldPrntDesgMaps { get; set; }

    public virtual DbSet<Chnl> Chnls { get; set; }

    public virtual DbSet<ChnlDtl> ChnlDtls { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ClntApp> ClntApps { get; set; }

    public virtual DbSet<ClntRoleType> ClntRoleTypes { get; set; }

    public virtual DbSet<CmplncActn> CmplncActns { get; set; }

    public virtual DbSet<Cmsn> Cmsns { get; set; }

    public virtual DbSet<CmsnCalcType> CmsnCalcTypes { get; set; }

    public virtual DbSet<CmsnDay> CmsnDays { get; set; }

    public virtual DbSet<CmsnDetl> CmsnDetls { get; set; }

    public virtual DbSet<CmsnDistDetl> CmsnDistDetls { get; set; }

    public virtual DbSet<CmsnGroup> CmsnGroups { get; set; }

    public virtual DbSet<CmsnGroupDetl> CmsnGroupDetls { get; set; }

    public virtual DbSet<CmsnPerdType> CmsnPerdTypes { get; set; }

    public virtual DbSet<CmsnPrfl> CmsnPrfls { get; set; }

    public virtual DbSet<CmsnPrflDetl> CmsnPrflDetls { get; set; }

    public virtual DbSet<CnclChrg> CnclChrgs { get; set; }

    public virtual DbSet<CntctU> CntctUs { get; set; }

    public virtual DbSet<Cnty> Cnties { get; set; }

    public virtual DbSet<Corp> Corps { get; set; }

    public virtual DbSet<CorpAgentRemtTemp> CorpAgentRemtTemps { get; set; }

    public virtual DbSet<CorpAgntFileUpldDoc> CorpAgntFileUpldDocs { get; set; }

    public virtual DbSet<CorpAlwdBrch> CorpAlwdBrches { get; set; }

    public virtual DbSet<CorpAlwdBrchDetl> CorpAlwdBrchDetls { get; set; }

    public virtual DbSet<CorpApiUser> CorpApiUsers { get; set; }

    public virtual DbSet<CorpAsgndRemt> CorpAsgndRemts { get; set; }

    public virtual DbSet<CorpAsgndRemtHist> CorpAsgndRemtHists { get; set; }

    public virtual DbSet<CorpAssgnRvwrBrch> CorpAssgnRvwrBrches { get; set; }

    public virtual DbSet<CorpAssgnRvwrBrchDetl> CorpAssgnRvwrBrchDetls { get; set; }

    public virtual DbSet<CorpCycl> CorpCycls { get; set; }

    public virtual DbSet<CorpCyclDetl> CorpCyclDetls { get; set; }

    public virtual DbSet<CorpDoc> CorpDocs { get; set; }

    public virtual DbSet<CorpFileUpldDoc> CorpFileUpldDocs { get; set; }

    public virtual DbSet<CorpInssRefundReq> CorpInssRefundReqs { get; set; }

    public virtual DbSet<CorpLoct> CorpLocts { get; set; }

    public virtual DbSet<CorpLoctActv> CorpLoctActvs { get; set; }

    public virtual DbSet<CorpRemt> CorpRemts { get; set; }

    public virtual DbSet<CorpRemt02jan22> CorpRemt02jan22s { get; set; }

    public virtual DbSet<CorpRemtAmndHstry> CorpRemtAmndHstries { get; set; }

    public virtual DbSet<CorpRemtDetl> CorpRemtDetls { get; set; }

    public virtual DbSet<CorpRemtHstry> CorpRemtHstries { get; set; }

    public virtual DbSet<CorpRemtInssDetl> CorpRemtInssDetls { get; set; }

    public virtual DbSet<CorpRemtTemp> CorpRemtTemps { get; set; }

    public virtual DbSet<CorpSttsType> CorpSttsTypes { get; set; }

    public virtual DbSet<CorpUserAgntReviewMap> CorpUserAgntReviewMaps { get; set; }

    public virtual DbSet<CpnyStng> CpnyStngs { get; set; }

    public virtual DbSet<CrcyType> CrcyTypes { get; set; }

    public virtual DbSet<Cust> Custs { get; set; }

    public virtual DbSet<CustAddr> CustAddrs { get; set; }

    public virtual DbSet<CustProfSetg> CustProfSetgs { get; set; }

    public virtual DbSet<CustSuplRgstn> CustSuplRgstns { get; set; }

    public virtual DbSet<CustType> CustTypes { get; set; }

    public virtual DbSet<CustomerAgentsMapping> CustomerAgentsMappings { get; set; }

    public virtual DbSet<Cycl> Cycls { get; set; }

    public virtual DbSet<CyclPrcsSttsType> CyclPrcsSttsTypes { get; set; }

    public virtual DbSet<CyclType> CyclTypes { get; set; }

    public virtual DbSet<DbLog> DbLogs { get; set; }

    public virtual DbSet<Dist> Dists { get; set; }

    public virtual DbSet<DocType> DocTypes { get; set; }

    public virtual DbSet<DpstAcctTranRevsMf> DpstAcctTranRevsMfs { get; set; }

    public virtual DbSet<DpstFileUpldDoc> DpstFileUpldDocs { get; set; }

    public virtual DbSet<DpstMfToMf> DpstMfToMfs { get; set; }

    public virtual DbSet<DpstMfToMfRvsl> DpstMfToMfRvsls { get; set; }

    public virtual DbSet<DpstToBkRvsl> DpstToBkRvsls { get; set; }

    public virtual DbSet<Dtyp> Dtyps { get; set; }

    public virtual DbSet<EPymt> EPymts { get; set; }

    public virtual DbSet<EPymtKjLimt> EPymtKjLimts { get; set; }

    public virtual DbSet<EPymtPrmtn> EPymtPrmtns { get; set; }

    public virtual DbSet<EPymtRvsl> EPymtRvsls { get; set; }

    public virtual DbSet<EPymtWaltToBank> EPymtWaltToBanks { get; set; }

    public virtual DbSet<EPymtWaltToBankBatch> EPymtWaltToBankBatches { get; set; }

    public virtual DbSet<EPymtWaltToBankBatchDetl> EPymtWaltToBankBatchDetls { get; set; }

    public virtual DbSet<EPymtWaltToBankRvsl> EPymtWaltToBankRvsls { get; set; }

    public virtual DbSet<EPymtZoneToZone> EPymtZoneToZones { get; set; }

    public virtual DbSet<EmplType> EmplTypes { get; set; }

    public virtual DbSet<EncryKey> EncryKeys { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<EtiAsgndRemt> EtiAsgndRemts { get; set; }

    public virtual DbSet<EtiAsgndRemtHist> EtiAsgndRemtHists { get; set; }

    public virtual DbSet<EtiBenProf> EtiBenProfs { get; set; }

    public virtual DbSet<EtiCyclAcct> EtiCyclAccts { get; set; }

    public virtual DbSet<EtiProd> EtiProds { get; set; }

    public virtual DbSet<EtiRemt> EtiRemts { get; set; }

    public virtual DbSet<EtiRemtDocRevw> EtiRemtDocRevws { get; set; }

    public virtual DbSet<EtiRemtOffLine> EtiRemtOffLines { get; set; }

    public virtual DbSet<EtimemberTemp> EtimemberTemps { get; set; }

    public virtual DbSet<ExcelImportBranch1> ExcelImportBranch1s { get; set; }

    public virtual DbSet<ExtrKeUrlCnfg> ExtrKeUrlCnfgs { get; set; }

    public virtual DbSet<FaildTran> FaildTrans { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<FeeCalcType> FeeCalcTypes { get; set; }

    public virtual DbSet<FeeDetl> FeeDetls { get; set; }

    public virtual DbSet<FeePerdType> FeePerdTypes { get; set; }

    public virtual DbSet<FinReqSttsType> FinReqSttsTypes { get; set; }

    public virtual DbSet<Flag> Flags { get; set; }

    public virtual DbSet<FnanAcctCnfg> FnanAcctCnfgs { get; set; }

    public virtual DbSet<FnanAcctCnfgForBillPymt> FnanAcctCnfgForBillPymts { get; set; }

    public virtual DbSet<FnanAcctCtgry> FnanAcctCtgries { get; set; }

    public virtual DbSet<FngrPrntHsty> FngrPrntHsties { get; set; }

    public virtual DbSet<FrzAcct> FrzAccts { get; set; }

    public virtual DbSet<FrzAcctDoc> FrzAcctDocs { get; set; }

    public virtual DbSet<FrzReqType> FrzReqTypes { get; set; }

    public virtual DbSet<FrzResnType> FrzResnTypes { get; set; }

    public virtual DbSet<FrzRqstTranMpng> FrzRqstTranMpngs { get; set; }

    public virtual DbSet<GndrType> GndrTypes { get; set; }

    public virtual DbSet<GovnCity> GovnCities { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupFee> GroupFees { get; set; }

    public virtual DbSet<GroupFeesDetl> GroupFeesDetls { get; set; }

    public virtual DbSet<GroupLimit> GroupLimits { get; set; }

    public virtual DbSet<GroupLimitDetl> GroupLimitDetls { get; set; }

    public virtual DbSet<Gvrn> Gvrns { get; set; }

    public virtual DbSet<HasebCashr> HasebCashrs { get; set; }

    public virtual DbSet<HasebPymt> HasebPymts { get; set; }

    public virtual DbSet<HasebPymtDetl> HasebPymtDetls { get; set; }

    public virtual DbSet<HasebPymtT24DaoCorrection> HasebPymtT24DaoCorrections { get; set; }

    public virtual DbSet<HasebToCust> HasebToCusts { get; set; }

    public virtual DbSet<IdType> IdTypes { get; set; }

    public virtual DbSet<InssRefundReq> InssRefundReqs { get; set; }

    public virtual DbSet<IsSkipWorkingHour> IsSkipWorkingHours { get; set; }

    public virtual DbSet<JobFildType> JobFildTypes { get; set; }

    public virtual DbSet<KeChnl> KeChnls { get; set; }

    public virtual DbSet<KeRemtStatus> KeRemtStatuses { get; set; }

    public virtual DbSet<KeRemtType> KeRemtTypes { get; set; }

    public virtual DbSet<KepaidBymftemp> KepaidBymftemps { get; set; }

    public virtual DbSet<KjToMf> KjToMfs { get; set; }

    public virtual DbSet<KycAttr> KycAttrs { get; set; }

    public virtual DbSet<KycSet> KycSets { get; set; }

    public virtual DbSet<KycSetDetl> KycSetDetls { get; set; }

    public virtual DbSet<LangType> LangTypes { get; set; }

    public virtual DbSet<LdgrCnfg> LdgrCnfgs { get; set; }

    public virtual DbSet<LdgrSyncJobHstry> LdgrSyncJobHstries { get; set; }

    public virtual DbSet<Limt> Limts { get; set; }

    public virtual DbSet<LimtDetl> LimtDetls { get; set; }

    public virtual DbSet<LimtPerdType> LimtPerdTypes { get; set; }

    public virtual DbSet<LimtType> LimtTypes { get; set; }

    public virtual DbSet<Lqdty> Lqdties { get; set; }

    public virtual DbSet<MdleType> MdleTypes { get; set; }

    public virtual DbSet<MenuPrvl> MenuPrvls { get; set; }

    public virtual DbSet<MfAgntAcctMapping> MfAgntAcctMappings { get; set; }

    public virtual DbSet<MfBranchList> MfBranchLists { get; set; }

    public virtual DbSet<MfBrchUserUpdt> MfBrchUserUpdts { get; set; }

    public virtual DbSet<MfEPymtFeeDdctnJobError> MfEPymtFeeDdctnJobErrors { get; set; }

    public virtual DbSet<MfKeRemt> MfKeRemts { get; set; }

    public virtual DbSet<MfKeRemtJobError> MfKeRemtJobErrors { get; set; }

    public virtual DbSet<MfT24AcctUpdate> MfT24AcctUpdates { get; set; }

    public virtual DbSet<MfToBk> MfToBks { get; set; }

    public virtual DbSet<MfToBkRvsl> MfToBkRvsls { get; set; }

    public virtual DbSet<MfToMf> MfToMfs { get; set; }

    public virtual DbSet<MfilsRemt> MfilsRemts { get; set; }

    public virtual DbSet<MfilsRemtDetl> MfilsRemtDetls { get; set; }

    public virtual DbSet<MfloosAccount> MfloosAccounts { get; set; }

    public virtual DbSet<MkrCustServ> MkrCustServs { get; set; }

    public virtual DbSet<MrtlSttsType> MrtlSttsTypes { get; set; }

    public virtual DbSet<NewsAdnc> NewsAdncs { get; set; }

    public virtual DbSet<NewsDoc> NewsDocs { get; set; }

    public virtual DbSet<NewsSetup> NewsSetups { get; set; }

    public virtual DbSet<NotifyAdnc> NotifyAdncs { get; set; }

    public virtual DbSet<NotifyAdncLog> NotifyAdncLogs { get; set; }

    public virtual DbSet<NotifyDoc> NotifyDocs { get; set; }

    public virtual DbSet<NotifySetup> NotifySetups { get; set; }

    public virtual DbSet<OfflnLimt> OfflnLimts { get; set; }

    public virtual DbSet<OfflnLimtDetl> OfflnLimtDetls { get; set; }

    public virtual DbSet<OfflnUser> OfflnUsers { get; set; }

    public virtual DbSet<OflnTran> OflnTrans { get; set; }

    public virtual DbSet<OflnTranInactvUsr> OflnTranInactvUsrs { get; set; }

    public virtual DbSet<OldAgentDataNew> OldAgentDataNews { get; set; }

    public virtual DbSet<OldAgentDatum> OldAgentData { get; set; }

    public virtual DbSet<OldUserLoginDetl> OldUserLoginDetls { get; set; }

    public virtual DbSet<OnyxAcctCnfg> OnyxAcctCnfgs { get; set; }

    public virtual DbSet<OnyxBrchGrp> OnyxBrchGrps { get; set; }

    public virtual DbSet<OprtnType> OprtnTypes { get; set; }

    public virtual DbSet<Org> Orgs { get; set; }

    public virtual DbSet<OrgDoc> OrgDocs { get; set; }

    public virtual DbSet<OrgRemt> OrgRemts { get; set; }

    public virtual DbSet<OrgStt> OrgStts { get; set; }

    public virtual DbSet<Ozla> Ozlas { get; set; }

    public virtual DbSet<PayHubDatamining1> PayHubDatamining1s { get; set; }

    public virtual DbSet<PerformanceActiveConnection> PerformanceActiveConnections { get; set; }

    public virtual DbSet<PhCorpLoginDashBoard> PhCorpLoginDashBoards { get; set; }

    public virtual DbSet<PhGamCntyMap> PhGamCntyMaps { get; set; }

    public virtual DbSet<PhLoginDashBoard> PhLoginDashBoards { get; set; }

    public virtual DbSet<PhonNmbrLineType> PhonNmbrLineTypes { get; set; }

    public virtual DbSet<PinPass> PinPasses { get; set; }

    public virtual DbSet<PinPassHsty> PinPassHsties { get; set; }

    public virtual DbSet<PosetMessage> PosetMessages { get; set; }

    public virtual DbSet<PostingLog> PostingLogs { get; set; }

    public virtual DbSet<PrcntCalOn> PrcntCalOns { get; set; }

    public virtual DbSet<PritType> PritTypes { get; set; }

    public virtual DbSet<Prod> Prods { get; set; }

    public virtual DbSet<ProdDetl> ProdDetls { get; set; }

    public virtual DbSet<ProdType> ProdTypes { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<QrActionType> QrActionTypes { get; set; }

    public virtual DbSet<QrAgntDetl> QrAgntDetls { get; set; }

    public virtual DbSet<QrCashrDetl> QrCashrDetls { get; set; }

    public virtual DbSet<QrGenLog> QrGenLogs { get; set; }

    public virtual DbSet<QrMain> QrMains { get; set; }

    public virtual DbSet<QrRsvrdWalt> QrRsvrdWalts { get; set; }

    public virtual DbSet<QrType> QrTypes { get; set; }

    public virtual DbSet<RefundEPaymt> RefundEPaymts { get; set; }

    public virtual DbSet<RefundEPaymtDetl> RefundEPaymtDetls { get; set; }

    public virtual DbSet<RefundEPymtBatch> RefundEPymtBatches { get; set; }

    public virtual DbSet<RefundEPymtBatchDetl> RefundEPymtBatchDetls { get; set; }

    public virtual DbSet<Regn> Regns { get; set; }

    public virtual DbSet<RegnCity> RegnCities { get; set; }

    public virtual DbSet<Remt> Remts { get; set; }

    public virtual DbSet<RemtBenfDetl> RemtBenfDetls { get; set; }

    public virtual DbSet<RemtCnclRqst> RemtCnclRqsts { get; set; }

    public virtual DbSet<RemtDetl> RemtDetls { get; set; }

    public virtual DbSet<RemtInssDetl> RemtInssDetls { get; set; }

    public virtual DbSet<RemtTranKycDetl> RemtTranKycDetls { get; set; }

    public virtual DbSet<RestrPrice> RestrPrices { get; set; }

    public virtual DbSet<RevnPrtnType> RevnPrtnTypes { get; set; }

    public virtual DbSet<RfundEPymt> RfundEPymts { get; set; }

    public virtual DbSet<RjctResnType> RjctResnTypes { get; set; }

    public virtual DbSet<RolePrvlDetl> RolePrvlDetls { get; set; }

    public virtual DbSet<RqstAprvDesg> RqstAprvDesgs { get; set; }

    public virtual DbSet<RqstSttsType> RqstSttsTypes { get; set; }

    public virtual DbSet<RqstType> RqstTypes { get; set; }

    public virtual DbSet<RstrctRolePrvl> RstrctRolePrvls { get; set; }

    public virtual DbSet<RtrnCode> RtrnCodes { get; set; }

    public virtual DbSet<Scrn> Scrns { get; set; }

    public virtual DbSet<SelfMfToBk> SelfMfToBks { get; set; }

    public virtual DbSet<SelfMfToBkRvsl> SelfMfToBkRvsls { get; set; }

    public virtual DbSet<Sesn> Sesns { get; set; }

    public virtual DbSet<SlideDoc> SlideDocs { get; set; }

    public virtual DbSet<SlideSetup> SlideSetups { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<SmsOprtType> SmsOprtTypes { get; set; }

    public virtual DbSet<SmsTmpl> SmsTmpls { get; set; }

    public virtual DbSet<SrvcPrvdAcct> SrvcPrvdAccts { get; set; }

    public virtual DbSet<SrvcType> SrvcTypes { get; set; }

    public virtual DbSet<SspcnStng> SspcnStngs { get; set; }

    public virtual DbSet<SttsType> SttsTypes { get; set; }

    public virtual DbSet<SubAgntTopup> SubAgntTopups { get; set; }

    public virtual DbSet<SubOprtnType> SubOprtnTypes { get; set; }

    public virtual DbSet<SubSrvcType> SubSrvcTypes { get; set; }

    public virtual DbSet<SubUserAlwdAmnt> SubUserAlwdAmnts { get; set; }

    public virtual DbSet<SubUserAlwdCrcy> SubUserAlwdCrcies { get; set; }

    public virtual DbSet<SubaccountToMf> SubaccountToMfs { get; set; }

    public virtual DbSet<SuplExtrUrlCnfg> SuplExtrUrlCnfgs { get; set; }

    public virtual DbSet<SuplPrfl> SuplPrfls { get; set; }

    public virtual DbSet<SuplZoneBlnc> SuplZoneBlncs { get; set; }

    public virtual DbSet<SupportRemtInssDetl> SupportRemtInssDetls { get; set; }

    public virtual DbSet<SuprAgnt> SuprAgnts { get; set; }

    public virtual DbSet<SuprAgntAlwdCrcy> SuprAgntAlwdCrcies { get; set; }

    public virtual DbSet<SuprAgntCmsnPrfl> SuprAgntCmsnPrfls { get; set; }

    public virtual DbSet<SuprAgntDoc> SuprAgntDocs { get; set; }

    public virtual DbSet<SuprAgntLimt> SuprAgntLimts { get; set; }

    public virtual DbSet<SuprAgntRestrPrice> SuprAgntRestrPrices { get; set; }

    public virtual DbSet<SuprAgntTopup> SuprAgntTopups { get; set; }

    public virtual DbSet<T24Acct> T24Accts { get; set; }

    public virtual DbSet<T24Branch> T24Branches { get; set; }

    public virtual DbSet<T24CobDate> T24CobDates { get; set; }

    public virtual DbSet<T24LdgrsGenerationSpError> T24LdgrsGenerationSpErrors { get; set; }

    public virtual DbSet<T24LdgrsSyncJobError> T24LdgrsSyncJobErrors { get; set; }

    public virtual DbSet<Temp08052022> Temp08052022s { get; set; }

    public virtual DbSet<TempAcctPrddAgntHasib> TempAcctPrddAgntHasibs { get; set; }

    public virtual DbSet<TempAcctRev> TempAcctRevs { get; set; }

    public virtual DbSet<TempAgntAcct> TempAgntAccts { get; set; }

    public virtual DbSet<TempCentralBankReport> TempCentralBankReports { get; set; }

    public virtual DbSet<TempCntBnkRept> TempCntBnkRepts { get; set; }

    public virtual DbSet<TempCsvMain> TempCsvMains { get; set; }

    public virtual DbSet<TempCsvMember> TempCsvMembers { get; set; }

    public virtual DbSet<TempPaymentSite> TempPaymentSites { get; set; }

    public virtual DbSet<TempRegion> TempRegions { get; set; }

    public virtual DbSet<TempTableToAdjustDatum> TempTableToAdjustData { get; set; }

    public virtual DbSet<TempUnicef20032022> TempUnicef20032022s { get; set; }

    public virtual DbSet<TempUnicefRemt08032022> TempUnicefRemt08032022s { get; set; }

    public virtual DbSet<TestJob> TestJobs { get; set; }

    public virtual DbSet<TmpHasebAgntAcct> TmpHasebAgntAccts { get; set; }

    public virtual DbSet<TmpMenuPrevilidgeAbd9839> TmpMenuPrevilidgeAbd9839s { get; set; }

    public virtual DbSet<TmpMenuPrvldgBkp> TmpMenuPrvldgBkps { get; set; }

    public virtual DbSet<TmpOnlyAgntAcct> TmpOnlyAgntAccts { get; set; }

    public virtual DbSet<TmpPostedLedger> TmpPostedLedgers { get; set; }

    public virtual DbSet<Tran> Trans { get; set; }

    public virtual DbSet<TranFor> TranFors { get; set; }

    public virtual DbSet<TranInptSetng> TranInptSetngs { get; set; }

    public virtual DbSet<TranOrgn> TranOrgns { get; set; }

    public virtual DbSet<UnicefAssignSite> UnicefAssignSites { get; set; }

    public virtual DbSet<UnicefAtchRevwStt> UnicefAtchRevwStts { get; set; }

    public virtual DbSet<UnicefBenProf> UnicefBenProfs { get; set; }

    public virtual DbSet<UnicefBenPstd> UnicefBenPstds { get; set; }

    public virtual DbSet<UnicefBenToPost> UnicefBenToPosts { get; set; }

    public virtual DbSet<UnicefBenToPostBenjo> UnicefBenToPostBenjos { get; set; }

    public virtual DbSet<UnicefBeneficiaryProfile> UnicefBeneficiaryProfiles { get; set; }

    public virtual DbSet<UnicefBlkdRemi> UnicefBlkdRemis { get; set; }

    public virtual DbSet<UnicefBlkdRemiHist> UnicefBlkdRemiHists { get; set; }

    public virtual DbSet<UnicefCyclFlag> UnicefCyclFlags { get; set; }

    public virtual DbSet<UnicefDocRevw> UnicefDocRevws { get; set; }

    public virtual DbSet<UnicefFileDoc> UnicefFileDocs { get; set; }

    public virtual DbSet<UnicefFileFlag> UnicefFileFlags { get; set; }

    public virtual DbSet<UnicefFileType> UnicefFileTypes { get; set; }

    public virtual DbSet<UnicefFlag> UnicefFlags { get; set; }

    public virtual DbSet<UnicefFmly> UnicefFmlies { get; set; }

    public virtual DbSet<UnicefLoctDsbld> UnicefLoctDsblds { get; set; }

    public virtual DbSet<UnicefLoctDsbldHstry> UnicefLoctDsbldHstries { get; set; }

    public virtual DbSet<UnicefLoctType> UnicefLoctTypes { get; set; }

    public virtual DbSet<UnicefMainBenfTmp> UnicefMainBenfTmps { get; set; }

    public virtual DbSet<UnicefMemberTemp> UnicefMemberTemps { get; set; }

    public virtual DbSet<UnicefMmbr> UnicefMmbrs { get; set; }

    public virtual DbSet<UnicefMmbrFlg> UnicefMmbrFlgs { get; set; }

    public virtual DbSet<UnicefRemt> UnicefRemts { get; set; }

    public virtual DbSet<UnicefRemtAmnt> UnicefRemtAmnts { get; set; }

    public virtual DbSet<UnicefRemtDoc> UnicefRemtDocs { get; set; }

    public virtual DbSet<UnicefRemtDocRevw> UnicefRemtDocRevws { get; set; }

    public virtual DbSet<UnicefRemtFlg> UnicefRemtFlgs { get; set; }

    public virtual DbSet<UnicefRemtFlgOutReach> UnicefRemtFlgOutReaches { get; set; }

    public virtual DbSet<UnicefRemtOffLine> UnicefRemtOffLines { get; set; }

    public virtual DbSet<UnicefSpecLimt> UnicefSpecLimts { get; set; }

    public virtual DbSet<UnicefUserAgntMap> UnicefUserAgntMaps { get; set; }

    public virtual DbSet<Unicefdataupload> Unicefdatauploads { get; set; }

    public virtual DbSet<UpdateAcitivity> UpdateAcitivities { get; set; }

    public virtual DbSet<UpgrdeMfilsToMfloo> UpgrdeMfilsToMfloos { get; set; }

    public virtual DbSet<UpgrdeMfloosAcct> UpgrdeMfloosAccts { get; set; }

    public virtual DbSet<UpldDocDetl> UpldDocDetls { get; set; }

    public virtual DbSet<UserChngngBrchDetl> UserChngngBrchDetls { get; set; }

    public virtual DbSet<UserChngngBrchDoc> UserChngngBrchDocs { get; set; }

    public virtual DbSet<UserChngngBrchRqst> UserChngngBrchRqsts { get; set; }

    public virtual DbSet<UserDesgDetl> UserDesgDetls { get; set; }

    public virtual DbSet<UserDesgHrcy> UserDesgHrcies { get; set; }

    public virtual DbSet<UserDesgType> UserDesgTypes { get; set; }

    public virtual DbSet<UserDvceRgstDetl> UserDvceRgstDetls { get; set; }

    public virtual DbSet<UserDvceRgstDetlHsty> UserDvceRgstDetlHsties { get; set; }

    public virtual DbSet<UserRoleDetl> UserRoleDetls { get; set; }

    public virtual DbSet<UserRoleType> UserRoleTypes { get; set; }

    public virtual DbSet<UsrPrvlDetl> UsrPrvlDetls { get; set; }

    public virtual DbSet<UsrRgstToken> UsrRgstTokens { get; set; }

    public virtual DbSet<Vilg> Vilgs { get; set; }

    public virtual DbSet<VuchrTran> VuchrTrans { get; set; }

    public virtual DbSet<VwbillPaymentCombined> VwbillPaymentCombineds { get; set; }

    public virtual DbSet<VwtransactionsWithLqdtyFee> VwtransactionsWithLqdtyFees { get; set; }

    public virtual DbSet<WaltLocalization> WaltLocalizations { get; set; }

    public virtual DbSet<WaltLocalizationGlbl> WaltLocalizationGlbls { get; set; }

    public virtual DbSet<WorkHour> WorkHours { get; set; }

    public virtual DbSet<WorkQue> WorkQues { get; set; }

    public virtual DbSet<WorkQueActnType> WorkQueActnTypes { get; set; }

    public virtual DbSet<WorkQueHsty> WorkQueHsties { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=10.64.50.188;Initial Catalog=MF_T24_UAT_APP;Integrated Security=False;User Id=PaymentHubNew;Password=PayHub1!2@3#4#;Connection Timeout=600;pooling=true;Max Pool Size=15000;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1256_CI_AS");

        modelBuilder.Entity<AaCpyProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AA_CPY_PROD");

            entity.Property(e => e.EmpEnterd).HasColumnName("Emp_Enterd");
            entity.Property(e => e.ProEnterd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Pro_Enterd");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SenderAccBrch)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Sender_Acc_Brch");
            entity.Property(e => e.SenderAccNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Sender_Acc_No");
            entity.Property(e => e.YmnAcc).HasColumnName("YMN_Acc");
            entity.Property(e => e.YmnAmountPaid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("YMN_AmountPaid");
            entity.Property(e => e.YmnAmountPaidAll)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YMN_AmountPaidAll");
            entity.Property(e => e.YmnAttNo).HasColumnName("YMN_AttNo");
            entity.Property(e => e.YmnBranchCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("YMN_BranchCode");
            entity.Property(e => e.YmnCommission)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YMN_Commission");
            entity.Property(e => e.YmnCustAcc).HasColumnName("YMN_Cust_Acc");
            entity.Property(e => e.YmnCustName)
                .HasMaxLength(100)
                .HasColumnName("YMN_CustName");
            entity.Property(e => e.YmnDateReceive)
                .HasColumnType("datetime")
                .HasColumnName("YMN_DateReceive");
            entity.Property(e => e.YmnDateSent)
                .HasColumnType("datetime")
                .HasColumnName("YMN_DateSent");
            entity.Property(e => e.YmnExport).HasColumnName("YMN_Export");
            entity.Property(e => e.YmnId)
                .HasMaxLength(50)
                .HasColumnName("YMN_Id");
            entity.Property(e => e.YmnMobileNo).HasColumnName("YMN_MobileNo");
            entity.Property(e => e.YmnNetworkType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("YMN_NetworkType");
            entity.Property(e => e.YmnNo).HasColumnName("YMN_No");
            entity.Property(e => e.YmnOfferCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YMN_OfferCode");
            entity.Property(e => e.YmnPackageReceive)
                .HasMaxLength(120)
                .HasColumnName("YMN_PackageReceive");
            entity.Property(e => e.YmnPackageReceiveXml).HasColumnName("YMN_PackageReceiveXML");
            entity.Property(e => e.YmnPackageSent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YMN_PackageSent");
            entity.Property(e => e.YmnPackageSentXml).HasColumnName("YMN_PackageSentXML");
            entity.Property(e => e.YmnPackageState).HasColumnName("YMN_PackageState");
            entity.Property(e => e.YmnPackageType).HasColumnName("YMN_PackageType");
            entity.Property(e => e.YmnRef).HasColumnName("YMN_Ref");
            entity.Property(e => e.YmnResulteState).HasColumnName("YMN_ResulteState");
            entity.Property(e => e.YmnSuccess).HasColumnName("YMN_Success");
            entity.Property(e => e.YmnTaskId).HasColumnName("YMN_TaskID");
            entity.Property(e => e.YmnTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("YMN_Timestamp");
            entity.Property(e => e.YmnType).HasColumnName("YMN_Type");
            entity.Property(e => e.YmnTypeEntry).HasColumnName("YMN_TypeEntry");
            entity.Property(e => e.YmnUserConf).HasColumnName("YMN_UserConf");
            entity.Property(e => e.YmnUserNo).HasColumnName("YMN_UserNo");
        });

        modelBuilder.Entity<AaYemennet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AA_YEMENNET");

            entity.Property(e => e.EmpEnterd).HasColumnName("Emp_Enterd");
            entity.Property(e => e.ProEnterd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Pro_Enterd");
            entity.Property(e => e.SenderAccBrch)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Sender_Acc_Brch");
            entity.Property(e => e.SenderAccNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Sender_Acc_No");
            entity.Property(e => e.YmnAcc).HasColumnName("YMN_Acc");
            entity.Property(e => e.YmnAmountPaid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("YMN_AmountPaid");
            entity.Property(e => e.YmnAmountPaidAll)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YMN_AmountPaidAll");
            entity.Property(e => e.YmnAttNo).HasColumnName("YMN_AttNo");
            entity.Property(e => e.YmnBranchCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("YMN_BranchCode");
            entity.Property(e => e.YmnCommission)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YMN_Commission");
            entity.Property(e => e.YmnCustAcc).HasColumnName("YMN_Cust_Acc");
            entity.Property(e => e.YmnCustName)
                .HasMaxLength(100)
                .HasColumnName("YMN_CustName");
            entity.Property(e => e.YmnDateReceive)
                .HasColumnType("datetime")
                .HasColumnName("YMN_DateReceive");
            entity.Property(e => e.YmnDateSent)
                .HasColumnType("datetime")
                .HasColumnName("YMN_DateSent");
            entity.Property(e => e.YmnExport).HasColumnName("YMN_Export");
            entity.Property(e => e.YmnId)
                .HasMaxLength(50)
                .HasColumnName("YMN_Id");
            entity.Property(e => e.YmnMobileNo).HasColumnName("YMN_MobileNo");
            entity.Property(e => e.YmnNetworkType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("YMN_NetworkType");
            entity.Property(e => e.YmnNo).HasColumnName("YMN_No");
            entity.Property(e => e.YmnPackageReceive)
                .HasMaxLength(120)
                .HasColumnName("YMN_PackageReceive");
            entity.Property(e => e.YmnPackageReceiveXml).HasColumnName("YMN_PackageReceiveXML");
            entity.Property(e => e.YmnPackageSent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YMN_PackageSent");
            entity.Property(e => e.YmnPackageSentXml).HasColumnName("YMN_PackageSentXML");
            entity.Property(e => e.YmnPackageState).HasColumnName("YMN_PackageState");
            entity.Property(e => e.YmnPackageType).HasColumnName("YMN_PackageType");
            entity.Property(e => e.YmnRef).HasColumnName("YMN_Ref");
            entity.Property(e => e.YmnResulteState).HasColumnName("YMN_ResulteState");
            entity.Property(e => e.YmnSuccess).HasColumnName("YMN_Success");
            entity.Property(e => e.YmnTaskId).HasColumnName("YMN_TaskID");
            entity.Property(e => e.YmnTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("YMN_Timestamp");
            entity.Property(e => e.YmnType).HasColumnName("YMN_Type");
            entity.Property(e => e.YmnTypeEntry).HasColumnName("YMN_TypeEntry");
            entity.Property(e => e.YmnUserConf).HasColumnName("YMN_UserConf");
            entity.Property(e => e.YmnUserNo).HasColumnName("YMN_UserNo");
        });

        modelBuilder.Entity<Acct>(entity =>
        {
            entity.ToTable("ACCT");

            entity.HasIndex(e => e.WaltAcctNmbr, "ACCT_MFLS_UNIQ").IsUnique();

            entity.HasIndex(e => new { e.BpMainId, e.AcctStts }, "IX_ACCT_BP_MAIN_ID_ACCT_STTS");

            entity.HasIndex(e => e.Type, "IX_TYPE");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.AcctStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_STTS");
            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BsnsTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BSNS_TYPE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CURR_ID");
            entity.Property(e => e.FinancialAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Financial_ACCT_NMBR");
            entity.Property(e => e.InsuranceAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Insurance_ACCT_NMBR");
            entity.Property(e => e.InsuranceInitialBalance)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Insurance_Initial_Balance");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LevlId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEVL_ID");
            entity.Property(e => e.OldAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Old_ACCT_NMBR");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ReservePercentageOfInsuranceAccount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReservePercentage_Of_InsuranceAccount");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SubType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUB_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UsblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("USBL_BLNC");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");

            entity.HasOne(d => d.AcctSttsNavigation).WithMany(p => p.Accts)
                .HasForeignKey(d => d.AcctStts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_RQST_STTS_TYPE");

            entity.HasOne(d => d.BpMain).WithMany(p => p.Accts)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_BP_MAIN");

            entity.HasOne(d => d.Prod).WithMany(p => p.Accts)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_PROD");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Accts)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_CLNT_ROLE_TYPE");
        });

        modelBuilder.Entity<Acct31122021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCT_31122021");

            entity.Property(e => e.AcctId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ACCT_ID");
            entity.Property(e => e.AcctStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_STTS");
            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BsnsTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BSNS_TYPE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CURR_ID");
            entity.Property(e => e.FinancialAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Financial_ACCT_NMBR");
            entity.Property(e => e.InsuranceAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Insurance_ACCT_NMBR");
            entity.Property(e => e.InsuranceInitialBalance)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Insurance_Initial_Balance");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LevlId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEVL_ID");
            entity.Property(e => e.OldAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Old_ACCT_NMBR");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ReservePercentageOfInsuranceAccount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReservePercentage_Of_InsuranceAccount");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SubType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUB_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UsblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("USBL_BLNC");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<AcctBeforeVip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACCT_BEFORE_VIP");

            entity.Property(e => e.AcctId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ACCT_ID");
            entity.Property(e => e.AcctStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_STTS");
            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BsnsTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BSNS_TYPE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CURR_ID");
            entity.Property(e => e.FinancialAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Financial_ACCT_NMBR");
            entity.Property(e => e.InsuranceAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Insurance_ACCT_NMBR");
            entity.Property(e => e.InsuranceInitialBalance)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Insurance_Initial_Balance");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LevlId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEVL_ID");
            entity.Property(e => e.OldAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("Old_ACCT_NMBR");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ReservePercentageOfInsuranceAccount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReservePercentage_Of_InsuranceAccount");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SubType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUB_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UsblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("USBL_BLNC");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<AcctDetl>(entity =>
        {
            entity.ToTable("ACCT_DETL");

            entity.Property(e => e.AcctDetlId).HasColumnName("ACCT_DETL_ID");
            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.CityCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Eml)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EML");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.IdIssuDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_ISSU_DATE");
            entity.Property(e => e.IdNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ID_NMBR");
            entity.Property(e => e.IdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.IdXpirDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_XPIR_DATE");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MidlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MIDL_NAME");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.PhonNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PHON_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");

            entity.HasOne(d => d.Acct).WithMany(p => p.AcctDetls)
                .HasForeignKey(d => d.AcctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_DETL_ACCT");

            entity.HasOne(d => d.CntyCodeNavigation).WithMany(p => p.AcctDetls)
                .HasForeignKey(d => d.CntyCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_DETL_CNTY");
        });

        modelBuilder.Entity<AcctDoc>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("ACCT_DOC");

            entity.HasIndex(e => e.AcctId, "IX_ACCT_ID");

            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.Acct).WithMany(p => p.AcctDocs)
                .HasForeignKey(d => d.AcctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_DOC_ACCT");

            entity.HasOne(d => d.UpldDoc).WithMany(p => p.AcctDocs)
                .HasForeignKey(d => d.UpldDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_DOC_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<AcctKycDetl>(entity =>
        {
            entity.HasKey(e => new { e.AcctId, e.KycSetId, e.KycAttrId }).HasName("PK_ACCT_KYC_DETL_1");

            entity.ToTable("ACCT_KYC_DETL");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.KycAttrId).HasColumnName("KYC_ATTR_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycAttrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KYC_ATTR_NAME");
            entity.Property(e => e.KycAttrVal)
                .HasMaxLength(500)
                .HasColumnName("KYC_ATTR_VAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Acct).WithMany(p => p.AcctKycDetls)
                .HasForeignKey(d => d.AcctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_KYC_DETL_ACCT");

            entity.HasOne(d => d.KycAttr).WithMany(p => p.AcctKycDetls)
                .HasForeignKey(d => d.KycAttrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_KYC_DETL_KYC_ATTR1");

            entity.HasOne(d => d.KycSet).WithMany(p => p.AcctKycDetls)
                .HasForeignKey(d => d.KycSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_KYC_DETL_KYC_SET");
        });

        modelBuilder.Entity<AcctLvl>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ACCT_LVL");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AcctOpngBlnc>(entity =>
        {
            entity.HasKey(e => e.AcctBlncId);

            entity.ToTable("ACCT_OPNG_BLNC");

            entity.Property(e => e.AcctBlncId).HasColumnName("ACCT_BLNC_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.PrfrmrId).HasColumnName("PRFRMR_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AcctSubType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ACCT_SUB_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.AcctTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_TYPE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AcctType).WithMany(p => p.AcctSubTypes)
                .HasForeignKey(d => d.AcctTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCT_SUB_TYPE_ACCT_TYPE");
        });

        modelBuilder.Entity<AcctTran>(entity =>
        {
            entity.ToTable("ACCT_TRAN");

            entity.HasIndex(e => new { e.AmntTypeCode, e.CrdtAcct }, "IX_ACCT_TRAN_AMNT_TYPE_CODE_CRDT_ACCT");

            entity.HasIndex(e => new { e.TranTypeId, e.TranTypeCode, e.AmntTypeCode, e.SubOprnType, e.CrdtAcct, e.OprnType }, "UK_ACCT_TRAN").IsUnique();

            entity.HasIndex(e => new { e.AmntTypeCode, e.SubOprnType, e.CreatedOn }, "ix_dba_acct_tran_16022021");

            entity.Property(e => e.AcctTranId).HasColumnName("ACCT_TRAN_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.AmntBaseCrcy)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_BASE_CRCY");
            entity.Property(e => e.AmntFrgnCrcy)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_FRGN_CRCY");
            entity.Property(e => e.AmntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AMNT_TYPE_CODE");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.BsnsPrtnId).HasColumnName("BSNS_PRTN_ID");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.IsPostedToAcct).HasColumnName("IS_POSTED_TO_ACCT");
            entity.Property(e => e.OprnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OPRN_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrceTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRCE_TYPE_CODE");
            entity.Property(e => e.SubOprnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUB_OPRN_TYPE");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.TrgtTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRGT_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.XchgRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("XCHG_RATE");
        });

        modelBuilder.Entity<AcctTranPostedDetl>(entity =>
        {
            entity.HasKey(e => e.AcctTranPostedId);

            entity.ToTable("ACCT_TRAN_POSTED_DETL");

            entity.HasIndex(e => e.TranTypeId, "NonClusteredIndex-20200704-134250").HasFillFactor(70);

            entity.Property(e => e.AcctTranPostedId).HasColumnName("ACCT_TRAN_POSTED_ID");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsPostedToAcctStts).HasColumnName("IS_POSTED_TO_ACCT_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AcctType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ACCT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsVisible)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IS_VISIBLE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AcmdType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ACMD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Agnt>(entity =>
        {
            entity.ToTable("AGNT");

            entity.HasIndex(e => e.BpMainId, "IX_AGNT").IsUnique();

            entity.HasIndex(e => e.OldAgntCode, "IX_AGNT_OLD_AGNT_CODE");

            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .HasColumnName("ADDR");
            entity.Property(e => e.AgntDesc)
                .HasMaxLength(500)
                .HasColumnName("AGNT_DESC");
            entity.Property(e => e.AgntNameLocal)
                .HasMaxLength(250)
                .HasColumnName("AGNT_NAME_LOCAL");
            entity.Property(e => e.AgntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_TYPE_CODE");
            entity.Property(e => e.BankAcctNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Dateofdeduction)
                .HasColumnType("datetime")
                .HasColumnName("DATEOFDEDUCTION");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FnanAcctNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_NO");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDailyTrfr).HasColumnName("IS_DAILY_TRFR");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsInssDdct).HasColumnName("IS_INSS_DDCT");
            entity.Property(e => e.IsKeAgent).HasColumnName("IS_KE_AGENT");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.PhneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHNE_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.SubUserCount).HasColumnName("SUB_USER_COUNT");
            entity.Property(e => e.SuprAgntId).HasColumnName("SUPR_AGNT_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WalletNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALLET_NO");

            entity.HasOne(d => d.AgntTypeCodeNavigation).WithMany(p => p.Agnts)
                .HasForeignKey(d => d.AgntTypeCode)
                .HasConstraintName("FK_AGNT_AGNT_TYPE");

            entity.HasOne(d => d.BpMain).WithOne(p => p.Agnt)
                .HasForeignKey<Agnt>(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_AGNT1");
        });

        modelBuilder.Entity<Agnt31122021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGNT_31122021");

            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .HasColumnName("ADDR");
            entity.Property(e => e.AgntDesc)
                .HasMaxLength(500)
                .HasColumnName("AGNT_DESC");
            entity.Property(e => e.AgntId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AGNT_ID");
            entity.Property(e => e.AgntNameLocal)
                .HasMaxLength(250)
                .HasColumnName("AGNT_NAME_LOCAL");
            entity.Property(e => e.AgntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_TYPE_CODE");
            entity.Property(e => e.BankAcctNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FnanAcctNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_NO");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsInssDdct).HasColumnName("IS_INSS_DDCT");
            entity.Property(e => e.IsKeAgent).HasColumnName("IS_KE_AGENT");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.PhneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHNE_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.SubUserCount).HasColumnName("SUB_USER_COUNT");
            entity.Property(e => e.SuprAgntId).HasColumnName("SUPR_AGNT_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WalletNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALLET_NO");
        });

        modelBuilder.Entity<AgntActv>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("AGNT_ACTV");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.AgntActvTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_ACTV_TYPE_CODE");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Mudirity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUDIRITY");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.Ozla)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OZLA");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntActvDetl>(entity =>
        {
            entity.ToTable("AGNT_ACTV_DETL");

            entity.Property(e => e.AgntActvDetlId).HasColumnName("AGNT_ACTV_DETL_ID");
            entity.Property(e => e.Age)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AGE");
            entity.Property(e => e.AgntActvCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_ACTV_CODE");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntActvCodeNavigation).WithMany(p => p.AgntActvDetls)
                .HasForeignKey(d => d.AgntActvCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_ACTV_DETL_AGNT_ACTV");

            entity.HasOne(d => d.Agnt).WithMany(p => p.AgntActvDetls)
                .HasForeignKey(d => d.AgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_ACTV_DETL_AGNT");
        });

        modelBuilder.Entity<AgntActvType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_AGN_ACTV_TYPE");

            entity.ToTable("AGNT_ACTV_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntAlwdCrcy>(entity =>
        {
            entity.ToTable("AGNT_ALWD_CRCY");

            entity.Property(e => e.AgntAlwdCrcyId).HasColumnName("AGNT_ALWD_CRCY_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntAsgnLoct>(entity =>
        {
            entity.HasKey(e => e.AsgnLoctId);

            entity.ToTable("AGNT_ASGN_LOCT");

            entity.HasIndex(e => new { e.BpMainId, e.OrgId }, "IX_BP_MAIN_ID");

            entity.HasIndex(e => new { e.BpSecdId, e.BpMainId, e.LoctId, e.OrgId }, "UK_BP_SECD_ID_BP_MAIN_ID_LOCT_ID").IsUnique();

            entity.HasIndex(e => new { e.BpSecdId, e.BpMainId, e.OrgId }, "UK_SUB_AGNT_ID").IsUnique();

            entity.Property(e => e.AsgnLoctId).HasColumnName("ASGN_LOCT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LoctId).HasColumnName("LOCT_ID");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Loct).WithMany(p => p.AgntAsgnLocts)
                .HasForeignKey(d => d.LoctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_ASGN_LOCT_AGNT_LOCT");
        });

        modelBuilder.Entity<AgntCmsnPrfl>(entity =>
        {
            entity.HasKey(e => e.AgntCmsnPrflId).HasName("PK_AGNT_CMSN_PROF");

            entity.ToTable("AGNT_CMSN_PRFL");

            entity.Property(e => e.AgntCmsnPrflId).HasColumnName("AGNT_CMSN_PRFL_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Agnt).WithMany(p => p.AgntCmsnPrfls)
                .HasForeignKey(d => d.AgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_CMSN_PRFL_AGNT");

            entity.HasOne(d => d.CmsnPrfl).WithMany(p => p.AgntCmsnPrfls)
                .HasForeignKey(d => d.CmsnPrflId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_CMSN_PRFL_CMSN_PRFL");
        });

        modelBuilder.Entity<AgntCnclDoc>(entity =>
        {
            entity.ToTable("AGNT_CNCL_DOC");

            entity.Property(e => e.AgntCnclDocId).HasColumnName("AGNT_CNCL_DOC_ID");
            entity.Property(e => e.AgntCnclReqId).HasColumnName("AGNT_CNCL_REQ_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOC_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.AgntCnclReq).WithMany(p => p.AgntCnclDocs)
                .HasForeignKey(d => d.AgntCnclReqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_CNCL_DOC_AGNT_CNCL_REQ");
        });

        modelBuilder.Entity<AgntCnclReq>(entity =>
        {
            entity.ToTable("AGNT_CNCL_REQ");

            entity.Property(e => e.AgntCnclReqId).HasColumnName("AGNT_CNCL_REQ_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RqstSttsType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RQST_STTS_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntDoc>(entity =>
        {
            entity.ToTable("AGNT_DOC");

            entity.Property(e => e.AgntDocId).HasColumnName("AGNT_DOC_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Agnt).WithMany(p => p.AgntDocs)
                .HasForeignKey(d => d.AgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_DOC_AGNT");
        });

        modelBuilder.Entity<AgntLimt>(entity =>
        {
            entity.ToTable("AGNT_LIMTS");

            entity.Property(e => e.AgntLimtId).HasColumnName("AGNT_LIMT_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_Bp_MAIN_ID");
            entity.Property(e => e.AgntLimtSetngId).HasColumnName("AGNT_LIMT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntLimtSetng).WithMany(p => p.AgntLimts)
                .HasForeignKey(d => d.AgntLimtSetngId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_LIMT_AGNT_LIMT_SETNG");
        });

        modelBuilder.Entity<AgntLimtSetng>(entity =>
        {
            entity.ToTable("AGNT_LIMT_SETNG");

            entity.Property(e => e.AgntLimtSetngId).HasColumnName("AGNT_LIMT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimtSetngDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_SETNG_DESC");
            entity.Property(e => e.LimtSetngName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_SETNG_NAME");
            entity.Property(e => e.LimtSetngNameLocl)
                .HasMaxLength(250)
                .HasColumnName("LIMT_SETNG_NAME_LOCL");
            entity.Property(e => e.LimtSetngStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LIMT_SETNG_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntLimtSetngDetl>(entity =>
        {
            entity.ToTable("AGNT_LIMT_SETNG_DETL");

            entity.Property(e => e.AgntLimtSetngDetlId).HasColumnName("AGNT_LIMT_SETNG_DETL_ID");
            entity.Property(e => e.AgntLimtSetngId).HasColumnName("AGNT_LIMT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.GroupLimtId).HasColumnName("Group_LIMT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntLimtSetng).WithMany(p => p.AgntLimtSetngDetls)
                .HasForeignKey(d => d.AgntLimtSetngId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_LIMT_SETNG_DETL_AGNT_LIMT_SETNG");

            entity.HasOne(d => d.GroupLimt).WithMany(p => p.AgntLimtSetngDetls)
                .HasForeignKey(d => d.GroupLimtId)
                .HasConstraintName("FK_AGNT_LIMT_SETNG_DETL_Group_LIMIT");

            entity.HasOne(d => d.Tran).WithMany(p => p.AgntLimtSetngDetls)
                .HasForeignKey(d => d.TranId)
                .HasConstraintName("FK_AGNT_LIMT_SETNG_DETL_TRAN");
        });

        modelBuilder.Entity<AgntLoct>(entity =>
        {
            entity.HasKey(e => e.LoctId);

            entity.ToTable("AGNT_LOCT");

            entity.Property(e => e.LoctId).HasColumnName("LOCT_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.AllwdSubuserCnt)
                .HasDefaultValueSql("((5))")
                .HasColumnName("ALLWD_SUBUSER_CNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LatiTude)
                .HasMaxLength(100)
                .HasColumnName("LATI_TUDE");
            entity.Property(e => e.LngiTude)
                .HasMaxLength(50)
                .HasColumnName("LNGI_TUDE");
            entity.Property(e => e.LoctName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOCT_NAME");
            entity.Property(e => e.LoctStrtDate)
                .HasColumnType("datetime")
                .HasColumnName("LOCT_STRT_DATE");
            entity.Property(e => e.LoctStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LOCT_STTS");
            entity.Property(e => e.LoctType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LOCT_TYPE");
            entity.Property(e => e.LoctXpirDate)
                .HasColumnType("datetime")
                .HasColumnName("LOCT_XPIR_DATE");
            entity.Property(e => e.OldSiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OLD_SITE_CODE");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.SchlName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SCHL_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StfFmalCshr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STF_FMAL_CSHR");
            entity.Property(e => e.StfFmalScrOfic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STF_FMAL_SCR_OFIC");
            entity.Property(e => e.StfMaleCshr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STF_MALE_CSHR");
            entity.Property(e => e.StfMaleScrOfic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STF_MALE_SCR_OFIC");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");
        });

        modelBuilder.Entity<AgntLoctDoc>(entity =>
        {
            entity.HasKey(e => e.LoctDocId).HasName("PK_LOCT_DOC");

            entity.ToTable("AGNT_LOCT_DOC");

            entity.Property(e => e.LoctDocId).HasColumnName("LOCT_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.LoctDocType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCT_DOC_TYPE");
            entity.Property(e => e.LoctId).HasColumnName("LOCT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.Loct).WithMany(p => p.AgntLoctDocs)
                .HasForeignKey(d => d.LoctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOCT_DOC_LOCT_DOC");

            entity.HasOne(d => d.UpldDoc).WithMany(p => p.AgntLoctDocs)
                .HasForeignKey(d => d.UpldDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOCT_DOC_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<AgntNmnl>(entity =>
        {
            entity.ToTable("AGNT_NMNL");

            entity.Property(e => e.AgntNmnlId).HasColumnName("AGNT_NMNL_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.AgntNmnlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AGNT_NMNL_NAME");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PhneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHNE_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Agnt).WithMany(p => p.AgntNmnls)
                .HasForeignKey(d => d.AgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_NMNL_AGNT");
        });

        modelBuilder.Entity<AgntPrfil>(entity =>
        {
            entity.ToTable("AGNT_PRFIL");

            entity.Property(e => e.AgntPrfilId).HasColumnName("AGNT_PRFIL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntPrfilDetl>(entity =>
        {
            entity.HasKey(e => e.DetlId);

            entity.ToTable("AGNT_PRFIL_DETL");

            entity.Property(e => e.DetlId).HasColumnName("DETL_ID");
            entity.Property(e => e.AgntPrfilId).HasColumnName("AGNT_PRFIL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimtId).HasColumnName("LIMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrvcTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SRVC_TYPE_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntPrfil).WithMany(p => p.AgntPrfilDetls)
                .HasForeignKey(d => d.AgntPrfilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_PRFIL_DETL_AGNT_PRFIL");

            entity.HasOne(d => d.Limt).WithMany(p => p.AgntPrfilDetls)
                .HasForeignKey(d => d.LimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_PRFIL_DETL_LIMT");

            entity.HasOne(d => d.SrvcType).WithMany(p => p.AgntPrfilDetls)
                .HasForeignKey(d => d.SrvcTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_PRFIL_DETL_SRVC_TYPE");
        });

        modelBuilder.Entity<AgntPrftRvsl>(entity =>
        {
            entity.ToTable("AGNT_PRFT_RVSL");

            entity.Property(e => e.AgntPrftRvslId).HasColumnName("AGNT_PRFT_RVSL_ID");
            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsRvrsd).HasColumnName("IS_RVRSD");
            entity.Property(e => e.MoneyDeduct)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MONEY_DEDUCT");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<AgntPrftSetng>(entity =>
        {
            entity.ToTable("AGNT_PRFT_SETNG");

            entity.Property(e => e.AgntPrftSetngId).HasColumnName("AGNT_PRFT_SETNG_ID");
            entity.Property(e => e.AgntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PrftSetngDesc)
                .HasMaxLength(500)
                .HasColumnName("PRFT_SETNG_DESC");
            entity.Property(e => e.PrftSetngName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PRFT_SETNG_NAME");
            entity.Property(e => e.PrftSetngNameLocal)
                .HasMaxLength(250)
                .HasColumnName("PRFT_SETNG_NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntPrftSetngDetl>(entity =>
        {
            entity.ToTable("AGNT_PRFT_SETNG_DETL");

            entity.Property(e => e.AgntPrftSetngDetlId).HasColumnName("AGNT_PRFT_SETNG_DETL_ID");
            entity.Property(e => e.AgntPrftSetngId).HasColumnName("AGNT_PRFT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeePrcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_PRCNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuprAgntFeePrcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SUPR_AGNT_FEE_PRCNT");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AgntRefndInss>(entity =>
        {
            entity.ToTable("AGNT_REFND_INSS");

            entity.Property(e => e.AgntRefndInssId).HasColumnName("AGNT_REFND_INSS_ID");
            entity.Property(e => e.AgntCnclReqId).HasColumnName("AGNT_CNCL_REQ_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.BankAcctDao)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_DAO");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsInssDdct).HasColumnName("IS_INSS_DDCT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntCnclReq).WithMany(p => p.AgntRefndInsses)
                .HasForeignKey(d => d.AgntCnclReqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_REFND_INSS_AGNT_CNCL_REQ");
        });

        modelBuilder.Entity<AgntRestrPrice>(entity =>
        {
            entity.HasKey(e => e.AgntPriceId);

            entity.ToTable("AGNT_RESTR_PRICES");

            entity.Property(e => e.AgntPriceId).HasColumnName("AGNT_PRICE_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_Bp_MAIN_ID");
            entity.Property(e => e.AgntRestrPriceId).HasColumnName("AGNT_RESTR_PRICE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntRestrPriceNavigation).WithMany(p => p.AgntRestrPrices)
                .HasForeignKey(d => d.AgntRestrPriceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGNT_RESTR_PRICES_RESTR_PRICE");
        });

        modelBuilder.Entity<AgntType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_AGN_TYPE");

            entity.ToTable("AGNT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AlhubanUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ALHUBAN_USERS");

            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .HasColumnName("branch");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(50)
                .HasColumnName("employee_name");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<AmfAccount>(entity =>
        {
            entity.HasKey(e => e.AmfCustNo);

            entity.ToTable("AMF_Accounts");

            entity.Property(e => e.AmfCustNo)
                .ValueGeneratedNever()
                .HasColumnName("AMF_CustNo");
            entity.Property(e => e.AmfAccFst).HasColumnName("AMF_Acc_Fst");
            entity.Property(e => e.AmfAmountIncom)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AMF_Amount_Incom");
            entity.Property(e => e.AmfAttNo).HasColumnName("AMF_AttNo");
            entity.Property(e => e.AmfBenCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMF_Ben_Code");
            entity.Property(e => e.AmfBenName)
                .HasMaxLength(100)
                .HasColumnName("AMF_Ben_Name");
            entity.Property(e => e.AmfBlackList).HasColumnName("AMF_BlackList");
            entity.Property(e => e.AmfBranchJoin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMF_Branch_Join");
            entity.Property(e => e.AmfComments)
                .HasMaxLength(50)
                .HasColumnName("AMF_Comments");
            entity.Property(e => e.AmfConfirmHistory).HasColumnName("Amf_ConfirmHistory");
            entity.Property(e => e.AmfCurrentAdd)
                .HasMaxLength(50)
                .HasColumnName("AMF_Current_Add");
            entity.Property(e => e.AmfCustType).HasColumnName("AMF_CustType");
            entity.Property(e => e.AmfCustomerName)
                .HasMaxLength(100)
                .HasColumnName("AMF_CustomerName");
            entity.Property(e => e.AmfDEnd)
                .HasColumnType("smalldatetime")
                .HasColumnName("AMF_D_End");
            entity.Property(e => e.AmfDIssue)
                .HasColumnType("smalldatetime")
                .HasColumnName("AMF_D_Issue");
            entity.Property(e => e.AmfDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("AMF_Date");
            entity.Property(e => e.AmfDateConf)
                .HasColumnType("datetime")
                .HasColumnName("AMF_DateConf");
            entity.Property(e => e.AmfDateTimeEntry)
                .HasColumnType("datetime")
                .HasColumnName("AMF_DateTime_Entry");
            entity.Property(e => e.AmfDateUpd)
                .HasColumnType("datetime")
                .HasColumnName("AMF_Date_Upd");
            entity.Property(e => e.AmfDob)
                .HasColumnType("smalldatetime")
                .HasColumnName("AMF_DOB");
            entity.Property(e => e.AmfEMail)
                .HasMaxLength(100)
                .HasColumnName("AMF_E_Mail");
            entity.Property(e => e.AmfFee).HasColumnName("AMF_Fee");
            entity.Property(e => e.AmfHasUsaNationality).HasColumnName("AMF_Has_USA_Nationality");
            entity.Property(e => e.AmfHoldReason)
                .HasMaxLength(100)
                .HasColumnName("AMF_HoldReason");
            entity.Property(e => e.AmfIdType).HasColumnName("AMF_ID_Type");
            entity.Property(e => e.AmfIdentityNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AMF_IdentityNo");
            entity.Property(e => e.AmfJob).HasColumnName("AMF_Job");
            entity.Property(e => e.AmfMainBen).HasColumnName("AMF_Main_Ben");
            entity.Property(e => e.AmfMomNo).HasColumnName("AMF_Mom_No");
            entity.Property(e => e.AmfPIssue)
                .HasMaxLength(50)
                .HasColumnName("AMF_P_Issue");
            entity.Property(e => e.AmfPob)
                .HasMaxLength(50)
                .HasColumnName("AMF_POB");
            entity.Property(e => e.AmfPointProv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AMF_Point_Prov");
            entity.Property(e => e.AmfPosition).HasColumnName("AMF_position");
            entity.Property(e => e.AmfQualification).HasColumnName("AMF_Qualification");
            entity.Property(e => e.AmfSStatus).HasColumnName("AMF_S_Status");
            entity.Property(e => e.AmfSourceIncom).HasColumnName("AMF_Source_Incom");
            entity.Property(e => e.AmfTelType).HasColumnName("AMF_TelType");
            entity.Property(e => e.AmfTelegram).HasColumnName("AMF_Telegram");
            entity.Property(e => e.AmfTypeEntry).HasColumnName("AMF_TypeEntry");
            entity.Property(e => e.AmfUnicefNo).HasColumnName("AMF_Unicef_No");
            entity.Property(e => e.AmfUsrConf).HasColumnName("AMF_Usr_Conf");
            entity.Property(e => e.AmfUsrEntry).HasColumnName("AMF_Usr_Entry");
            entity.Property(e => e.AmfUsrUpd).HasColumnName("AMF_Usr_Upd");
            entity.Property(e => e.AmfWhatsapp).HasColumnName("AMF_Whatsapp");
            entity.Property(e => e.Sno).HasColumnName("sno");
        });

        modelBuilder.Entity<AmfAgentRequest>(entity =>
        {
            entity.HasKey(e => e.ReqNo);

            entity.ToTable("AMF_AgentRequests");

            entity.Property(e => e.ReqNo)
                .ValueGeneratedNever()
                .HasColumnName("Req_No");
            entity.Property(e => e.AccNo).HasColumnName("Acc_no");
            entity.Property(e => e.AccNoNew).HasColumnName("Acc_no_New");
            entity.Property(e => e.AmfCasheir).HasColumnName("AMF_casheir");
            entity.Property(e => e.AmfCustNo).HasColumnName("AMF_CustNo");
            entity.Property(e => e.AmfState)
                .HasDefaultValueSql("((42))")
                .HasColumnName("AMF_State");
            entity.Property(e => e.AmfUnicefPrint)
                .HasDefaultValueSql("((37))")
                .HasColumnName("AMF_UnicefPrint");
            entity.Property(e => e.CustNo).HasColumnName("Cust_No");
            entity.Property(e => e.CustNoNew).HasColumnName("cust_no_new");
            entity.Property(e => e.ReqActiveGroup).HasColumnName("Req_ActiveGroup");
            entity.Property(e => e.ReqActivityAge)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_ActivityAge");
            entity.Property(e => e.ReqActivityName)
                .HasMaxLength(50)
                .HasColumnName("Req_ActivityName");
            entity.Property(e => e.ReqActivityPlace).HasColumnName("Req_ActivityPlace");
            entity.Property(e => e.ReqActivityType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_ActivityType");
            entity.Property(e => e.ReqAddress)
                .HasMaxLength(150)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_Address");
            entity.Property(e => e.ReqAgentAccount).HasColumnName("Req_AgentAccount");
            entity.Property(e => e.ReqAgentAdd)
                .HasMaxLength(150)
                .HasColumnName("Req_Agent_Add");
            entity.Property(e => e.ReqAgentMobile).HasColumnName("Req_Agent_Mobile");
            entity.Property(e => e.ReqAgentName)
                .HasMaxLength(150)
                .HasColumnName("Req_AgentName");
            entity.Property(e => e.ReqAgentPossibilities).HasColumnName("Req_Agent_possibilities");
            entity.Property(e => e.ReqAgentTel).HasColumnName("Req_Agent_Tel");
            entity.Property(e => e.ReqAgentType).HasColumnName("Req_Agent_Type");
            entity.Property(e => e.ReqAmountInsurance)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Req_Amount_Insurance");
            entity.Property(e => e.ReqAtt).HasColumnName("Req_Att");
            entity.Property(e => e.ReqAttCan).HasColumnName("Req_Att_can");
            entity.Property(e => e.ReqBranchEntry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Req_Branch_Entry");
            entity.Property(e => e.ReqBranchJoin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("Req_Branch_Join");
            entity.Property(e => e.ReqCity)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_City");
            entity.Property(e => e.ReqComments)
                .HasMaxLength(150)
                .HasColumnName("Req_Comments");
            entity.Property(e => e.ReqConfDate)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("date")
                .HasColumnName("Req_ConfDate");
            entity.Property(e => e.ReqConfdateCancel)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("date")
                .HasColumnName("req_confdate_cancel");
            entity.Property(e => e.ReqCountUsr).HasColumnName("Req_Count_Usr");
            entity.Property(e => e.ReqCustSeat).HasColumnName("Req_CustSeat");
            entity.Property(e => e.ReqDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Req_Date");
            entity.Property(e => e.ReqDateTimeEntry)
                .HasColumnType("datetime")
                .HasColumnName("Req_DateTime_Entry");
            entity.Property(e => e.ReqFee).HasColumnName("Req_Fee");
            entity.Property(e => e.ReqGamConf).HasColumnName("Req_GAM_Conf");
            entity.Property(e => e.ReqGover).HasColumnName("Req_Gover");
            entity.Property(e => e.ReqHasActivity).HasColumnName("Req_Has_Activity");
            entity.Property(e => e.ReqHaseb)
                .HasDefaultValueSql("((37))")
                .HasColumnName("Req_Haseb");
            entity.Property(e => e.ReqIdentfire2nd)
                .HasMaxLength(50)
                .HasColumnName("Req_Identfire2nd");
            entity.Property(e => e.ReqIdentfire2ndEpithet).HasColumnName("Req_Identfire2nd_Epithet");
            entity.Property(e => e.ReqIdentfire2ndMobile).HasColumnName("Req_Identfire2nd_Mobile");
            entity.Property(e => e.ReqIdentfire3rd)
                .HasMaxLength(50)
                .HasColumnName("Req_Identfire3rd");
            entity.Property(e => e.ReqIdentfire3rdEpithet).HasColumnName("Req_Identfire3rd_Epithet");
            entity.Property(e => e.ReqIdentfire3rdMobile).HasColumnName("Req_Identfire3rd_Mobile");
            entity.Property(e => e.ReqIdentfireFst)
                .HasMaxLength(50)
                .HasColumnName("Req_IdentfireFst");
            entity.Property(e => e.ReqIdentfireFstEpithet).HasColumnName("Req_IdentfireFst_Epithet");
            entity.Property(e => e.ReqIdentfireFstMobile).HasColumnName("Req_IdentfireFst_Mobile");
            entity.Property(e => e.ReqMarkInStreet)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_MarkInStreet");
            entity.Property(e => e.ReqMarkInVillage)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_MarkInVillage");
            entity.Property(e => e.ReqModereyah).HasColumnName("Req_Modereyah");
            entity.Property(e => e.ReqOzlah).HasColumnName("Req_Ozlah");
            entity.Property(e => e.ReqPaidInsurance).HasColumnName("Req_Paid_Insurance");
            entity.Property(e => e.ReqPointService)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Req_PointService");
            entity.Property(e => e.ReqQuarter)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_Quarter");
            entity.Property(e => e.ReqRCNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Req_R_C_No");
            entity.Property(e => e.ReqShopCustDaily).HasColumnName("Req_Shop_Cust_Daily");
            entity.Property(e => e.ReqShopType).HasColumnName("Req_Shop_type");
            entity.Property(e => e.ReqShopType1).HasColumnName("Req_ShopType");
            entity.Property(e => e.ReqStreet)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_Street");
            entity.Property(e => e.ReqType).HasColumnName("Req_Type");
            entity.Property(e => e.ReqUsrCancel).HasColumnName("Req_Usr_Cancel");
            entity.Property(e => e.ReqUsrChange)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Req_Usr_change");
            entity.Property(e => e.ReqUsrConf).HasColumnName("Req_Usr_Conf");
            entity.Property(e => e.ReqUsrConfCancel).HasColumnName("Req_Usr_Conf_Cancel");
            entity.Property(e => e.ReqUsrConfUpd).HasColumnName("Req_Usr_Conf_Upd");
            entity.Property(e => e.ReqUsrDatechange)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("Req_Usr_Datechange");
            entity.Property(e => e.ReqUsrEntry).HasColumnName("Req_Usr_Entry");
            entity.Property(e => e.ReqUsrUpd).HasColumnName("Req_Usr_Upd");
            entity.Property(e => e.ReqWasHaseb).HasColumnName("Req_WasHaseb");
        });

        modelBuilder.Entity<AmntType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("AMNT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<AsgnBrchRevwr>(entity =>
        {
            entity.ToTable("ASGN_BRCH_REVWR");

            entity.Property(e => e.AsgnBrchRevwrId).HasColumnName("ASGN_BRCH_REVWR_ID");
            entity.Property(e => e.BrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCH_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable("AUDIT_LOGS");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENT_IP");
            entity.Property(e => e.Rqst).HasColumnName("RQST");
            entity.Property(e => e.RqstTime)
                .HasColumnType("datetime")
                .HasColumnName("RQST_TIME");
            entity.Property(e => e.Rspns).HasColumnName("RSPNS");
            entity.Property(e => e.RspnsTime)
                .HasColumnType("datetime")
                .HasColumnName("RSPNS_TIME");
            entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<AutoTrfrSchdl>(entity =>
        {
            entity.ToTable("AUTO_TRFR_SCHDL");

            entity.Property(e => e.AutoTrfrSchdlId).HasColumnName("AUTO_TRFR_SCHDL_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NextPrcsDate)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_PRCS_DATE");
            entity.Property(e => e.ReptSttsCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REPT_STTS_CODE");
            entity.Property(e => e.SchdlDate)
                .HasColumnType("datetime")
                .HasColumnName("SCHDL_DATE");
            entity.Property(e => e.SchdlTime).HasColumnName("SCHDL_TIME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BalanceDiff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BALANCE_DIFF");

            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.Diff)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("diff");
            entity.Property(e => e.TotalBalance).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BANK");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BenProfDoc>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("BEN_PROF_DOC");

            entity.HasIndex(e => new { e.BenProfId, e.OrgId }, "NonClusteredIndex-20200705-092059").HasFillFactor(70);

            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.BenProfId).HasColumnName("BEN_PROF_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocCycleId).HasColumnName("DOC_CYCLE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.UpldDoc).WithMany(p => p.BenProfDocs)
                .HasForeignKey(d => d.UpldDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BEN_PROF_DOC_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<BillAdenNetPymt>(entity =>
        {
            entity.HasKey(e => e.AdenNetPymtId);

            entity.ToTable("BILL_ADEN_NET_PYMT");

            entity.Property(e => e.AdenNetPymtId).HasColumnName("ADEN_NET_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PkgAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PKG_AMNT");
            entity.Property(e => e.PkgName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PKG_NAME");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillAdslPymt>(entity =>
        {
            entity.HasKey(e => e.AdslPymtId);

            entity.ToTable("BILL_ADSL_PYMT");

            entity.Property(e => e.AdslPymtId).HasColumnName("ADSL_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDeciveId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HostDeciveID");
            entity.Property(e => e.IphostAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IPHostAddress");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillAdslPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ADSL_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillAdslPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ADSL_PYMT_ACCT1");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillAdslPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ADSL_PYMT_ACCT");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillAdslPymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ADSL_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillAdslPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ADSL_PYMT_TRAN");
        });

        modelBuilder.Entity<BillElctPymt>(entity =>
        {
            entity.ToTable("BILL_ELCT_PYMT");

            entity.Property(e => e.BillElctPymtId).HasColumnName("BILL_ELCT_PYMT_ID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAddr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADDR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SbcnNmbr).HasColumnName("SBCN_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillElctPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ELCT_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillElctPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ELCT_PYMT_ACCT1");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillElctPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ELCT_PYMT_ACCT");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillElctPymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ELCT_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillElctPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_ELCT_PYMT_TRAN");
        });

        modelBuilder.Entity<BillExtrUrlCnfg>(entity =>
        {
            entity.HasKey(e => e.ExtrUrlCnfgId);

            entity.ToTable("BILL_EXTR_URL_CNFG");

            entity.Property(e => e.ExtrUrlCnfgId).HasColumnName("EXTR_URL_CNFG_ID");
            entity.Property(e => e.AuthBaseUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("AUTH_BASE_URL");
            entity.Property(e => e.AuthEndPoint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("AUTH_END_POINT");
            entity.Property(e => e.AuthTokn)
                .IsUnicode(false)
                .HasColumnName("AUTH_TOKN");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BASE_URL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.EndPoint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("END_POINT");
            entity.Property(e => e.Envr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENVR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Port).HasColumnName("PORT");
            entity.Property(e => e.ProjName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PROJ_NAME");
            entity.Property(e => e.Pswd)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UrlCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("URL_CODE");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<BillLandLinePymt>(entity =>
        {
            entity.HasKey(e => e.LandLinePymtId);

            entity.ToTable("BILL_LAND_LINE_PYMT");

            entity.Property(e => e.LandLinePymtId).HasColumnName("LAND_LINE_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDeciveId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HostDeciveID");
            entity.Property(e => e.IphostAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IPHostAddress");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillLandLinePymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_LAND_LINE_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillLandLinePymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_LAND_LINE_PYMT_ACCT1");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillLandLinePymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_LAND_LINE_PYMT_ACCT");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillLandLinePymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_LAND_LINE_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillLandLinePymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_LAND_LINE_PYMT_TRAN");
        });

        modelBuilder.Entity<BillMtnPkgPymt>(entity =>
        {
            entity.HasKey(e => e.BillMtnPkgPymtId).HasName("PK_MTN_PKG_PYMT");

            entity.ToTable("BILL_MTN_PKG_PYMT");

            entity.Property(e => e.BillMtnPkgPymtId).HasColumnName("BILL_MTN_PKG_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OffrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFFR_CODE");
            entity.Property(e => e.OffrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFFR_NAME");
            entity.Property(e => e.OffrPric)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OFFR_PRIC");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PymtType).HasColumnName("PYMT_TYPE");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillMtnPkgPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PKG_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillMtnPkgPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PKG_PYMT_ACCT");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillMtnPkgPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PKG_PYMT_ACCT1");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillMtnPkgPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PKG_PYMT_TRAN");
        });

        modelBuilder.Entity<BillMtnPymt>(entity =>
        {
            entity.HasKey(e => e.MtnPymtId);

            entity.ToTable("BILL_MTN_PYMT");

            entity.HasIndex(e => e.PerformerId, "IX_performerid,custmob,debtacct");

            entity.Property(e => e.MtnPymtId).HasColumnName("MTN_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillMtnPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillMtnPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PYMT_ACCT");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillMtnPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PYMT_ACCT1");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillMtnPymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillMtnPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_MTN_PYMT_TRAN");
        });

        modelBuilder.Entity<BillPymtRvrsl>(entity =>
        {
            entity.HasKey(e => e.BillPymtRvrslId).HasName("PK__BILL_PYM__720F0D2CA8F81B10");

            entity.ToTable("BILL_PYMT_RVRSL");

            entity.Property(e => e.BillPymtRvrslId).HasColumnName("BILL_PYMT_RVRSL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillPymtRvrslErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BILL_PYMT_RVRSL_ERROR_LOGS");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
        });

        modelBuilder.Entity<BillPymtTblName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BILL_PYMT_TBL_NAMES");

            entity.HasIndex(e => e.TnanTypeCode, "UQ__BILL_PYM__AC8FEB43362F65C7").IsUnique();

            entity.Property(e => e.BillTablName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BILL_TABL_NAME");
            entity.Property(e => e.TnanTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TNAN_TYPE_CODE");
            entity.Property(e => e.TranIdCol)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TRAN_ID_COL");
        });

        modelBuilder.Entity<BillRegn>(entity =>
        {
            entity.HasKey(e => e.BillRegnCode);

            entity.ToTable("BILL_REGN");

            entity.Property(e => e.BillRegnCode)
                .ValueGeneratedNever()
                .HasColumnName("BILL_REGN_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LqdtyCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LQDTY_CODE");
            entity.Property(e => e.RegnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REGN_NAME");
            entity.Property(e => e.RegnNameLocal)
                .HasMaxLength(250)
                .HasColumnName("REGN_NAME_LOCAL");
            entity.Property(e => e.RegnOldCode).HasColumnName("REGN_OLD_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrvcPrvdrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRVC_PRVDR_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillSabaFonePymt>(entity =>
        {
            entity.HasKey(e => e.SabaFonePymtId);

            entity.ToTable("BILL_SABA_FONE_PYMT");

            entity.Property(e => e.SabaFonePymtId).HasColumnName("SABA_FONE_PYMT_ID");
            entity.Property(e => e.AmntUnit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_UNIT");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PymtType).HasColumnName("PYMT_TYPE");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillSrvcPrvdr>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BILL_SRVC_PRVDR");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.AdvcTax)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ADVC_TAX");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.HighLqdtyExtraFeePcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HIGH_LQDTY_EXTRA_FEE_PCNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LowLqdtyExtraFeePcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LOW_LQDTY_EXTRA_FEE_PCNT");
            entity.Property(e => e.MidLqdtyExtraFeePcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MID_LQDTY_EXTRA_FEE_PCNT");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TaxCnfg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TAX_CNFG");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillWatrPymt>(entity =>
        {
            entity.HasKey(e => e.BillWatrPymtId).HasName("PK_WATR_BILL");

            entity.ToTable("BILL_WATR_PYMT");

            entity.Property(e => e.BillWatrPymtId).HasColumnName("BILL_WATR_PYMT_ID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAddr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADDR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SbcnNmbr).HasColumnName("SBCN_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillWatrPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_WATR_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillWatrPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WATR_BILL_ACCT1");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillWatrPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WATR_BILL_ACCT");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillWatrPymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WATR_BILL_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillWatrPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_WATR_PYMT_TRAN");
        });

        modelBuilder.Entity<BillYemnMblPkgPymt>(entity =>
        {
            entity.HasKey(e => e.YemnMblPkgPymtId);

            entity.ToTable("BILL_YEMN_MBL_PKG_PYMT");

            entity.Property(e => e.YemnMblPkgPymtId).HasColumnName("YEMN_MBL_PKG_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OffrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFFR_CODE");
            entity.Property(e => e.OffrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFFR_NAME");
            entity.Property(e => e.OffrPric)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OFFR_PRIC");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PymtType).HasColumnName("PYMT_TYPE");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillYemnMblPymt>(entity =>
        {
            entity.HasKey(e => e.YemnMblPymtId);

            entity.ToTable("BILL_YEMN_MBL_PYMT");

            entity.Property(e => e.YemnMblPymtId).HasColumnName("YEMN_MBL_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BillYgsmPymt>(entity =>
        {
            entity.HasKey(e => e.YgsmPymtId);

            entity.ToTable("BILL_YGSM_PYMT");

            entity.Property(e => e.YgsmPymtId).HasColumnName("YGSM_PYMT_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustMoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBL_NO");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HostDvicId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HOST_DVIC_ID");
            entity.Property(e => e.IpHostAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP_HOST_ADD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RfrncId).HasColumnName("RFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00002')")
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.BillYgsmPymts)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_YGSM_PYMT_CHNL");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.BillYgsmPymtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_YGSM_PYMT_ACCT");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.BillYgsmPymtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_YGSM_PYMT_ACCT1");

            entity.HasOne(d => d.Performer).WithMany(p => p.BillYgsmPymts)
                .HasForeignKey(d => d.PerformerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_YGSM_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.BillYgsmPymts)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_YGSM_PYMT_TRAN");
        });

        modelBuilder.Entity<BkToMf>(entity =>
        {
            entity.ToTable("BK_TO_MF");

            entity.Property(e => e.BkToMfId).HasColumnName("BK_TO_MF_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BankBrchDao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BANK_BRCH_DAO");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(500)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BlckListStpdOprn>(entity =>
        {
            entity.ToTable("BLCK_LIST_STPD_OPRN");

            entity.Property(e => e.BlckListStpdOprnId).HasColumnName("BLCK_LIST_STPD_OPRN_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BsnsOprnDate)
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Ntlty)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NTLTY");
            entity.Property(e => e.Phn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PHN");
            entity.Property(e => e.Pob)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("POB");
            entity.Property(e => e.PrfmrAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PRFMR_ACCT");
            entity.Property(e => e.PrfmrBankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BANK_ACCT_NMBR");
            entity.Property(e => e.PrfmrBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH_CODE");
            entity.Property(e => e.PrfmrBsnsTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BSNS_TYPE_ID");
            entity.Property(e => e.PrfmrCurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_CURR_ID");
            entity.Property(e => e.PrfmrName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PRFMR_NAME");
            entity.Property(e => e.RcvrAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RCVR_ACCT");
            entity.Property(e => e.RcvrBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH_CODE");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BpDetl>(entity =>
        {
            entity.HasKey(e => e.BpDetlId).HasName("PK__USER_DETL");

            entity.ToTable("BP_DETL");

            entity.HasIndex(e => e.BpMainId, "IX_BP_DETL_BP_MAIN_ID");

            entity.HasIndex(e => e.Phon, "IX_PHONENUMBER");

            entity.Property(e => e.BpDetlId).HasColumnName("BP_DETL_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CityCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Eml)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EML");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.IdIssuDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_ISSU_DATE");
            entity.Property(e => e.IdNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ID_NMBR");
            entity.Property(e => e.IdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.IdXpirDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_XPIR_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");

            entity.HasOne(d => d.BpMain).WithMany(p => p.BpDetls)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BP_DETL_BP_MAIN");
        });

        modelBuilder.Entity<BpDetl09May>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BP_DETL_09_may");

            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.BpDetlId).HasColumnName("BP_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CityCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Eml)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EML");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.IdIssuDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_ISSU_DATE");
            entity.Property(e => e.IdNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ID_NMBR");
            entity.Property(e => e.IdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.IdXpirDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_XPIR_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");
        });

        modelBuilder.Entity<BpDetlPra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BP_DETL_PRA");

            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.BpDetlId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BP_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Eml)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EML");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BpMain>(entity =>
        {
            entity.ToTable("BP_MAIN");

            entity.HasIndex(e => new { e.BpSecdId, e.BpType }, "IX_BP_SEC_ID,BP_TYPE");

            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.BrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCH_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BpTypeNavigation).WithMany(p => p.BpMains)
                .HasForeignKey(d => d.BpType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BP_MAIN_CLNT_ROLE_TYPE");

            entity.HasOne(d => d.BrchCodeNavigation).WithMany(p => p.BpMains)
                .HasForeignKey(d => d.BrchCode)
                .HasConstraintName("FK_BP_MAIN_BRCH_CODE");
        });

        modelBuilder.Entity<BpSysUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_USER");

            entity.ToTable("BP_SYS_USER");

            entity.HasIndex(e => e.BrchCode, "IX_BP_SYS_USER_BRCH_CODE");

            entity.HasIndex(e => e.Businesspartnerid, "IX_BUSINESSPARTNERID");

            entity.HasIndex(e => e.UserStts, "IX_USER_STTS");

            entity.HasIndex(e => e.UserName, "UC_BP_SYS_USER").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.AccsFailCount).HasColumnName("ACCS_FAIL_COUNT");
            entity.Property(e => e.BrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCH_CODE");
            entity.Property(e => e.Businesspartnerid).HasColumnName("BUSINESSPARTNERID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFrstLogin).HasColumnName("IS_FRST_LOGIN");
            entity.Property(e => e.LangCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.LockOutEnab).HasColumnName("LOCK_OUT_ENAB");
            entity.Property(e => e.LockOutEnd)
                .HasColumnType("datetime")
                .HasColumnName("LOCK_OUT_END");
            entity.Property(e => e.Pswd).HasColumnName("PSWD");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TwoFactEnab).HasColumnName("TWO_FACT_ENAB");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UserStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_STTS");

            entity.HasOne(d => d.BrchCodeNavigation).WithMany(p => p.BpSysUsers)
                .HasForeignKey(d => d.BrchCode)
                .HasConstraintName("FK_USER_BRCH");

            entity.HasOne(d => d.Businesspartner).WithMany(p => p.BpSysUsers)
                .HasForeignKey(d => d.Businesspartnerid)
                .HasConstraintName("FK_BP_SYS_USER_BUSINESSPARTNERID1");
        });

        modelBuilder.Entity<Brch>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__BRCH__B9FEEA52F9A00767");

            entity.ToTable("BRCH");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.BrchAdrs)
                .HasMaxLength(250)
                .HasColumnName("BRCH_ADRS");
            entity.Property(e => e.BrchDao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRCH_DAO");
            entity.Property(e => e.BrchId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BRCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsMainBrch).HasColumnName("IS_MAIN_BRCH");
            entity.Property(e => e.LqdtyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY_CODE");
            entity.Property(e => e.MfloosSpclstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MFLOOS_SPCLST_NAME");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.OnyxBrchGrpId).HasColumnName("ONYX_BRCH_GRP_ID");
            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.Wrkqstts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WRKQSTTS");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
        });

        modelBuilder.Entity<BrchDr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BRCH_DR");

            entity.Property(e => e.BrchAdrs)
                .HasMaxLength(250)
                .HasColumnName("BRCH_ADRS");
            entity.Property(e => e.BrchDao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRCH_DAO");
            entity.Property(e => e.BrchId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BRCH_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostCntr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COST_CNTR");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.GrpCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GRP_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsMainBrch).HasColumnName("IS_MAIN_BRCH");
            entity.Property(e => e.LqdtyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY_CODE");
            entity.Property(e => e.MfloosSpclstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MFLOOS_SPCLST_NAME");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.OnyxBrchGrpId).HasColumnName("ONYX_BRCH_GRP_ID");
            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.Wrkqstts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WRKQSTTS");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
        });

        modelBuilder.Entity<BrchLqdty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BRCH_LQDTY");

            entity.Property(e => e.BranchId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.Liquidtiy)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RegionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Region_Name");
        });

        modelBuilder.Entity<BsnsAcctType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BSNS_ACCT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BsnsPrtn>(entity =>
        {
            entity.ToTable("BSNS_PRTN");

            entity.Property(e => e.BsnsPrtnId).HasColumnName("BSNS_PRTN_ID");
            entity.Property(e => e.AcctNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ACCT_NO");
            entity.Property(e => e.BankCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BANK_CODE");
            entity.Property(e => e.BsnsPrtnDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BSNS_PRTN_DESC");
            entity.Property(e => e.BsnsPrtnItrnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BSNS_PRTN_ITRN_TYPE_CODE");
            entity.Property(e => e.BsnsPrtnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BSNS_PRTN_NAME");
            entity.Property(e => e.BsnsPrtnNameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BSNS_PRTN_NAME_LOCAL");
            entity.Property(e => e.BsnsPrtnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BSNS_PRTN_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.SwftCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SWFT_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BankCodeNavigation).WithMany(p => p.BsnsPrtns)
                .HasForeignKey(d => d.BankCode)
                .HasConstraintName("FK_BSNS_PRTN_BANK");

            entity.HasOne(d => d.BsnsPrtnItrnTypeCodeNavigation).WithMany(p => p.BsnsPrtns)
                .HasForeignKey(d => d.BsnsPrtnItrnTypeCode)
                .HasConstraintName("FK_BSNS_PRTN_BSNS_PRTN_ITRN_TYPE");

            entity.HasOne(d => d.BsnsPrtnTypeCodeNavigation).WithMany(p => p.BsnsPrtns)
                .HasForeignKey(d => d.BsnsPrtnTypeCode)
                .HasConstraintName("FK_BSNS_PRTN_BSNS_PRTN_TYPE");

            entity.HasOne(d => d.StatusTypeCodeNavigation).WithMany(p => p.BsnsPrtns)
                .HasForeignKey(d => d.StatusTypeCode)
                .HasConstraintName("FK_BSNS_PRTN_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<BsnsPrtnItrnType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BSNS_PRTN_ITRN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<BsnsPrtnType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BSNS_PRTN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CashWdrl>(entity =>
        {
            entity.ToTable("CASH_WDRL");

            entity.Property(e => e.CashWdrlId).HasColumnName("CASH_WDRL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Debtacct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBTACCT");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.OprnCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("OPRN_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.TrgtAgntCode).HasColumnName("TRGT_AGNT_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WdrlAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WDRL_AMNT");

            entity.HasOne(d => d.BpMain).WithMany(p => p.CashWdrls)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CASH_WDRL_BP_MAIN");

            entity.HasOne(d => d.SttsTypeCodeNavigation).WithMany(p => p.CashWdrls)
                .HasForeignKey(d => d.SttsTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CASH_WDRL_FIN_REQ_STTS_TYPE");
        });

        modelBuilder.Entity<CashWdrlDetl>(entity =>
        {
            entity.ToTable("CASH_WDRL_DETL");

            entity.HasIndex(e => e.CashWdrlId, "NonClusteredIndex-20200611-122537").HasFillFactor(70);

            entity.Property(e => e.CashWdrlDetlId).HasColumnName("CASH_WDRL_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.CashWdrlId).HasColumnName("CASH_WDRL_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CreditAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREDIT_ACCT");
            entity.Property(e => e.DebitAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBIT_ACCT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BpMain).WithMany(p => p.CashWdrlDetls)
                .HasForeignKey(d => d.BpMainId)
                .HasConstraintName("FK_CASH_WDRL_DETL_BP_MAIN");

            entity.HasOne(d => d.CashWdrl).WithMany(p => p.CashWdrlDetls)
                .HasForeignKey(d => d.CashWdrlId)
                .HasConstraintName("FK_CASH_WDRL_DETL_CASH_WDRL_MAIN");
        });

        modelBuilder.Entity<CashWdrlMain>(entity =>
        {
            entity.HasKey(e => e.CashWdrlId);

            entity.ToTable("CASH_WDRL_MAIN");

            entity.HasIndex(e => e.CashWdrlNo, "CASH_WDRL_NO");

            entity.Property(e => e.CashWdrlId).HasColumnName("CASH_WDRL_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BankAcctBrchDao)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_BRCH_DAO");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.CashWdrlNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CASH_WDRL_NO");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_TYPE");
            entity.Property(e => e.CustName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NAME");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.PayLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAY_LQDTY");
            entity.Property(e => e.PayLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAY_LQDTY_FEE");
            entity.Property(e => e.PaydByQrCode).HasColumnName("PAYD_BY_QR_CODE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.TrgtAgntCode).HasColumnName("TRGT_AGNT_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.SttsTypeCodeNavigation).WithMany(p => p.CashWdrlMains)
                .HasForeignKey(d => d.SttsTypeCode)
                .HasConstraintName("FK_CASH_WDRL_MAIN_FIN_REQ_STTS_TYPE");
        });

        modelBuilder.Entity<CashWdrlMainT24DaoCorrection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASH_WDRL_MAIN_T24_DAO_CORRECTION");

            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BankAcctBrchDao)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_BRCH_DAO");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.CashWdrlId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CASH_WDRL_ID");
            entity.Property(e => e.CashWdrlNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CASH_WDRL_NO");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_TYPE");
            entity.Property(e => e.CustName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NAME");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.PayLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAY_LQDTY");
            entity.Property(e => e.PayLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAY_LQDTY_FEE");
            entity.Property(e => e.PaydByQrCode).HasColumnName("PAYD_BY_QR_CODE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.TrgtAgntCode).HasColumnName("TRGT_AGNT_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CatgType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("CATG_TYPE_CODE");

            entity.ToTable("CATG_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CbtApril21>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-April21");

            entity.Property(e => e.CardNumber).HasColumnName("Card_Number");
        });

        modelBuilder.Entity<CbtFebCycle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-Feb-Cycle");

            entity.Property(e => e.CardNumber).HasColumnName("Card_Number");
            entity.Property(e => e.FinancialNumber).HasColumnName("Financial_Number");
        });

        modelBuilder.Entity<CbtFebCycle1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-Feb-Cycle1");

            entity.Property(e => e.CardNo).HasColumnName("Card_No");
        });

        modelBuilder.Entity<CbtJune21>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-JUNE21");

            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .HasColumnName("column1");
            entity.Property(e => e.Column2).HasColumnName("column2");
        });

        modelBuilder.Entity<CbtMarch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-MARCH");

            entity.Property(e => e.CardNumber).HasColumnName("Card_Number");
        });

        modelBuilder.Entity<CbtMarch1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-MARCH1");

            entity.Property(e => e.CardNo).HasColumnName("card_No");
        });

        modelBuilder.Entity<CbtMay21>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBT-MAY'21");

            entity.Property(e => e.CardNumber).HasColumnName("Card_Number");
            entity.Property(e => e.SN)
                .HasMaxLength(50)
                .HasColumnName("S_N");
        });

        modelBuilder.Entity<CertType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("CERT_TYPE_CODE");

            entity.ToTable("CERT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<ChkrBrchMngr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Chkr_Brch_Mngr");

            entity.Property(e => e.BranchId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.Brithday).HasColumnType("date");
            entity.Property(e => e.Disgnation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<ChkrMfloosDev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Chkr_Mfloos_Dev");

            entity.Property(e => e.BranchId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.Brithday).HasColumnType("date");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("Description ");
            entity.Property(e => e.Disgnation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<ChkrRegnMngr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Chkr_REGN_MNGR");

            entity.Property(e => e.BranchId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.Brithday).HasColumnType("date");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("Description ");
            entity.Property(e => e.Disgnation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<ChldPrntDesgMap>(entity =>
        {
            entity.HasKey(e => e.PrntChldDesgMapId).HasName("PK_PRNT_CHLD_DESG_MAP");

            entity.ToTable("CHLD_PRNT_DESG_MAP");

            entity.Property(e => e.PrntChldDesgMapId).HasColumnName("PRNT_CHLD_DESG_MAP_ID");
            entity.Property(e => e.ChldDesg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHLD_DESG");
            entity.Property(e => e.ChldId).HasColumnName("CHLD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PrntDesg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRNT_DESG");
            entity.Property(e => e.PrntId).HasColumnName("PRNT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChldDesgNavigation).WithMany(p => p.ChldPrntDesgMapChldDesgNavigations)
                .HasForeignKey(d => d.ChldDesg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHLD_PRNT_DESG_MAP_USER_DESG_TYPE1");

            entity.HasOne(d => d.Chld).WithMany(p => p.ChldPrntDesgMapChlds)
                .HasForeignKey(d => d.ChldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHLD_PRNT_DESG_MAP_BP_SYS_USER1");

            entity.HasOne(d => d.PrntDesgNavigation).WithMany(p => p.ChldPrntDesgMapPrntDesgNavigations)
                .HasForeignKey(d => d.PrntDesg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHLD_PRNT_DESG_MAP_USER_DESG_TYPE");

            entity.HasOne(d => d.Prnt).WithMany(p => p.ChldPrntDesgMapPrnts)
                .HasForeignKey(d => d.PrntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHLD_PRNT_DESG_MAP_BP_SYS_USER");
        });

        modelBuilder.Entity<Chnl>(entity =>
        {
            entity.ToTable("CHNL");

            entity.Property(e => e.ChnlId).HasColumnName("CHNL_ID");
            entity.Property(e => e.ChnlDesc)
                .HasMaxLength(500)
                .HasColumnName("CHNL_DESC");
            entity.Property(e => e.ChnlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_NAME");
            entity.Property(e => e.ChnlNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CHNL_NAME_LOCAL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OutUrl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OUT_URL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.StatusTypeCodeNavigation).WithMany(p => p.Chnls)
                .HasForeignKey(d => d.StatusTypeCode)
                .HasConstraintName("FK_CHNL_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<ChnlDtl>(entity =>
        {
            entity.ToTable("CHNL_DTL");

            entity.Property(e => e.ChnlDtlId).HasColumnName("CHNL_DTL_ID");
            entity.Property(e => e.ChnlId).HasColumnName("CHNL_ID");
            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Chnl).WithMany(p => p.ChnlDtls)
                .HasForeignKey(d => d.ChnlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHNL_DTL_CHNL");

            entity.HasOne(d => d.CmsnPrfl).WithMany(p => p.ChnlDtls)
                .HasForeignKey(d => d.CmsnPrflId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHNL_DTL_CMSN_PRFL");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("City_CODE");

            entity.ToTable("CITY");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CntyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Cnty).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CntyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CITY_CNTY");
        });

        modelBuilder.Entity<ClntApp>(entity =>
        {
            entity.HasKey(e => e.AppId).HasName("PK_CLNT_APPS");

            entity.ToTable("CLNT_APP");

            entity.Property(e => e.AppId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("APP_ID");
            entity.Property(e => e.AppCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APP_CODE");
            entity.Property(e => e.AppDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("APP_DESC");
            entity.Property(e => e.AppName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("APP_NAME");
            entity.Property(e => e.AppScrt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("APP_SCRT");
            entity.Property(e => e.AppVer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APP_VER");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.InMntnce).HasColumnName("IN_MNTNCE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsVerForced).HasColumnName("IS_VER_FORCED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<ClntRoleType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CLNT_ROL__D02AA36E2292E276");

            entity.ToTable("CLNT_ROLE_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CmplncActn>(entity =>
        {
            entity.HasKey(e => e.CmplncId);

            entity.ToTable("CMPLNC_ACTN");

            entity.Property(e => e.CmplncId).HasColumnName("CMPLNC_ID");
            entity.Property(e => e.ActnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACTN_TYPE");
            entity.Property(e => e.CmplncDesc)
                .HasMaxLength(500)
                .HasColumnName("CMPLNC_DESC");
            entity.Property(e => e.CmplncName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CMPLNC_NAME");
            entity.Property(e => e.CmplncNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CMPLNC_NAME_LOCAL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Cmsn>(entity =>
        {
            entity.ToTable("CMSN");

            entity.Property(e => e.CmsnId).HasColumnName("CMSN_ID");
            entity.Property(e => e.CmsnCalcTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_CALC_TYPE_CODE");
            entity.Property(e => e.CmsnDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_DESC");
            entity.Property(e => e.CmsnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_NAME");
            entity.Property(e => e.CmsnNameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_NAME_LOCAL");
            entity.Property(e => e.CmsnPerdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_PERD_TYPE_CODE");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FlatCmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FLAT_CMSN");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PcntCalcOn).HasColumnName("PCNT_CALC_ON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.TierDtrmBy).HasColumnName("TIER_DTRM_BY");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CmsnCalcTypeCodeNavigation).WithMany(p => p.Cmsns)
                .HasForeignKey(d => d.CmsnCalcTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_CMSN_TYPE");

            entity.HasOne(d => d.CmsnPerdTypeCodeNavigation).WithMany(p => p.Cmsns)
                .HasForeignKey(d => d.CmsnPerdTypeCode)
                .HasConstraintName("FK_CMSN_CMSN_PERD_TYPE");

            entity.HasOne(d => d.CrcyTypeCodeNavigation).WithMany(p => p.Cmsns)
                .HasForeignKey(d => d.CrcyTypeCode)
                .HasConstraintName("FK_CMSN_CRCY_TYPE");
        });

        modelBuilder.Entity<CmsnCalcType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CMSN_CALC_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CmsnDay>(entity =>
        {
            entity.HasKey(e => e.CmsnDaysId);

            entity.ToTable("CMSN_DAYS");

            entity.Property(e => e.CmsnDaysId).HasColumnName("CMSN_DAYS_ID");
            entity.Property(e => e.CmsnId).HasColumnName("CMSN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fri).HasColumnName("FRI");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.FromTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("FROM_TIME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Mon).HasColumnName("MON");
            entity.Property(e => e.Sat).HasColumnName("SAT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Sun).HasColumnName("SUN");
            entity.Property(e => e.Thu).HasColumnName("THU");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.ToTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TO_TIME");
            entity.Property(e => e.Tue).HasColumnName("TUE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.Wed).HasColumnName("WED");

            entity.HasOne(d => d.Cmsn).WithMany(p => p.CmsnDays)
                .HasForeignKey(d => d.CmsnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_DAYS_CMSN");
        });

        modelBuilder.Entity<CmsnDetl>(entity =>
        {
            entity.ToTable("CMSN_DETL");

            entity.Property(e => e.CmsnDetlId).HasColumnName("CMSN_DETL_ID");
            entity.Property(e => e.CmsnId).HasColumnName("CMSN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPcnt).HasColumnName("IS_PCNT");
            entity.Property(e => e.Lqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY");
            entity.Property(e => e.MaxCmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAX_CMSN");
            entity.Property(e => e.MinCmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN_CMSN");
            entity.Property(e => e.Pcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PCNT");
            entity.Property(e => e.PerdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PERD_TYPE_CODE");
            entity.Property(e => e.RngeEnd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RNGE_END");
            entity.Property(e => e.RngeStrt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RNGE_STRT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Cmsn).WithMany(p => p.CmsnDetls)
                .HasForeignKey(d => d.CmsnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_DETL_CMSN");
        });

        modelBuilder.Entity<CmsnDistDetl>(entity =>
        {
            entity.ToTable("CMSN_DIST_DETL");

            entity.HasIndex(e => e.AcctNo, "IX_Ahmed_08102019").HasFillFactor(70);

            entity.HasIndex(e => e.TranTypeCode, "IX_TRAN_TYPE_CODE");

            entity.Property(e => e.CmsnDistDetlId).HasColumnName("CMSN_DIST_DETL_ID");
            entity.Property(e => e.AcctNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCT_NO");
            entity.Property(e => e.BsnsPrtnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BSNS_PRTN_TYPE");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Pcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PCNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<CmsnGroup>(entity =>
        {
            entity.ToTable("CMSN_GROUP");

            entity.Property(e => e.CmsnGroupId).HasColumnName("CMSN_GROUP_ID");
            entity.Property(e => e.CmsnGroupName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CMSN_GROUP_NAME");
            entity.Property(e => e.CmsnGroupNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CMSN_GROUP_NAME_LOCAL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CmsnGroupDetl>(entity =>
        {
            entity.ToTable("CMSN_GROUP_DETL");

            entity.Property(e => e.CmsnGroupDetlId).HasColumnName("CMSN_GROUP_DETL_ID");
            entity.Property(e => e.CmsnGroupId).HasColumnName("CMSN_GROUP__ID");
            entity.Property(e => e.CmsnId).HasColumnName("CMSN_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Lqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CmsnPerdType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CMSN_PERD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CmsnPrfl>(entity =>
        {
            entity.ToTable("CMSN_PRFL");

            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CmsnId).HasColumnName("CMSN_ID");
            entity.Property(e => e.CmsnPrflDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_PRFL_DESC");
            entity.Property(e => e.CmsnPrflName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_PRFL_NAME");
            entity.Property(e => e.CmsnPrflNameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CMSN_PRFL_NAME_LOCAL");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CrcyTypeCodeNavigation).WithMany(p => p.CmsnPrfls)
                .HasForeignKey(d => d.CrcyTypeCode)
                .HasConstraintName("FK_CMSN_PRFL_CRCY_TYPE");

            entity.HasOne(d => d.StatusTypeCodeNavigation).WithMany(p => p.CmsnPrfls)
                .HasForeignKey(d => d.StatusTypeCode)
                .HasConstraintName("FK_CMSN_PRFL_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<CmsnPrflDetl>(entity =>
        {
            entity.ToTable("CMSN_PRFL_DETL");

            entity.Property(e => e.CmsnPrflDetlId).HasColumnName("CMSN_PRFL_DETL_ID");
            entity.Property(e => e.BsnsPrtnId).HasColumnName("BSNS_PRTN_ID");
            entity.Property(e => e.CmsnGroupId).HasColumnName("CMSN_GROUP_ID");
            entity.Property(e => e.CmsnPcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_PCNT");
            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BsnsPrtn).WithMany(p => p.CmsnPrflDetls)
                .HasForeignKey(d => d.BsnsPrtnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_PRFL_DETL_BSNS_PRTN");

            entity.HasOne(d => d.CmsnPrfl).WithMany(p => p.CmsnPrflDetls)
                .HasForeignKey(d => d.CmsnPrflId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_PRFL_DETL_CMSN_PRFL");

            entity.HasOne(d => d.Tran).WithMany(p => p.CmsnPrflDetls)
                .HasForeignKey(d => d.TranId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSN_PRFL_DETL_TRAN");
        });

        modelBuilder.Entity<CnclChrg>(entity =>
        {
            entity.ToTable("CNCL_CHRG");

            entity.Property(e => e.CnclChrgId).HasColumnName("CNCL_CHRG_ID");
            entity.Property(e => e.CnclChrgPercnt)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CNCL_CHRG_PERCNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TransTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRANS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CntctU>(entity =>
        {
            entity.HasKey(e => e.CntctUsId);

            entity.ToTable("CNTCT_US");

            entity.Property(e => e.CntctUsId).HasColumnName("CNTCT_US_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Msg)
                .HasMaxLength(1000)
                .HasColumnName("MSG");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");
        });

        modelBuilder.Entity<Cnty>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CNTY");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.GamCntyCode)
                .HasMaxLength(5)
                .HasColumnName("GAM_CNTY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Corp>(entity =>
        {
            entity.ToTable("CORP");

            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.AcctNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCT_NMBR");
            entity.Property(e => e.CorpAddress)
                .HasMaxLength(500)
                .HasColumnName("CORP_ADDRESS");
            entity.Property(e => e.CorpCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CORP_CODE");
            entity.Property(e => e.CorpDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CORP_DESC");
            entity.Property(e => e.CorpName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CORP_NAME");
            entity.Property(e => e.CorpNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CORP_NAME_LOCAL");
            entity.Property(e => e.CorpStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CORP_STTS");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MoblNmbr).HasColumnName("MOBL_NMBR");
            entity.Property(e => e.RcvrPhon).HasColumnName("RCVR_PHON");
            entity.Property(e => e.RpstvName)
                .HasMaxLength(250)
                .HasColumnName("RPSTV_NAME");
            entity.Property(e => e.SendOtp).HasColumnName("SEND_OTP");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CorpSttsNavigation).WithMany(p => p.Corps)
                .HasForeignKey(d => d.CorpStts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_ORG_STTS");

            entity.HasOne(d => d.Doc).WithMany(p => p.Corps)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<CorpAgentRemtTemp>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("CorpAgentRemtTemp");

            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CardNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARD_NUMB");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.FinaNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINA_NUMB");
        });

        modelBuilder.Entity<CorpAgntFileUpldDoc>(entity =>
        {
            entity.HasKey(e => e.CorpAgntFileUpldId).HasName("PK__CORP_AGN__16862B8EE9A34C85");

            entity.ToTable("CORP_AGNT_FILE_UPLD_DOC");

            entity.Property(e => e.CorpAgntFileUpldId).HasColumnName("CORP_AGNT_FILE_UPLD_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.DocType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOC_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpAlwdBrch>(entity =>
        {
            entity.ToTable("CORP_ALWD_BRCH");

            entity.Property(e => e.CorpAlwdBrchId).HasColumnName("CORP_ALWD_BRCH_ID");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpAlwdBrchDetl>(entity =>
        {
            entity.ToTable("CORP_ALWD_BRCH_DETL");

            entity.Property(e => e.CorpAlwdBrchDetlId).HasColumnName("CORP_ALWD_BRCH_DETL_ID");
            entity.Property(e => e.BrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCH_CODE");
            entity.Property(e => e.CorpAlwdBrchId).HasColumnName("CORP_ALWD_BRCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpApiUser>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__CORP_API__E0B75F6E4ADE5F05");

            entity.ToTable("CORP_API_USER");

            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Pswd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PSWD");
        });

        modelBuilder.Entity<CorpAsgndRemt>(entity =>
        {
            entity.ToTable("CORP_ASGND_REMT");

            entity.HasIndex(e => new { e.CorpId, e.CorpCyclId, e.CorpRemtId }, "UK_CORP_ASGND_REMT").IsUnique();

            entity.Property(e => e.CorpAsgndRemtId).HasColumnName("CORP_ASGND_REMT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsDownloaded).HasColumnName("IS_DOWNLOADED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpAsgndRemtHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CORP_ASGND_REMT_HIST");

            entity.Property(e => e.AsgndStts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASGND_STTS");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CorpAsgndRemtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CORP_ASGND_REMT_ID");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpAssgnRvwrBrch>(entity =>
        {
            entity.HasKey(e => e.CorpAssgnRvwrBrchId).HasName("PK__CORP_ASS__98ED95542E363CD4");

            entity.ToTable("CORP_ASSGN_RVWR_BRCH");

            entity.Property(e => e.CorpAssgnRvwrBrchId).HasColumnName("CORP_ASSGN_RVWR_BRCH_ID");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RvwrId).HasColumnName("RVWR_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpAssgnRvwrBrchDetl>(entity =>
        {
            entity.HasKey(e => e.CorpAssgnRvwrBrchDetlId).HasName("PK__CORP_ASS__E623FD77292D33A2");

            entity.ToTable("CORP_ASSGN_RVWR_BRCH_DETL");

            entity.Property(e => e.CorpAssgnRvwrBrchDetlId).HasColumnName("CORP_ASSGN_RVWR_BRCH_DETL_ID");
            entity.Property(e => e.BrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCH_CODE");
            entity.Property(e => e.CorpAssgnRvwrBrchId).HasColumnName("CORP_ASSGN_RVWR_BRCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpCycl>(entity =>
        {
            entity.HasKey(e => e.CyclId);

            entity.ToTable("CORP_CYCL");

            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.BatchDate)
                .HasColumnType("date")
                .HasColumnName("BATCH_DATE");
            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CYCL_DESC");
            entity.Property(e => e.CyclName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CYCL_NAME");
            entity.Property(e => e.CyclNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CYCL_NAME_LOCAL");
            entity.Property(e => e.CyclProcStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CYCL_PROC_STTS");
            entity.Property(e => e.CyclStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CYCL_STTS");
            entity.Property(e => e.ExpDate)
                .HasColumnType("date")
                .HasColumnName("EXP_DATE");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.FeesGroupId).HasColumnName("FEES_GROUP_ID");
            entity.Property(e => e.InsurBlokPerc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("INSUR_BLOK_PERC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFeeDdctFrmBen).HasColumnName("IS_FEE_DDCT_FRM_BEN");
            entity.Property(e => e.LetterDate)
                .HasColumnType("date")
                .HasColumnName("LETTER_DATE");
            entity.Property(e => e.Lqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StrtDate)
                .HasColumnType("date")
                .HasColumnName("STRT_DATE");
            entity.Property(e => e.Totamnt)
                .HasColumnType("decimal(24, 4)")
                .HasColumnName("TOTAMNT");
            entity.Property(e => e.Totremi).HasColumnName("TOTREMI");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Corp).WithMany(p => p.CorpCycls)
                .HasForeignKey(d => d.CorpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_CYCL_CORP");
        });

        modelBuilder.Entity<CorpCyclDetl>(entity =>
        {
            entity.ToTable("CORP_CYCL_DETL");

            entity.Property(e => e.CorpCyclDetlId).HasColumnName("CORP_CYCL_DETL_ID");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsPrcntCmsn).HasColumnName("IS_PRCNT_CMSN");
            entity.Property(e => e.IsPrcntFee).HasColumnName("IS_PRCNT_FEE");
            entity.Property(e => e.Liquidity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LIQUIDITY");
            entity.Property(e => e.LoctType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LOCT_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CorpCycl).WithMany(p => p.CorpCyclDetls)
                .HasForeignKey(d => d.CorpCyclId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_CYCL_DETL_CORP_CYCL");
        });

        modelBuilder.Entity<CorpDoc>(entity =>
        {
            entity.HasKey(e => e.CorpDocId).HasName("PK__CORP_DOC__76AB8AD9353223BF");

            entity.ToTable("CORP_DOC");

            entity.HasIndex(e => e.CorpRemtId, "IX_REMT_ID");

            entity.Property(e => e.CorpDocId).HasColumnName("CORP_DOC_ID");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ReviewStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVIEW_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CorpRemt).WithMany(p => p.CorpDocs)
                .HasForeignKey(d => d.CorpRemtId)
                .HasConstraintName("FK_CORP_DOC_CORP_REMT");

            entity.HasOne(d => d.Doc).WithMany(p => p.CorpDocs)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CORP_DOC_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<CorpFileUpldDoc>(entity =>
        {
            entity.HasKey(e => e.CorpFileUpldDocId).HasName("PK__CORP_FIL__5488BC6A710ADD60");

            entity.ToTable("CORP_FILE_UPLD_DOC");

            entity.Property(e => e.CorpFileUpldDocId).HasColumnName("CORP_FILE_UPLD_DOC_ID");
            entity.Property(e => e.AprvStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APRV_STTS");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.DocType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DOC_TYPE");

            entity.HasOne(d => d.Corp).WithMany(p => p.CorpFileUpldDocs)
                .HasForeignKey(d => d.CorpId)
                .HasConstraintName("FK_CORP_FILE_UPLD_DOC_CORP_ID");

            entity.HasOne(d => d.Cycl).WithMany(p => p.CorpFileUpldDocs)
                .HasForeignKey(d => d.CyclId)
                .HasConstraintName("FK_CORP_FILE_UPLD_DOC_CORP_CYCL");

            entity.HasOne(d => d.Doc).WithMany(p => p.CorpFileUpldDocs)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_CORP_FILE_UPLD_DOC_UPLD_DOC_ID");
        });

        modelBuilder.Entity<CorpInssRefundReq>(entity =>
        {
            entity.ToTable("CORP_INSS_REFUND_REQ");

            entity.Property(e => e.CorpInssRefundReqId).HasColumnName("CORP_INSS_REFUND_REQ_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpLoct>(entity =>
        {
            entity.HasKey(e => e.CorpLoctId).HasName("PK__CORP_LOC__856DBA82023D29E3");

            entity.ToTable("CORP_LOCT");

            entity.HasIndex(e => e.LoctName, "AK_CORP_LOCT_LOCT_NAME").IsUnique();

            entity.Property(e => e.CorpLoctId).HasColumnName("CORP_LOCT_ID");
            entity.Property(e => e.AprvStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APRV_STTS");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.ExpirDate)
                .HasColumnType("date")
                .HasColumnName("EXPIR_DATE");
            entity.Property(e => e.FmalCshr).HasColumnName("FMAL_CSHR");
            entity.Property(e => e.FmalStaf).HasColumnName("FMAL_STAF");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.ImagDocId).HasColumnName("IMAG_DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LatiTude)
                .HasMaxLength(200)
                .HasColumnName("LATI_TUDE");
            entity.Property(e => e.LngiTude)
                .HasMaxLength(100)
                .HasColumnName("LNGI_TUDE");
            entity.Property(e => e.LoctName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOCT_NAME");
            entity.Property(e => e.LoctNameLoc)
                .HasMaxLength(500)
                .HasColumnName("LOCT_NAME_LOC");
            entity.Property(e => e.LoctType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LOCT_TYPE");
            entity.Property(e => e.MaleCshr).HasColumnName("MALE_CSHR");
            entity.Property(e => e.MaleStaf).HasColumnName("MALE_STAF");
            entity.Property(e => e.OldSiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OLD_SITE_CODE");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StrtDate)
                .HasColumnType("date")
                .HasColumnName("STRT_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");

            entity.HasOne(d => d.BpMain).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.BpMainId)
                .HasConstraintName("FK_CORP_LOCT_BP_MAIN");

            entity.HasOne(d => d.DistCodeNavigation).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.DistCode)
                .HasConstraintName("FK_CORP_LOCT_DIST");

            entity.HasOne(d => d.GvrnCodeNavigation).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.GvrnCode)
                .HasConstraintName("FK_CORP_LOCT_GVRN");

            entity.HasOne(d => d.ImagDoc).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.ImagDocId)
                .HasConstraintName("FK_CORP_LOCT_UPLD_DOC_DETL");

            entity.HasOne(d => d.OzlaCodeNavigation).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.OzlaCode)
                .HasConstraintName("FK_CORP_LOCT_OZLA");

            entity.HasOne(d => d.VilgCodeNavigation).WithMany(p => p.CorpLocts)
                .HasForeignKey(d => d.VilgCode)
                .HasConstraintName("FK_CORP_LOCT_VILG");
        });

        modelBuilder.Entity<CorpLoctActv>(entity =>
        {
            entity.HasKey(e => e.CorpLoctActvId).HasName("PK__CORP_LOC__6E8CEF5E4C41ACFD");

            entity.ToTable("CORP_LOCT_ACTV");

            entity.HasIndex(e => new { e.BpMainId, e.BpSecId, e.CorpLoctId, e.CorpId, e.IsAsgnd }, "UK_CORP_LOCT_ACTV_BP_MAIN_ID_BP_SEC_ID_CORP_LOCT_ID_CORP_ID_ASGN_STTS").IsUnique();

            entity.Property(e => e.CorpLoctActvId).HasColumnName("CORP_LOCT_ACTV_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecId).HasColumnName("BP_SEC_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CorpLoctId).HasColumnName("CORP_LOCT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsAsgnd).HasColumnName("IS_ASGND");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BpMain).WithMany(p => p.CorpLoctActvs)
                .HasForeignKey(d => d.BpMainId)
                .HasConstraintName("FK_CORP_LOCT_ACTV_BP_MAIN");

            entity.HasOne(d => d.Corp).WithMany(p => p.CorpLoctActvs)
                .HasForeignKey(d => d.CorpId)
                .HasConstraintName("FK_CORP_LOCT_ACTV_CORP");

            entity.HasOne(d => d.CorpLoct).WithMany(p => p.CorpLoctActvs)
                .HasForeignKey(d => d.CorpLoctId)
                .HasConstraintName("FK_CORP_LOCT_ACTV_CORP_LOCT");
        });

        modelBuilder.Entity<CorpRemt>(entity =>
        {
            entity.HasKey(e => e.CorpRemtId).HasName("PK__tmp_ms_x__422230C19303F204");

            entity.ToTable("CORP_REMT");

            entity.HasIndex(e => e.CardNmbr, "IX_CARD_NUMBER");

            entity.HasIndex(e => e.FinaNmbr, "IX_FIN_NUMBER");

            entity.HasIndex(e => new { e.CorpId, e.CorpCyclId, e.SttsTypeCode }, "NonClusteredIndex-20201105-150338");

            entity.HasIndex(e => new { e.CardNmbr, e.FinaNmbr }, "NonClusteredIndex-20201105-150545");

            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.AltIdNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ALT_ID_NUM");
            entity.Property(e => e.AltIdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ALT_ID_TYPE");
            entity.Property(e => e.AltName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALT_NAME");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CalcLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CALC_LQDTY");
            entity.Property(e => e.CardNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARD_NMBR");
            entity.Property(e => e.Cmnt)
                .HasMaxLength(200)
                .HasColumnName("CMNT");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ExtraClmn1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_CLMN1");
            entity.Property(e => e.ExtraClmn2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_CLMN2");
            entity.Property(e => e.FinaNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINA_NMBR");
            entity.Property(e => e.IdType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPayedOffline).HasColumnName("IS_PAYED_OFFLINE");
            entity.Property(e => e.MobNumb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOB_NUMB");
            entity.Property(e => e.PaidBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAID_BRCH_CODE");
            entity.Property(e => e.PaydBpmainId).HasColumnName("PAYD_BPMAIN_ID");
            entity.Property(e => e.PaydLoctId).HasColumnName("PAYD_LOCT_ID");
            entity.Property(e => e.PayedChnl).HasColumnName("PAYED_CHNL");
            entity.Property(e => e.PayedOfflineDate)
                .HasColumnType("datetime")
                .HasColumnName("PAYED_OFFLINE_DATE");
            entity.Property(e => e.PrjtNme)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRJT_NME");
            entity.Property(e => e.PrpdAgntBpMainId).HasColumnName("PRPD_AGNT_BP_MAIN_ID");
            entity.Property(e => e.PrpdBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRPD_BRCH_CODE");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(250)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.RecvLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RECV_LQDTY");
            entity.Property(e => e.Ref)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF");
            entity.Property(e => e.SendLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SEND_LQDTY");
            entity.Property(e => e.SerlNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERL_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SmsMsg)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SMS_MSG");
            entity.Property(e => e.SndrName)
                .HasMaxLength(250)
                .HasColumnName("SNDR_NAME");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.T24RefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("T24_REF_NO");
            entity.Property(e => e.T24UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("T24_USER_ID");
            entity.Property(e => e.TrsfrCndtn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TRSFR_CNDTN");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CorpCycl).WithMany(p => p.CorpRemts)
                .HasForeignKey(d => d.CorpCyclId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_CORP_CYCL");

            entity.HasOne(d => d.Corp).WithMany(p => p.CorpRemts)
                .HasForeignKey(d => d.CorpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_CORP");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CorpRemtCreatedByNavigations).HasForeignKey(d => d.CreatedBy);

            entity.HasOne(d => d.PaydBpmain).WithMany(p => p.CorpRemts)
                .HasForeignKey(d => d.PaydBpmainId)
                .HasConstraintName("FK_CORP_REMT_BP_MAIN");

            entity.HasOne(d => d.PaydLoct).WithMany(p => p.CorpRemts)
                .HasForeignKey(d => d.PaydLoctId)
                .HasConstraintName("FK_CORP_REMT_CORP_LOCT");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CorpRemtUpdatedByNavigations).HasForeignKey(d => d.UpdatedBy);
        });

        modelBuilder.Entity<CorpRemt02jan22>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CORP_REMT_02JAN22");

            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CardNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARD_NMBR");
            entity.Property(e => e.Cmnt)
                .HasMaxLength(200)
                .HasColumnName("CMNT");
            entity.Property(e => e.CorpCyclId).HasColumnName("CORP_CYCL_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CorpRemtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FinaNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINA_NMBR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPayedOffline).HasColumnName("IS_PAYED_OFFLINE");
            entity.Property(e => e.MobNumb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOB_NUMB");
            entity.Property(e => e.PaydBpmainId).HasColumnName("PAYD_BPMAIN_ID");
            entity.Property(e => e.PaydLoctId).HasColumnName("PAYD_LOCT_ID");
            entity.Property(e => e.PayedChnl).HasColumnName("PAYED_CHNL");
            entity.Property(e => e.PayedOfflineDate)
                .HasColumnType("datetime")
                .HasColumnName("PAYED_OFFLINE_DATE");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(250)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrName)
                .HasMaxLength(250)
                .HasColumnName("SNDR_NAME");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpRemtAmndHstry>(entity =>
        {
            entity.HasKey(e => e.CorpRemtAmndHstryId).HasName("PK__CORP_REM__00EB4DEE42ADF8B6");

            entity.ToTable("CORP_REMT_AMND_HSTRY");

            entity.Property(e => e.CorpRemtAmndHstryId).HasColumnName("CORP_REMT_AMND_HSTRY_ID");
            entity.Property(e => e.CardNmbr)
                .HasMaxLength(50)
                .HasColumnName("CARD_NMBR");
            entity.Property(e => e.Cmnt)
                .HasMaxLength(400)
                .HasColumnName("CMNT");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.MobNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOB_NMBR");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(500)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

            entity.HasOne(d => d.CorpRemt).WithMany(p => p.CorpRemtAmndHstries)
                .HasForeignKey(d => d.CorpRemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_AMND_HSTRY_CORP_REMT");
        });

        modelBuilder.Entity<CorpRemtDetl>(entity =>
        {
            entity.HasKey(e => e.CorpRemtDetlId).HasName("PK__tmp_ms_x__24CFE7F70F3DEE7A");

            entity.ToTable("CORP_REMT_DETL");

            entity.HasIndex(e => e.CorpRemtId, "IX_CORP_REMT_ID");

            entity.Property(e => e.CorpRemtDetlId).HasColumnName("CORP_REMT_DETL_ID");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.InsuAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSU_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LqdtyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LQDTY_FEE");
            entity.Property(e => e.PerformerBpmainId).HasColumnName("PERFORMER_BPMAIN_ID");
            entity.Property(e => e.RemtAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("REMT_AMNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CorpRemt).WithMany(p => p.CorpRemtDetls)
                .HasForeignKey(d => d.CorpRemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_DETL_CORP_REMT");

            entity.HasOne(d => d.PerformerBpmain).WithMany(p => p.CorpRemtDetls)
                .HasForeignKey(d => d.PerformerBpmainId)
                .HasConstraintName("FK_CORP_REMT_DETL_BP_MAIN");
        });

        modelBuilder.Entity<CorpRemtHstry>(entity =>
        {
            entity.HasKey(e => e.CorpRemtHstryId).HasName("PK__CORP_REM__95A77BBC6C434189");

            entity.ToTable("CORP_REMT_HSTRY");

            entity.Property(e => e.CorpRemtHstryId).HasColumnName("CORP_REMT_HSTRY_ID");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");

            entity.HasOne(d => d.CorpRemt).WithMany(p => p.CorpRemtHstries)
                .HasForeignKey(d => d.CorpRemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_HSTRY_CORP_REMT");
        });

        modelBuilder.Entity<CorpRemtInssDetl>(entity =>
        {
            entity.HasKey(e => e.CorpRemtInssDetlId).HasName("PK__CORP_REM__F2FF525030650394");

            entity.ToTable("CORP_REMT_INSS_DETL");

            entity.Property(e => e.CorpRemtInssDetlId).HasColumnName("CORP_REMT_INSS_DETL_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CorpRemtId).HasColumnName("CORP_REMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.InssReqId).HasColumnName("INSS_REQ_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsReFund).HasColumnName("IS_RE_FUND");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntBpMain).WithMany(p => p.CorpRemtInssDetls)
                .HasForeignKey(d => d.AgntBpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_INSS_DETL_BP_MAIN");

            entity.HasOne(d => d.Corp).WithMany(p => p.CorpRemtInssDetls)
                .HasForeignKey(d => d.CorpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_INSS_DETL_CORP");

            entity.HasOne(d => d.CorpRemt).WithMany(p => p.CorpRemtInssDetls)
                .HasForeignKey(d => d.CorpRemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_INSS_DETL_CORP_REMT");

            entity.HasOne(d => d.Cycl).WithMany(p => p.CorpRemtInssDetls)
                .HasForeignKey(d => d.CyclId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_REMT_INSS_DETL_CORP_CYCL");
        });

        modelBuilder.Entity<CorpRemtTemp>(entity =>
        {
            entity.HasKey(e => e.RemtId).HasName("PK__tmp_ms_x__C531BCBBF3C29E43");

            entity.ToTable("CorpRemtTemp");

            entity.HasIndex(e => e.CardNumb, "IX_CorpRemtTemp_CARD_NUMB")
                .IsUnique()
                .HasFilter("([CARD_NUMB] IS NOT NULL AND [CARD_NUMB]<>'')");

            entity.HasIndex(e => e.FinaNumb, "IX_CorpRemtTemp_FINA_NUMB")
                .IsUnique()
                .HasFilter("([FINA_NUMB] IS NOT NULL AND [FINA_NUMB]<>'')");

            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.AltIdNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ALT_ID_NUM");
            entity.Property(e => e.AltIdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ALT_ID_TYPE");
            entity.Property(e => e.AltName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALT_NAME");
            entity.Property(e => e.Amnt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMNT");
            entity.Property(e => e.CardNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARD_NUMB");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .HasColumnName("COMMENT");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.ExtraClmn1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_CLMN1");
            entity.Property(e => e.ExtraClmn2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_CLMN2");
            entity.Property(e => e.FinaNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINA_NUMB");
            entity.Property(e => e.IdType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.MobNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOB_NUMB");
            entity.Property(e => e.PrjtNme)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRJT_NME");
            entity.Property(e => e.ReciName)
                .HasMaxLength(500)
                .HasColumnName("RECI_NAME");
            entity.Property(e => e.Ref)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REF");
            entity.Property(e => e.SendName)
                .HasMaxLength(500)
                .HasColumnName("SEND_NAME");
            entity.Property(e => e.SerlNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERL_NO");
            entity.Property(e => e.SmsMsg)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SMS_MSG");
            entity.Property(e => e.TrsfrCndtn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TRSFR_CNDTN");
        });

        modelBuilder.Entity<CorpSttsType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CORP_STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CorpUserAgntReviewMap>(entity =>
        {
            entity.ToTable("CORP_USER_AGNT_REVIEW_MAP");

            entity.Property(e => e.CorpUserAgntReviewMapId).HasColumnName("CORP_USER_AGNT_REVIEW_MAP_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CorpId).HasColumnName("CORP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.BpMain).WithMany(p => p.CorpUserAgntReviewMaps)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_USER_AGNT_REVIEW_MAP_BP_MAIN");

            entity.HasOne(d => d.User).WithMany(p => p.CorpUserAgntReviewMaps)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CORP_USER_AGNT_REVIEW_MAP_BP_SYS_USER");
        });

        modelBuilder.Entity<CpnyStng>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CPNY_STNG");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.FileSrvr)
                .HasMaxLength(250)
                .HasColumnName("FILE_SRVR");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.ProcDate)
                .HasColumnType("datetime")
                .HasColumnName("PROC_DATE");
        });

        modelBuilder.Entity<CrcyType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CRCY_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Symb)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SYMB");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Cust>(entity =>
        {
            entity.ToTable("CUST");

            entity.Property(e => e.CustId).HasColumnName("CUST_ID");
            entity.Property(e => e.AmcnNtly)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AMCN_NTLY");
            entity.Property(e => e.CertTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CERT_TYPE_ID");
            entity.Property(e => e.Cmnt)
                .HasMaxLength(500)
                .HasColumnName("CMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CUST_TYPE_ID");
            entity.Property(e => e.DateOfBrth)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_BRTH");
            entity.Property(e => e.FrstName)
                .HasMaxLength(500)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.GndrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GNDR_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.JobFildTypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("JOB_FILD_TYPE_ID");
            entity.Property(e => e.JobTitl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("JOB_TITL");
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MrtlSttsId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MRTL_STTS_ID");
            entity.Property(e => e.PhonNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PHON_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WhtsAppNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WHTS_APP_NMBR");

            entity.HasOne(d => d.CertType).WithMany(p => p.Custs)
                .HasForeignKey(d => d.CertTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_CERT_TYPE");

            entity.HasOne(d => d.CustType).WithMany(p => p.Custs)
                .HasForeignKey(d => d.CustTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_TYPE_CUST");

            entity.HasOne(d => d.Gndr).WithMany(p => p.Custs)
                .HasForeignKey(d => d.GndrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_GNDR_TYPE");

            entity.HasOne(d => d.JobFildType).WithMany(p => p.Custs)
                .HasForeignKey(d => d.JobFildTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_JOB_FILD_TYPE");

            entity.HasOne(d => d.MrtlStts).WithMany(p => p.Custs)
                .HasForeignKey(d => d.MrtlSttsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_MRTL_STTS_TYPE");
        });

        modelBuilder.Entity<CustAddr>(entity =>
        {
            entity.HasKey(e => e.AddrId);

            entity.ToTable("CUST_ADDR");

            entity.Property(e => e.AddrId).HasColumnName("ADDR_ID");
            entity.Property(e => e.CityId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CITY_ID");
            entity.Property(e => e.CntyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustId).HasColumnName("CUST_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StrtAddr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STRT_ADDR");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.City).WithMany(p => p.CustAddrs)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_ADDR_CITY");

            entity.HasOne(d => d.Cnty).WithMany(p => p.CustAddrs)
                .HasForeignKey(d => d.CntyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUST_ADDR_CNTY");
        });

        modelBuilder.Entity<CustProfSetg>(entity =>
        {
            entity.HasKey(e => e.CustProfSetgId).HasName("PK_CUST_PROF_SETG_1");

            entity.ToTable("CUST_PROF_SETG");

            entity.Property(e => e.CustProfSetgId).HasColumnName("CUST_PROF_SETG_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CUST_TYPE_CODE");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.LimtId).HasColumnName("LIMT_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WrkqStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WRKQ_STTS");

            entity.HasOne(d => d.CustTypeCodeNavigation).WithMany(p => p.CustProfSetgs)
                .HasForeignKey(d => d.CustTypeCode)
                .HasConstraintName("FK_CUST_PROF_SETG_CUST_TYPE");

            entity.HasOne(d => d.KycSet).WithMany(p => p.CustProfSetgs)
                .HasForeignKey(d => d.KycSetId)
                .HasConstraintName("FK_CUST_PROF_SETG_KYC_SET");

            entity.HasOne(d => d.Limt).WithMany(p => p.CustProfSetgs)
                .HasForeignKey(d => d.LimtId)
                .HasConstraintName("FK_CUST_PROF_SETG_AGNT_LIMT_SETNG");
        });

        modelBuilder.Entity<CustSuplRgstn>(entity =>
        {
            entity.ToTable("CUST_SUPL_RGSTN");

            entity.HasIndex(e => new { e.SuplBpMainId, e.IsActive, e.SCustId }, "UC_CUST_SUPL_RGSTN").IsUnique();

            entity.Property(e => e.CustSuplRgstnId).HasColumnName("CUST_SUPL_RGSTN_ID");
            entity.Property(e => e.BankAcctBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_BRCH");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctNmber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_NMBER");
            entity.Property(e => e.CustBpMainId).HasColumnName("CUST_BP_MAIN_ID");
            entity.Property(e => e.CustEmail)
                .HasMaxLength(300)
                .HasColumnName("CUST_EMAIL");
            entity.Property(e => e.CustExtlId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CUST_EXTL_ID");
            entity.Property(e => e.CustMobileNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUST_MOBILE_NO");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MumiazNmber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MUMIAZ_NMBER");
            entity.Property(e => e.SCustId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("S_CUST_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CustType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("CUST_TYPE_CODE");

            entity.ToTable("CUST_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CustomerAgentsMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer_agents_mapping");

            entity.Property(e => e.AgentUserid).HasColumnName("Agent_userid");
            entity.Property(e => e.AgentUsername)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Agent_username");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Customer_name");
            entity.Property(e => e.CustomerUserId).HasColumnName("Customer_user_id");
        });

        modelBuilder.Entity<Cycl>(entity =>
        {
            entity.HasKey(e => e.CyclId).HasName("PK_CYCL_1");

            entity.ToTable("CYCL");

            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.CommBlckPerc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("COMM_BLCK_PERC");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclDesc)
                .HasMaxLength(500)
                .HasColumnName("CYCL_DESC");
            entity.Property(e => e.CyclName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CYCL_NAME");
            entity.Property(e => e.CyclNameLocal)
                .HasMaxLength(250)
                .HasColumnName("CYCL_NAME_LOCAL");
            entity.Property(e => e.CyclProcStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CYCL_PROC_STTS");
            entity.Property(e => e.ExpDate)
                .HasColumnType("datetime")
                .HasColumnName("EXP_DATE");
            entity.Property(e => e.FixdLocComi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIXD_LOC_COMI");
            entity.Property(e => e.FixdLocFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIXD_LOC_FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MoblLocComi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MOBL_LOC_COMI");
            entity.Property(e => e.MoblLocFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MOBL_LOC_FEE");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ORG_CODE");
            entity.Property(e => e.OutReachEndDate)
                .HasColumnType("datetime")
                .HasColumnName("OUT_REACH_END_DATE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StrtDate)
                .HasColumnType("datetime")
                .HasColumnName("STRT_DATE");
            entity.Property(e => e.TotAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOT_AMNT");
            entity.Property(e => e.TotFee).HasColumnName("TOT_FEE");
            entity.Property(e => e.TotMainFile).HasColumnName("TOT_MAIN_FILE");
            entity.Property(e => e.TotMembFile).HasColumnName("TOT_MEMB_FILE");
            entity.Property(e => e.TotRemi).HasColumnName("TOT_REMI");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Cycls)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_CYCL_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<CyclPrcsSttsType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CYCL_PRCS_STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<CyclType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CYCL_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DbLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DB_LOG");

            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.DbErrorLine)
                .HasMaxLength(10)
                .HasColumnName("DB_ERROR_LINE");
            entity.Property(e => e.DbErrorMessage).HasColumnName("DB_ERROR_MESSAGE");
            entity.Property(e => e.DbErrorNumber)
                .HasMaxLength(10)
                .HasColumnName("DB_ERROR_NUMBER");
            entity.Property(e => e.DbErrorProcedure)
                .HasMaxLength(500)
                .HasColumnName("DB_ERROR_PROCEDURE");
            entity.Property(e => e.DbErrorSeverity)
                .HasMaxLength(10)
                .HasColumnName("DB_ERROR_SEVERITY");
            entity.Property(e => e.DbErrorState)
                .HasMaxLength(10)
                .HasColumnName("DB_ERROR_STATE");
            entity.Property(e => e.Dblogid)
                .ValueGeneratedOnAdd()
                .HasColumnName("DBLOGID");
        });

        modelBuilder.Entity<Dist>(entity =>
        {
            entity.HasKey(e => e.DistCode);

            entity.ToTable("DIST");

            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.DistName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIST_NAME");
            entity.Property(e => e.DistNameLocal)
                .HasMaxLength(250)
                .HasColumnName("DIST_NAME_LOCAL");
            entity.Property(e => e.DistOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_OLD_CODE");
            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.GvrnCodeNavigation).WithMany(p => p.Dists)
                .HasForeignKey(d => d.GvrnCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIST_GVRN");
        });

        modelBuilder.Entity<DocType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("DOC_TYPE_CODE");

            entity.ToTable("DOC_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<DpstAcctTranRevsMf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DPST_ACCT_TRAN_REVS_MF");

            entity.Property(e => e.AcctTranId).HasColumnName("ACCT_TRAN_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.AmntBaseCrcy)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_BASE_CRCY");
            entity.Property(e => e.AmntFrgnCrcy)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_FRGN_CRCY");
            entity.Property(e => e.AmntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AMNT_TYPE_CODE");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.BsnsPrtnId).HasColumnName("BSNS_PRTN_ID");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.IsPostedToAcct).HasColumnName("IS_POSTED_TO_ACCT");
            entity.Property(e => e.OprnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OPRN_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrceTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRCE_TYPE_CODE");
            entity.Property(e => e.SubOprnType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUB_OPRN_TYPE");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.TrgtTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRGT_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.XchgRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("XCHG_RATE");
        });

        modelBuilder.Entity<DpstFileUpldDoc>(entity =>
        {
            entity.HasKey(e => e.DpstFileUpldDocId).HasName("PK__DPST_FIL__E55DED7EEA4EDE8E");

            entity.ToTable("DPST_FILE_UPLD_DOC");

            entity.Property(e => e.DpstFileUpldDocId).HasColumnName("DPST_FILE_UPLD_DOC_ID");
            entity.Property(e => e.AprvStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APRV_STTS");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFeeDedctd).HasColumnName("IS_FEE_DEDCTD");
            entity.Property(e => e.IsPrcnt).HasColumnName("IS_PRCNT");
            entity.Property(e => e.PrfmrId).HasColumnName("PRFMR_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TotlAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTL_AMNT");
            entity.Property(e => e.TotlFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTL_FEE");
            entity.Property(e => e.TotlWallets).HasColumnName("TOTL_WALLETS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.UpldDoc).WithMany(p => p.DpstFileUpldDocs)
                .HasForeignKey(d => d.UpldDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DPST_FILE_UPLD_DOC_UPLD_DOC_ID");
        });

        modelBuilder.Entity<DpstMfToMf>(entity =>
        {
            entity.ToTable("DPST_MF_TO_MF");

            entity.HasIndex(e => e.DpstFileDocId, "IX_DPST_FILE_DOC_ID");

            entity.Property(e => e.DpstMfToMfId).HasColumnName("DPST_MF_TO_MF_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.Cmnts)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CMNTS");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.DpstFileDocId).HasColumnName("DPST_FILE_DOC_ID");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrId).HasColumnName("PRFMR_ID");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.SndrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SNDR_NAME");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<DpstMfToMfRvsl>(entity =>
        {
            entity.HasKey(e => e.DpstMfToMfRvslId).HasName("PK_DPST_MF_TO_MF_RVSL_ID");

            entity.ToTable("DPST_MF_TO_MF_RVSL");

            entity.HasIndex(e => e.DpstMfToMfId, "UK_DPST_MF_TO_MF_ID").IsUnique();

            entity.Property(e => e.DpstMfToMfRvslId).HasColumnName("DPST_MF_TO_MF_RVSL_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.DpstMfToMfId).HasColumnName("DPST_MF_TO_MF_ID");
            entity.Property(e => e.DpstTranDate)
                .HasColumnType("datetime")
                .HasColumnName("DPST_TRAN_DATE");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.PrfmrId).HasColumnName("PRFMR_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<DpstToBkRvsl>(entity =>
        {
            entity.ToTable("DPST_TO_BK_RVSL");

            entity.HasIndex(e => e.TranTypeId, "UK_TRAN_TYPE_ID").IsUnique();

            entity.Property(e => e.DpstToBkRvslId).HasColumnName("DPST_TO_BK_RVSL_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BefrAvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BEFR_AVBL_BLNC");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(250)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts).HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
        });

        modelBuilder.Entity<Dtyp>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__DTYP__AC0316148744F128");

            entity.ToTable("DTYP");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.DsplOrd).HasColumnName("DSPL_ORD");
            entity.Property(e => e.HtmlType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("HTML_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsList).HasColumnName("IS_LIST");
            entity.Property(e => e.ListTablName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LIST_TABL_NAME");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymt>(entity =>
        {
            entity.ToTable("E_PYMT");

            entity.HasIndex(e => e.EPymtNo, "IX_E_PYMT_EPYMTNO").IsDescending();

            entity.HasIndex(e => e.SuplRefNo, "IX_E_PYMT_SUPL_REF_NO").IsDescending();

            entity.HasIndex(e => new { e.SuplBpMainId, e.SuplRefNo }, "UK2_E_PYMT").IsUnique();

            entity.HasIndex(e => e.EPymtNo, "UK_E_PYMT").IsUnique();

            entity.Property(e => e.EPymtId).HasColumnName("E_PYMT_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustBpMainId).HasColumnName("CUST_BP_MAIN_ID");
            entity.Property(e => e.CustBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CUST_BRCH");
            entity.Property(e => e.CustSuplRgstnId).HasColumnName("CUST_SUPL_RGSTN_ID");
            entity.Property(e => e.CustZoneId).HasColumnName("CUST_ZONE_ID");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.EPymtNo).HasColumnName("E_PYMT_NO");
            entity.Property(e => e.EPymtPrmtnId).HasColumnName("E_PYMT_PRMTN_ID");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFeeDdctd).HasColumnName("IS_FEE_DDCTD");
            entity.Property(e => e.MrchntName)
                .HasMaxLength(200)
                .HasColumnName("MRCHNT_NAME");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.OrgnlFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ORGNL_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.SuplBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUPL_BRCH");
            entity.Property(e => e.SuplRefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUPL_REF_NO");
            entity.Property(e => e.T24RefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("T24_REF_NO");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.XchgRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("XCHG_RATE");
        });

        modelBuilder.Entity<EPymtKjLimt>(entity =>
        {
            entity.ToTable("E_PYMT_KJ_LIMT");

            entity.Property(e => e.EPymtKjLimtId).HasColumnName("E_PYMT_KJ_LIMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DailyLimtAmt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DAILY_LIMT_AMT");
            entity.Property(e => e.DailyLimtCnt).HasColumnName("DAILY_LIMT_CNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranLimtAmt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TRAN_LIMT_AMT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymtPrmtn>(entity =>
        {
            entity.ToTable("E_PYMT_PRMTN");

            entity.Property(e => e.EPymtPrmtnId).HasColumnName("E_PYMT_PRMTN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.GroupFeeId).HasColumnName("GROUP_FEE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(50)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymtRvsl>(entity =>
        {
            entity.ToTable("E_PYMT_RVSL");

            entity.Property(e => e.EPymtRvslId).HasColumnName("E_PYMT_RVSL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.EPymtId).HasColumnName("E_PYMT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RjctnResn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RJCTN_RESN");
            entity.Property(e => e.RtryCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RTRY_COUNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.SuplCustId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUPL_CUST_ID");
            entity.Property(e => e.SuplRefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUPL_REF_NO");
            entity.Property(e => e.T24RqstStts)
                .HasDefaultValueSql("((1))")
                .HasColumnName("T24_RQST_STTS");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymtWaltToBank>(entity =>
        {
            entity.ToTable("E_PYMT_WALT_TO_BANK");

            entity.Property(e => e.EPymtWaltToBankId).HasColumnName("E_PYMT_WALT_TO_BANK_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(250)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CrdtBankAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_BANK_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtWaltAcct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEBT_WALT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LqdtyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LQDTY_FEE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.RetryCount).HasColumnName("RETRY_COUNT");
            entity.Property(e => e.SendZoneId).HasColumnName("SEND_ZONE_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymtWaltToBankBatch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__E_PYMT_W__2172E4636191BF39");

            entity.ToTable("E_PYMT_WALT_TO_BANK_BATCH");

            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.AcctType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.TotalRcrd).HasColumnName("TOTAL_RCRD");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EPymtWaltToBankBatches)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__E_PYMT_WA__CREAT__414BB0B5");

            entity.HasOne(d => d.Doc).WithMany(p => p.EPymtWaltToBankBatches)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__E_PYMT_WA__DOC_I__423FD4EE");
        });

        modelBuilder.Entity<EPymtWaltToBankBatchDetl>(entity =>
        {
            entity.HasKey(e => e.BatchDetlId).HasName("PK__E_PYMT_W__06156F3DB87999EE");

            entity.ToTable("E_PYMT_WALT_TO_BANK_BATCH_DETL");

            entity.Property(e => e.BatchDetlId).HasColumnName("BATCH_DETL_ID");
            entity.Property(e => e.AcctNo).HasColumnName("ACCT_NO");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ERROR_MSG");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EPymtWaltToBankRvsl>(entity =>
        {
            entity.ToTable("E_PYMT_WALT_TO_BANK_RVSL");

            entity.HasIndex(e => e.TranTypeId, "UQ_TRAN_TYPE_ID").IsUnique();

            entity.Property(e => e.EPymtWaltToBankRvslId).HasColumnName("E_PYMT_WALT_TO_BANK_RVSL_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(100)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.SendBpId).HasColumnName("SEND_BP_ID");
            entity.Property(e => e.SendZoneId).HasColumnName("SEND_ZONE_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts).HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
        });

        modelBuilder.Entity<EPymtZoneToZone>(entity =>
        {
            entity.ToTable("E_PYMT_ZONE_TO_ZONE");

            entity.Property(e => e.EPymtZoneToZoneId).HasColumnName("E_PYMT_ZONE_TO_ZONE_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.FrmLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FRM_LQDTY");
            entity.Property(e => e.FrmZoneId).HasColumnName("FRM_ZONE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LqdtyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LQDTY_FEE");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("NOTES");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.ToLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TO_LQDTY");
            entity.Property(e => e.ToZoneId).HasColumnName("TO_ZONE_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EmplType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_EmployeeType");

            entity.ToTable("EMPL_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EncryKey>(entity =>
        {
            entity.HasKey(e => e.KeyId);

            entity.ToTable("ENCRY_KEY");

            entity.Property(e => e.KeyId).HasColumnName("KEY_ID");
            entity.Property(e => e.Algorithm)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KeyLength).HasColumnName("KEY_LENGTH");
            entity.Property(e => e.KeyName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("KEY_NAME");
            entity.Property(e => e.PrivateKey)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("Private_KEY");
            entity.Property(e => e.PublicKey)
                .HasMaxLength(1600)
                .IsUnicode(false)
                .HasColumnName("Public_KEY");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.ToTable("ERROR_LOGS");

            entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<EtiAsgndRemt>(entity =>
        {
            entity.ToTable("ETI_ASGND_REMT");

            entity.Property(e => e.EtiAsgndRemtId).HasColumnName("ETI_ASGND_REMT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsDownloaded).HasColumnName("IS_DOWNLOADED");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EtiAsgndRemtHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ETI_ASGND_REMT_HIST");

            entity.Property(e => e.AsgnStts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASGN_STTS");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.EtiAsgndRemtId).HasColumnName("ETI_ASGND_REMT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EtiBenProf>(entity =>
        {
            entity.HasKey(e => e.BenProfId);

            entity.ToTable("ETI_BEN_PROF");

            entity.Property(e => e.BenProfId).HasColumnName("BEN_PROF_ID");
            entity.Property(e => e.BenAdrs)
                .HasMaxLength(250)
                .HasColumnName("BEN_ADRS");
            entity.Property(e => e.BenDob)
                .HasColumnType("date")
                .HasColumnName("BEN_DOB");
            entity.Property(e => e.BenIdExpiryDate)
                .HasColumnType("date")
                .HasColumnName("BEN_ID_EXPIRY_DATE");
            entity.Property(e => e.BenIdIssueDate)
                .HasColumnType("date")
                .HasColumnName("BEN_ID_ISSUE_DATE");
            entity.Property(e => e.BenIdNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_NUMB");
            entity.Property(e => e.BenIdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_TYPE");
            entity.Property(e => e.BenPlceOfBrth)
                .HasMaxLength(100)
                .HasColumnName("BEN_PLCE_OF_BRTH");
            entity.Property(e => e.BenVeriCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_VERI_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.LastUpdtCycleId).HasColumnName("LAST_UPDT_CYCLE_ID");
            entity.Property(e => e.MidlName)
                .HasMaxLength(250)
                .HasColumnName("MIDL_NAME");
            entity.Property(e => e.PhonNumb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON_NUMB");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.LastUpdtCycle).WithMany(p => p.EtiBenProfs)
                .HasForeignKey(d => d.LastUpdtCycleId)
                .HasConstraintName("FK_ETI_BEN_PROF_CYCL");
        });

        modelBuilder.Entity<EtiCyclAcct>(entity =>
        {
            entity.HasKey(e => e.EtiCyclAcctsId);

            entity.ToTable("ETI_CYCL_ACCTS");

            entity.Property(e => e.EtiCyclAcctsId).HasColumnName("ETI_CYCL_ACCTS_ID");
            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.AcctSubType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCT_SUB_TYPE");
            entity.Property(e => e.BenVeriCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_VERI_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EtiProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ETI_PROD");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ProdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROD_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<EtiRemt>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("ETI_REMT");

            entity.Property(e => e.RemtId)
                .ValueGeneratedNever()
                .HasColumnName("REMT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BenElecId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_ELEC_ID");
            entity.Property(e => e.BenName)
                .HasMaxLength(250)
                .HasColumnName("BEN_NAME");
            entity.Property(e => e.BenVeriCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_VERI_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.DistrctCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISTRCT_CODE");
            entity.Property(e => e.EPaymentFlag).HasColumnName("E_PAYMENT_FLAG");
            entity.Property(e => e.GovrntCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GOVRNT_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPayedOffline).HasColumnName("IS_PAYED_OFFLINE");
            entity.Property(e => e.NoPaymentFlag).HasColumnName("NO_PAYMENT_FLAG");
            entity.Property(e => e.PaydLoctId).HasColumnName("PAYD_LOCT_ID");
            entity.Property(e => e.PaydMmbrId).HasColumnName("PAYD_MMBR_ID");
            entity.Property(e => e.PayedBy).HasColumnName("PAYED_BY");
            entity.Property(e => e.PayedChnl).HasColumnName("PAYED_CHNL");
            entity.Property(e => e.RequiresBankAccount).HasColumnName("REQUIRES_BANK_ACCOUNT");
            entity.Property(e => e.RequiresVerificationFormFlag).HasColumnName("REQUIRES_VERIFICATION_FORM_FLAG");
            entity.Property(e => e.ScheduledPaymentDate)
                .HasColumnType("date")
                .HasColumnName("SCHEDULED_PAYMENT_DATE");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(250)
                .HasColumnName("SCHOOL_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.SubAcct)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SUB_ACCT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VerifiedFlag).HasColumnName("VERIFIED_FLAG");
        });

        modelBuilder.Entity<EtiRemtDocRevw>(entity =>
        {
            entity.ToTable("ETI_REMT_DOC_REVW");

            entity.Property(e => e.EtiRemtDocRevwId).HasColumnName("ETI_REMT_DOC_REVW_ID");
            entity.Property(e => e.BenVeriCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_VERI_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocCycleId).HasColumnName("DOC_CYCLE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.RevwBy).HasColumnName("REVW_BY");
            entity.Property(e => e.RevwStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVW_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.EtiRemtDocRevws)
                .HasForeignKey(d => d.RemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ETI_REMT_DOC_REVW_ETI_REMT");

            entity.HasOne(d => d.RevwByNavigation).WithMany(p => p.EtiRemtDocRevws)
                .HasForeignKey(d => d.RevwBy)
                .HasConstraintName("FK_ETI_REMT_DOC_REVW_BP_SYS_USER");
        });

        modelBuilder.Entity<EtiRemtOffLine>(entity =>
        {
            entity.ToTable("ETI_REMT_OFF_LINE");

            entity.Property(e => e.EtiRemtOffLineId).HasColumnName("ETI_REMT_OFF_LINE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OffLinePaidDate)
                .HasColumnType("datetime")
                .HasColumnName("OFF_LINE_PAID_DATE");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.EtiRemtOffLines)
                .HasForeignKey(d => d.RemtId)
                .HasConstraintName("FK_ETI_REMT_OFF_LINE_ETI_REMT");
        });

        modelBuilder.Entity<EtimemberTemp>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("ETIMemberTemp");

            entity.Property(e => e.BenElectronicId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ben_electronic_id");
            entity.Property(e => e.BenName)
                .HasMaxLength(250)
                .HasColumnName("ben_name");
            entity.Property(e => e.BenVerificationCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ben_verification_code");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("district_code");
            entity.Property(e => e.EPaymentFlag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("e_payment_flag");
            entity.Property(e => e.GovernorateCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("governorate_code");
            entity.Property(e => e.NoPaymentFlag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("no_payment_flag");
            entity.Property(e => e.PaymentAmount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_amount");
            entity.Property(e => e.RequiresBankAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("requires_bank_account");
            entity.Property(e => e.RequiresVerificationFormFlag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("requires_verification_form_flag");
            entity.Property(e => e.ScheduledPaymentDate)
                .HasMaxLength(50)
                .HasColumnName("scheduled_payment_date");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(250)
                .HasColumnName("school_name");
            entity.Property(e => e.SubAccount)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("sub_account");
            entity.Property(e => e.VerifiedFlag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("verified_flag");
        });

        modelBuilder.Entity<ExcelImportBranch1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Excel_Import_Branch1");

            entity.Property(e => e.BrachCode)
                .HasMaxLength(255)
                .HasColumnName("Brach Code");
            entity.Property(e => e.BranchName)
                .HasMaxLength(255)
                .HasColumnName("Branch Name");
            entity.Property(e => e.FamilyCode).HasColumnName("Family_Code");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Payment Date");
        });

        modelBuilder.Entity<ExtrKeUrlCnfg>(entity =>
        {
            entity.ToTable("EXTR_KE_URL_CNFG");

            entity.Property(e => e.ExtrKeUrlCnfgId).HasColumnName("EXTR_KE_URL_CNFG_ID");
            entity.Property(e => e.AppCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APP_CODE");
            entity.Property(e => e.AppVrsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APP_VRSN");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BASE_URL");
            entity.Property(e => e.ClntId)
                .IsUnicode(false)
                .HasColumnName("CLNT_ID");
            entity.Property(e => e.ClntScrt)
                .IsUnicode(false)
                .HasColumnName("CLNT_SCRT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.EndPoint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("END_POINT");
            entity.Property(e => e.Envr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENVR");
            entity.Property(e => e.GrntType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRNT_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Port).HasColumnName("PORT");
            entity.Property(e => e.ProjName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PROJ_NAME");
            entity.Property(e => e.Pswd)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.RfrshTkn)
                .IsUnicode(false)
                .HasColumnName("RFRSH_TKN");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UrlCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("URL_CODE");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<FaildTran>(entity =>
        {
            entity.HasKey(e => e.FaildTranId).HasName("PK_BILL_FAILD_PYMT");

            entity.ToTable("FAILD_TRANS");

            entity.Property(e => e.FaildTranId).HasColumnName("FAILD_TRAN_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.FeeDiff)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_DIFF");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPrcsd).HasColumnName("IS_PRCSD");
            entity.Property(e => e.PaidAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAID_AMNT");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RefrncId).HasColumnName("REFRNC_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrvcPrvdrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRVC_PRVDR_CODE");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChnlTypeCodeNavigation).WithMany(p => p.FaildTrans)
                .HasForeignKey(d => d.ChnlTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_FAILD_PYMT_CHNL");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.FaildTrans)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_FAILD_PYMT_ACCT1");

            entity.HasOne(d => d.Performer).WithMany(p => p.FaildTrans)
                .HasForeignKey(d => d.PerformerId)
                .HasConstraintName("FK_BILL_FAILD_PYMT_BP_MAIN");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.FaildTrans)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_FAILD_PYMT_TRAN");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.ToTable("FEE");

            entity.Property(e => e.FeeId).HasColumnName("FEE_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeeCalcTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("FEE_CALC_TYPE_CODE");
            entity.Property(e => e.FeeDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("FEE_DESC");
            entity.Property(e => e.FeeName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("FEE_NAME");
            entity.Property(e => e.FeeNameLocal)
                .HasMaxLength(250)
                .HasColumnName("FEE_NAME_LOCAL");
            entity.Property(e => e.FeePerdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("FEE_PERD_TYPE_CODE");
            entity.Property(e => e.FeeStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FEE_STTS");
            entity.Property(e => e.FlatFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FLAT_FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CrcyTypeCodeNavigation).WithMany(p => p.Fees)
                .HasForeignKey(d => d.CrcyTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FEE_CRCY_TYPE_CODE");

            entity.HasOne(d => d.FeeCalcTypeCodeNavigation).WithMany(p => p.Fees)
                .HasForeignKey(d => d.FeeCalcTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FEE_FEE_CALC_TYPE");

            entity.HasOne(d => d.FeePerdTypeCodeNavigation).WithMany(p => p.Fees)
                .HasForeignKey(d => d.FeePerdTypeCode)
                .HasConstraintName("FK_FEE_PERD_TYPE_CODE");

            entity.HasOne(d => d.FeeSttsNavigation).WithMany(p => p.Fees)
                .HasForeignKey(d => d.FeeStts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FEE_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<FeeCalcType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("FEE_CALC_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FeeDetl>(entity =>
        {
            entity.ToTable("FEE_DETL");

            entity.Property(e => e.FeeDetlId).HasColumnName("FEE_DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeeId).HasColumnName("FEE_ID");
            entity.Property(e => e.FeePerdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FEE_PERD_TYPE_CODE");
            entity.Property(e => e.Incr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INCR");
            entity.Property(e => e.IncrFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INCR_FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Lqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY");
            entity.Property(e => e.MaxFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAX_FEE");
            entity.Property(e => e.MinFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN_FEE");
            entity.Property(e => e.Pcnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PCNT");
            entity.Property(e => e.RngeEnd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RNGE_END");
            entity.Property(e => e.RngeStrt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RNGE_STRT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Fee).WithMany(p => p.FeeDetls)
                .HasForeignKey(d => d.FeeId)
                .HasConstraintName("FK_FEE_DETL_FEE");
        });

        modelBuilder.Entity<FeePerdType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("FEE_PERD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FinReqSttsType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("FIN_REQ_STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Flag>(entity =>
        {
            entity.HasKey(e => e.FlgNo);

            entity.ToTable("FLAGS");

            entity.Property(e => e.FlgNo)
                .ValueGeneratedNever()
                .HasColumnName("FLG_NO");
            entity.Property(e => e.FlgChange).HasColumnName("FLG_Change");
            entity.Property(e => e.FlgDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FLG_DESC");
            entity.Property(e => e.FlgEname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLG_ENAME");
            entity.Property(e => e.FlgName)
                .HasMaxLength(50)
                .HasColumnName("FLG_NAME");
            entity.Property(e => e.FlgType).HasColumnName("FLG_Type");
            entity.Property(e => e.FlgTypeValue)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FLG_TYPE_VALUE");
            entity.Property(e => e.FlgUser).HasColumnName("FLG_USER");
        });

        modelBuilder.Entity<FnanAcctCnfg>(entity =>
        {
            entity.HasKey(e => e.FnanAcctId);

            entity.ToTable("FNAN_ACCT_CNFG");

            entity.Property(e => e.FnanAcctId).HasColumnName("FNAN_ACCT_ID");
            entity.Property(e => e.AcctNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ACCT_NO");
            entity.Property(e => e.AcctTitleAr)
                .HasMaxLength(80)
                .HasColumnName("ACCT_TITLE_AR");
            entity.Property(e => e.AcctTitleEn)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ACCT_TITLE_EN");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FnanAcctCtgryCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_CTGRY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
        });

        modelBuilder.Entity<FnanAcctCnfgForBillPymt>(entity =>
        {
            entity.HasKey(e => e.FnanAcctId).HasName("PK_FNAN_ACCT_CNFG_FOR_WATER_BILL");

            entity.ToTable("FNAN_ACCT_CNFG_FOR_BILL_PYMT");

            entity.Property(e => e.FnanAcctId).HasColumnName("FNAN_ACCT_ID");
            entity.Property(e => e.AcctBrchDao)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ACCT_BRCH_DAO");
            entity.Property(e => e.AcctNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ACCT_NO");
            entity.Property(e => e.AcctTitleAr)
                .HasMaxLength(80)
                .HasColumnName("ACCT_TITLE_AR");
            entity.Property(e => e.AcctTitleEn)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ACCT_TITLE_EN");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FnanAcctCtgryCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_CTGRY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
        });

        modelBuilder.Entity<FnanAcctCtgry>(entity =>
        {
            entity.HasKey(e => e.CtgryCode);

            entity.ToTable("FNAN_ACCT_CTGRY");

            entity.Property(e => e.CtgryCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CTGRY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CtgryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTGRY_NAME");
            entity.Property(e => e.DaoLinkType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DAO_LINK_TYPE");
            entity.Property(e => e.Desc)
                .HasMaxLength(80)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FngrPrntHsty>(entity =>
        {
            entity.HasKey(e => e.FngrPrntId);

            entity.ToTable("FNGR_PRNT_HSTY");

            entity.Property(e => e.FngrPrntId).HasColumnName("FNGR_PRNT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DvceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FrzAcct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FRZ_ACCT_Id");

            entity.ToTable("FRZ_ACCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FrzAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("FRZ_Amount");
            entity.Property(e => e.FrzDate)
                .HasColumnType("date")
                .HasColumnName("FRZ_DATE");
            entity.Property(e => e.FrzReqTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRZ_REQ_Type_Code");
            entity.Property(e => e.FrzResnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FRZ_RESN_Type_Code");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsCanceledAll).HasColumnName("Is_Canceled_All");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFreezedAll).HasColumnName("Is_Freezed_All");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Acct).WithMany(p => p.FrzAccts)
                .HasForeignKey(d => d.Acctid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_ACCT_ACCT");

            entity.HasOne(d => d.FrzReqTypeCodeNavigation).WithMany(p => p.FrzAccts)
                .HasForeignKey(d => d.FrzReqTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_ACCT_FRZ_REQ_TYPE");

            entity.HasOne(d => d.FrzResnTypeCodeNavigation).WithMany(p => p.FrzAccts)
                .HasForeignKey(d => d.FrzResnTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_ACCT_FRZ_RESN_TYPE");
        });

        modelBuilder.Entity<FrzAcctDoc>(entity =>
        {
            entity.ToTable("FRZ_ACCT_DOC");

            entity.Property(e => e.FrzAcctDocId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FRZ_ACCT_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.FrzAcctId).HasColumnName("FRZ_ACCT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.FrzAcctDocNavigation).WithOne(p => p.FrzAcctDoc)
                .HasForeignKey<FrzAcctDoc>(d => d.FrzAcctDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_ACCT_DOC_UPLD_DOC_DETL");

            entity.HasOne(d => d.FrzAcct).WithMany(p => p.FrzAcctDocs)
                .HasForeignKey(d => d.FrzAcctId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_ACCT_DOC_FRZ_ACCT");
        });

        modelBuilder.Entity<FrzReqType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("FRZ_REQ_TYPE_CODE");

            entity.ToTable("FRZ_REQ_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FrzResnType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("FRZ_RESN_TYPE_CODE");

            entity.ToTable("FRZ_RESN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<FrzRqstTranMpng>(entity =>
        {
            entity.ToTable("FRZ_RQST_TRAN_MPNG");

            entity.Property(e => e.FrzRqstTranMpngId).HasColumnName("FRZ_RQST_TRAN_MPNG_ID");
            entity.Property(e => e.ChnlId).HasColumnName("CHNL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FrzReqTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRZ_REQ_TYPE_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Chnl).WithMany(p => p.FrzRqstTranMpngs)
                .HasForeignKey(d => d.ChnlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_RQST_TRAN_MPNG_CHNL");

            entity.HasOne(d => d.FrzReqTypeCodeNavigation).WithMany(p => p.FrzRqstTranMpngs)
                .HasForeignKey(d => d.FrzReqTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FRZ_RQST_TRAN_MPNG_FRZ_REQ_TYPE");
        });

        modelBuilder.Entity<GndrType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("GENDER_TYPE_CODE");

            entity.ToTable("GNDR_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<GovnCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Govn_Cities");

            entity.Property(e => e.AgentCityAr)
                .HasMaxLength(50)
                .HasColumnName("Agent_City_AR");
            entity.Property(e => e.AgentCityEng)
                .HasMaxLength(50)
                .HasColumnName("Agent_City_ENG");
            entity.Property(e => e.AgentGovernateAr)
                .HasMaxLength(50)
                .HasColumnName("Agent_Governate_AR");
            entity.Property(e => e.AgentGovernateEng)
                .HasMaxLength(50)
                .HasColumnName("Agent_Governate_ENG");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.AgntNameLocal)
                .HasMaxLength(100)
                .HasColumnName("AGNT_NAME_LOCAL");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CityStatus)
                .HasMaxLength(50)
                .HasColumnName("City_status");
            entity.Property(e => e.GvnStatus)
                .HasMaxLength(50)
                .HasColumnName("GVN_status");
            entity.Property(e => e.OldAgntCode)
                .HasMaxLength(50)
                .HasColumnName("OLD_AGNT_CODE");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GrpNo).HasName("PK_GROUPS");

            entity.Property(e => e.GrpNo)
                .ValueGeneratedNever()
                .HasColumnName("Grp_No");
            entity.Property(e => e.GrpAccount)
                .HasMaxLength(15)
                .HasColumnName("Grp_Account");
            entity.Property(e => e.GrpNameAr)
                .HasMaxLength(100)
                .HasColumnName("Grp_Name_Ar");
            entity.Property(e => e.GrpNameEn)
                .HasMaxLength(30)
                .HasColumnName("Grp_Name_En");
            entity.Property(e => e.GrpPower).HasColumnName("Grp_Power");
            entity.Property(e => e.GrpState)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Grp_State");
            entity.Property(e => e.GrpType).HasColumnName("Grp_Type");
        });

        modelBuilder.Entity<GroupFee>(entity =>
        {
            entity.HasKey(e => e.FeesGroupId);

            entity.ToTable("Group_FEES");

            entity.Property(e => e.FeesGroupId).HasColumnName("FEES_Group_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeesDesc)
                .HasMaxLength(500)
                .HasColumnName("FEES_DESC");
            entity.Property(e => e.FeesName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FEES_NAME");
            entity.Property(e => e.FeesNameLocal)
                .HasMaxLength(250)
                .HasColumnName("FEES_NAME_LOCAL");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<GroupFeesDetl>(entity =>
        {
            entity.HasKey(e => e.DetlId);

            entity.ToTable("Group_FEES_DETL");

            entity.Property(e => e.DetlId).HasColumnName("DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeesGroupId).HasColumnName("FEES_Group_ID");
            entity.Property(e => e.FeesId).HasColumnName("FEES_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.FeesGroup).WithMany(p => p.GroupFeesDetls)
                .HasForeignKey(d => d.FeesGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_FEES_DETL_Group_FEES");

            entity.HasOne(d => d.Fees).WithMany(p => p.GroupFeesDetls)
                .HasForeignKey(d => d.FeesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_FEES_DETL_FEES");
        });

        modelBuilder.Entity<GroupLimit>(entity =>
        {
            entity.HasKey(e => e.LimitGroupId);

            entity.ToTable("Group_LIMIT");

            entity.Property(e => e.LimitGroupId).HasColumnName("LIMIT_Group_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimitDesc)
                .HasMaxLength(500)
                .HasColumnName("LIMIT_DESC");
            entity.Property(e => e.LimitName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LIMIT_NAME");
            entity.Property(e => e.LimitNameLocal)
                .HasMaxLength(250)
                .HasColumnName("LIMIT_NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<GroupLimitDetl>(entity =>
        {
            entity.HasKey(e => e.DetlId);

            entity.ToTable("Group_LIMIT_DETL");

            entity.Property(e => e.DetlId).HasColumnName("DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimitGroupId).HasColumnName("LIMIT_Group_ID");
            entity.Property(e => e.LimitId).HasColumnName("LIMIT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.LimitGroup).WithMany(p => p.GroupLimitDetls)
                .HasForeignKey(d => d.LimitGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_LIMIT_DETL_Group_LIMIT");

            entity.HasOne(d => d.Limit).WithMany(p => p.GroupLimitDetls)
                .HasForeignKey(d => d.LimitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_LIMIT_DETL_LIMT");
        });

        modelBuilder.Entity<Gvrn>(entity =>
        {
            entity.HasKey(e => e.GvrnCode);

            entity.ToTable("GVRN");

            entity.Property(e => e.GvrnCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_CODE");
            entity.Property(e => e.CntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.GvrnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GVRN_NAME");
            entity.Property(e => e.GvrnNameLocal)
                .HasMaxLength(250)
                .HasColumnName("GVRN_NAME_LOCAL");
            entity.Property(e => e.GvrnOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_OLD_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CntyCodeNavigation).WithMany(p => p.Gvrns)
                .HasForeignKey(d => d.CntyCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GVRN_CNTY");
        });

        modelBuilder.Entity<HasebCashr>(entity =>
        {
            entity.HasKey(e => e.CashrId);

            entity.ToTable("HASEB_CASHR");

            entity.HasIndex(e => e.AgntBpMainId, "IX_AGNT_BP_MAIN_ID");

            entity.HasIndex(e => e.BpMainId, "IX_BP_MAIN_ID");

            entity.Property(e => e.CashrId).HasColumnName("CASHR_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CashrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CASHR_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.RqstSttsCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RQST_STTS_CODE");
            entity.Property(e => e.SeqncNmbr).HasColumnName("SEQNC_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<HasebPymt>(entity =>
        {
            entity.ToTable("HASEB_PYMT");

            entity.HasIndex(e => e.HasebPointNmbr, "IX_HASEB_POINT_NUMBER");

            entity.Property(e => e.HasebPymtId).HasColumnName("HASEB_PYMT_ID");
            entity.Property(e => e.BankAcctBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_BRCH");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_TYPE");
            entity.Property(e => e.CustName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NAME");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HasebPointNmbr).HasColumnName("HASEB_POINT_NMBR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsOfln)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IS_OFLN");
            entity.Property(e => e.PaydByQrCode).HasColumnName("PAYD_BY_QR_CODE");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.PymtAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PYMT_AMNT");
            entity.Property(e => e.PymtDate)
                .HasColumnType("datetime")
                .HasColumnName("PYMT_DATE");
            entity.Property(e => e.PymtRfndBy).HasColumnName("PYMT_RFND_BY");
            entity.Property(e => e.PymtRfndDate)
                .HasColumnType("datetime")
                .HasColumnName("PYMT_RFND_DATE");
            entity.Property(e => e.PymtStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PYMT_STTS");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.RfndBsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RFND_BSNS_OPRN_DATE");
            entity.Property(e => e.RfndByQrCode)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RFND_BY_QR_CODE");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<HasebPymtDetl>(entity =>
        {
            entity.ToTable("HASEB_PYMT_DETL");

            entity.Property(e => e.HasebPymtDetlId).HasColumnName("HASEB_PYMT_DETL_ID");
            entity.Property(e => e.CashrCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CASHR_CODE");
            entity.Property(e => e.CashrSeqncNmbr).HasColumnName("CASHR_SEQNC_NMBR");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.HasebPointNmbr).HasColumnName("HASEB_POINT_NMBR");
            entity.Property(e => e.HasebPymtId).HasColumnName("HASEB_PYMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<HasebPymtT24DaoCorrection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HASEB_PYMT_T24_DAO_CORRECTION");

            entity.Property(e => e.BankAcctBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_BRCH");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_TYPE");
            entity.Property(e => e.CustName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NAME");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.FeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE_AMNT");
            entity.Property(e => e.HasebPointNmbr).HasColumnName("HASEB_POINT_NMBR");
            entity.Property(e => e.HasebPymtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HASEB_PYMT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PaydByQrCode).HasColumnName("PAYD_BY_QR_CODE");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.PymtAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PYMT_AMNT");
            entity.Property(e => e.PymtDate)
                .HasColumnType("datetime")
                .HasColumnName("PYMT_DATE");
            entity.Property(e => e.PymtRfndBy).HasColumnName("PYMT_RFND_BY");
            entity.Property(e => e.PymtRfndDate)
                .HasColumnType("datetime")
                .HasColumnName("PYMT_RFND_DATE");
            entity.Property(e => e.PymtStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PYMT_STTS");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<HasebToCust>(entity =>
        {
            entity.HasKey(e => e.MfToCustId);

            entity.ToTable("HASEB_TO_CUST");

            entity.Property(e => e.MfToCustId).HasColumnName("MF_TO_CUST_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.CalcLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CALC_LQDTY");
            entity.Property(e => e.CalcLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CALC_LQDTY_FEE");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.PrfmrBpMainId).HasColumnName("PRFMR_BP_MAIN_ID");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBpMainId).HasColumnName("RCVR_BP_MAIN_ID");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<IdType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ID_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<InssRefundReq>(entity =>
        {
            entity.ToTable("INSS_REFUND_REQ");

            entity.Property(e => e.InssRefundReqId).HasColumnName("INSS_REFUND_REQ_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<IsSkipWorkingHour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IS_SKIP_WORKING_HOUR");

            entity.HasIndex(e => e.BpMainId, "UK_BP_MAIN_ID").IsUnique();

            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<JobFildType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("JOB_FILD_TYPE_CODE");

            entity.ToTable("JOB_FILD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<KeChnl>(entity =>
        {
            entity.ToTable("KE_CHNL");

            entity.Property(e => e.KeChnlId).HasColumnName("KE_CHNL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KeChnlDesc)
                .HasMaxLength(500)
                .HasColumnName("KE_CHNL_DESC");
            entity.Property(e => e.KeChnlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KE_CHNL_NAME");
            entity.Property(e => e.KeChnlNameLocal)
                .HasMaxLength(250)
                .HasColumnName("KE_CHNL_NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<KeRemtStatus>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_REMT_STATUS");

            entity.ToTable("KE_REMT_STATUS");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(50)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<KeRemtType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("KE_REMT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<KepaidBymftemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KEPaidBYMFTemp");

            entity.Property(e => e.KeRemtId).HasColumnName("KE_REMT_ID");
        });

        modelBuilder.Entity<KjToMf>(entity =>
        {
            entity.ToTable("KJ_TO_MF");

            entity.Property(e => e.KjToMfId).HasColumnName("KJ_TO_MF_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BankAcctDao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_DAO");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BsnsOprnDate)
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustAcctType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_ACCT_TYPE");
            entity.Property(e => e.CustBankLqdty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUST_BANK_LQDTY");
            entity.Property(e => e.CustName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_NAME");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.Lqdtyfee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LQDTYFEE");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<KycAttr>(entity =>
        {
            entity.HasKey(e => e.KycAttrId).HasName("PK__KYC_ATTR__F5D988D81F82243E");

            entity.ToTable("KYC_ATTR");

            entity.Property(e => e.KycAttrId).HasColumnName("KYC_ATTR_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DtypCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DTYP_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycAttrDesc)
                .HasMaxLength(500)
                .HasColumnName("KYC_ATTR_DESC");
            entity.Property(e => e.KycAttrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("KYC_ATTR_NAME");
            entity.Property(e => e.KycAttrNameLocl)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("KYC_ATTR_NAME_LOCL");
            entity.Property(e => e.KycAttrStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KYC_ATTR_STTS");
            entity.Property(e => e.MaxLong).HasColumnName("MAX_LONG");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.DtypCodeNavigation).WithMany(p => p.KycAttrs)
                .HasForeignKey(d => d.DtypCode)
                .HasConstraintName("FK__KYC_ATTR__DTYP_C__5BAD9CC8");

            entity.HasOne(d => d.KycAttrSttsNavigation).WithMany(p => p.KycAttrs)
                .HasForeignKey(d => d.KycAttrStts)
                .HasConstraintName("FK_KYC_ATTR_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<KycSet>(entity =>
        {
            entity.HasKey(e => e.KycSetId).HasName("PK__KYC_SET__8DCC1FE8C5D12BC2");

            entity.ToTable("KYC_SET");

            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycSetDesc)
                .HasMaxLength(500)
                .HasColumnName("KYC_SET_DESC");
            entity.Property(e => e.KycSetName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("KYC_SET_NAME");
            entity.Property(e => e.KycSetNameLocl)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("KYC_SET_NAME_LOCL");
            entity.Property(e => e.KycSetStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KYC_SET_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ClntRoleTypeCodeNavigation).WithMany(p => p.KycSets)
                .HasForeignKey(d => d.ClntRoleTypeCode)
                .HasConstraintName("FK__KYC_SET__CLNT_RO__0880433F");

            entity.HasOne(d => d.KycSetSttsNavigation).WithMany(p => p.KycSets)
                .HasForeignKey(d => d.KycSetStts)
                .HasConstraintName("FK_KYC_SET_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<KycSetDetl>(entity =>
        {
            entity.HasKey(e => e.KycSetDetlId).HasName("PK__KYC_SET___8B71FB30BA5B22C8");

            entity.ToTable("KYC_SET_DETL");

            entity.Property(e => e.KycSetDetlId).HasColumnName("KYC_SET_DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DsplOrd).HasColumnName("DSPL_ORD");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsMand).HasColumnName("IS_MAND");
            entity.Property(e => e.KycAttrId).HasColumnName("KYC_ATTR_ID");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.KycAttr).WithMany(p => p.KycSetDetls)
                .HasForeignKey(d => d.KycAttrId)
                .HasConstraintName("FK__KYC_SET_D__KYC_A__0C50D423");

            entity.HasOne(d => d.KycSet).WithMany(p => p.KycSetDetls)
                .HasForeignKey(d => d.KycSetId)
                .HasConstraintName("FK__KYC_SET_D__KYC_S__0B5CAFEA");
        });

        modelBuilder.Entity<LangType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LANG_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<LdgrCnfg>(entity =>
        {
            entity.ToTable("LDGR_CNFG");

            entity.Property(e => e.LdgrCnfgId).HasColumnName("LDGR_CNFG_ID");
            entity.Property(e => e.AcctType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00000')")
                .HasColumnName("ACCT_TYPE");
            entity.Property(e => e.AmntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AMNT_TYPE_CODE");
            entity.Property(e => e.CrLdgrDescAr)
                .HasMaxLength(150)
                .HasColumnName("CR_LDGR_DESC_AR");
            entity.Property(e => e.CrLdgrDescEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CR_LDGR_DESC_EN");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DrLdgrDescAr)
                .HasMaxLength(150)
                .HasColumnName("DR_LDGR_DESC_AR");
            entity.Property(e => e.DrLdgrDescEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DR_LDGR_DESC_EN");
            entity.Property(e => e.FnanAcctCtgryCodeCr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_CTGRY_CODE_CR");
            entity.Property(e => e.FnanAcctCtgryCodeDr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_CTGRY_CODE_DR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RevnPrtnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVN_PRTN_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<LdgrSyncJobHstry>(entity =>
        {
            entity.HasKey(e => e.LdgrSyncJobHstryId).HasName("PK__LDGR_SYN__D7770F1C4DECB621");

            entity.ToTable("LDGR_SYNC_JOB_HSTRY");

            entity.Property(e => e.LdgrSyncJobHstryId).HasColumnName("LDGR_SYNC_JOB_HSTRY_ID");
            entity.Property(e => e.SyncDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SYNC_DATE");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
        });

        modelBuilder.Entity<Limt>(entity =>
        {
            entity.HasKey(e => e.LimtId).HasName("PK__LIMT__177F556BC02638D0");

            entity.ToTable("LIMT");

            entity.Property(e => e.LimtId).HasColumnName("LIMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimtDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_DESC");
            entity.Property(e => e.LimtName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_NAME");
            entity.Property(e => e.LimtNameLocl)
                .HasMaxLength(250)
                .HasColumnName("LIMT_NAME_LOCL");
            entity.Property(e => e.LimtStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LIMT_STTS");
            entity.Property(e => e.LimtTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.LimtTypeCodeNavigation).WithMany(p => p.Limts)
                .HasForeignKey(d => d.LimtTypeCode)
                .HasConstraintName("FK__LIMT__LIMT_TYPE___740F363E");
        });

        modelBuilder.Entity<LimtDetl>(entity =>
        {
            entity.HasKey(e => e.LimtDetlId).HasName("PK__LIMT_DET__64BF23DBCBDA28B8");

            entity.ToTable("LIMT_DETL");

            entity.Property(e => e.LimtDetlId).HasColumnName("LIMT_DETL_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsNdvd).HasColumnName("IS_NDVD");
            entity.Property(e => e.IsUnLmtd).HasColumnName("IS_UN_LMTD");
            entity.Property(e => e.LimtId).HasColumnName("LIMT_ID");
            entity.Property(e => e.LimtPerdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LIMT_PERD_TYPE");
            entity.Property(e => e.Lqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LQDTY");
            entity.Property(e => e.MaxAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAX_AMNT");
            entity.Property(e => e.MaxTranCnt).HasColumnName("MAX_TRAN_CNT");
            entity.Property(e => e.MinAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN_AMNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CrcyTypeCodeNavigation).WithMany(p => p.LimtDetls)
                .HasForeignKey(d => d.CrcyTypeCode)
                .HasConstraintName("FK__LIMT_DETL__CRCY___10AB74EC");

            entity.HasOne(d => d.Limt).WithMany(p => p.LimtDetls)
                .HasForeignKey(d => d.LimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LIMT_DETL__LIMT___0FB750B3");

            entity.HasOne(d => d.LimtPerdTypeNavigation).WithMany(p => p.LimtDetls)
                .HasForeignKey(d => d.LimtPerdType)
                .HasConstraintName("FK__LIMT_DETL__LIMT___119F9925");
        });

        modelBuilder.Entity<LimtPerdType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__LIMT_PER__7C83C689A2687190");

            entity.ToTable("LIMT_PERD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<LimtType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__LIMT_TYP__BBB77B747D6132FA");

            entity.ToTable("LIMT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Lqdty>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LQDTY");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MdleType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("MDLE_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MenuPrvl>(entity =>
        {
            entity.ToTable("MENU_PRVL");

            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.ActnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACTN_NAME");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.ContName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONT_NAME");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IconName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ICON_NAME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsMobl).HasColumnName("IS_MOBL");
            entity.Property(e => e.IsVsbl).HasColumnName("IS_VSBL");
            entity.Property(e => e.MenuParamName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MENU_PARAM_NAME");
            entity.Property(e => e.MenuParamValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MENU_PARAM_VALUE");
            entity.Property(e => e.MenuPrvlDesc)
                .HasMaxLength(250)
                .HasColumnName("MENU_PRVL_DESC");
            entity.Property(e => e.MenuPrvlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MENU_PRVL_NAME");
            entity.Property(e => e.MenuPrvlNameLocal)
                .HasMaxLength(250)
                .HasColumnName("MENU_PRVL_NAME_LOCAL");
            entity.Property(e => e.PrntId).HasColumnName("PRNT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SortOrdr).HasColumnName("SORT_ORDR");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MfAgntAcctMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_AGNT_ACCT_MAPPING");

            entity.Property(e => e.BankAcctNo).HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.Phon).HasColumnName("PHON");
        });

        modelBuilder.Entity<MfBranchList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_BRANCH_LIST");

            entity.Property(e => e.BrchAdrs)
                .HasMaxLength(100)
                .HasColumnName("BRCH_ADRS");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .HasColumnName("comment");
            entity.Property(e => e.LqdtyCode).HasColumnName("LQDTY_CODE");
            entity.Property(e => e.MfloosSpclstName)
                .HasMaxLength(50)
                .HasColumnName("MFLOOS_SPCLST_NAME");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(50)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(50)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.OnyxBrchGrpId).HasColumnName("ONYX_BRCH_GRP_ID");
            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.RegnName)
                .HasMaxLength(50)
                .HasColumnName("REGN_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");
            entity.Property(e => e.T24Code).HasColumnName("T24_code");
            entity.Property(e => e.T24Name)
                .HasMaxLength(50)
                .HasColumnName("T24_Name");
            entity.Property(e => e.Wrkqstts).HasColumnName("WRKQSTTS");
        });

        modelBuilder.Entity<MfBrchUserUpdt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_BRCH_USER_UPDT");

            entity.Property(e => e.Addr)
                .HasMaxLength(100)
                .HasColumnName("ADDR");
            entity.Property(e => e.BpDetlId).HasColumnName("BP_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .HasColumnName("DOB");
            entity.Property(e => e.Eml)
                .HasMaxLength(50)
                .HasColumnName("EML");
            entity.Property(e => e.FrstName)
                .HasMaxLength(50)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(50)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.NewBrchCode)
                .HasMaxLength(50)
                .HasColumnName("new_BRCH_CODE");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(50)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.Phon).HasColumnName("PHON");
        });

        modelBuilder.Entity<MfEPymtFeeDdctnJobError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_E_PYMT_FEE_DDCTN_JOB_ERRORS");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            entity.Property(e => e.Logged).HasColumnType("datetime");
        });

        modelBuilder.Entity<MfKeRemt>(entity =>
        {
            entity.ToTable("MF_KE_REMT");

            entity.HasIndex(e => e.KeRemtTypeCode, "IX_REMT_STTS_CODE");

            entity.HasIndex(e => e.KeNo, "KE_NO");

            entity.Property(e => e.MfKeRemtId).HasColumnName("MF_KE_REMT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CURR_ID");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IdNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_NMBR");
            entity.Property(e => e.IdType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KeNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KE_NO");
            entity.Property(e => e.KeRemtId).HasColumnName("KE_REMT_ID");
            entity.Property(e => e.KeRemtTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KE_REMT_TYPE_CODE");
            entity.Property(e => e.MainPrfmrId).HasColumnName("MAIN_PRFMR_ID");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PayLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAY_LQDTY");
            entity.Property(e => e.PayLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAY_LQDTY_FEE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.PrfmrType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_TYPE");
            entity.Property(e => e.RcvrName)
                .HasMaxLength(250)
                .HasColumnName("RCVR_NAME");
            entity.Property(e => e.RcvrPhon)
                .HasMaxLength(50)
                .HasColumnName("RCVR_PHON");
            entity.Property(e => e.RecevLqdtyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RECEV_LQDTY_CODE");
            entity.Property(e => e.RemtRefNo)
                .HasMaxLength(50)
                .HasColumnName("REMT_REF_NO");
            entity.Property(e => e.RemtSttsCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REMT_STTS_CODE");
            entity.Property(e => e.RemtTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMT_TYPE_CODE");
            entity.Property(e => e.SendDate)
                .HasColumnType("datetime")
                .HasColumnName("SEND_DATE");
            entity.Property(e => e.SendLqdtyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SEND_LQDTY_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBrch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNDR_BRCH");
            entity.Property(e => e.SndrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SNDR_NAME");
            entity.Property(e => e.SndrPhon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNDR_PHON");
            entity.Property(e => e.SubPrfmrId).HasColumnName("SUB_PRFMR_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.XchgRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("XCHG_RATE");
        });

        modelBuilder.Entity<MfKeRemtJobError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_KE_REMT_JOB_ERRORS");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
        });

        modelBuilder.Entity<MfT24AcctUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MF_T24_ACCT_UPDATE");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.AvblBlnc).HasColumnName("AVBL_BLNC");
            entity.Property(e => e.BankAcctNmbr).HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BankAcctNo).HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.WaltAcctNmbr).HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<MfToBk>(entity =>
        {
            entity.ToTable("MF_TO_BK");

            entity.HasIndex(e => e.TranTypeCode, "IX_TRAN_TYPE_CODE");

            entity.Property(e => e.MfToBkId).HasColumnName("MF_TO_BK_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(500)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(50)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.RetryCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RETRY_COUNT");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(250)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MfToBkRvsl>(entity =>
        {
            entity.ToTable("MF_TO_BK_RVSL");

            entity.HasIndex(e => e.MfToBkId, "uk_MF_TO_BK_ID").IsUnique();

            entity.Property(e => e.MfToBkRvslId).HasColumnName("MF_TO_BK_RVSL_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(50)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.MfToBkId).HasColumnName("MF_TO_BK_ID");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(250)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts).HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<MfToMf>(entity =>
        {
            entity.ToTable("MF_TO_MF");

            entity.Property(e => e.MfToMfId).HasColumnName("MF_TO_MF_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SentLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SENT_LQDTY");
            entity.Property(e => e.SentLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SENT_LQDTY_FEE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MfilsRemt>(entity =>
        {
            entity.ToTable("MFILS_REMT");

            entity.Property(e => e.MfilsRemtId).HasColumnName("MFILS_REMT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CalcLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CALC_LQDTY");
            entity.Property(e => e.CalcLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CALC_LQDTY_FEE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.MfilsRemtNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("MFILS_REMT_NO");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .HasColumnName("NOTE");
            entity.Property(e => e.PreprdBy).HasColumnName("PREPRD_BY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SNDR_BRCH");
            entity.Property(e => e.SndrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SNDR_LQDTY");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MfilsRemtDetl>(entity =>
        {
            entity.ToTable("MFILS_REMT_DETL");

            entity.Property(e => e.MfilsRemtDetlId).HasColumnName("MFILS_REMT_DETL_ID");
            entity.Property(e => e.BenfBpMainId).HasColumnName("BENF_BP_MAIN_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CreditAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREDIT_ACCT");
            entity.Property(e => e.DebitAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBIT_ACCT");
            entity.Property(e => e.MfilsRemtId).HasColumnName("MFILS_REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<MfloosAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mfloos_Account");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(1003)
                .IsUnicode(false)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.IdNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ID_NMBR");
            entity.Property(e => e.LinkedBranch)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("linked_branch");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("Request_Date");
            entity.Property(e => e.SourceIncome)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("Source_Income");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<MkrCustServ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MKR_CUST_SERV");

            entity.Property(e => e.BranchId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.Brithday).HasColumnType("date");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("Description ");
            entity.Property(e => e.Disgnation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<MrtlSttsType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("MRTL_STTS_TYPE_CODE");

            entity.ToTable("MRTL_STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<NewsAdnc>(entity =>
        {
            entity.ToTable("NEWS_ADNC");

            entity.Property(e => e.NewsAdncId).HasColumnName("NEWS_ADNC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsRead).HasColumnName("IS_READ");
            entity.Property(e => e.NewsSetupId).HasColumnName("NEWS_SETUP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");

            entity.HasOne(d => d.NewsSetup).WithMany(p => p.NewsAdncs)
                .HasForeignKey(d => d.NewsSetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NEWS_ADNC_NEWS_SETUP");
        });

        modelBuilder.Entity<NewsDoc>(entity =>
        {
            entity.ToTable("NEWS_DOC");

            entity.Property(e => e.NewsDocId).HasColumnName("NEWS_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NewsSetupId).HasColumnName("NEWS_SETUP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.NewsSetup).WithMany(p => p.NewsDocs)
                .HasForeignKey(d => d.NewsSetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NEWS_DOC_NEWS_SETUP");
        });

        modelBuilder.Entity<NewsSetup>(entity =>
        {
            entity.ToTable("NEWS_SETUP");

            entity.Property(e => e.NewsSetupId).HasColumnName("NEWS_SETUP_ID");
            entity.Property(e => e.Chnl)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHNL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NewsLink)
                .HasMaxLength(350)
                .HasColumnName("NEWS_LINK");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(60)
                .HasColumnName("TITLE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<NotifyAdnc>(entity =>
        {
            entity.ToTable("NOTIFY_ADNC");

            entity.Property(e => e.NotifyAdncId).HasColumnName("NOTIFY_ADNC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsRead).HasColumnName("IS_READ");
            entity.Property(e => e.NotifySetupId).HasColumnName("NOTIFY_SETUP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<NotifyAdncLog>(entity =>
        {
            entity.HasKey(e => e.NotifyAdncLogId).HasName("PK_TNOTIFY_ADNC_LOG_ID");

            entity.ToTable("NOTIFY_ADNC_LOGS");

            entity.Property(e => e.NotifyAdncLogId).HasColumnName("NOTIFY_ADNC_LOG_ID");
            entity.Property(e => e.FailedCount).HasColumnName("FAILED_COUNT");
            entity.Property(e => e.Logged)
                .HasColumnType("datetime")
                .HasColumnName("LOGGED");
            entity.Property(e => e.NotifyFailedResp).HasColumnName("NOTIFY_FAILED_RESP");
            entity.Property(e => e.NotifySetupId).HasColumnName("NOTIFY_SETUP_ID");
            entity.Property(e => e.SucessCount).HasColumnName("SUCESS_COUNT");
        });

        modelBuilder.Entity<NotifyDoc>(entity =>
        {
            entity.ToTable("NOTIFY_DOC");

            entity.Property(e => e.NotifyDocId).HasColumnName("NOTIFY_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NotifySetupId).HasColumnName("NOTIFY_SETUP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");
        });

        modelBuilder.Entity<NotifySetup>(entity =>
        {
            entity.ToTable("NOTIFY_SETUP");

            entity.Property(e => e.NotifySetupId).HasColumnName("NOTIFY_SETUP_ID");
            entity.Property(e => e.Chnl)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHNL");
            entity.Property(e => e.Cntnt)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("CNTNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<OfflnLimt>(entity =>
        {
            entity.ToTable("OFFLN_LIMT");

            entity.Property(e => e.OfflnLimtId).HasColumnName("OFFLN_LIMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OfflnLimtName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OFFLN_LIMT_NAME");
            entity.Property(e => e.OfflnLimtNameLocal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OFFLN_LIMT_NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<OfflnLimtDetl>(entity =>
        {
            entity.ToTable("OFFLN_LIMT_DETL");

            entity.Property(e => e.OfflnLimtDetlId).HasColumnName("OFFLN_LIMT_DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustmLimtId).HasColumnName("CUSTM_LIMT_ID");
            entity.Property(e => e.GnrlLimtId).HasColumnName("GNRL_LIMT_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OfflnLimtId).HasColumnName("OFFLN_LIMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CustmLimt).WithMany(p => p.OfflnLimtDetlCustmLimts)
                .HasForeignKey(d => d.CustmLimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OFFLN_LIM__CUSTM__61D87BD8");

            entity.HasOne(d => d.GnrlLimt).WithMany(p => p.OfflnLimtDetlGnrlLimts)
                .HasForeignKey(d => d.GnrlLimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OFFLN_LIM__GNRL___5FF03366");

            entity.HasOne(d => d.OfflnLimt).WithMany(p => p.OfflnLimtDetls)
                .HasForeignKey(d => d.OfflnLimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OFFLN_LIM__OFFLN__60E4579F");

            entity.HasOne(d => d.TranTypeCodeNavigation).WithMany(p => p.OfflnLimtDetls)
                .HasForeignKey(d => d.TranTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OFFLN_LIM__TRAN___62CCA011");
        });

        modelBuilder.Entity<OfflnUser>(entity =>
        {
            entity.ToTable("OFFLN_USER");

            entity.Property(e => e.OfflnUserId).HasColumnName("OFFLN_USER_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BpMain).WithMany(p => p.OfflnUsers)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OFFLN_USE__BP_MA__63C0C44A");
        });

        modelBuilder.Entity<OflnTran>(entity =>
        {
            entity.ToTable("OFLN_TRAN");

            entity.Property(e => e.OflnTranId).HasColumnName("OFLN_TRAN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<OflnTranInactvUsr>(entity =>
        {
            entity.ToTable("OFLN_TRAN_INACTV_USR");

            entity.Property(e => e.OflnTranInactvUsrId).HasColumnName("OFLN_TRAN_INACTV_USR_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MblNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MBL_NMBR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<OldAgentDataNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OLD_AGENT_DATA_New");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DeviceID");
            entity.Property(e => e.Usr1stTime).HasColumnName("Usr_1stTime");
            entity.Property(e => e.UsrAddDatetime)
                .HasColumnType("datetime")
                .HasColumnName("usr_add_datetime");
            entity.Property(e => e.UsrAgent).HasColumnName("Usr_Agent");
            entity.Property(e => e.UsrAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Usr_Amount");
            entity.Property(e => e.UsrChange).HasColumnName("Usr_Change");
            entity.Property(e => e.UsrGroup).HasColumnName("Usr_Group");
            entity.Property(e => e.UsrLoginhash)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usr_loginhash");
            entity.Property(e => e.UsrName)
                .HasMaxLength(100)
                .HasColumnName("usr_name");
            entity.Property(e => e.UsrNo).HasColumnName("Usr_No");
            entity.Property(e => e.UsrPassword)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Usr_Password");
            entity.Property(e => e.UsrPasswordFinish)
                .HasColumnType("datetime")
                .HasColumnName("Usr_PasswordFinish");
            entity.Property(e => e.UsrSalt)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Usr_Salt");
            entity.Property(e => e.UsrState).HasColumnName("Usr_state");
            entity.Property(e => e.UsrStopTime)
                .HasColumnType("datetime")
                .HasColumnName("Usr_StopTime");
            entity.Property(e => e.UsrTryLogin).HasColumnName("Usr_TryLogin");
            entity.Property(e => e.UsrUser).HasColumnName("Usr_User");
            entity.Property(e => e.UsrUserActive).HasColumnName("Usr_UserActive");
        });

        modelBuilder.Entity<OldAgentDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OLD_AGENT_DATA");

            entity.Property(e => e.UsrAgent).HasColumnName("usr_agent");
        });

        modelBuilder.Entity<OldUserLoginDetl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_USER1");

            entity.ToTable("OLD_USER_LOGIN_DETL");

            entity.HasIndex(e => e.UserName, "UK_OLD_USER_LOGIN_DETL_USER_NAME").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.Hash).HasColumnName("HASH");
            entity.Property(e => e.IsFrstPswdResetd).HasColumnName("IS_FRST_PSWD_RESETD");
            entity.Property(e => e.Pswd).HasColumnName("PSWD");
            entity.Property(e => e.Salt).HasColumnName("SALT");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<OnyxAcctCnfg>(entity =>
        {
            entity.ToTable("ONYX_ACCT_CNFG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmntType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AMNT_TYPE");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.CrdtAcctDesc)
                .HasMaxLength(250)
                .HasColumnName("CRDT_ACCT_DESC");
            entity.Property(e => e.CrdtAcctName)
                .HasMaxLength(250)
                .HasColumnName("CRDT_ACCT_NAME");
            entity.Property(e => e.CrdtAcctNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT_NO");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcctDesc)
                .HasMaxLength(250)
                .HasColumnName("DEBT_ACCT_DESC");
            entity.Property(e => e.DebtAcctName)
                .HasMaxLength(250)
                .HasColumnName("DEBT_ACCT_NAME");
            entity.Property(e => e.DebtAcctNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT_NO");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LdgrTranTypeCode).HasColumnName("LDGR_TRAN_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TransTypeCode).HasColumnName("TRANS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.TransTypeCodeNavigation).WithMany(p => p.OnyxAcctCnfgs)
                .HasForeignKey(d => d.TransTypeCode)
                .HasConstraintName("FK_ONYX_ACCT_CNFG_TRAN");
        });

        modelBuilder.Entity<OnyxBrchGrp>(entity =>
        {
            entity.HasKey(e => e.OnyxBrchGrpId).HasName("PK_ONYX_CNFG");

            entity.ToTable("ONYX_BRCH_GRP");

            entity.Property(e => e.OnyxBrchGrpId).HasColumnName("ONYX_BRCH_GRP_ID");
            entity.Property(e => e.CostCenter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COST_CENTER");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OnyxBrchGrpNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ONYX_BRCH_GRP_NUMB");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SourceSysCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOURCE_SYS_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<OprtnType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("OPRTN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Org>(entity =>
        {
            entity.ToTable("ORG");

            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DpstFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DPST_FEE");
            entity.Property(e => e.DpstUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DPST_USD");
            entity.Property(e => e.DpstYer)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DPST_YER");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MinLmtUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN_LMT_USD");
            entity.Property(e => e.MinLmtYer)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN_LMT_YER");
            entity.Property(e => e.Mobile)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MOBILE");
            entity.Property(e => e.OpenAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OPEN_ACCT");
            entity.Property(e => e.OrgAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ORG_ADDRESS");
            entity.Property(e => e.OrgDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ORG_DESC");
            entity.Property(e => e.OrgName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORG_NAME");
            entity.Property(e => e.OrgNameLocal)
                .HasMaxLength(250)
                .HasColumnName("ORG_NAME_LOCAL");
            entity.Property(e => e.OrgSts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ORG_STS");
            entity.Property(e => e.OrgWqStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ORG_WQ_STTS");
            entity.Property(e => e.Plac)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PLAC");
            entity.Property(e => e.RcvrPhon).HasColumnName("RCVR_PHON");
            entity.Property(e => e.RemtFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("REMT_FEE");
            entity.Property(e => e.RpstvName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RPSTV_NAME");
            entity.Property(e => e.SendOtp).HasColumnName("SEND_OTP");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TrnsUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TRNS_USD");
            entity.Property(e => e.TrnsYer)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TRNS_YER");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.OrgStsNavigation).WithMany(p => p.Orgs)
                .HasForeignKey(d => d.OrgSts)
                .HasConstraintName("FK__ORG__ORG_STS__4EDE7CE6");
        });

        modelBuilder.Entity<OrgDoc>(entity =>
        {
            entity.ToTable("ORG_DOC");

            entity.Property(e => e.OrgDocId).HasColumnName("ORG_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Org).WithMany(p => p.OrgDocs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_ORG_DOC_ORG");
        });

        modelBuilder.Entity<OrgRemt>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("ORG_REMT");

            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMNT");
            entity.Property(e => e.BenfName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BENF_NAME");
            entity.Property(e => e.BenfPhon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_PHON");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MainPrfmrId).HasColumnName("MAIN_PRFMR_ID");
            entity.Property(e => e.PrfmrType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_TYPE");
            entity.Property(e => e.RemtCardNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REMT_CARD_NO");
            entity.Property(e => e.RemtExprsNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REMT_EXPRS_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrOrgCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SNDR_ORG_CODE");
            entity.Property(e => e.SndrOrgName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SNDR_ORG_NAME");
            entity.Property(e => e.SttsCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STTS_CODE");
            entity.Property(e => e.SubPrfmrId).HasColumnName("SUB_PRFMR_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode).HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CrdtAcctNavigation).WithMany(p => p.OrgRemtCrdtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.CrdtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_REMT_ACCT1");

            entity.HasOne(d => d.DebtAcctNavigation).WithMany(p => p.OrgRemtDebtAcctNavigations)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.DebtAcct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_REMT_ACCT");

            entity.HasOne(d => d.MainPrfmr).WithMany(p => p.OrgRemtMainPrfmrs)
                .HasForeignKey(d => d.MainPrfmrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_REMT_BP_MAIN");

            entity.HasOne(d => d.SubPrfmr).WithMany(p => p.OrgRemtSubPrfmrs)
                .HasForeignKey(d => d.SubPrfmrId)
                .HasConstraintName("FK_ORG_REMT_BP_MAIN1");
        });

        modelBuilder.Entity<OrgStt>(entity =>
        {
            entity.HasKey(e => e.SttsCode);

            entity.ToTable("ORG_STTS");

            entity.Property(e => e.SttsCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsDesc)
                .HasMaxLength(500)
                .HasColumnName("STTS_DESC");
            entity.Property(e => e.SttsName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STTS_NAME");
            entity.Property(e => e.SttsNameLocal)
                .HasMaxLength(250)
                .HasColumnName("STTS_NAME_LOCAL");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Ozla>(entity =>
        {
            entity.HasKey(e => e.OzlaCode);

            entity.ToTable("OZLA");

            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.DistCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OzlaName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OZLA_NAME");
            entity.Property(e => e.OzlaNameLocal)
                .HasMaxLength(250)
                .HasColumnName("OZLA_NAME_LOCAL");
            entity.Property(e => e.OzlaOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_OLD_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.DistCodeNavigation).WithMany(p => p.Ozlas)
                .HasForeignKey(d => d.DistCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OZLA_DIST");
        });

        modelBuilder.Entity<PayHubDatamining1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAY_HUB_DATAMINING1");

            entity.Property(e => e.AmfCusAgentWalletId).HasColumnName("AMF_CusAgentWALLET_ID");
            entity.Property(e => e.T24Account).HasColumnName("T24_Account");
            entity.Property(e => e.T24Customer).HasColumnName("T24_customer");
        });

        modelBuilder.Entity<PerformanceActiveConnection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Performance_ActiveConnections");

            entity.Property(e => e.Dbname)
                .HasMaxLength(128)
                .HasColumnName("DBName");
            entity.Property(e => e.Loginame)
                .HasMaxLength(128)
                .IsFixedLength()
                .HasColumnName("loginame");
            entity.Property(e => e.TimeOfReading)
                .HasColumnType("datetime")
                .HasColumnName("Time_Of_Reading");
        });

        modelBuilder.Entity<PhCorpLoginDashBoard>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK_CRLoginUser");

            entity.ToTable("PH_CORP_Login_DashBoard");

            entity.Property(e => e.LoginId).HasColumnName("LoginID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CashTranRprt).HasColumnName("CASH_TRAN_RPRT");
            entity.Property(e => e.CorpId).HasColumnName("CorpID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.FromTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FROM_TIME");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.ToTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TO_TIME");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ViewDwndAtch).HasColumnName("VIEW_DWND_ATCH");
        });

        modelBuilder.Entity<PhGamCntyMap>(entity =>
        {
            entity.ToTable("PH_GAM_CNTY_MAP");

            entity.Property(e => e.PhGamCntyMapId).HasColumnName("PH_GAM_CNTY_MAP_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.GamCntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GAM_CNTY_CODE");
            entity.Property(e => e.PhCntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PH_CNTY_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<PhLoginDashBoard>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK_LoginUser");

            entity.ToTable("PH_Login_DashBoard");

            entity.Property(e => e.LoginId).HasColumnName("LoginID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PhonNmbrLineType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("PHON_NMBR_LINE_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<PinPass>(entity =>
        {
            entity.ToTable("PIN_PASS");

            entity.Property(e => e.PinPassId).HasColumnName("PIN_PASS_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsOfln)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IS_OFLN");
            entity.Property(e => e.PinPass1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PIN_PASS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<PinPassHsty>(entity =>
        {
            entity.ToTable("PIN_PASS_HSTY");

            entity.Property(e => e.PinPassHstyId).HasColumnName("PIN_PASS_HSTY_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NewPinPass)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NEW_PIN_PASS");
            entity.Property(e => e.OldPinPass)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OLD_PIN_PASS");
            entity.Property(e => e.PinPassId).HasColumnName("PIN_PASS_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<PosetMessage>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK_PosetMessage_New");

            entity.ToTable("PosetMessage");

            entity.Property(e => e.PmBranch)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PM_Branch");
            entity.Property(e => e.PmComment)
                .HasMaxLength(1000)
                .HasColumnName("Pm_Comment");
            entity.Property(e => e.PmDate)
                .HasColumnType("datetime")
                .HasColumnName("PM_Date");
            entity.Property(e => e.PmDatePosted)
                .HasColumnType("datetime")
                .HasColumnName("pm_DatePosted");
            entity.Property(e => e.PmDatePostedEnd)
                .HasColumnType("datetime")
                .HasColumnName("pm_DatePosted_End");
            entity.Property(e => e.PmExpress).HasColumnName("PM_Express");
            entity.Property(e => e.PmGetType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComputedColumnSql("(left([pm_no],(2)))", false)
                .HasColumnName("PM_GetType");
            entity.Property(e => e.PmMessageSent).HasColumnName("PM_MessageSent");
            entity.Property(e => e.PmName)
                .HasMaxLength(100)
                .HasColumnName("PM_Name");
            entity.Property(e => e.PmNo).HasColumnName("PM_No");
            entity.Property(e => e.PmPosted).HasColumnName("PM_Posted");
            entity.Property(e => e.PmRepId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pm_RepID");
            entity.Property(e => e.PmType).HasColumnName("PM_Type");
        });

        modelBuilder.Entity<PostingLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PostingLog");

            entity.Property(e => e.Oprdate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OPRDATE");
        });

        modelBuilder.Entity<PrcntCalOn>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("PRCNT_CAL_ON");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<PritType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__PRIT_TYP__3F06047DA49D02A1");

            entity.ToTable("PRIT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.PritTypeOrdr).HasColumnName("PRIT_TYPE_ORDR");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Prod>(entity =>
        {
            entity.ToTable("PROD");

            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ActMax)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ACT_MAX");
            entity.Property(e => e.ActMin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ACT_MIN");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsVisible)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IS_VISIBLE");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.ProdDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PROD_DESC");
            entity.Property(e => e.ProdName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PROD_NAME");
            entity.Property(e => e.ProdNameLocal)
                .HasMaxLength(250)
                .HasColumnName("PROD_NAME_LOCAL");
            entity.Property(e => e.ProdStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROD_STTS");
            entity.Property(e => e.ProdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROD_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CrcyTypeCodeNavigation).WithMany(p => p.Prods)
                .HasForeignKey(d => d.CrcyTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_CRCY_TYPE");

            entity.HasOne(d => d.KycSet).WithMany(p => p.Prods)
                .HasForeignKey(d => d.KycSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_PROD");

            entity.HasOne(d => d.ProdSttsNavigation).WithMany(p => p.Prods)
                .HasForeignKey(d => d.ProdStts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_RQST_STTS_TYPE");

            entity.HasOne(d => d.ProdTypeCodeNavigation).WithMany(p => p.Prods)
                .HasForeignKey(d => d.ProdTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_CLNT_TOLE_TYPE");
        });

        modelBuilder.Entity<ProdDetl>(entity =>
        {
            entity.ToTable("PROD_DETL");

            entity.Property(e => e.ProdDetlId).HasColumnName("PROD_DETL_ID");
            entity.Property(e => e.ChnlId).HasColumnName("CHNL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FeeId).HasColumnName("FEE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LimtId).HasColumnName("LIMT_ID");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Chnl).WithMany(p => p.ProdDetls)
                .HasForeignKey(d => d.ChnlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_DETL_CHNL");

            entity.HasOne(d => d.Fee).WithMany(p => p.ProdDetls)
                .HasForeignKey(d => d.FeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_DETL_FEE");

            entity.HasOne(d => d.Limt).WithMany(p => p.ProdDetls)
                .HasForeignKey(d => d.LimtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_DETL_LIMT");

            entity.HasOne(d => d.Prod).WithMany(p => p.ProdDetls)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_DETL_PROD");

            entity.HasOne(d => d.Tran).WithMany(p => p.ProdDetls)
                .HasForeignKey(d => d.TranId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROD_DETL_TRAN");
        });

        modelBuilder.Entity<ProdType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PROD_TYPE_CODE");

            entity.ToTable("PROD_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProCode).HasName("PK_PROFILES");

            entity.Property(e => e.ProCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Pro_Code");
            entity.Property(e => e.AdrsCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Adrs_Code");
            entity.Property(e => e.Dbused).HasColumnName("DBUsed");
            entity.Property(e => e.FlgEnglishName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FLG_EnglishNAME");
            entity.Property(e => e.GeneralComm).HasDefaultValueSql("((76))");
            entity.Property(e => e.GrpNo).HasColumnName("Grp_No");
            entity.Property(e => e.L)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ProAdrsAr)
                .HasMaxLength(200)
                .HasColumnName("Pro_Adrs_Ar");
            entity.Property(e => e.ProAdrsEn)
                .HasMaxLength(200)
                .HasColumnName("Pro_Adrs_En");
            entity.Property(e => e.ProAgentType).HasColumnName("Pro_agent_type");
            entity.Property(e => e.ProAllowAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Pro_AllowAmount");
            entity.Property(e => e.ProAllowBuy)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("Pro_AllowBuy");
            entity.Property(e => e.ProAllowExt)
                .HasDefaultValueSql("((76))")
                .HasColumnName("Pro_AllowExt");
            entity.Property(e => e.ProAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_amount");
            entity.Property(e => e.ProAmountComm)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Pro_amount_comm");
            entity.Property(e => e.ProAmountDeposit)
                .HasDefaultValueSql("((10000000))")
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("pro_AmountDeposit");
            entity.Property(e => e.ProAmountTransFer)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Pro_AmountTransFer");
            entity.Property(e => e.ProBobox)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Pro_Bobox");
            entity.Property(e => e.ProChange).HasColumnName("Pro_Change");
            entity.Property(e => e.ProChangeCurrablity).HasColumnName("Pro_ChangeCurrablity");
            entity.Property(e => e.ProChangeCurrablitySale).HasColumnName("Pro_ChangeCurrablitySale");
            entity.Property(e => e.ProCheckPass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Pro_Check_pass");
            entity.Property(e => e.ProCity).HasColumnName("Pro_City");
            entity.Property(e => e.ProCityNo).HasColumnName("Pro_CityNo");
            entity.Property(e => e.ProClass).HasColumnName("Pro_class");
            entity.Property(e => e.ProCollectAmountExchange)
                .HasDefaultValueSql("((1133))")
                .HasColumnName("Pro_CollectAmountExchange");
            entity.Property(e => e.ProComment).HasColumnName("Pro_Comment");
            entity.Property(e => e.ProConfPass)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Pro_Conf_pass");
            entity.Property(e => e.ProConfPassEnc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pro_Conf_pass_enc");
            entity.Property(e => e.ProCord)
                .HasMaxLength(50)
                .HasColumnName("pro_cord");
            entity.Property(e => e.ProCostCenterNo).HasColumnName("Pro_CostCenterNo");
            entity.Property(e => e.ProCountUsers).HasColumnName("Pro_CountUsers");
            entity.Property(e => e.ProCurrRate).HasColumnName("Pro_CurrRate");
            entity.Property(e => e.ProCurrRec).HasColumnName("pro_curr_Rec");
            entity.Property(e => e.ProDate)
                .HasColumnType("datetime")
                .HasColumnName("Pro_Date");
            entity.Property(e => e.ProDownload)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Pro_Download");
            entity.Property(e => e.ProEmail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Pro_Email");
            entity.Property(e => e.ProFax)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_Fax");
            entity.Property(e => e.ProFinger)
                .HasDefaultValueSql("((76))")
                .HasColumnName("Pro_finger");
            entity.Property(e => e.ProFinishContract)
                .HasDefaultValueSql("(((1)/(1))/(1900))")
                .HasColumnType("datetime")
                .HasColumnName("Pro_FinishContract");
            entity.Property(e => e.ProFluidityType)
                .HasDefaultValueSql("((3033))")
                .HasColumnName("_Pro_FluidityType");
            entity.Property(e => e.ProGover).HasColumnName("Pro_Gover");
            entity.Property(e => e.ProGroupAcc)
                .HasMaxLength(10)
                .HasColumnName("Pro_Group_Acc");
            entity.Property(e => e.ProGrpDeposit).HasColumnName("Pro_Grp_Deposit");
            entity.Property(e => e.ProGrpPriv).HasColumnName("pro_Grp_priv");
            entity.Property(e => e.ProInTimeHrs1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_inTime_hrs1");
            entity.Property(e => e.ProInTimeHrs2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_inTime_hrs2");
            entity.Property(e => e.ProInTimeMin1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_InTime_min1");
            entity.Property(e => e.ProInTimeMin2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_InTime_min2");
            entity.Property(e => e.ProIpadress)
                .HasMaxLength(15)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_IPAdress");
            entity.Property(e => e.ProLocation).HasColumnName("pro_location");
            entity.Property(e => e.ProLoginState)
                .HasMaxLength(10)
                .HasColumnName("Pro_LoginState");
            entity.Property(e => e.ProMainCode)
                .HasMaxLength(9)
                .HasColumnName("Pro_Main_Code");
            entity.Property(e => e.ProMaxExchangAmount)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Pro_MaxExchangAmount");
            entity.Property(e => e.ProMultiCurr)
                .HasDefaultValueSql("((76))")
                .HasColumnName("Pro_Multi_Curr");
            entity.Property(e => e.ProNameAr)
                .HasMaxLength(100)
                .HasColumnName("Pro_Name_Ar");
            entity.Property(e => e.ProNameEn)
                .HasMaxLength(1000)
                .HasColumnName("Pro_Name_En");
            entity.Property(e => e.ProNo).HasColumnName("Pro_No");
            entity.Property(e => e.ProOfficeType)
                .HasDefaultValueSql("((1241))")
                .HasColumnName("Pro_OfficeType");
            entity.Property(e => e.ProOpertype).HasColumnName("pro_opertype");
            entity.Property(e => e.ProOutTimeHrs1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Pro_OutTime_hrs1");
            entity.Property(e => e.ProOutTimeHrs2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_OutTime_hrs2");
            entity.Property(e => e.ProOutTimeMin1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Pro_OutTime_min1");
            entity.Property(e => e.ProOutTimeMin2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro_OutTime_min2");
            entity.Property(e => e.ProPassword)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Pro_Password");
            entity.Property(e => e.ProPasswordEnc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Pro_Password_enc");
            entity.Property(e => e.ProPasswordFinsh)
                .HasColumnType("datetime")
                .HasColumnName("Pro_PasswordFinsh");
            entity.Property(e => e.ProPayUnicef)
                .HasDefaultValueSql("((76))")
                .HasColumnName("pro_payUnicef");
            entity.Property(e => e.ProPerCurr)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("Pro_PerCurr");
            entity.Property(e => e.ProPerYr).HasColumnName("Pro_PerYR");
            entity.Property(e => e.ProPeriodSell)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Pro_PeriodSell");
            entity.Property(e => e.ProPremium)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Pro_Premium");
            entity.Property(e => e.ProPrintAfter)
                .HasDefaultValueSql("((76))")
                .HasColumnName("pro_print_after");
            entity.Property(e => e.ProPrintCurBill)
                .HasDefaultValueSql("((77))")
                .HasColumnName("Pro_PrintCurBill");
            entity.Property(e => e.ProReportHeader)
                .HasDefaultValueSql("((77))")
                .HasColumnName("Pro_ReportHeader");
            entity.Property(e => e.ProRistrictSell)
                .HasDefaultValueSql("((77))")
                .HasColumnName("Pro_RistrictSell");
            entity.Property(e => e.ProServiceSp).HasColumnName("Pro_Service_sp");
            entity.Property(e => e.ProState).HasColumnName("Pro_State");
            entity.Property(e => e.ProSysUsing)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_SysUsing");
            entity.Property(e => e.ProTel1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_Tel1");
            entity.Property(e => e.ProTel2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pro_Tel2");
            entity.Property(e => e.ProTyepIn).HasColumnName("Pro_tyep_in");
            entity.Property(e => e.ProType).HasColumnName("Pro_Type");
            entity.Property(e => e.ProTypeComm).HasColumnName("Pro_type_comm");
            entity.Property(e => e.ProTypePrinter).HasColumnName("Pro_TypePrinter");
            entity.Property(e => e.ProUser).HasColumnName("Pro_User");
            entity.Property(e => e.ProUserState).HasColumnName("Pro_UserState");
            entity.Property(e => e.ProUserType).HasColumnName("Pro_user_Type");
            entity.Property(e => e.ProUsername)
                .HasMaxLength(300)
                .HasColumnName("Pro_username");
            entity.Property(e => e.ProUsernameEnc)
                .HasMaxLength(20)
                .HasColumnName("Pro_username_enc");
            entity.Property(e => e.ProWebSite)
                .HasMaxLength(30)
                .HasColumnName("Pro_WebSite");
            entity.Property(e => e.TransSaveState).HasDefaultValueSql("((23))");
            entity.Property(e => e.UseVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength()
                .HasColumnName("Use_Version");
        });

        modelBuilder.Entity<QrActionType>(entity =>
        {
            entity.HasKey(e => e.QrActionTypeCode);

            entity.ToTable("QR_ACTION_TYPE");

            entity.Property(e => e.QrActionTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("QR_ACTION_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<QrAgntDetl>(entity =>
        {
            entity.ToTable("QR_AGNT_DETL");

            entity.Property(e => e.QrAgntDetlId).HasColumnName("QR_AGNT_DETL_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.QrMainId).HasColumnName("QR_MAIN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.AgntBpMain).WithMany(p => p.QrAgntDetls)
                .HasForeignKey(d => d.AgntBpMainId)
                .HasConstraintName("FK_AGNT_BP_MAIN_ID");

            entity.HasOne(d => d.QrMain).WithMany(p => p.QrAgntDetls)
                .HasForeignKey(d => d.QrMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QR_MAIN_ID");
        });

        modelBuilder.Entity<QrCashrDetl>(entity =>
        {
            entity.ToTable("QR_CASHR_DETL");

            entity.Property(e => e.QrCashrDetlId).HasColumnName("QR_CASHR_DETL_ID");
            entity.Property(e => e.CashrBpMainId).HasColumnName("CASHR_BP_MAIN_ID");
            entity.Property(e => e.CashrCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CASHR_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.QrMainId).HasColumnName("QR_MAIN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CashrBpMain).WithMany(p => p.QrCashrDetls)
                .HasForeignKey(d => d.CashrBpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CASHR_BP_MAIN_ID");

            entity.HasOne(d => d.QrMain).WithMany(p => p.QrCashrDetls)
                .HasForeignKey(d => d.QrMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CASHR_QR_MAIN_ID");
        });

        modelBuilder.Entity<QrGenLog>(entity =>
        {
            entity.HasKey(e => e.QrGenId).HasName("PK__QR_GEN_L__35B2CE4176F6A7CC");

            entity.ToTable("QR_GEN_LOGS");

            entity.Property(e => e.QrGenId).HasColumnName("QR_GEN_ID");
            entity.Property(e => e.AgntCode).HasColumnName("AGNT_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.FailResn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FAIL_RESN");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
        });

        modelBuilder.Entity<QrMain>(entity =>
        {
            entity.ToTable("QR_MAIN");

            entity.Property(e => e.QrMainId).HasColumnName("QR_MAIN_ID");
            entity.Property(e => e.ChnlTypeCode).HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsExport).HasColumnName("IS_EXPORT");
            entity.Property(e => e.QrTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("QR_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.QrTypeCodeNavigation).WithMany(p => p.QrMains)
                .HasForeignKey(d => d.QrTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QR_TYPE_CODE");
        });

        modelBuilder.Entity<QrRsvrdWalt>(entity =>
        {
            entity.HasKey(e => e.QrRsvrdWaltId).HasName("PK__QR_RSVRD__DF849AD7C0D9F7D5");

            entity.ToTable("QR_RSVRD_WALT");

            entity.Property(e => e.QrRsvrdWaltId).HasColumnName("QR_RSVRD_WALT_ID");
            entity.Property(e => e.AgntCode).HasColumnName("AGNT_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<QrType>(entity =>
        {
            entity.HasKey(e => e.QrTypeCode);

            entity.ToTable("QR_TYPE");

            entity.Property(e => e.QrTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("QR_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RefundEPaymt>(entity =>
        {
            entity.ToTable("REFUND_E_PAYMT");

            entity.Property(e => e.RefundEPaymtId).HasColumnName("REFUND_E_PAYMT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsRefund).HasColumnName("IS_REFUND");
            entity.Property(e => e.MovementType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MOVEMENT_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_AMOUNT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RefundEPaymtDetl>(entity =>
        {
            entity.ToTable("REFUND_E_PAYMT_DETL");

            entity.Property(e => e.RefundEPaymtDetlId).HasColumnName("REFUND_E_PAYMT_DETL_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BenVeriCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BEN_VERI_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DepositDate)
                .HasColumnType("datetime")
                .HasColumnName("DEPOSIT_DATE");
            entity.Property(e => e.RefundEPaymentsId).HasColumnName("REFUND_E_PAYMENTS_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SubAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SUB_ACCT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RefundEPymtBatch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__REFUND_E__2172E4630C9561EA");

            entity.ToTable("REFUND_E_PYMT_BATCH");

            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.TotalRcrd).HasColumnName("TOTAL_RCRD");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RefundEPymtBatches)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__REFUND_E___CREAT__44281D60");

            entity.HasOne(d => d.Doc).WithMany(p => p.RefundEPymtBatches)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__REFUND_E___DOC_I__4333F927");
        });

        modelBuilder.Entity<RefundEPymtBatchDetl>(entity =>
        {
            entity.HasKey(e => e.BatchDetlId).HasName("PK__REFUND_E__06156F3DB53DFE6D");

            entity.ToTable("REFUND_E_PYMT_BATCH_DETL");

            entity.Property(e => e.BatchDetlId).HasColumnName("BATCH_DETL_ID");
            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(1000)
                .HasColumnName("ERROR_MSG");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PhTranId).HasColumnName("PH_TRAN_ID");
            entity.Property(e => e.RefundAmnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REFUND_AMNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SuplPymtId).HasColumnName("SUPL_PYMT_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Batch).WithMany(p => p.RefundEPymtBatchDetls)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__REFUND_E___BATCH__451C4199");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RefundEPymtBatchDetls)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__REFUND_E___CREAT__461065D2");
        });

        modelBuilder.Entity<Regn>(entity =>
        {
            entity.ToTable("REGN");

            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.CntyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CNTY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LqdtyCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LQDTY_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.RegnStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REGN_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RegnCity>(entity =>
        {
            entity.ToTable("REGN_CITY");

            entity.Property(e => e.RegnCityId).HasColumnName("REGN_CITY_ID");
            entity.Property(e => e.CityCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RegnId).HasColumnName("REGN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CityCodeNavigation).WithMany(p => p.RegnCities)
                .HasForeignKey(d => d.CityCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGN_CITY_CITY");
        });

        modelBuilder.Entity<Remt>(entity =>
        {
            entity.ToTable("REMT");

            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .HasColumnName("NOTE");
            entity.Property(e => e.PayLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PAY_LQDTY");
            entity.Property(e => e.PayLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PAY_LQDTY_FEE");
            entity.Property(e => e.PreprdBy).HasColumnName("PREPRD_BY");
            entity.Property(e => e.PrfmrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_BRCH");
            entity.Property(e => e.PrfmrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFMR_LQDTY");
            entity.Property(e => e.RcvrBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_BRCH");
            entity.Property(e => e.RcvrLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RCVR_LQDTY");
            entity.Property(e => e.RemtNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("REMT_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RemtBenfDetl>(entity =>
        {
            entity.HasKey(e => e.RemtBenfDeltId);

            entity.ToTable("REMT_BENF_DETL");

            entity.HasIndex(e => e.RemtId, "IX_REMT_ID");

            entity.Property(e => e.RemtBenfDeltId).HasColumnName("REMT_BENF_DELT_ID");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.IdExpDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_EXP_DATE");
            entity.Property(e => e.IdIsueDate)
                .HasColumnType("datetime")
                .HasColumnName("ID_ISUE_DATE");
            entity.Property(e => e.IdNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ID_NO");
            entity.Property(e => e.IdTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ID_TYPE_CODE");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MidlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MIDL_NAME");
            entity.Property(e => e.MoblNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOBL_NO");
            entity.Property(e => e.PlacOfIsue)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PLAC_OF_ISUE");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");

            entity.HasOne(d => d.Remt).WithMany(p => p.RemtBenfDetls)
                .HasForeignKey(d => d.RemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_BENF_DETL_REMT");
        });

        modelBuilder.Entity<RemtCnclRqst>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("REMT_CNCL_RQST");

            entity.Property(e => e.RemtId)
                .ValueGeneratedNever()
                .HasColumnName("REMT_ID");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.HasOne(d => d.Remt).WithOne(p => p.RemtCnclRqst)
                .HasForeignKey<RemtCnclRqst>(d => d.RemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_CNCL_RQST_REMT");
        });

        modelBuilder.Entity<RemtDetl>(entity =>
        {
            entity.ToTable("REMT_DETL");

            entity.HasIndex(e => e.PerformerId, "IX_PERFORMERID");

            entity.HasIndex(e => e.RemtId, "IX_REMT_ID");

            entity.Property(e => e.RemtDetlId).HasColumnName("REMT_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.CmsnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN_AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CreditAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREDIT_ACCT");
            entity.Property(e => e.DebitAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBIT_ACCT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.RemtDetls)
                .HasForeignKey(d => d.RemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_DETL_REMT");
        });

        modelBuilder.Entity<RemtInssDetl>(entity =>
        {
            entity.HasKey(e => e.RemtInssDetl1);

            entity.ToTable("REMT_INSS_DETL");

            entity.HasIndex(e => e.RemtId, "UQ__REMT_INS__C531BCBACE768EA3").IsUnique();

            entity.Property(e => e.RemtInssDetl1).HasColumnName("REMT_INSS_DETL");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.InssReqId).HasColumnName("INSS_REQ_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsReFund).HasColumnName("IS_RE_FUND");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RemtTranKycDetl>(entity =>
        {
            entity.HasKey(e => new { e.RemtTranId, e.KycSetId, e.KycAttrId }).HasName("PK_REMT_TRAN_DETL");

            entity.ToTable("REMT_TRAN_KYC_DETL");

            entity.Property(e => e.RemtTranId).HasColumnName("REMT_TRAN_ID");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.KycAttrId).HasColumnName("KYC_ATTR_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycAttrName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KYC_ATTR_NAME");
            entity.Property(e => e.KycAttrVal)
                .HasMaxLength(500)
                .HasColumnName("KYC_ATTR_VAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.KycAttr).WithMany(p => p.RemtTranKycDetls)
                .HasForeignKey(d => d.KycAttrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_TRAN_DETL_KYC_ATTR");

            entity.HasOne(d => d.KycSet).WithMany(p => p.RemtTranKycDetls)
                .HasForeignKey(d => d.KycSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_TRAN_DETL_KYC_SET");
        });

        modelBuilder.Entity<RestrPrice>(entity =>
        {
            entity.ToTable("RESTR_PRICE");

            entity.Property(e => e.RestrPriceId).HasColumnName("RESTR_PRICE_ID");
            entity.Property(e => e.AcctCurrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ACCT_CURR_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PRICE");
            entity.Property(e => e.RemtCurrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("REMT_CURR_CODE");
            entity.Property(e => e.RestrPriceName)
                .HasMaxLength(250)
                .HasColumnName("RESTR_PRICE_NAME");
            entity.Property(e => e.RestrPriceNameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RESTR_PRICE_NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TransType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TRANS_TYPE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WrkqStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WRKQ_STTS");

            entity.HasOne(d => d.AcctCurrCodeNavigation).WithMany(p => p.RestrPriceAcctCurrCodeNavigations)
                .HasForeignKey(d => d.AcctCurrCode)
                .HasConstraintName("FK_RESTR_PRICE_RESTR_PRICE");

            entity.HasOne(d => d.RemtCurrCodeNavigation).WithMany(p => p.RestrPriceRemtCurrCodeNavigations)
                .HasForeignKey(d => d.RemtCurrCode)
                .HasConstraintName("FK_RESTR_PRICE_CRCY_TYPE");
        });

        modelBuilder.Entity<RevnPrtnType>(entity =>
        {
            entity.HasKey(e => e.RevnPrtnTypeCode);

            entity.ToTable("REVN_PRTN_TYPE");

            entity.Property(e => e.RevnPrtnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVN_PRTN_TYPE_CODE");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.RevnPrtnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REVN_PRTN_NAME");
        });

        modelBuilder.Entity<RfundEPymt>(entity =>
        {
            entity.HasKey(e => e.RfundEPymtId).HasName("PK__RFUND_E___2C674515DFFC854E");

            entity.ToTable("RFUND_E_PYMT");

            entity.HasIndex(e => e.PhTranId, "UK_RFUND_E_PYMT").IsUnique();

            entity.Property(e => e.RfundEPymtId).HasColumnName("RFUND_E_PYMT_ID");
            entity.Property(e => e.BatchId).HasColumnName("BATCH_ID");
            entity.Property(e => e.BsnsOprnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("BSNS_OPRN_DATE");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DbtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DBT_ACCT");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PhTranId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PH_TRAN_ID");
            entity.Property(e => e.RefundAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("REFUND_AMNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplPymtId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUPL_PYMT_ID");
            entity.Property(e => e.T24RefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("T24_REF_NO");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RfundEPymts)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RFUND_E_P__CREAT__47048A0B");
        });

        modelBuilder.Entity<RjctResnType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__RJCT_RES__FEF4DC5C51B54F93");

            entity.ToTable("RJCT_RESN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RolePrvlDetl>(entity =>
        {
            entity.ToTable("ROLE_PRVL_DETL");

            entity.Property(e => e.RolePrvlDetlId).HasColumnName("ROLE_PRVL_DETL_ID");
            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.RoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ROLE_TYPE_CODE");

            entity.HasOne(d => d.MenuPrvl).WithMany(p => p.RolePrvlDetls)
                .HasForeignKey(d => d.MenuPrvlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_PRVL_DETL_MENU_PRVL");

            entity.HasOne(d => d.RoleTypeCodeNavigation).WithMany(p => p.RolePrvlDetls)
                .HasForeignKey(d => d.RoleTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_PRVL_DETL_USER_ROLE_TYPE");
        });

        modelBuilder.Entity<RqstAprvDesg>(entity =>
        {
            entity.HasKey(e => e.RqstAprvDesgId).HasName("PK_RQST_APRV_ROLE");

            entity.ToTable("RQST_APRV_DESG");

            entity.Property(e => e.RqstAprvDesgId).HasColumnName("RQST_APRV_DESG_ID");
            entity.Property(e => e.AprvBrch).HasColumnName("APRV_BRCH");
            entity.Property(e => e.AprvHeadQrtr).HasColumnName("APRV_HEAD_QRTR");
            entity.Property(e => e.AprvMainBrch).HasColumnName("APRV_MAIN_BRCH");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RqstTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RQST_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserDesgTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_DESG_TYPE_CODE");

            entity.HasOne(d => d.RqstTypeCodeNavigation).WithMany(p => p.RqstAprvDesgs)
                .HasForeignKey(d => d.RqstTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RQST_APRV_ROLE_RQST_TYPE_CODE");

            entity.HasOne(d => d.UserDesgTypeCodeNavigation).WithMany(p => p.RqstAprvDesgs)
                .HasForeignKey(d => d.UserDesgTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RQST_APRV_DESG_USER_DESG_TYPE");
        });

        modelBuilder.Entity<RqstSttsType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__RQST_STT__B3A69E38C6FF4B30");

            entity.ToTable("RQST_STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<RqstType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__RQST_TYP__8ACDD27A6A31F279");

            entity.ToTable("RQST_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.PritTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRIT_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.PritTypeCodeNavigation).WithMany(p => p.RqstTypes)
                .HasForeignKey(d => d.PritTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RQST_TYPE__PRIT___07420643");
        });

        modelBuilder.Entity<RstrctRolePrvl>(entity =>
        {
            entity.ToTable("RSTRCT_ROLE_PRVL");

            entity.Property(e => e.RstrctRolePrvlId).HasColumnName("RSTRCT_ROLE_PRVL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.RoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ROLE_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.MenuPrvl).WithMany(p => p.RstrctRolePrvls)
                .HasForeignKey(d => d.MenuPrvlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RSTRCT_ROLE_PRVL_MENU_PRVL");
        });

        modelBuilder.Entity<RtrnCode>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("RTRN_CODES");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Scrn>(entity =>
        {
            entity.ToTable("SCRN");

            entity.HasIndex(e => e.ScrnId, "IX_SCRN").IsUnique();

            entity.Property(e => e.ScrnId).HasColumnName("SCRN_ID");
            entity.Property(e => e.AppCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APP_CODE");
            entity.Property(e => e.ScrnDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SCRN_DESC");
            entity.Property(e => e.ScrnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SCRN_NAME");
        });

        modelBuilder.Entity<SelfMfToBk>(entity =>
        {
            entity.ToTable("SELF_MF_TO_BK");

            entity.Property(e => e.SelfMfToBkId).HasColumnName("SELF_MF_TO_BK_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankBrchDao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BANK_BRCH_DAO");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(500)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(50)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.IsAutoTrfr).HasColumnName("IS_AUTO_TRFR");
            entity.Property(e => e.RetryCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RETRY_COUNT");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(250)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<SelfMfToBkRvsl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SELF_MF_TO_BK_RVSL");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankRfrncId)
                .HasMaxLength(50)
                .HasColumnName("BANK_RFRNC_ID");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.SelfMfToBkId).HasColumnName("SELF_MF_TO_BK_ID");
            entity.Property(e => e.SelfMfToBkRvslId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SELF_MF_TO_BK_RVSL_ID");
            entity.Property(e => e.SendCustName)
                .HasMaxLength(250)
                .HasColumnName("SEND_CUST_NAME");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<Sesn>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("SESN");

            entity.HasIndex(e => new { e.SessionId, e.UserId, e.IsActive }, "IX_Ahmed-20191010").HasFillFactor(70);

            entity.HasIndex(e => new { e.UserId, e.IsActive }, "IX_SESN_31102021");

            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.BpId).HasColumnName("BP_ID");
            entity.Property(e => e.BpScndryId).HasColumnName("BP_SCNDRY_ID");
            entity.Property(e => e.DnsNme)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DNS_NME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.LangCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.LogOffDte)
                .HasColumnType("datetime")
                .HasColumnName("LOG_OFF_DTE");
            entity.Property(e => e.LogOnDte)
                .HasColumnType("datetime")
                .HasColumnName("LOG_ON_DTE");
            entity.Property(e => e.SessionCde)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CDE");
            entity.Property(e => e.SessionIp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SESSION_IP");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<SlideDoc>(entity =>
        {
            entity.ToTable("SLIDE_DOC");

            entity.Property(e => e.SlideDocId).HasColumnName("SLIDE_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SlideSetupId).HasColumnName("SLIDE_SETUP_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.SlideSetup).WithMany(p => p.SlideDocs)
                .HasForeignKey(d => d.SlideSetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SLIDE_DOC_SLIDE_SETUP");
        });

        modelBuilder.Entity<SlideSetup>(entity =>
        {
            entity.ToTable("SLIDE_SETUP");

            entity.Property(e => e.SlideSetupId).HasColumnName("SLIDE_SETUP_ID");
            entity.Property(e => e.Chnl)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHNL");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FrbseNodeId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRBSE_NODE_ID");
            entity.Property(e => e.ImgFileLink)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IMG_FILE_LINK");
            entity.Property(e => e.ImgFileName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IMG_FILE_NAME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("TITLE");
            entity.Property(e => e.Txt)
                .HasMaxLength(150)
                .HasColumnName("TXT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.SmsId);

            entity.ToTable("SMS");

            entity.HasIndex(e => new { e.UserId, e.SmsOtpNum, e.SmsIsVerified }, "ix_dba_sms_15032021");

            entity.Property(e => e.SmsId).HasColumnName("SMS_ID");
            entity.Property(e => e.IsPosted).HasColumnName("IS_POSTED");
            entity.Property(e => e.SmsBody)
                .HasMaxLength(500)
                .HasColumnName("SMS_BODY");
            entity.Property(e => e.SmsIsVerified)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SMS_IS_VERIFIED");
            entity.Property(e => e.SmsOtpNum).HasColumnName("SMS_OTP_NUM");
            entity.Property(e => e.SmsSentDate)
                .HasColumnType("datetime")
                .HasColumnName("SMS_SENT_DATE");
            entity.Property(e => e.SmsTrgtPhnNum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SMS_TRGT_PHN_NUM");
            entity.Property(e => e.SmsType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SMS_TYPE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SmsOprtType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_OPRT_TYPE");

            entity.ToTable("SMS_OPRT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SmsTmpl>(entity =>
        {
            entity.ToTable("SMS_TMPL");

            entity.Property(e => e.SmsTmplId).HasColumnName("SMS_TMPL_ID");
            entity.Property(e => e.AgntSms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("AGNT_SMS");
            entity.Property(e => e.AgntSmsLocal)
                .HasMaxLength(500)
                .HasColumnName("AGNT_SMS_LOCAL");
            entity.Property(e => e.AgntSmsTmplType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_SMS_TMPL_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustSms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUST_SMS");
            entity.Property(e => e.CustSmsLocal)
                .HasMaxLength(500)
                .HasColumnName("CUST_SMS_LOCAL");
            entity.Property(e => e.CustSmsTmplType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CUST_SMS_TMPL_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OprtTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OPRT_TYPE_CODE");
            entity.Property(e => e.RecvSms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RECV_SMS");
            entity.Property(e => e.RecvSmsLocal)
                .HasMaxLength(500)
                .HasColumnName("RECV_SMS_LOCAL");
            entity.Property(e => e.RecvSmsTmplType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RECV_SMS_TMPL_TYPE");
            entity.Property(e => e.SendSms)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SEND_SMS");
            entity.Property(e => e.SendSmsLocal)
                .HasMaxLength(500)
                .HasColumnName("SEND_SMS_LOCAL");
            entity.Property(e => e.SendSmsTmplType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SEND_SMS_TMPL_TYPE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.OprtTypeCodeNavigation).WithMany(p => p.SmsTmpls)
                .HasForeignKey(d => d.OprtTypeCode)
                .HasConstraintName("FK_SMS_TMPL_SMS_TMPL");
        });

        modelBuilder.Entity<SrvcPrvdAcct>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("SRVC_PRVD_ACCT");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SrvcType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("SRVC_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SspcnStng>(entity =>
        {
            entity.HasKey(e => e.SspcnId);

            entity.ToTable("SSPCN_STNG");

            entity.Property(e => e.SspcnId).HasColumnName("SSPCN_ID");
            entity.Property(e => e.CrcyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRCY_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CustType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CUST_TYPE");
            entity.Property(e => e.DCmplncActnId).HasColumnName("D_CMPLNC_ACTN_ID");
            entity.Property(e => e.DilyTrnsLmt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DILY_TRNS_LMT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MCmplncActnId).HasColumnName("M_CMPLNC_ACTN_ID");
            entity.Property(e => e.MntlyTrnsLmt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MNTLY_TRNS_LMT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SspcnDesc)
                .HasMaxLength(500)
                .HasColumnName("SSPCN_DESC");
            entity.Property(e => e.SspcnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SSPCN_NAME");
            entity.Property(e => e.SspcnNameLocal)
                .HasMaxLength(250)
                .HasColumnName("SSPCN_NAME_LOCAL");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.DCmplncActn).WithMany(p => p.SspcnStngDCmplncActns)
                .HasForeignKey(d => d.DCmplncActnId)
                .HasConstraintName("FK_SSPCN_STNG_CMPLNC_ACTN");

            entity.HasOne(d => d.MCmplncActn).WithMany(p => p.SspcnStngMCmplncActns)
                .HasForeignKey(d => d.MCmplncActnId)
                .HasConstraintName("FK_SSPCN_STNG_CMPLNC_ACTN1");

            entity.HasOne(d => d.Tran).WithMany(p => p.SspcnStngs)
                .HasForeignKey(d => d.TranId)
                .HasConstraintName("FK_SSPCN_STNG_TRAN");
        });

        modelBuilder.Entity<SttsType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("STTS_TYPE_CODE");

            entity.ToTable("STTS_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SubAgntTopup>(entity =>
        {
            entity.ToTable("SUB_AGNT_TOPUP");

            entity.Property(e => e.SubAgntTopupId).HasColumnName("SUB_AGNT_TOPUP_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SubOprtnType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("SUB_OPRTN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SubSrvcType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("SUB_SRVC_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SubUserAlwdAmnt>(entity =>
        {
            entity.ToTable("SUB_USER_ALWD_AMNT");

            entity.Property(e => e.SubUserAlwdAmntId).HasColumnName("SUB_USER_ALWD_AMNT_ID");
            entity.Property(e => e.AlwdAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ALWD_AMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserBpMainId).HasColumnName("USER_BP_MAIN_ID");
        });

        modelBuilder.Entity<SubUserAlwdCrcy>(entity =>
        {
            entity.ToTable("SUB_USER_ALWD_CRCY");

            entity.Property(e => e.SubUserAlwdCrcyId).HasColumnName("SUB_USER_ALWD_CRCY_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserBpMainId).HasColumnName("USER_BP_MAIN_ID");
        });

        modelBuilder.Entity<SubaccountToMf>(entity =>
        {
            entity.ToTable("SUBACCOUNT_TO_MF");

            entity.Property(e => e.SubaccountToMfId).HasColumnName("SUBACCOUNT_TO_MF_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
        });

        modelBuilder.Entity<SuplExtrUrlCnfg>(entity =>
        {
            entity.ToTable("SUPL_EXTR_URL_CNFG");

            entity.Property(e => e.SuplExtrUrlCnfgId).HasColumnName("SUPL_EXTR_URL_CNFG_ID");
            entity.Property(e => e.AuthTokn)
                .IsUnicode(false)
                .HasColumnName("AUTH_TOKN");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BASE_URL");
            entity.Property(e => e.CommType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COMM_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.EndPoint)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("END_POINT");
            entity.Property(e => e.Envr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENVR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Port).HasColumnName("PORT");
            entity.Property(e => e.Pswd)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SuplPrfl>(entity =>
        {
            entity.ToTable("SUPL_PRFL");

            entity.Property(e => e.SuplPrflId).HasColumnName("SUPL_PRFL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CatgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CATG_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.EPymtPromotnId).HasColumnName("E_PYMT_PROMOTN_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsEml).HasColumnName("IS_EML");
            entity.Property(e => e.IsMobNum).HasColumnName("IS_MOB_NUM");
            entity.Property(e => e.IsRegstrId).HasColumnName("IS_REGSTR_ID");
            entity.Property(e => e.LogoFileId).HasColumnName("LOGO_FILE_ID");
            entity.Property(e => e.PrjtName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRJT_NAME");
            entity.Property(e => e.RfndExprDays).HasColumnName("RFND_EXPR_DAYS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SuplZoneBlnc>(entity =>
        {
            entity.ToTable("SUPL_ZONE_BLNC");

            entity.Property(e => e.SuplZoneBlncId).HasColumnName("SUPL_ZONE_BLNC_ID");
            entity.Property(e => e.AvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuplBpMainId).HasColumnName("SUPL_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.ZoneBrch)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZONE_BRCH");
            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
        });

        modelBuilder.Entity<SupportRemtInssDetl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUPPORT_REMT_INSS_DETL");

            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.InssReqId).HasColumnName("INSS_REQ_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsReFund).HasColumnName("IS_RE_FUND");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.RemtInssDetl)
                .ValueGeneratedOnAdd()
                .HasColumnName("REMT_INSS_DETL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SuprAgnt>(entity =>
        {
            entity.ToTable("SUPR_AGNT");

            entity.Property(e => e.SuprAgntId).HasColumnName("SUPR_AGNT_ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(250)
                .HasColumnName("ADDR");
            entity.Property(e => e.AgntNameLocal)
                .HasMaxLength(250)
                .HasColumnName("AGNT_NAME_LOCAL");
            entity.Property(e => e.AgntState)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_STATE");
            entity.Property(e => e.AgntTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AGNT_TYPE_CODE");
            entity.Property(e => e.BankAcctNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CmplSettngCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CMPL_SETTNG_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(300)
                .HasColumnName("DESC");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FnanAcctNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FNAN_ACCT_NO");
            entity.Property(e => e.FrstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.InitialInssBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INITIAL_INSS_BLNC");
            entity.Property(e => e.InssAcct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INSS_ACCT");
            entity.Property(e => e.InssAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INSS_AMNT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsInssDdct).HasColumnName("IS_INSS_DDCT");
            entity.Property(e => e.IsKeagent).HasColumnName("IS_KEAGENT");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.PhonNumb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON_NUMB");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.SubAgntCount).HasColumnName("SUB_AGNT_COUNT");
            entity.Property(e => e.SubUserCount).HasColumnName("SUB_USER_COUNT");
            entity.Property(e => e.SuprAgntCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPR_AGNT_CODE");
            entity.Property(e => e.TranLevlCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_LEVL_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WalletNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALLET_NO");

            entity.HasOne(d => d.BpMain).WithMany(p => p.SuprAgnts)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPR_AGNT_BP_MAIN");

            entity.HasOne(d => d.WalletNoNavigation).WithMany(p => p.SuprAgnts)
                .HasPrincipalKey(p => p.WaltAcctNmbr)
                .HasForeignKey(d => d.WalletNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPR_AGNT_ACCT");
        });

        modelBuilder.Entity<SuprAgntAlwdCrcy>(entity =>
        {
            entity.ToTable("SUPR_AGNT_ALWD_CRCY");

            entity.Property(e => e.SuprAgntAlwdCrcyId).HasColumnName("SUPR_AGNT_ALWD_CRCY_ID");
            entity.Property(e => e.CrcyTypeCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CRCY_TYPE_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuprAgntBpMainId).HasColumnName("SUPR_AGNT_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.SuprAgntBpMain).WithMany(p => p.SuprAgntAlwdCrcies)
                .HasForeignKey(d => d.SuprAgntBpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPR_AGNT_ALWD_CRCY_BP_MAIN");
        });

        modelBuilder.Entity<SuprAgntCmsnPrfl>(entity =>
        {
            entity.ToTable("SUPR_AGNT_CMSN_PRFL");

            entity.Property(e => e.SuprAgntCmsnPrflId).HasColumnName("SUPR_AGNT_CMSN_PRFL_ID");
            entity.Property(e => e.CmsnPrflId).HasColumnName("CMSN_PRFL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SuprAgntId).HasColumnName("SUPR_AGNT_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.SuprAgnt).WithMany(p => p.SuprAgntCmsnPrfls)
                .HasForeignKey(d => d.SuprAgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPR_AGNT_CMSN_PRFL_SUPR_AGNT");
        });

        modelBuilder.Entity<SuprAgntDoc>(entity =>
        {
            entity.ToTable("SUPR_AGNT_DOC");

            entity.Property(e => e.SuprAgntDocId).HasColumnName("SUPR_AGNT_DOC_ID");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.SuprAgntId).HasColumnName("SUPR_AGNT_ID");

            entity.HasOne(d => d.SuprAgnt).WithMany(p => p.SuprAgntDocs)
                .HasForeignKey(d => d.SuprAgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPR_AGNT_DOC_SUPR_AGNT");
        });

        modelBuilder.Entity<SuprAgntLimt>(entity =>
        {
            entity.ToTable("SUPR_AGNT_LIMTS");

            entity.Property(e => e.SuprAgntLimtId).HasColumnName("SUPR_AGNT_LIMT_ID");
            entity.Property(e => e.AgntLimtSetngId).HasColumnName("AGNT_LIMT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.SuprAgntBpMainId).HasColumnName("SUPR_AGNT_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SuprAgntRestrPrice>(entity =>
        {
            entity.HasKey(e => e.SuprAgntPriceId);

            entity.ToTable("SUPR_AGNT_RESTR_PRICES");

            entity.Property(e => e.SuprAgntPriceId).HasColumnName("SUPR_AGNT_PRICE_ID");
            entity.Property(e => e.AgntRestrPriceId).HasColumnName("AGNT_RESTR_PRICE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.SuprAgntBpMainId).HasColumnName("SUPR_AGNT_BP_MAIN_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<SuprAgntTopup>(entity =>
        {
            entity.ToTable("SUPR_AGNT_TOPUP");

            entity.Property(e => e.SuprAgntTopupId).HasColumnName("SUPR_AGNT_TOPUP_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankAcctDao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_DAO");
            entity.Property(e => e.BankAcctNmbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NMBR");
            entity.Property(e => e.BankCustName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANK_CUST_NAME");
            entity.Property(e => e.ChnlTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CHNL_TYPE_CODE");
            entity.Property(e => e.ClntRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CLNT_ROLE_TYPE_CODE");
            entity.Property(e => e.Cmsn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CMSN");
            entity.Property(e => e.CrdtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CRDT_ACCT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DebtAcct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEBT_ACCT");
            entity.Property(e => e.Desc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.RcvrBpId).HasColumnName("RCVR_BP_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SndrBpId).HasColumnName("SNDR_BP_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<T24Acct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T24_ACCT");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(64)
                .HasColumnName("ACCOUNT_NUMBER");
            entity.Property(e => e.AcctId)
                .HasMaxLength(64)
                .HasColumnName("ACCT_ID");
            entity.Property(e => e.AltAcctId).HasColumnName("ALT_ACCT_ID");
            entity.Property(e => e.CustomerNo).HasColumnName("CUSTOMER_NO");
        });

        modelBuilder.Entity<T24Branch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T24_BRANCH");

            entity.Property(e => e.Dao).HasColumnName("DAO");
            entity.Property(e => e.DeptParent).HasColumnName("DEPT_PARENT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(50)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(50)
                .HasColumnName("ZONE_CODE");
        });

        modelBuilder.Entity<T24CobDate>(entity =>
        {
            entity.HasKey(e => e.T24CobDateId).HasName("PK_T24_COB_DATE_ID");

            entity.ToTable("T24_COB_DATE");

            entity.Property(e => e.T24CobDateId).HasColumnName("T24_COB_DATE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.T24Date)
                .HasColumnType("datetime")
                .HasColumnName("T24_DATE");
        });

        modelBuilder.Entity<T24LdgrsGenerationSpError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T24_Ldgrs_Generation_SP_Errors");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
        });

        modelBuilder.Entity<T24LdgrsSyncJobError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T24_Ldgrs_Sync_Job_Errors");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            entity.Property(e => e.Logged)
                .HasColumnType("datetime")
                .HasColumnName("LOGGED");
        });

        modelBuilder.Entity<Temp08052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_08052022");

            entity.Property(e => e.BranchId).HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .HasColumnName("Branch_Name");
            entity.Property(e => e.BrchAdrs)
                .HasMaxLength(50)
                .HasColumnName("BRCH_ADRS");
            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .HasColumnName("DOB");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(1)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FrstName)
                .HasMaxLength(50)
                .HasColumnName("FRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MddlName)
                .HasMaxLength(50)
                .HasColumnName("MDDL_NAME");
            entity.Property(e => e.PhoneNumber).HasColumnName("Phone_Number");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.UserRoleTypeCode).HasColumnName("USER_ROLE_TYPE_CODE");
        });

        modelBuilder.Entity<TempAcctPrddAgntHasib>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_ACCT_PRDD_AGNT_HASIB");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_ROLE_TYPE_CODE");
        });

        modelBuilder.Entity<TempAcctRev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_ACCT_REVS");

            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.AvblBlncBefr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AVBL_BLNC_BEFR");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.Orgn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ORGN");
            entity.Property(e => e.WaltAcctNmbr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALT_ACCT_NMBR");
        });

        modelBuilder.Entity<TempAgntAcct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_AGNT_ACCT");

            entity.Property(e => e.AgntName)
                .HasMaxLength(752)
                .IsUnicode(false)
                .HasColumnName("AGNT_NAME");
            entity.Property(e => e.BankAcctNo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCT_NO");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.CurrId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CURR_ID");
            entity.Property(e => e.Phon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<TempCentralBankReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_CENTRAL_BANK_REPORT");

            entity.Property(e => e.AccountType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Account Type");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("DATE");
            entity.Property(e => e.RecieverAccount)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Reciever Account");
            entity.Property(e => e.RecieverName)
                .HasMaxLength(1003)
                .IsUnicode(false)
                .HasColumnName("Reciever Name");
            entity.Property(e => e.RelatedBranchToReciever)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Related Branch To Reciever");
            entity.Property(e => e.RelatedBranchToSender)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Related Branch To Sender");
            entity.Property(e => e.SenderAccount)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Sender Account");
            entity.Property(e => e.SenderName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Sender Name");
            entity.Property(e => e.Time).HasMaxLength(4000);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(503)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Transaction Type");
        });

        modelBuilder.Entity<TempCntBnkRept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_CNT_BNK_REPT");

            entity.Property(e => e.AccountType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Account Type");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("DATE");
            entity.Property(e => e.RecieverAccount)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Reciever Account");
            entity.Property(e => e.RecieverName)
                .HasMaxLength(1003)
                .IsUnicode(false)
                .HasColumnName("Reciever Name");
            entity.Property(e => e.RelatedBranchToReciever)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Related Branch To Reciever");
            entity.Property(e => e.RelatedBranchToSender)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Related Branch To Sender");
            entity.Property(e => e.SenderAccount)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Sender Account");
            entity.Property(e => e.SenderName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Sender Name");
            entity.Property(e => e.Time).HasMaxLength(4000);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(503)
                .HasColumnName("Transaction Type");
        });

        modelBuilder.Entity<TempCsvMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CSV_Main");

            entity.Property(e => e.Amounttobepaid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("amounttobepaid");
            entity.Property(e => e.Cmcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cmcode");
            entity.Property(e => e.Districtwherehelives)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("districtwherehelives");
            entity.Property(e => e.Flagnopayment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagnopayment");
            entity.Property(e => e.Flagoutreach)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagoutreach");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Governoratewherehelives)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("governoratewherehelives");
            entity.Property(e => e.Membercode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("membercode");
            entity.Property(e => e.Olduniquecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olduniquecode");
            entity.Property(e => e.Ozlawherehelives)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ozlawherehelives");
            entity.Property(e => e.Primarybeneficiaryfamilyname)
                .HasMaxLength(50)
                .HasColumnName("primarybeneficiaryfamilyname");
            entity.Property(e => e.Primarybeneficiarynames)
                .HasMaxLength(50)
                .HasColumnName("primarybeneficiarynames");
            entity.Property(e => e.Uniquecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniquecode");
            entity.Property(e => e.Villagewherehelives)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("villagewherehelives");
        });

        modelBuilder.Entity<TempCsvMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CSV_Members");

            entity.Property(e => e.Birthcertificatenumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("birthcertificatenumber");
            entity.Property(e => e.Cviformnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cviformnumber");
            entity.Property(e => e.Disabledcareidnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("disabledcareidnumber");
            entity.Property(e => e.Electoralidnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("electoralidnumber");
            entity.Property(e => e.Familycardnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("familycardnumber");
            entity.Property(e => e.Familymembernames)
                .HasMaxLength(500)
                .HasColumnName("familymembernames");
            entity.Property(e => e.Flagdeceasednopayment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagdeceasednopayment");
            entity.Property(e => e.Flagdisqualified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagdisqualified");
            entity.Property(e => e.Flagpayonly)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagpayonly");
            entity.Property(e => e.Flagrequirescmform)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagrequirescmform");
            entity.Property(e => e.Flagverified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flagverified");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Marriagecontractnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marriagecontractnumber");
            entity.Property(e => e.Membercode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("membercode");
            entity.Property(e => e.Membersadjustedname)
                .HasMaxLength(500)
                .HasColumnName("membersadjustedname");
            entity.Property(e => e.Membersfamilyname)
                .HasMaxLength(500)
                .HasColumnName("membersfamilyname");
            entity.Property(e => e.Nationalidnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationalidnumber");
            entity.Property(e => e.Oldnationalidnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oldnationalidnumber");
            entity.Property(e => e.Passportnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passportnumber");
            entity.Property(e => e.Studentseatnumbercardnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("studentseatnumbercardnumber");
            entity.Property(e => e.Uniquecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniquecode");
        });

        modelBuilder.Entity<TempPaymentSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_PAYMENT_SITE");

            entity.Property(e => e.CorrectSiteNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CORRECT_SITE_NUMBER");
            entity.Property(e => e.WrongSiteNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("WRONG_SITE_NUMBER");
        });

        modelBuilder.Entity<TempRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempRegion");

            entity.Property(e => e.CityArb)
                .HasMaxLength(100)
                .HasColumnName("City_Arb");
            entity.Property(e => e.CityEng)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Eng");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descr).HasMaxLength(100);
            entity.Property(e => e.Liquidity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LocalName)
                .HasMaxLength(200)
                .HasColumnName("Local_Name");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempTableToAdjustDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_TABLE_TO_ADJUST_DATA");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT NUMBER");
            entity.Property(e => e.AmountForAgentAfterDeductingInsuranace)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("AMOUNT FOR AGENT AFTER DEDUCTING INSURANACE");
            entity.Property(e => e.AmountToBeAdjusted)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("AMOUNT TO BE ADJUSTED");
            entity.Property(e => e.CurrentAvailbaleBalanceInAgentAccount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CURRENT AVAILBALE BALANCE IN AGENT ACCOUNT");
            entity.Property(e => e.NumberOfRemittanceForTheAccount).HasColumnName("NUMBER OF REMITTANCE FOR THE ACCOUNT");
            entity.Property(e => e.TotalRemittanceAmount)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TOTAL REMITTANCE AMOUNT");
            entity.Property(e => e.TransferredAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TRANSFERRED AMOUNT");
        });

        modelBuilder.Entity<TempUnicef20032022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempUNICEF20032022");

            entity.Property(e => e.CmCode)
                .HasMaxLength(50)
                .HasColumnName("cm_code");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.Membercode)
                .HasMaxLength(50)
                .HasColumnName("membercode");
            entity.Property(e => e.Uniquecode)
                .HasMaxLength(50)
                .HasColumnName("uniquecode");
        });

        modelBuilder.Entity<TempUnicefRemt08032022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_UNICEF_REMT_08032022");

            entity.Property(e => e.AcctOfBenf)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCT_OF_BENF");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.AmntSouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_SOUTH");
            entity.Property(e => e.BenfDistrct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_DISTRCT");
            entity.Property(e => e.BenfGovrnt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_GOVRNT");
            entity.Property(e => e.BenfOzla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_OZLA");
            entity.Property(e => e.BenfVillg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_VILLG");
            entity.Property(e => e.CmCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CM_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPayedOffline).HasColumnName("IS_PAYED_OFFLINE");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.PaydLoctId).HasColumnName("PAYD_LOCT_ID");
            entity.Property(e => e.PaydMmbrId).HasColumnName("PAYD_MMBR_ID");
            entity.Property(e => e.PayedBy).HasColumnName("PAYED_BY");
            entity.Property(e => e.PayedChnl).HasColumnName("PAYED_CHNL");
            entity.Property(e => e.PrimryMmbrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRIMRY_MMBR_CODE");
            entity.Property(e => e.Region)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TestJob>(entity =>
        {
            entity.ToTable("Test_Job");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
        });

        modelBuilder.Entity<TmpHasebAgntAcct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_HASEB_AGNT_ACCTS");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
        });

        modelBuilder.Entity<TmpMenuPrevilidgeAbd9839>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpMenuPrevilidgeABD9839");

            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.MenuPrvlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MENU_PRVL_NAME");
            entity.Property(e => e.UsrId).HasColumnName("USR_ID");
            entity.Property(e => e.UsrPrvlDetlId).HasColumnName("USR_PRVL_DETL_ID");
        });

        modelBuilder.Entity<TmpMenuPrvldgBkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpMenuPrvldgBKP");

            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.MenuPrvlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MENU_PRVL_NAME");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UsrId).HasColumnName("USR_ID");
            entity.Property(e => e.UsrPrvlDetlId).HasColumnName("USR_PRVL_DETL_ID");
        });

        modelBuilder.Entity<TmpOnlyAgntAcct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_ONLY_AGNT_ACCTS");

            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
        });

        modelBuilder.Entity<TmpPostedLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_POSTED_LEDGERS");

            entity.Property(e => e.TranDate)
                .HasColumnType("date")
                .HasColumnName("tran_date");
            entity.Property(e => e.TranTypeId).HasColumnName("tran_Type_id");
        });

        modelBuilder.Entity<Tran>(entity =>
        {
            entity.ToTable("TRAN");

            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SrvcTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SRVC_TYPE_CODE");
            entity.Property(e => e.SubSrvcTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SUB_SRVC_TYPE_CODE");
            entity.Property(e => e.TranDesc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TRAN_DESC");
            entity.Property(e => e.TranFor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_FOR");
            entity.Property(e => e.TranName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TRAN_NAME");
            entity.Property(e => e.TranNameLocal)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TRAN_NAME_LOCAL");
            entity.Property(e => e.TranStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRAN_STTS");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.SrvcTypeCodeNavigation).WithMany(p => p.Trans)
                .HasForeignKey(d => d.SrvcTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRAN_SRVC_TYPE");

            entity.HasOne(d => d.SubSrvcTypeCodeNavigation).WithMany(p => p.Trans)
                .HasForeignKey(d => d.SubSrvcTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRAN_SUB_SRVC_TYPE");

            entity.HasOne(d => d.TranSttsNavigation).WithMany(p => p.Trans)
                .HasForeignKey(d => d.TranStts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRAN_RQST_STTS_TYPE");
        });

        modelBuilder.Entity<TranFor>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("TRAN_FOR");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<TranInptSetng>(entity =>
        {
            entity.ToTable("TRAN_INPT_SETNG");

            entity.Property(e => e.TranInptSetngId).HasColumnName("TRAN_INPT_SETNG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.KycSetId).HasColumnName("KYC_SET_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.TranInptSetngDesc)
                .HasMaxLength(500)
                .HasColumnName("TRAN_INPT_SETNG_DESC");
            entity.Property(e => e.TranInptSetngName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_INPT_SETNG_NAME");
            entity.Property(e => e.TranInptSetngNameLocl)
                .HasMaxLength(250)
                .HasColumnName("TRAN_INPT_SETNG_NAME_LOCL");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WrkqStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WRKQ_STTS");

            entity.HasOne(d => d.Tran).WithMany(p => p.TranInptSetngs)
                .HasForeignKey(d => d.TranId)
                .HasConstraintName("FK_TRAN_INPT_SETNG_TRAN");
        });

        modelBuilder.Entity<TranOrgn>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("TRAN_ORGN");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefAssignSite>(entity =>
        {
            entity.HasKey(e => e.UauSno);

            entity.ToTable("Unicef_Assign_Sites");

            entity.Property(e => e.UauSno).HasColumnName("UAU_sno");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UauDate)
                .HasColumnType("datetime")
                .HasColumnName("UAU_Date");
            entity.Property(e => e.UauSiteCode)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("UAU_SiteCode");
            entity.Property(e => e.UauStatus).HasColumnName("UAU_Status");
            entity.Property(e => e.UsrNo).HasColumnName("Usr_No");
        });

        modelBuilder.Entity<UnicefAtchRevwStt>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("UNICEF_ATCH_REVW_STTS");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefBenProf>(entity =>
        {
            entity.HasKey(e => e.BenProfId);

            entity.ToTable("UNICEF_BEN_PROF");

            entity.HasIndex(e => e.BenMembCode, "IX_Ahmed-20191010").HasFillFactor(70);

            entity.Property(e => e.BenProfId).HasColumnName("BEN_PROF_ID");
            entity.Property(e => e.BenDob)
                .HasColumnType("datetime")
                .HasColumnName("BEN_DOB");
            entity.Property(e => e.BenIdNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_NUMB");
            entity.Property(e => e.BenIdType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_TYPE");
            entity.Property(e => e.BenMembCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BEN_MEMB_CODE");
            entity.Property(e => e.BenName)
                .HasMaxLength(250)
                .HasColumnName("BEN_NAME");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LastUpdtCycleNum).HasColumnName("LAST_UPDT_CYCLE_NUM");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("NOTES");
            entity.Property(e => e.OldSno).HasColumnName("OLD_SNO");
            entity.Property(e => e.PhonNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PHON_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefBenPstd>(entity =>
        {
            entity.ToTable("UNICEF_BEN_PSTD");

            entity.HasIndex(e => e.CyclId, "IX_CYCLE_ID");

            entity.Property(e => e.UnicefBenPstdId).HasColumnName("UNICEF_BEN_PSTD_ID");
            entity.Property(e => e.ApiResp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("API_RESP");
            entity.Property(e => e.ApiRqst)
                .IsUnicode(false)
                .HasColumnName("API_RQST");
            entity.Property(e => e.BenIdNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_NUMB");
            entity.Property(e => e.BenIdType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_TYPE");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("END_TIME");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00001')")
                .HasColumnName("ORG_CODE");
            entity.Property(e => e.Phon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.PrimryMmbrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRIMRY_MMBR_CODE");
            entity.Property(e => e.Region)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StrtTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRT_TIME");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .HasColumnName("USER_NAME");

            entity.HasOne(d => d.Cycl).WithMany(p => p.UnicefBenPstds).HasForeignKey(d => d.CyclId);
        });

        modelBuilder.Entity<UnicefBenToPost>(entity =>
        {
            entity.ToTable("UNICEF_BEN_TO_POST");

            entity.HasIndex(e => e.RemtId, "IX_Ahmed_16102019").HasFillFactor(70);

            entity.Property(e => e.UnicefBenToPostId).HasColumnName("UNICEF_BEN_TO_POST_ID");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.ApiResp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("API_RESP");
            entity.Property(e => e.ApiRqst)
                .IsUnicode(false)
                .HasColumnName("API_RQST");
            entity.Property(e => e.BenIdNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_NUMB");
            entity.Property(e => e.BenIdType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_TYPE");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("END_TIME");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IsFail).HasColumnName("IS_FAIL");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('00001')")
                .HasColumnName("ORG_CODE");
            entity.Property(e => e.Phon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.PrimryMmbrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRIMRY_MMBR_CODE");
            entity.Property(e => e.Region)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.Resn).HasColumnName("RESN");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StrtTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRT_TIME");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .HasColumnName("USER_NAME");

            entity.HasOne(d => d.Cycl).WithMany(p => p.UnicefBenToPosts).HasForeignKey(d => d.CyclId);
        });

        modelBuilder.Entity<UnicefBenToPostBenjo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UNICEF_BEN_TO_POST_BENJO");

            entity.Property(e => e.BenIdNumb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_NUMB");
            entity.Property(e => e.BenIdType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEN_ID_TYPE");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("END_TIME");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IsFail).HasColumnName("IS_FAIL");
            entity.Property(e => e.OldAgntCode).HasColumnName("OLD_AGNT_CODE");
            entity.Property(e => e.Phon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHON");
            entity.Property(e => e.PrimryMmbrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRIMRY_MMBR_CODE");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.Resn).HasColumnName("RESN");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StrtTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRT_TIME");
            entity.Property(e => e.UnicefBenToPostId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UNICEF_BEN_TO_POST_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<UnicefBeneficiaryProfile>(entity =>
        {
            entity.HasKey(e => e.UbpSno);

            entity.ToTable("Unicef_Beneficiary_Profiles");

            entity.HasIndex(e => e.UbpAttNo, "UK_Uncf_Ben_Prof_AttNo").IsUnique();

            entity.Property(e => e.UbpSno).HasColumnName("UBP_Sno");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UbpAttNo).HasColumnName("UBP_AttNo");
            entity.Property(e => e.UbpBenDob)
                .HasColumnType("date")
                .HasColumnName("UBP_Ben_DOB");
            entity.Property(e => e.UbpBenName)
                .HasMaxLength(150)
                .HasColumnName("UBP_Ben_Name");
            entity.Property(e => e.UbpBenNameAsId)
                .HasMaxLength(150)
                .HasColumnName("UBP_Ben_Name_AS_ID");
            entity.Property(e => e.UbpBenRegCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBP_Ben_Reg_Code");
            entity.Property(e => e.UbpBenUniqueNo).HasColumnName("UBP_Ben_UniqueNo");
            entity.Property(e => e.UbpBranchAgentEntry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UBP_Branch_Agent_Entry");
            entity.Property(e => e.UbpStatus).HasColumnName("UBP_Status");
        });

        modelBuilder.Entity<UnicefBlkdRemi>(entity =>
        {
            entity.ToTable("UNICEF_BLKD_REMI");

            entity.Property(e => e.UnicefBlkdRemiId).HasColumnName("UNICEF_BLKD_REMI_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsDownloaded).HasColumnName("IS_DOWNLOADED");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefBlkdRemiHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UNICEF_BLKD_REMI_HIST");

            entity.Property(e => e.AsgnStts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASGN_STTS");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecdId).HasColumnName("BP_SECD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UnicefBlkdRemiId).HasColumnName("UNICEF_BLKD_REMI_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.BpMain).WithMany()
                .HasForeignKey(d => d.BpMainId)
                .HasConstraintName("FK_UNICEF_BLKD_REMI_HIST_BP_MAIN");

            entity.HasOne(d => d.BpSecd).WithMany()
                .HasForeignKey(d => d.BpSecdId)
                .HasConstraintName("FK_UNICEF_BLKD_REMI_HIST_UNICEF_BLKD_REMI_HIST");

            entity.HasOne(d => d.Remt).WithMany()
                .HasForeignKey(d => d.RemtId)
                .HasConstraintName("FK_UNICEF_BLKD_REMI_HIST_UNICEF_REMT");
        });

        modelBuilder.Entity<UnicefCyclFlag>(entity =>
        {
            entity.HasKey(e => e.CyclFlagCode).HasName("PK_CYCL_FLAG");

            entity.ToTable("UNICEF_CYCL_FLAGS");

            entity.Property(e => e.CyclFlagCode).HasColumnName("CYCL_FLAG_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.CyclName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CYCL_NAME");
            entity.Property(e => e.FlagCode).HasColumnName("FLAG_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Cycl).WithMany(p => p.UnicefCyclFlags)
                .HasForeignKey(d => d.CyclId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNICEF_CYCL_FLAGS_CYCL");

            entity.HasOne(d => d.FlagCodeNavigation).WithMany(p => p.UnicefCyclFlags)
                .HasForeignKey(d => d.FlagCode)
                .HasConstraintName("FK_UNICEF_CYCL_FLAGS_UNICEF_FILE_FLAGS");
        });

        modelBuilder.Entity<UnicefDocRevw>(entity =>
        {
            entity.ToTable("UNICEF_DOC_REVW");

            entity.HasIndex(e => e.DocId, "UNICEF_DOC_REVW_DOC_ID_INDEX");

            entity.Property(e => e.UnicefDocRevwId).HasColumnName("UNICEF_DOC_REVW_ID");
            entity.Property(e => e.Cmnt)
                .HasMaxLength(500)
                .HasColumnName("CMNT");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.RevwBy).HasColumnName("REVW_BY");
            entity.Property(e => e.RevwStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVW_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefFileDoc>(entity =>
        {
            entity.ToTable("UNICEF_FILE_DOC");

            entity.Property(e => e.UnicefFileDocId).HasColumnName("UNICEF_FILE_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.FileTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FILE_TYPE_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StatusTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATUS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefFileFlag>(entity =>
        {
            entity.HasKey(e => e.FlagCode);

            entity.ToTable("UNICEF_FILE_FLAGS");

            entity.Property(e => e.FlagCode).HasColumnName("FLAG_CODE");
            entity.Property(e => e.FlagDesc)
                .HasMaxLength(500)
                .HasColumnName("FLAG_DESC");
            entity.Property(e => e.FlagName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FLAG_NAME");
            entity.Property(e => e.OrgId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ORG_ID");
        });

        modelBuilder.Entity<UnicefFileType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("UNICEF_FILE_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefFlag>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("Unicef_Flags");

            entity.Property(e => e.DistrictCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DistrictCodeV)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when right(rtrim([DistrictCode]),(4)) like '%-[0-9]-%' then [dbo].[GetNumeric](right(rtrim([DistrictCode]),(3))) else [dbo].[GetNumeric](right(rtrim([DistrictCode]),(4))) end)", false);
            entity.Property(e => e.DistrictNameAr)
                .HasMaxLength(50)
                .HasColumnName("DistrictName_Ar");
            entity.Property(e => e.DistrictNameEn)
                .HasMaxLength(50)
                .HasColumnName("DistrictName_En");
            entity.Property(e => e.GovernCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GovernCodeV)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComputedColumnSql("(substring([GovernCode],(2),(2)))", false);
            entity.Property(e => e.GovernNameAr)
                .HasMaxLength(50)
                .HasColumnName("GovernName_AR");
            entity.Property(e => e.GovernNameEn)
                .HasMaxLength(50)
                .HasColumnName("GovernName_En");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OzlaCodeV)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when right(rtrim([OzlaCode]),(4)) like '%-[0-9]-%' then [dbo].[GetNumeric](right(rtrim([OzlaCode]),(3))) else [dbo].[GetNumeric](right(rtrim([OzlaCode]),(4))) end)", false);
            entity.Property(e => e.OzlaName).HasMaxLength(50);
            entity.Property(e => e.VillageCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VillageCodeV)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when right(rtrim([VillageCode]),(4)) like '%-[0-9]-%' then [dbo].[GetNumeric](right(rtrim([VillageCode]),(2))) when right(rtrim([VillageCode]),(4)) like '-%' then [dbo].[GetNumeric](right(rtrim([VillageCode]),(3))) else [dbo].[GetNumeric](right(rtrim([VillageCode]),(5))) end)", false);
            entity.Property(e => e.VillageName).HasMaxLength(50);
        });

        modelBuilder.Entity<UnicefFmly>(entity =>
        {
            entity.HasKey(e => e.FmlyId);

            entity.ToTable("UNICEF_FMLY");

            entity.HasIndex(e => e.FmlyCode, "IX_Ahmed-20191010").HasFillFactor(70);

            entity.Property(e => e.FmlyId).HasColumnName("FMLY_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.FmlyName)
                .HasMaxLength(250)
                .HasColumnName("FMLY_NAME");
            entity.Property(e => e.FmlyOldCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_OLD_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefLoctDsbld>(entity =>
        {
            entity.ToTable("UNICEF_LOCT_DSBLD");

            entity.HasIndex(e => new { e.GvrnOldCode, e.DistOldCode, e.OzlaOldCode, e.VilgOldCode, e.CyclId }, "IX_UNICEF_LOCT_DSBLD_BENF");

            entity.Property(e => e.UnicefLoctDsbldId).HasColumnName("UNICEF_LOCT_DSBLD_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.DistOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_OLD_CODE");
            entity.Property(e => e.GvrnOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_OLD_CODE");
            entity.Property(e => e.OzlaOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_OLD_CODE");
            entity.Property(e => e.RemtCount).HasColumnName("REMT_COUNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.VilgOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_OLD_CODE");
        });

        modelBuilder.Entity<UnicefLoctDsbldHstry>(entity =>
        {
            entity.ToTable("UNICEF_LOCT_DSBLD_HSTRY");

            entity.Property(e => e.UnicefLoctDsbldHstryId).HasColumnName("UNICEF_LOCT_DSBLD_HSTRY_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.DistOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIST_OLD_CODE");
            entity.Property(e => e.GvrnOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GVRN_OLD_CODE");
            entity.Property(e => e.OzlaOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_OLD_CODE");
            entity.Property(e => e.RemtCount).HasColumnName("REMT_COUNT");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_OLD_CODE");
        });

        modelBuilder.Entity<UnicefLoctType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("UNICEF_LOCT_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefMainBenfTmp>(entity =>
        {
            entity.HasKey(e => e.MainMmbrId);

            entity.ToTable("UnicefMainBenfTmp");

            entity.HasIndex(e => e.Uniquecode, "NonClusteredIndex-20190919-215239").IsUnique();

            entity.Property(e => e.Amounttobepaid)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amounttobepaid");
            entity.Property(e => e.Baseamount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("baseamount");
            entity.Property(e => e.Cmcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cmcode");
            entity.Property(e => e.Districtwherehelives)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("districtwherehelives");
            entity.Property(e => e.Electronicpaymentflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("electronicpaymentflag");
            entity.Property(e => e.Flagnopayment)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagnopayment");
            entity.Property(e => e.Flagoutreach)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagoutreach");
            entity.Property(e => e.Flagrequirescmform)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagrequirescmform");
            entity.Property(e => e.Gender)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Governoratewherehelives)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("governoratewherehelives");
            entity.Property(e => e.Membercode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("membercode");
            entity.Property(e => e.Olduniquecode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olduniquecode");
            entity.Property(e => e.Ozlawherehelives)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ozlawherehelives");
            entity.Property(e => e.Paymentamountwithouttopupyersouth)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("paymentamountwithouttopupyersouth");
            entity.Property(e => e.Primarybeneficiaryfamilyname)
                .HasMaxLength(250)
                .HasColumnName("primarybeneficiaryfamilyname");
            entity.Property(e => e.Primarybeneficiarynames)
                .HasMaxLength(250)
                .HasColumnName("primarybeneficiarynames");
            entity.Property(e => e.Topupamount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("topupamount");
            entity.Property(e => e.Topupamountyersouth)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("topupamountyersouth");
            entity.Property(e => e.Totalpaymentamountusdnorth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("totalpaymentamountusdnorth");
            entity.Property(e => e.Totalpaymentamountusdsouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("totalpaymentamountusdsouth");
            entity.Property(e => e.Totalpaymentamountyersouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("totalpaymentamountyersouth");
            entity.Property(e => e.Uniquecode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("uniquecode");
            entity.Property(e => e.Villagewherehelives)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("villagewherehelives");
        });

        modelBuilder.Entity<UnicefMemberTemp>(entity =>
        {
            entity.HasKey(e => e.MmbrId).HasName("PK_UnicefMemberTemp_1");

            entity.ToTable("UnicefMemberTemp");

            entity.HasIndex(e => e.Membercode, "NonClusteredIndex-20190919-221236").IsUnique();

            entity.Property(e => e.Birthcertificatenumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("birthcertificatenumber");
            entity.Property(e => e.Cmcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cmcode");
            entity.Property(e => e.Cviformnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cviformnumber");
            entity.Property(e => e.Disabledcareidnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("disabledcareidnumber");
            entity.Property(e => e.Electoralidnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("electoralidnumber");
            entity.Property(e => e.Familycardnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("familycardnumber");
            entity.Property(e => e.Familymembernames)
                .HasMaxLength(250)
                .HasColumnName("familymembernames");
            entity.Property(e => e.Flagdeceasednopayment)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagdeceasednopayment");
            entity.Property(e => e.Flagdisqualified)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagdisqualified");
            entity.Property(e => e.Flagpayonly)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagpayonly");
            entity.Property(e => e.Flagrequirescmform)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flagrequirescmform");
            entity.Property(e => e.Flagtakephoto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagtakephoto");
            entity.Property(e => e.Flagverified)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flagverified");
            entity.Property(e => e.Gender)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Marriagecontractnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marriagecontractnumber");
            entity.Property(e => e.Membercode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("membercode");
            entity.Property(e => e.Membersadjustedname)
                .HasMaxLength(250)
                .HasColumnName("membersadjustedname");
            entity.Property(e => e.Membersfamilyname)
                .HasMaxLength(250)
                .HasColumnName("membersfamilyname");
            entity.Property(e => e.Nationalidnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nationalidnumber");
            entity.Property(e => e.Oldnationalidnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oldnationalidnumber");
            entity.Property(e => e.Passportnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("passportnumber");
            entity.Property(e => e.Studentseatnumbercardnumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("studentseatnumbercardnumber");
            entity.Property(e => e.Uniquecode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("uniquecode");
        });

        modelBuilder.Entity<UnicefMmbr>(entity =>
        {
            entity.HasKey(e => e.MmbrId);

            entity.ToTable("UNICEF_MMBR");

            entity.HasIndex(e => new { e.ElectrolIdNo, e.CycleId }, "IX_UNICEF_MMBR_01112021");

            entity.HasIndex(e => new { e.FmlyCode, e.CycleId }, "IX_UNICEF_MMBR_FMLY_CODE_CYCLE_ID").HasFillFactor(70);

            entity.HasIndex(e => new { e.MmbrCode, e.CycleId }, "NonClusteredIndex-20200704-192049").HasFillFactor(70);

            entity.Property(e => e.MmbrId)
                .ValueGeneratedNever()
                .HasColumnName("MMBR_ID");
            entity.Property(e => e.BrthCrtfctNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BRTH_CRTFCT_NO");
            entity.Property(e => e.CmCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CM_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CviFormNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CVI_FORM_NO");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.DisabledCariedNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DISABLED_CARIED_NO");
            entity.Property(e => e.ElectrolIdNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ELECTROL_ID_NO");
            entity.Property(e => e.FmlyCardNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CARD_NO");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IdNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_NUM");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MargContNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MARG_CONT_NO");
            entity.Property(e => e.MmbrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MMBR_CODE");
            entity.Property(e => e.MmbrGndrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MMBR_GNDR_CODE");
            entity.Property(e => e.MmbrName)
                .HasMaxLength(250)
                .HasColumnName("MMBR_NAME");
            entity.Property(e => e.OldIdNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OLD_ID_NO");
            entity.Property(e => e.PsprtNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PSPRT_NO");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StdntSeatNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STDNT_SEAT_NO");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefMmbrFlg>(entity =>
        {
            entity.HasKey(e => e.MmbrFlgId);

            entity.ToTable("UNICEF_MMBR_FLG");

            entity.HasIndex(e => e.MmbrId, "IX_Ahmed_08102019").HasFillFactor(70);

            entity.Property(e => e.MmbrFlgId).HasColumnName("MMBR_FLG_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.FlgDeceasedNoPymt).HasColumnName("FLG_DECEASED_NO_PYMT");
            entity.Property(e => e.FlgDisQualified).HasColumnName("FLG_DIS_QUALIFIED");
            entity.Property(e => e.FlgPayOnly).HasColumnName("FLG_PAY_ONLY");
            entity.Property(e => e.FlgReqCm).HasColumnName("FLG_REQ_CM");
            entity.Property(e => e.FlgTakePhoto).HasColumnName("FLG_TAKE_PHOTO");
            entity.Property(e => e.FlgVerfied).HasColumnName("FLG_VERFIED");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MmbrId).HasColumnName("MMBR_ID");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefRemt>(entity =>
        {
            entity.HasKey(e => e.RemtId);

            entity.ToTable("UNICEF_REMT");

            entity.HasIndex(e => new { e.SttsTypeCode, e.PayedChnl }, "IX_Ahmed_08102019").HasFillFactor(70);

            entity.HasIndex(e => e.FmlyCode, "IX_Ahmed_08102019_2").HasFillFactor(70);

            entity.HasIndex(e => new { e.PayedBy, e.SttsTypeCode, e.PayedChnl }, "IX_PAYED_BY,STTS_CODE,PAYED_CHANNEL");

            entity.HasIndex(e => new { e.CycleId, e.PayedBy, e.SttsTypeCode }, "IX_UNICEF_REMT_01112021");

            entity.HasIndex(e => e.SttsTypeCode, "IX_UNICEF_REMT_STTS_TYPE_CODE_FMLY_CODE_01112021");

            entity.HasIndex(e => new { e.SttsTypeCode, e.UpdatedBy, e.UpdatedOn }, "IX_UNICEF_REMT_STTS_TYPE_CODE_UPDATED_BY_01112021");

            entity.HasIndex(e => new { e.SttsTypeCode, e.UpdatedBy, e.UpdatedOn }, "IX_UNICEF_REMT_STTS_TYPE_CODE_UPDATED_BY_UPDATED_ON");

            entity.Property(e => e.RemtId)
                .ValueGeneratedNever()
                .HasColumnName("REMT_ID");
            entity.Property(e => e.AcctOfBenf)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCT_OF_BENF");
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT");
            entity.Property(e => e.AmntSouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMNT_SOUTH");
            entity.Property(e => e.BenfDistrct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_DISTRCT");
            entity.Property(e => e.BenfGovrnt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_GOVRNT");
            entity.Property(e => e.BenfOzla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_OZLA");
            entity.Property(e => e.BenfVillg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BENF_VILLG");
            entity.Property(e => e.CmCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CM_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FEE");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsPayedOffline).HasColumnName("IS_PAYED_OFFLINE");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.PaydLoctId).HasColumnName("PAYD_LOCT_ID");
            entity.Property(e => e.PaydMmbrId).HasColumnName("PAYD_MMBR_ID");
            entity.Property(e => e.PayedBy).HasColumnName("PAYED_BY");
            entity.Property(e => e.PayedChnl).HasColumnName("PAYED_CHNL");
            entity.Property(e => e.PrimryMmbrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRIMRY_MMBR_CODE");
            entity.Property(e => e.Region)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefRemtAmnt>(entity =>
        {
            entity.ToTable("UNICEF_REMT_AMNT");

            entity.HasIndex(e => e.RemtId, "IX_UnicefRemtAmnt_RemtID").HasFillFactor(70);

            entity.Property(e => e.UnicefRemtAmntId).HasColumnName("UNICEF_REMT_AMNT_ID");
            entity.Property(e => e.ExtraAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_AMNT");
            entity.Property(e => e.ExtraAmntSouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_AMNT_SOUTH");
            entity.Property(e => e.MainAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAIN_AMNT");
            entity.Property(e => e.MainAmntSouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAIN_AMNT_SOUTH");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.TotalAmntUsdNorth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_AMNT_USD_NORTH");
            entity.Property(e => e.TotalAmntUsdSouth)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_AMNT_USD_SOUTH");
        });

        modelBuilder.Entity<UnicefRemtDoc>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("PK_REMT_DOC");

            entity.ToTable("UNICEF_REMT_DOC");

            entity.HasIndex(e => e.RemtId, "IX_REMTID");

            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocCycleId).HasColumnName("DOC_CYCLE_ID");
            entity.Property(e => e.DocTypecode).HasColumnName("DOC_TYPECODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UpldDocId).HasColumnName("UPLD_DOC_ID");

            entity.HasOne(d => d.UpldDoc).WithMany(p => p.UnicefRemtDocs)
                .HasForeignKey(d => d.UpldDocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REMT_DOC_UPLD_DOC_DETL");
        });

        modelBuilder.Entity<UnicefRemtDocRevw>(entity =>
        {
            entity.ToTable("UNICEF_REMT_DOC_REVW");

            entity.HasIndex(e => e.RevwStts, "IX_UNICEF_REMT_DOC_REVW_04112021");

            entity.HasIndex(e => new { e.RemtId, e.RevwStts }, "IX_UNICEF_REMT_DOC_REVW_REMT_ID_01112021");

            entity.Property(e => e.UnicefRemtDocRevwId).HasColumnName("UNICEF_REMT_DOC_REVW_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocCycleId).HasColumnName("DOC_CYCLE_ID");
            entity.Property(e => e.FmlyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FMLY_CODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PaydMmbrId).HasColumnName("PAYD_MMBR_ID");
            entity.Property(e => e.PayedBy).HasColumnName("PAYED_BY");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.RevwBy).HasColumnName("REVW_BY");
            entity.Property(e => e.RevwStts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REVW_STTS");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.UnicefRemtDocRevws)
                .HasForeignKey(d => d.RemtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNICEF_REMT_DOC_REVW_UNICEF_REMT");

            entity.HasOne(d => d.RevwByNavigation).WithMany(p => p.UnicefRemtDocRevws)
                .HasForeignKey(d => d.RevwBy)
                .HasConstraintName("FK_UNICEF_REMT_DOC_REVW_BP_SYS_USER");
        });

        modelBuilder.Entity<UnicefRemtFlg>(entity =>
        {
            entity.HasKey(e => e.RetmFlgId);

            entity.ToTable("UNICEF_REMT_FLG");

            entity.HasIndex(e => e.RemtId, "IX_UNICEF_REMT_FLG_REMT_ID");

            entity.Property(e => e.RetmFlgId).HasColumnName("RETM_FLG_ID");
            entity.Property(e => e.CycleId).HasColumnName("CYCLE_ID");
            entity.Property(e => e.ElectrncPymtFlg).HasColumnName("ELECTRNC_PYMT_FLG");
            entity.Property(e => e.FlgNoPymt).HasColumnName("FLG_NO_PYMT");
            entity.Property(e => e.FlgOutReach).HasColumnName("FLG_OUT_REACH");
            entity.Property(e => e.FlgReqCm).HasColumnName("FLG_REQ_CM");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
        });

        modelBuilder.Entity<UnicefRemtFlgOutReach>(entity =>
        {
            entity.HasKey(e => e.RemtFlgOutReachId).HasName("PK_REMT_FLG_OUT_REACH");

            entity.ToTable("UNICEF_REMT_FLG_OUT_REACH");

            entity.Property(e => e.RemtFlgOutReachId).HasColumnName("REMT_FLG_OUT_REACH_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.FlgOutReachVal).HasColumnName("FLG_OUT_REACH_VAL");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.IsFlgOutReachRemt).HasColumnName("IS_FLG_OUT_REACH_REMT");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.UnicefRemtFlgOutReaches)
                .HasForeignKey(d => d.RemtId)
                .HasConstraintName("FK_UNICEF_REMT_FLG_OUT_REACH_UNICEF_REMT");
        });

        modelBuilder.Entity<UnicefRemtOffLine>(entity =>
        {
            entity.ToTable("UNICEF_REMT_OFF_LINE");

            entity.Property(e => e.UnicefRemtOffLineId).HasColumnName("UNICEF_REMT_OFF_LINE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OffLinePaidDate)
                .HasColumnType("datetime")
                .HasColumnName("OFF_LINE_PAID_DATE");
            entity.Property(e => e.RemtId).HasColumnName("REMT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Remt).WithMany(p => p.UnicefRemtOffLines)
                .HasForeignKey(d => d.RemtId)
                .HasConstraintName("FK_UNICEF_REMT_OFF_LINE_UNICEF_REMT");
        });

        modelBuilder.Entity<UnicefSpecLimt>(entity =>
        {
            entity.ToTable("UNICEF_SPEC_LIMT");

            entity.Property(e => e.UnicefSpecLimtId).HasColumnName("UNICEF_SPEC_LIMT_ID");
            entity.Property(e => e.AgntBpMainId).HasColumnName("AGNT_BP_MAIN_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LoctId).HasColumnName("LOCT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TranCount).HasColumnName("TRAN_COUNT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UnicefUserAgntMap>(entity =>
        {
            entity.HasKey(e => e.UserAgntMapId).HasName("PK_USER_AGNT_MAP");

            entity.ToTable("UNICEF_USER_AGNT_MAP");

            entity.HasIndex(e => e.UserId, "IX_UNICEF_USER_AGNT_MAP_04112021");

            entity.Property(e => e.UserAgntMapId).HasColumnName("USER_AGNT_MAP_ID");
            entity.Property(e => e.AgntId).HasColumnName("AGNT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgId)
                .HasDefaultValueSql("((5))")
                .HasColumnName("ORG_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Agnt).WithMany(p => p.UnicefUserAgntMaps)
                .HasForeignKey(d => d.AgntId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNICEF_USER_AGNT_MAP_AGNT");

            entity.HasOne(d => d.User).WithMany(p => p.UnicefUserAgntMaps)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNICEF_USER_AGNT_MAP_BP_SYS_USER");
        });

        modelBuilder.Entity<Unicefdataupload>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK_UNICEFDATAUpload_NEW");

            entity.ToTable("UNICEFDATAUpload");

            entity.Property(e => e.ConnectionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("connectionType");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.EndingDate)
                .HasColumnType("datetime")
                .HasColumnName("endingDate");
            entity.Property(e => e.ExpectedNoOfBeneficiaries).HasColumnName("expectedNoOfBeneficiaries");
            entity.Property(e => e.FixedSiteType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fixedSiteType");
            entity.Property(e => e.GpsLatitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("gpsLatitude");
            entity.Property(e => e.GpsLongitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("gpsLongitude");
            entity.Property(e => e.InitialDate)
                .HasColumnType("datetime")
                .HasColumnName("initialDate");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsProductionEnvironment).HasDefaultValueSql("((0))");
            entity.Property(e => e.MobilePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobilePhoneNumber");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.NumberDailyPayments).HasColumnName("numberDailyPayments");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ozlaCode");
            entity.Property(e => e.PaymentAgencyId)
                .HasMaxLength(250)
                .HasColumnName("paymentAgencyId");
            entity.Property(e => e.PaymentAgent)
                .HasMaxLength(250)
                .HasColumnName("paymentAgent");
            entity.Property(e => e.PaymentSiteAddress)
                .HasMaxLength(250)
                .HasColumnName("paymentSiteAddress");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('UNICEF')")
                .HasColumnName("projectName");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegionPaymentSite)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("regionPaymentSite");
            entity.Property(e => e.RequestJson)
                .HasMaxLength(1000)
                .HasColumnName("RequestJSON");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("siteCode");
            entity.Property(e => e.SiteStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("siteStatus");
            entity.Property(e => e.StaffingFemalesCashiers).HasColumnName("staffingFemalesCashiers");
            entity.Property(e => e.StaffingFemalesScreening)
                .HasMaxLength(250)
                .HasColumnName("staffingFemalesScreening");
            entity.Property(e => e.StaffingMalesCashiers).HasColumnName("staffingMalesCashiers");
            entity.Property(e => e.StaffingMalesScreening).HasColumnName("staffingMalesScreening");
            entity.Property(e => e.StatusResponse).HasMaxLength(500);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.WorkingDays).HasColumnName("workingDays");
        });

        modelBuilder.Entity<UpdateAcitivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("update_acitivity");

            entity.Property(e => e.ActivtyName)
                .HasMaxLength(100)
                .HasColumnName("activty_name");
            entity.Property(e => e.WalletNo).HasColumnName("wallet_no");
        });

        modelBuilder.Entity<UpgrdeMfilsToMfloo>(entity =>
        {
            entity.HasKey(e => e.UpgrdAcctId);

            entity.ToTable("UPGRDE_MFILS_TO_MFLOOS");

            entity.Property(e => e.UpgrdAcctId).HasColumnName("UPGRD_ACCT_ID");
            entity.Property(e => e.CalcLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CALC_LQDTY");
            entity.Property(e => e.CalcLqdtyFee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CALC_LQDTY_FEE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.MfilsAcctId).HasColumnName("MFILS_ACCT_ID");
            entity.Property(e => e.MfilsAvblBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MFILS_AVBL_BLNC");
            entity.Property(e => e.MfloosAcctId).HasColumnName("MFLOOS_ACCT_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UpgrdeMfloosAcct>(entity =>
        {
            entity.ToTable("UPGRDE_MFLOOS_ACCT");

            entity.Property(e => e.UpgrdeMfloosAcctId).HasColumnName("UPGRDE_MFLOOS_ACCT_ID");
            entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NewProdId).HasColumnName("NEW_PROD_ID");
            entity.Property(e => e.OldProdId).HasColumnName("OLD_PROD_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UpldDocDetl>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("UPLD_DOC_DETL");

            entity.Property(e => e.DocId).HasColumnName("DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.DocContent).HasColumnName("DOC_CONTENT");
            entity.Property(e => e.DocExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOC_EXT");
            entity.Property(e => e.DocMdul)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOC_MDUL");
            entity.Property(e => e.DocName)
                .HasMaxLength(250)
                .HasColumnName("DOC_NAME");
            entity.Property(e => e.DocPath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DOC_PATH");
            entity.Property(e => e.DocType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOC_TYPE");
            entity.Property(e => e.DocUpldDate)
                .HasColumnType("datetime")
                .HasColumnName("DOC_UPLD_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UserChngngBrchDetl>(entity =>
        {
            entity.ToTable("USER_CHNGNG_BRCH_DETL");

            entity.Property(e => e.UserChngngBrchDetlId).HasColumnName("USER_CHNGNG_BRCH_DETL_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpSecId).HasColumnName("BP_SEC_ID");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserChngngBrchRqstId).HasColumnName("USER_CHNGNG_BRCH_RQST_ID");

            entity.HasOne(d => d.UserChngngBrchRqst).WithMany(p => p.UserChngngBrchDetls)
                .HasForeignKey(d => d.UserChngngBrchRqstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_CHNGNG_BRCH_DETL_RQST");
        });

        modelBuilder.Entity<UserChngngBrchDoc>(entity =>
        {
            entity.ToTable("USER_CHNGNG_BRCH_DOC");

            entity.Property(e => e.UserChngngBrchDocId).HasColumnName("USER_CHNGNG_BRCH_DOC_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UplcDocId).HasColumnName("UPLC_DOC_ID");
            entity.Property(e => e.UserChngngBrchRqstId).HasColumnName("USER_CHNGNG_BRCH_RQST_ID");

            entity.HasOne(d => d.UserChngngBrchRqst).WithMany(p => p.UserChngngBrchDocs)
                .HasForeignKey(d => d.UserChngngBrchRqstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_CHNGNG_BRCH_DOC_RQST");
        });

        modelBuilder.Entity<UserChngngBrchRqst>(entity =>
        {
            entity.ToTable("USER_CHNGNG_BRCH_RQST");

            entity.Property(e => e.UserChngngBrchRqstId).HasColumnName("USER_CHNGNG_BRCH_RQST_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.BpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BP_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.NewBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("NEW_BRCH_CODE");
            entity.Property(e => e.NewBrchLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("NEW_BRCH_LQDTY");
            entity.Property(e => e.OldBrchCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OLD_BRCH_CODE");
            entity.Property(e => e.OldBrchLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OLD_BRCH_LQDTY");
            entity.Property(e => e.PrfmrBpMainId).HasColumnName("PRFMR_BP_MAIN_ID");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STTS_TYPE_CODE");
            entity.Property(e => e.TotlTransCount).HasColumnName("TOTL_TRANS_COUNT");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserAvlbBlnc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("USER_AVLB_BLNC");

            entity.HasOne(d => d.BpMain).WithMany(p => p.UserChngngBrchRqsts)
                .HasForeignKey(d => d.BpMainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_CHNGNG_BRCH_RQST_BP_MAIN_ID");
        });

        modelBuilder.Entity<UserDesgDetl>(entity =>
        {
            entity.ToTable("USER_DESG_DETL");

            entity.HasIndex(e => e.UserDesgTypeCode, "IX_USER_DESG_DETL_USER_ID");

            entity.HasIndex(e => e.UserId, "IX_USER_ID");

            entity.Property(e => e.UserDesgDetlId).HasColumnName("USER_DESG_DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserDesgTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_DESG_TYPE_CODE");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.UserDesgTypeCodeNavigation).WithMany(p => p.UserDesgDetls)
                .HasForeignKey(d => d.UserDesgTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_DESG_DETL_USER_DESG_TYPE");

            entity.HasOne(d => d.User).WithMany(p => p.UserDesgDetls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_DESG_DETL_USER");
        });

        modelBuilder.Entity<UserDesgHrcy>(entity =>
        {
            entity.ToTable("USER_DESG_HRCY");

            entity.Property(e => e.UserDesgHrcyId).HasColumnName("USER_DESG_HRCY_ID");
            entity.Property(e => e.ChldDesgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHLD_DESG_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.PrntDesgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRNT_DESG_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.ChldDesgCodeNavigation).WithMany(p => p.UserDesgHrcyChldDesgCodeNavigations)
                .HasForeignKey(d => d.ChldDesgCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_DESG_HRCY_USER_DESG_TYPE");

            entity.HasOne(d => d.PrntDesgCodeNavigation).WithMany(p => p.UserDesgHrcyPrntDesgCodeNavigations)
                .HasForeignKey(d => d.PrntDesgCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_DESG_HRCY_USER_DESG_TYPE1");
        });

        modelBuilder.Entity<UserDesgType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("USER_DESG_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UserDvceRgstDetl>(entity =>
        {
            entity.ToTable("USER_DVCE_RGST_DETL");

            entity.Property(e => e.UserDvceRgstDetlId).HasColumnName("USER_DVCE_RGST_DETL_ID");
            entity.Property(e => e.DvceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCE_ID");
            entity.Property(e => e.MacAddrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAC_ADDRS");
            entity.Property(e => e.RegisterOn)
                .HasColumnType("datetime")
                .HasColumnName("REGISTER_ON");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<UserDvceRgstDetlHsty>(entity =>
        {
            entity.HasKey(e => e.UserDvceRgstDetlId);

            entity.ToTable("USER_DVCE_RGST_DETL_HSTY");

            entity.Property(e => e.UserDvceRgstDetlId).HasColumnName("USER_DVCE_RGST_DETL_ID");
            entity.Property(e => e.DvceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCE_ID");
            entity.Property(e => e.MacAddrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAC_ADDRS");
            entity.Property(e => e.RegisterOn)
                .HasColumnType("datetime")
                .HasColumnName("REGISTER_ON");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<UserRoleDetl>(entity =>
        {
            entity.HasKey(e => e.UserRoleDetlId).HasName("PK_USER_ROLE_DETL_1");

            entity.ToTable("USER_ROLE_DETL");

            entity.HasIndex(e => new { e.UserId, e.UserRoleTypeCode }, "IX_USER_ROLE_DETL_USER_ID_USER_ROLE_TYPE_CODE");

            entity.HasIndex(e => e.UserRoleTypeCode, "IX_USER_ROLE_DETL_USER_ROLE_TYPE_CODE");

            entity.Property(e => e.UserRoleDetlId).HasColumnName("USER_ROLE_DETL_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserRoleTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USER_ROLE_TYPE_CODE");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoleDetls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ROLE_DETL_USER");

            entity.HasOne(d => d.UserRoleTypeCodeNavigation).WithMany(p => p.UserRoleDetls)
                .HasForeignKey(d => d.UserRoleTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ROLE_DETL_USER_ROLE_TYPE");
        });

        modelBuilder.Entity<UserRoleType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__USER_ROL__40866B9BD2A64A67");

            entity.ToTable("USER_ROLE_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.BsnsType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BSNS_TYPE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<UsrPrvlDetl>(entity =>
        {
            entity.ToTable("USR_PRVL_DETL");

            entity.Property(e => e.UsrPrvlDetlId).HasColumnName("USR_PRVL_DETL_ID");
            entity.Property(e => e.MenuPrvlId).HasColumnName("MENU_PRVL_ID");
            entity.Property(e => e.UsrId).HasColumnName("USR_ID");

            entity.HasOne(d => d.MenuPrvl).WithMany(p => p.UsrPrvlDetls)
                .HasForeignKey(d => d.MenuPrvlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USR_PRVL_DETL_MENU_PRVL");
        });

        modelBuilder.Entity<UsrRgstToken>(entity =>
        {
            entity.HasKey(e => e.UsrRgstTokenId).HasName("PK_USR_RGST_TOKEN_ID\r\n");

            entity.ToTable("USR_RGST_TOKEN");

            entity.Property(e => e.UsrRgstTokenId).HasColumnName("USR_RGST_TOKEN_ID");
            entity.Property(e => e.Appcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APPCODE");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.RegisterOn)
                .HasColumnType("datetime")
                .HasColumnName("REGISTER_ON");
            entity.Property(e => e.Token)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<Vilg>(entity =>
        {
            entity.HasKey(e => e.VilgCode);

            entity.ToTable("VILG");

            entity.Property(e => e.VilgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OzlaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZLA_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.VilgName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VILG_NAME");
            entity.Property(e => e.VilgNameLocal)
                .HasMaxLength(250)
                .HasColumnName("VILG_NAME_LOCAL");
            entity.Property(e => e.VilgOldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VILG_OLD_CODE");

            entity.HasOne(d => d.OzlaCodeNavigation).WithMany(p => p.Vilgs)
                .HasForeignKey(d => d.OzlaCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VILG_OZLA");
        });

        modelBuilder.Entity<VuchrTran>(entity =>
        {
            entity.ToTable("VUCHR_TRAN");

            entity.Property(e => e.VuchrTranId).HasColumnName("VUCHR_TRAN_ID");
            entity.Property(e => e.BpMainId).HasColumnName("BP_MAIN_ID");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_TYPE_CODE");
            entity.Property(e => e.TranTypeId).HasColumnName("TRAN_TYPE_ID");
            entity.Property(e => e.VuchrSeqno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VUCHR_SEQNO");
        });

        modelBuilder.Entity<VwbillPaymentCombined>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWBillPaymentCombined");

            entity.Property(e => e.Amntunit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amntunit");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areacode");
            entity.Property(e => e.Chnltypecode).HasColumnName("chnltypecode");
            entity.Property(e => e.ChrgdLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CHRGD_LQDTY");
            entity.Property(e => e.Cmsnamnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("cmsnamnt");
            entity.Property(e => e.Crdtacct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("crdtacct");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Debtacct)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("debtacct");
            entity.Property(e => e.ExtraFeeAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EXTRA_FEE_AMNT");
            entity.Property(e => e.Feeamnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("feeamnt");
            entity.Property(e => e.Mbilenmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mbilenmbr");
            entity.Property(e => e.Offrcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("offrcode");
            entity.Property(e => e.Offrname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("offrname");
            entity.Property(e => e.Offrprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("offrprice");
            entity.Property(e => e.OrgnAmnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ORGN_AMNT");
            entity.Property(e => e.Paidamnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("paidamnt");
            entity.Property(e => e.Pkpymtid).HasColumnName("pkpymtid");
            entity.Property(e => e.Prfmrid).HasColumnName("prfmrid");
            entity.Property(e => e.Pymttype).HasColumnName("pymttype");
            entity.Property(e => e.Scribrnmbr).HasColumnName("scribrnmbr");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.Trandate)
                .HasColumnType("datetime")
                .HasColumnName("trandate");
            entity.Property(e => e.Trantypecode).HasColumnName("trantypecode");
        });

        modelBuilder.Entity<VwtransactionsWithLqdtyFee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWTransactionsWithLqdtyFee");

            entity.Property(e => e.AcctType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amnt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("amnt");
            entity.Property(e => e.Creditaccount)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREDITACCOUNT");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("fee");
            entity.Property(e => e.Lqdtyfee)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("lqdtyfee");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Receiverbranchname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("receiverbranchname");
            entity.Property(e => e.Senderbrnchname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("senderbrnchname");
            entity.Property(e => e.Trantypeid).HasColumnName("trantypeid");
            entity.Property(e => e.Trasactiontype).HasColumnName("trasactiontype");
            entity.Property(e => e.Walltacctnum)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WALLTACCTNUM");
        });

        modelBuilder.Entity<WaltLocalization>(entity =>
        {
            entity.ToTable("WALT_LOCALIZATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArbText)
                .HasMaxLength(500)
                .HasColumnName("ARB_TEXT");
            entity.Property(e => e.EngText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ENG_TEXT");
            entity.Property(e => e.Key)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KEY");
            entity.Property(e => e.ScrnId).HasColumnName("SCRN_ID");

            entity.HasOne(d => d.Scrn).WithMany(p => p.WaltLocalizations)
                .HasForeignKey(d => d.ScrnId)
                .HasConstraintName("FK_WALT_LOCALIZATION_SCRN");
        });

        modelBuilder.Entity<WaltLocalizationGlbl>(entity =>
        {
            entity.ToTable("WALT_LOCALIZATION_GLBL");

            entity.HasIndex(e => e.Id, "IX_WALT_LOCALIZATION_GLBL").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArbText)
                .HasMaxLength(500)
                .HasColumnName("ARB_TEXT");
            entity.Property(e => e.EngText)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ENG_TEXT");
            entity.Property(e => e.Key)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("KEY");
            entity.Property(e => e.MsgType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MSG_TYPE");
        });

        modelBuilder.Entity<WorkHour>(entity =>
        {
            entity.ToTable("WORK_HOUR");

            entity.Property(e => e.WorkHourId).HasColumnName("WORK_HOUR_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.CyclId).HasColumnName("CYCL_ID");
            entity.Property(e => e.EndTime).HasColumnName("END_TIME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ORG_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.StrtTime).HasColumnName("STRT_TIME");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<WorkQue>(entity =>
        {
            entity.HasKey(e => e.WorkQueId).HasName("PK__WORK_QUE__78E75D385578CDBF");

            entity.ToTable("WORK_QUE");

            entity.HasIndex(e => e.MakrId, "IX_MAKR_ID");

            entity.HasIndex(e => e.RqstId, "IX_RQST_ID");

            entity.HasIndex(e => e.RqstSttsTypeCode, "IX_RQST_STTS_TYPE_CODE");

            entity.HasIndex(e => e.RqstTypeCode, "IX_RQST_TYPE_CODE");

            entity.Property(e => e.WorkQueId).HasColumnName("WORK_QUE_ID");
            entity.Property(e => e.ChkrCmnt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CHKR_CMNT");
            entity.Property(e => e.ChkrId).HasColumnName("CHKR_ID");
            entity.Property(e => e.ChkrLastUpdtDate)
                .HasColumnType("datetime")
                .HasColumnName("CHKR_LAST_UPDT_DATE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MakrCmnt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MAKR_CMNT");
            entity.Property(e => e.MakrId).HasColumnName("MAKR_ID");
            entity.Property(e => e.MakrLastUpdtDate)
                .HasColumnType("datetime")
                .HasColumnName("MAKR_LAST_UPDT_DATE");
            entity.Property(e => e.RjctResnTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RJCT_RESN_TYPE_CODE");
            entity.Property(e => e.RqstId).HasColumnName("RQST_ID");
            entity.Property(e => e.RqstSttsTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RQST_STTS_TYPE_CODE");
            entity.Property(e => e.RqstTypeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RQST_TYPE_CODE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");

            entity.HasOne(d => d.Chkr).WithMany(p => p.WorkQueChkrs)
                .HasForeignKey(d => d.ChkrId)
                .HasConstraintName("FK_WORK_QUE_USER");

            entity.HasOne(d => d.Makr).WithMany(p => p.WorkQueMakrs)
                .HasForeignKey(d => d.MakrId)
                .HasConstraintName("FK_WORK_QUE_USER1");

            entity.HasOne(d => d.RjctResnTypeCodeNavigation).WithMany(p => p.WorkQues)
                .HasForeignKey(d => d.RjctResnTypeCode)
                .HasConstraintName("FK__WORK_QUE__RJCT_R__0DEF03D2");

            entity.HasOne(d => d.RqstSttsTypeCodeNavigation).WithMany(p => p.WorkQues)
                .HasForeignKey(d => d.RqstSttsTypeCode)
                .HasConstraintName("FK__WORK_QUE__RQST_S__0B129727");

            entity.HasOne(d => d.RqstTypeCodeNavigation).WithMany(p => p.WorkQues)
                .HasForeignKey(d => d.RqstTypeCode)
                .HasConstraintName("FK__WORK_QUE__RQST_T__0A1E72EE");
        });

        modelBuilder.Entity<WorkQueActnType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("WORK_QUE_ACTN_TYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("DESC");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NameLocal)
                .HasMaxLength(250)
                .HasColumnName("NAME_LOCAL");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
        });

        modelBuilder.Entity<WorkQueHsty>(entity =>
        {
            entity.ToTable("WORK_QUE_HSTY");

            entity.Property(e => e.WorkQueHstyId).HasColumnName("WORK_QUE_HSTY_ID");
            entity.Property(e => e.Actn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACTN");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.WorkQueId).HasColumnName("WORK_QUE_ID");

            entity.HasOne(d => d.User).WithMany(p => p.WorkQueHsties)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORK_QUE_HSTY_USER");

            entity.HasOne(d => d.WorkQue).WithMany(p => p.WorkQueHsties)
                .HasForeignKey(d => d.WorkQueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORK_QUE_HSTY_WORK_QUE");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.ToTable("ZONE");

            entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.SessionCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SESSION_CODE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_ON");
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ZONE_CODE");
            entity.Property(e => e.ZoneLqdty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZONE_LQDTY");
            entity.Property(e => e.ZoneName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONE_NAME");
        });
        modelBuilder.HasSequence("CashwithdrawalNumber").StartsAt(10000000L);
        modelBuilder.HasSequence("EPaymentNumber").StartsAt(10000000L);
        modelBuilder.HasSequence("MFILSRemittanceNumber").StartsAt(10000000L);
        modelBuilder.HasSequence("MFILSWaltAccountNumber").StartsAt(80000000L);
        modelBuilder.HasSequence("RemittanceNumber").StartsAt(10000000L);
        modelBuilder.HasSequence("WaltAccountNumber").StartsAt(10000000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
