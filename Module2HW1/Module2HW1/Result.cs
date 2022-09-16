using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Result
    {
        private string? _message;
        private bool _status;
        private LogType _typeLog;
        public Result(LogType type, bool status, string? message = null)
        {
            TypeLog = type;
            Status = status;
            Message = message;
        }

        public string? Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }

            init
            {
                _status = value;
            }
        }

        public LogType TypeLog
        {
            get
            {
                return _typeLog;
            }

            init
            {
                _typeLog = value;
            }
        }
    }
}