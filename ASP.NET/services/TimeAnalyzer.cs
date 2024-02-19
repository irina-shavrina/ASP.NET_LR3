namespace ASP.NET.services
{
    public class TimeAnalyzer : interfaces.ITimeAnalyzer
    {
        public string GetTime(DateTime dateTime)
        {
            int hour = dateTime.Hour;
            if (0 <= hour && hour < 6) 
            {
                return "It's night now";
            }
            if (6 <= hour && hour < 12)
            {
                return "It's morning now";
            }
            if (12 <= hour && hour < 18)
            {
                return "It's day now";
            }
            if (18 <= hour && hour < 24)
            {
                return "It's evening now";
            }
            throw new Exception("Invalid data");
        }

    }
}
