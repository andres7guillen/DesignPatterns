using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDomain.ResultNotificationResult
{
    public class ResultNotification
    {
        public bool IsSuccess { get; private set; }
        public List<string> Errors { get; private set; }

        public ResultNotification()
        {
            IsSuccess = false;
            Errors = new List<string>();
        }

        public void Success()
        {
            IsSuccess = true;
        }

        public void Failure(List<string> errors)
        {
            Errors = errors;
        }
    }
}
