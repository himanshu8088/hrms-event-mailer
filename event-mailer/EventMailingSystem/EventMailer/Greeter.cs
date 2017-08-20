using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    public class Greeter : IEmpGreeter
    {
        public List<KeyValuePair<IEmpGreeting, IEmployee>> GreetingList { get; private set; }
        
        public Greeter(List<IEmployee> dataList)
        {
            foreach(IEmployee data in dataList)
            {

            }
        }

        public void SendGreet()
        {
            throw new NotImplementedException();
        }
    }
}
