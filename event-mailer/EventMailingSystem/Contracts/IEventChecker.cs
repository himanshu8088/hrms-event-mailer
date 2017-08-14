using System;
using System.Collections.Generic;

namespace HRMS
{
    public interface IEventChecker
    {
        List<IEventType> EventList { get; }
        IEventType Check();                
    }
}
