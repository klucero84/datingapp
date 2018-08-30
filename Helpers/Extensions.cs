using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    /// <summary>
    /// Utility class for Extension methods
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Adds headers for application error to the http response
        /// Adds Access control allow origin headers
        /// </summary>
        /// <param name="response">http response to add the headers to</param>
        /// <param name="message">error message to include in application-error header</param>
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        /// <summary>
        /// Calculates the years between a different date and today rounded down.
        /// </summary>
        /// <param name="theDateTime">the starting date</param>
        /// <returns>the difference in years rounded down between given date and now</returns>
        public static int CalculateAge(this DateTime theDateTime){
            var age = DateTime.Today.Year - theDateTime.Year;
            if(theDateTime.AddYears(age)> DateTime.Today)
                age--;
            return age;
        }
        
    }
}