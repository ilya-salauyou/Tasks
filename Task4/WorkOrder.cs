using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class WorkOrder
    {
        public Status CurrentStatus;
        public int Priority { get; private set; }

        public WorkOrder(Status currentStatus, int priority)
        {
            CurrentStatus = currentStatus;
            Priority = priority;
        }

        public bool TryChangeStatus(Status newStatus, out string message)
        {
            var validator = new StatusValidator();
            return validator.IsTransitionValid( ref CurrentStatus, newStatus, Priority, out message);
        }
    }
}
