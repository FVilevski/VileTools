namespace VileTools.Primaries.Contracts
{
    using System;

    public interface IDateTimeService
    {
        /// <summary>
        /// Provides current UTC Date/Time. On every call of this method, new current UTC Date/Time will be provided.
        /// </summary>
        /// <returns>Current UTC Date/Time value</returns>
        DateTime UtcNow();

        /// <summary>
        /// Returns same UTC Date/Time from start of execution, till the end of execution.
        /// </summary>
        /// <returns>UTC Date/Time value</returns>
        DateTime UtcNowScoped();
    }
}
