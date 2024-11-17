namespace PaControl.Collections;

public interface IPool<T>
{
    T Acquire();

    bool Release(T instance);
}
