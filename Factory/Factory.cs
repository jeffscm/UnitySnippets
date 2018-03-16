using System;

public class Factory<T>
{

    public T1 CreateNew<T1>()
    {        
        return Activator.CreateInstance<T1>();
    }

}
