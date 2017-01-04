using Spotfire.Dxp.Framework.DocumentModel.Triggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public class DocumentNode : Node, IDocumentNode, ITransactions, INodeContext
    {
        public IMutableProperty<T> GetMutableProperty<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        public IMutablePropertyTriggerHost<T> GetMutablePropertyTriggerHost<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        public IRuntimeProperty<T> GetRuntimeProperty<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        public IUndoableProperty<T> GetUndoableProperty<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUndoableZombieCrossReference<TNode, TZombie>> GetZombieCrossReferencesThatReferenceThisNode<TNode, TZombie>()
        {
            throw new NotImplementedException();
        }

        public CampatibilityCallbackCollection PropagateResolveCompatibility(CompatibilityItemCollection compatibilityItems, IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        IMutablePropertyTriggerHost<T> IDocumentNode.GetMutablePropertyTriggerHost<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        IMutablePropertyTriggerHost<T> IDocumentNode.GetMutablePropertyTriggerHost<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }

        IMutablePropertyTriggerHost<T> IDocumentNode.GetMutablePropertyTriggerHost<T>(PropertyName propertyName)
        {
            throw new NotImplementedException();
        }
        #region Internal class

        public class PropertyNames
        {
        }

        #endregion
    }
}
