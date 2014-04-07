using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QlockTwoCreator.Classes.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public static class FactoryTimes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public static List<DateTime> GetTimes(int factor)
        {
            int steps = (24 * 60) / factor;
            List<DateTime> r = new List<DateTime>();
            DateTime starting = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            r.Add(starting);
            for (int i = 0; i < steps; i++)
            {
                DateTime tmp = starting.AddMinutes(factor);
                r.Add(tmp);
                starting = tmp;
            }
            return r;
        }
    }
}
