using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private static string[] _results = new string[0];

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Log(Result result)
        {
            string log = $"{DateTime.Now}: {result.TypeLog}: {result.Message}";
            ResultsAdd(log);
            Console.WriteLine(log);
        }

        public static string[] GetResults()
        {
            return _results;
        }

        private void ResultsAdd(string result)
        {
            ResizeAdd(ref _results, result);
        }

        private void ResizeAdd(ref string[] res, string value)
        {
            string[] result = new string[res.Length + 1];
            for (int i = 0; i < res.Length; i++)
            {
                result[i] = res[i];
            }

            result[result.Length - 1] = value;
            res = result;
        }
    }
}
