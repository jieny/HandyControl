using System;

namespace PaControl.Controls;

public interface ISingleOpen : IDisposable
{
    bool CanDispose { get; }
}
