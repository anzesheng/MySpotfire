using System;
using System.Runtime.Serialization;
using Spotfire.Dxp.Framework.Commands;
using Spotfire.Dxp.Framework.ApplicationModel;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public class Node : INode, ISerializable
    {
        public bool IsFrozen { get; }
        public CommandHistory CommandHistory { get; }

        public int Generation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDocumentNodeOwner Owner
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {

        }

        public virtual object GetService(System.Type serviceType)
        {
            return AnalysisServices.GetService(serviceType);
        }

        public Node CreateSnapshot(StreamingContext sContext, StreamingContext dContext)
        {
            throw new NotImplementedException();
        }

        public CommandHistory GetCommandHistory()
        {
            throw new NotImplementedException();
        }
    }
}