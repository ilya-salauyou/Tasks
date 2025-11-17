using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class StatusValidator : IStatusValidator
    {
        private int minPriority = 3;
        private int maxPriority = 1;

        public bool IsTransitionValid( ref Status currentStatus, Status newStatus, int priority, out string message)
        {
            //Paused -> Completed
            if (priority < maxPriority || priority > minPriority)
            {
                message = $"Приоритет должен быть в диопозоне [{maxPriority}, {minPriority}]";
                return false;
            }
            //Active -> Paused
            if (currentStatus == Status.Active && newStatus == Status.Paused && priority != minPriority)
            {
                message = "Для перехода со статуса \"Активен\" на \"Приостановлен\" необходим приоритет 3";
                return false;
            }
            //Paused -> Completed
            if (currentStatus == Status.Paused && newStatus == Status.Completed)
            {
                message = "Переход со статуса \"Приостановлен\" на \"Завершен\" запрещён";
                return false;
            }

            //Если необходимо установить новый статус статус
            currentStatus = newStatus;
            message = $"Переход разрешён. Новый статус {currentStatus} установлен";

            return true;
        }
    }
}
