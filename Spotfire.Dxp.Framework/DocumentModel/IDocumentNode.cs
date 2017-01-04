using Spotfire.Dxp.Framework.DocumentModel.Triggers;
using System.Collections.Generic;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface IDocumentNode
    {
        IUndoableProperty<T> GetUndoableProperty<T>(PropertyName propertyName);
        IMutableProperty<T> GetMutableProperty<T>(PropertyName propertyName);
        IRuntimeProperty<T> GetRuntimeProperty<T>(PropertyName propertyName);

        IEnumerable<IUndoableZombieCrossReference<TNode, TZombie>> GetZombieCrossReferencesThatReferenceThisNode<TNode, TZombie>();

        IMutablePropertyTriggerHost<T> GetMutablePropertyTriggerHost<T>(PropertyName propertyName);

        CampatibilityCallbackCollection PropagateResolveCompatibility(CompatibilityItemCollection compatibilityItems, IServiceProvider serviceProvider);
    }
}
