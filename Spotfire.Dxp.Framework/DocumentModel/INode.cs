using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface INode:IDocumentNodeOwner, IDocumentNodeChild
    {
        Node CreateSnapshot(StreamingContext sContext, StreamingContext dContext);
    }
}
