using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DumpClipboard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Win32Native.AttachConsole();

            var contents = GetClipboardContents();
            ConsoleEx.WriteJson(contents);
        }

        private static ClipboardContent GetClipboardContents()
        {
            if (Clipboard.ContainsFileDropList())
            {
                return new ClipboardContent
                {
                    Files = Clipboard.GetFileDropList().Cast<string>().ToList()
                };
            }

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                return new ClipboardContent
                {
                    Text = Clipboard.GetText()
                };
            }

            return new ClipboardContent();
        }
    }
}