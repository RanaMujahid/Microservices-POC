using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EncryKey
{
    public int KeyId { get; set; }

    public string KeyName { get; set; } = null!;

    public string PublicKey { get; set; } = null!;

    public string PrivateKey { get; set; } = null!;

    public string Algorithm { get; set; } = null!;

    public int KeyLength { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
