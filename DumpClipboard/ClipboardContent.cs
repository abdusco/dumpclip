using System.Collections.Generic;

namespace DumpClipboard
{
    internal class ClipboardContent
    {
        public List<string> Files { get; set; }
        public string Text { get; set; }
    }
}