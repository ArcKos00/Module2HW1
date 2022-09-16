using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Actions
    {
        private Logger _log = Logger.Instance;
        public Result ActionInfo()
        {
            Result res = new Result(LogType.Info, true, "Started method: \"ActionInfo\"");
            _log.Log(res);
            return res;
        }

        public Result ActionWarning()
        {
            Result res = new Result(LogType.Warning, true, "Skipped logic in method: \"ActionWarning\"");
            _log.Log(res);
            return res;
        }

        public Result ActionError()
        {
            Result res = new Result(LogType.Error, false, "I broke a logic");
            return res;
        }
    }
}
