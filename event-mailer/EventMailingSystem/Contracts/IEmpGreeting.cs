using System.Collections.Generic;

namespace EventMailingSystem
{
    public interface IEmpGreeting
    {
        IGreet GetType(IEmployee data);
    }
}