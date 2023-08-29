using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AmfAccount
{
    public string AmfPointProv { get; set; } = null!;

    public string AmfCustomerName { get; set; } = null!;

    public long AmfCustNo { get; set; }

    public short AmfQualification { get; set; }

    public string AmfPob { get; set; } = null!;

    public DateTime AmfDob { get; set; }

    public short AmfSStatus { get; set; }

    public string? AmfIdentityNo { get; set; }

    public string AmfPIssue { get; set; } = null!;

    public DateTime AmfDIssue { get; set; }

    public DateTime AmfDEnd { get; set; }

    public string AmfCurrentAdd { get; set; } = null!;

    public short AmfHasUsaNationality { get; set; }

    public string? AmfEMail { get; set; }

    public short AmfJob { get; set; }

    public short AmfPosition { get; set; }

    public short AmfSourceIncom { get; set; }

    public decimal AmfAmountIncom { get; set; }

    public long AmfAccFst { get; set; }

    public long AmfTelegram { get; set; }

    public long AmfWhatsapp { get; set; }

    public string? AmfComments { get; set; }

    public int AmfUsrEntry { get; set; }

    public long AmfAttNo { get; set; }

    public DateTime AmfDate { get; set; }

    public DateTime AmfDateTimeEntry { get; set; }

    public int AmfUsrConf { get; set; }

    public short AmfCustType { get; set; }

    public string AmfBranchJoin { get; set; } = null!;

    public short AmfBlackList { get; set; }

    public short AmfTelType { get; set; }

    public int AmfUsrUpd { get; set; }

    public DateTime? AmfDateUpd { get; set; }

    public long Sno { get; set; }

    public short AmfFee { get; set; }

    public DateTime AmfDateConf { get; set; }

    public short AmfTypeEntry { get; set; }

    public int AmfMomNo { get; set; }

    public int AmfConfirmHistory { get; set; }

    public string? AmfHoldReason { get; set; }

    public int AmfUnicefNo { get; set; }

    public bool AmfMainBen { get; set; }

    public string AmfBenName { get; set; } = null!;

    public string AmfBenCode { get; set; } = null!;

    public short AmfIdType { get; set; }
}
