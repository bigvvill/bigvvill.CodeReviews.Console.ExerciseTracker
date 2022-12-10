using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    internal class Validation
    {
        internal static bool IsValidDateTime(string dateTimeInput)
        {
            if (String.IsNullOrEmpty(dateTimeInput) || !DateTime.TryParse(dateTimeInput, out _))
            {
                return false;
            }

            return true;
        }
    }
}
