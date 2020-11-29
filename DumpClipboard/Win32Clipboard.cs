using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DumpClipboard
{
    public class ClipboardMonitor : IDisposable
    {
        private readonly MessageListener _messageListener;
        public event EventHandler<ClipboardChangedEventArgs> ClipboardChanged;

        public ClipboardMonitor()
        {
            _messageListener = new MessageListener(() =>
            {
                var contents = ClipboardEx.GetContents();
                ClipboardChanged?.Invoke(this, new ClipboardChangedEventArgs(contents));
            });
        }

        public void Dispose()
        {
            _messageListener?.Dispose();
        }

        public class ClipboardChangedEventArgs : EventArgs
        {
            public readonly ClipboardContent Contents;
            public ClipboardChangedEventArgs(ClipboardContent contents) => Contents = contents;
        }

        private class MessageListener : Form
        {
            private readonly Action _onClipboardChanged;
            private const int WM_CLIPBOARDUPDATE = 0x031D;

            public MessageListener(Action onClipboardChanged)
            {
                _onClipboardChanged = onClipboardChanged;
                Win32Api.AddClipboardFormatListener(this.Handle);
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg != WM_CLIPBOARDUPDATE) return;
                _onClipboardChanged();
            }

            protected override void Dispose(bool disposing)
            {
                base.Dispose();
                Win32Api.RemoveClipboardFormatListener(this.Handle);
            }
        }

        private static class Win32Api
        {
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            /// <summary>
            /// Removes the given window from the system-maintained clipboard format listener list.
            /// </summary>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
        }
    }
}