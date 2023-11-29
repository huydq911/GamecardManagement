using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Provider
{
    public string ProviderId { get; set; } = null!;

    public string ProviderName { get; set; } = null!;

    public string ProviderDescription { get; set; } = null!;

    public bool? IsOnline { get; set; }

    public virtual ICollection<GameCardInfo> GameCardInfos { get; set; } = new List<GameCardInfo>();
}
