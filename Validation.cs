using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public class Validation
    {
        public static bool IsValidDateTime(string dateTimeInput)
        {
            if (String.IsNullOrEmpty(dateTimeInput) || !DateTime.TryParse(dateTimeInput, out _))
            {
                return false;
            }

            return true;
        }
    }
}
