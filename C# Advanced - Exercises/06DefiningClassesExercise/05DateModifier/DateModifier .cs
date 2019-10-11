using System;

namespace _05DateModifier
{
    public static class DateModifier
    {
        public static double ReturnsDaysBetweenTwoDates(DateTime firstTime, DateTime secondTime)
        {
            double result = Math.Abs((firstTime - secondTime).TotalDays);

            return result;
        }
    }
}
