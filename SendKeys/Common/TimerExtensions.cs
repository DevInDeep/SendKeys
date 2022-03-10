using System;
using System.Timers;

namespace SendKeys.Common
{
    public static class TimerExtensions
    {
        public static void Start(this Timer timer, Action executeBeforeStart)
        {
            executeBeforeStart();
            timer.Start();
        }
    }
}
