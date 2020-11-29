using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

[assembly: AssemblyTitle("dumpclip")]
[assembly: AssemblyVersion("1.1.0")]

namespace DumpClipboard
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Win32Console.AttachConsole();

            if (args.Contains("--listen"))
            {
                using var monitor = new ClipboardMonitor();
                monitor.ClipboardChanged += (sender, eventArgs) => ConsoleEx.WriteJson(eventArgs.Contents);
                Application.Run();
                return;
            }

            var contents = ClipboardEx.GetContents();
            ConsoleEx.WriteJson(contents);
        }
    }
}