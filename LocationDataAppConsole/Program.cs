using System;
using System.Collections.Generic;
using LocationDataApp;

namespace LocationDataAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the LocationService
            LocationService locationService = new LocationService();

            // Initialize the data
            List<LocationData> locations = locationService.InitializeData();

            // Execute the query
            List<string> result = locationService.GetNamesWithCodeStartingWithZ(locations);

            // Display the result
            DisplayResult(result);

            // Wait for user input before closing
            WaitForUserToClose();
        }

        private static void DisplayResult(List<string> result)
        {
            result.ForEach(Console.WriteLine);
        }

        private static void WaitForUserToClose()
        {
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}