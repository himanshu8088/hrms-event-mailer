using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    interface IEmpGreeter
    {             
        List<KeyValuePair<IEmpGreeting, IEmployee>> GreetingList { get;}        
        void SendGreet();          
    }
}
