using System;
using System.Collections.Generic;

namespace EventMailingSystem
{
    public interface IEventChecker
    {
        List<IEventType> EventList { get; }
        IEventType Check();                
    }
}
