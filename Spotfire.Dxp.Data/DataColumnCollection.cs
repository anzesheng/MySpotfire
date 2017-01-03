using Spotfire.Dxp.Framework.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Spotfire.Dxp.Data
{
    public sealed class DataColumnCollection : DocumentNode, IEnumerable<DataColumn>
    {
        private readonly UndoableKeyedZombieCollection<string, DataColumn, RemovedDataColumn> columns;
        private readonly RuntimeProperty<ImmutableSet<string>> columnNames;

        public IEnumerator<DataColumn> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #region Internal class

        public new abstract class PropertyNames:DocumentNode.PropertyNames
        {
        }

        #endregion
    }
}
