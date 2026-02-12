using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0) return;

        string url = args[0];

        url = url.Replace("openexplorer://", "");
        url = url.Replace("openexplorer:", "");
        url = url.Replace("/", "\\");

        if (!url.StartsWith("\\\\"))
            url = "\\\\" + url;

        Process.Start("explorer.exe", url);
    }
}
