using Spotfire.Dxp.Framework.DocumentModel;
using System;
using System.Collections.Generic;

namespace Spotfire.Dxp.Framework.Persistence
{
    public interface CampatibilityCallbackCollection
    {
        List<Tuple<DocumentNode, Action<CompatibilityItemCollection, DocumentNode>, bool>> compatibilityConfigureCallbacks;
    }
}