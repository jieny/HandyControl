using System;

namespace PaControl.Interactivity;

public class PreviewInvokeEventArgs : EventArgs
{
    public bool Cancelling { get; set; }
}
