using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace QlockTwoCreator.Classes.Extensions
{
    public static class In
    {
        public static bool IsIn<T>(this T @this, params T[] possibles)
        {
            return possibles.Contains(@this);
        }

    }

}
