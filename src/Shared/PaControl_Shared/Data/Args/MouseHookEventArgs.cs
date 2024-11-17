using System;
using PaControl.Tools.Interop;

namespace PaControl.Data;

internal class MouseHookEventArgs : EventArgs
{
    public MouseHookMessageType MessageType { get; set; }

    public InteropValues.POINT Point { get; set; }
}
