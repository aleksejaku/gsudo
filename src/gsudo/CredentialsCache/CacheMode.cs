﻿using System.ComponentModel;

namespace gsudo.CredentialsCache
{
    enum CacheMode
    {
        Disabled,
        Explicit,
        [Description("Enabling the credentials cache is a security risk.")]
        Auto,
    }
}
