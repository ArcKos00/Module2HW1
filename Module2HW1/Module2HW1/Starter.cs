using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public static class Starter
    {
        private static int _counter = 0;
        private static Result _result;
        private static Logger logg = Logger.Instance;
        private static Actions _action = new Actions();
        private static Random _rand = new Random();
        public static void Run()
        {
            while (_counter < 100)
            {
                switch (_rand.Next(0, 3))
                {
                    case 0:
                        _result = _action.ActionInfo();
                        break;
                    case 1:
                        _result = _action.ActionWarning();
                        break;
                    case 2:
                        _result = _action.ActionError();
                        break;
                }

                if (_result.Status.Equals(false))
                {
                    string? tmp = _result.Message;
                    _result.Message = "Action failed by a reason: " + tmp;
                    logg.Log(_result);
                }

                _counter++;
            }

            var sb = new StringBuilder();
            for (int i = 0; i < Logger.GetResults().Length; i++)
            {
                sb.Append(Logger.GetResults()[i] + "\n");
            }

            File.WriteAllText("log.txt", sb.ToString());
        }
    }
}