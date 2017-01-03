using Spotfire.Dxp.Framework.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Data
{
    public sealed class DataColumn : DocumentNode, IDataColumn
    {
        public DataHierarchy Hierarchy
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DataColumnProperties Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DataValueCollection RowValues
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #region Internal class

        public new abstract class PropertyNames : DocumentNode.PropertyNames
        {
        }

        #endregion
    }
}
