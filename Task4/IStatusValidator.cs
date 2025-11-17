using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public interface IStatusValidator
    {
        public bool IsTransitionValid(ref Status currentStatus, Status newStatus, int priority, out string message);
    }
}   
