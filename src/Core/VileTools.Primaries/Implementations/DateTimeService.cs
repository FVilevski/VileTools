namespace VileTools.Primaries.Implementations
{
    using System;
    using VileTools.Primaries.Contracts;

    public class DateTimeService : IDateTimeService
    {
        public DateTime UtcNow()
        {
            return DateTime.UtcNow;
        }

        DateTime? UtcNowScopedValue { get; set; }
        public DateTime UtcNowScoped()
        {
            if (!UtcNowScopedValue.HasValue)
            {
                UtcNowScopedValue = UtcNow();
            }

            return UtcNowScopedValue.Value;
        }
    }
}
