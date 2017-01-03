using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public sealed class UndoableKeyedZombieCollection<TKey, TNode, TZombie> 
        : UndoableKeyedCollection<TKey, TNode>, IUndoableZombieCollection, IZombieHolderOwner where TNode:DocumentNode
    {

    }
}
