using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    public interface IDetail
    {
        List<DateTime> DateOfJoining { get; set; }
        List<DateTime> DateOfBirth { get; set; }
        List<int> EmpIdList { get; set; }        
    }
}
