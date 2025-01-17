﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Contoso.Forms.Demo
{
    public interface IAppConfiguration
    {
        string GetAppSecret();
        string GetTargetToken();
    }
}
