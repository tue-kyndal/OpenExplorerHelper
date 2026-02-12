using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Make sure an argument is provided
            if (args.Length == 0)
            {
                Console.WriteLine("No URL provided!");
                Console.ReadKey(); // Pause to see message
                return;
            }

            string url = args[0];

            // Remove protocol prefix
            url = url.Replace("openexplorer://", "");
            url = url.Replace("openexplorer:", "");

            // Convert to Windows UNC path
            url = url.Replace("/", "\\");

            // If it doesn't already start with \\ assume it's a network path
            if (!url.StartsWith("\\\\"))
                url = "\\\\" + url;

            Console.WriteLine($"Opening Explorer at: {url}");

            // Start Explorer
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error opening Explorer: " + ex.Message);
            Console.ReadKey(); // Pause to see the error
        }
    }
}

