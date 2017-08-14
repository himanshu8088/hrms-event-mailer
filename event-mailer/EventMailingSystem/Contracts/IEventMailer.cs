using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    interface IEventMailer
    {                
        void FetchDetail();
        void CheckEvent();        
        void SendMail();
    }
}
