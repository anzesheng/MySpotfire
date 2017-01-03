using Spotfire.Dxp.Framework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface IDocumentNodeOwner : System.IServiceProvider
    {
        int Generation { get; }
        IDocumentNodeOwner Owner { get; }

        CommandHistory GetCommandHistory();
    }
}
