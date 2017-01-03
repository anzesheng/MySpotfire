using Spotfire.Dxp.Framework.DocumentModel;
using System;
using System.Collections.Generic;

namespace Spotfire.Dxp.Framework.Commands
{
    public sealed class CommandHistory : IDisposable
    {
        private readonly DocumentViewManager documentViewManager;
        private List<DocumentView> documentViews;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #region Inner class

        private class OutermostTransactionHandle:TransactionHandle
        {
        }

        private class NestedTransactionHandle : TransactionHandle
        {
        }

        private class InternalTransactionHandle : TransactionHandle
        {
        }

        #endregion
    }
}