using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DumpClipboard
{
    public class ClipboardContent
    {
        public List<string> Files { get; set; }
        public string Text { get; set; }
    }

    public static class ClipboardEx
    {
        public static ClipboardContent GetContents()
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