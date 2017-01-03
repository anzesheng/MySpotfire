using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.ApplicationModel
{
    public delegate void ApplicationInvocation();

    public abstract class ApplicationThread
    {
        private static ApplicationThread oldApplicationThread;
        private long backgroundTaskCount;
        private Thread currentThread;

        public abstract void Invoke(ApplicationInvocation method);

        #region Internal class

        private class UnsafeBorrowedApplicationThread : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
