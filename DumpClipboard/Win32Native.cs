using System.Runtime.InteropServices;

namespace DumpClipboard
{
    internal static class Win32Native
    {
        [DllImport("Kernel32.dll")]
        private static extern bool AttachConsole(int processId);

        public static void AttachConsole() => AttachConsole(-1);
    }
}