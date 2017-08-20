using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    public enum Event{ Birthday,Anivarsary}
    public class Greeting : IEmpGreeting
    {
        private Dictionary<Event, IGreet> _greetingDictionary;

        public Greeting()
        {
            _greetingDictionary = new Dictionary<Event, IGreet>()
            {
                {Event.Birthday ,new Birthday()}                
            };          
        }

        public IGreet GetType(IEmployee emp)
        {
            if(DateTime.Now.Day==emp.DateOfBirth.Day && DateTime.Now.Month == emp.DateOfBirth.Month)
            {
                return _greetingDictionary[Event.Birthday];
            }
            else
            {
                throw new  KeyNotFoundException();
            }

        }
    }
}
