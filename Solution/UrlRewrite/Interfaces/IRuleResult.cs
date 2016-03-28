﻿using System.Collections.Generic;

namespace UrlRewrite.Interfaces
{
    public interface IRuleResult
    {
        bool StopProcessing { get; }
        bool EndRequest { get; }
        List<IAction> Actions { get; }
        IPropertyBag Properties { get; }
    }
}
