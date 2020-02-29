﻿using System.Collections.Generic;

namespace CCLLC.Core
{
    public interface ISettingsProviderDataConnector
    {
        IDictionary<string, string> LoadSettings(IDataService dataService);
    }
}
