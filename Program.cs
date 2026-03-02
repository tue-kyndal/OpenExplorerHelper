using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0) return;

        string url = args[0];

        // Remove the scheme
        url = url.Replace("openexplorer://", "").Replace("openexplorer:", "");

        // Normalize slashes
        url = url.Replace("/", "\\");

        // If it’s not a UNC path, keep the drive letter (like Z:)
        if (!url.StartsWith("\\\\") && url.Length > 1 && url[1] == ':')
        {
            // Already a drive path, do nothing
        }
        else if (!url.StartsWith("\\\\"))
        {
            // Otherwise treat as UNC
            url = "\\\\" + url;
        }

        // Open folder
        Process.Start("explorer.exe", url);
    }
}
