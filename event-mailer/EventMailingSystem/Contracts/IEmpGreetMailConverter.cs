using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    public interface IEmpGreetMailConverter
    {
        IMail Convert(IEmployee data,IEmpGreeting greetType);
    }
}
