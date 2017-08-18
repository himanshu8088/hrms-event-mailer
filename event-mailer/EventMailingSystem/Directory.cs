using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    public class Directory
    {        
        public Directory()
        {
            Path=ConfigurationManager.AppSettings["empRecDir"];            
        }
        public string  Path { get; private set; }        
    }
}
