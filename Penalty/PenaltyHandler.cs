using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public static class PenaltyHandler
    {
            public static void ServiceDisconnectionPenalty(float amount)
            {
                Console.WriteLine("disconnection charges " + amount);
            }

            public static void NotificationPenalty(float amount)
            {
                Console.WriteLine("notification charges" + amount);
            }
    }
}
