using log4net;
using System;
using System.Security.Principal;

namespace LTI.IMF.WebApi.Common
{
    public class ErrorLogging
    {
        private readonly ILog log = LogManager.GetLogger("");

        public void SaveErrorLog(Exception ex, string codePath, string methodName)
        {
            log.Error(WindowsIdentity.GetCurrent().Name + " " + codePath + " " + methodName + " " + ex);
        }
    }
}
