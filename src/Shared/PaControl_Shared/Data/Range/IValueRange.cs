﻿namespace PaControl.Data;

public interface IValueRange<T>
{
    T Start { get; set; }

    T End { get; set; }
}
