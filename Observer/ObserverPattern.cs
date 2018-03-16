// 2018 - Author : Jefferson Scomacao - Observer Pattern
// 
// how to use:  
// var f = new Observer<float>(0).OnChange ( (ff) => { Debug.Log(ff); } );
// f.Value = 10f;

using System;

public class Observer<T>
{

    bool _reportValue = false;

    public Observer(T defaultValue, bool reportInitialState = false)
    {
        _value = defaultValue;
        _reportValue = reportInitialState;
    }

    Action<T> _onChange;

    public Observer <T>OnChange(Action<T> a)
    {
        _onChange += a;
        if (_reportValue)
        {
            _reportValue = false;
            _onChange(_value);
        }
        return this;
    }

    public void RemoveAll()
    {
        _onChange = null;
    }

    T _value = default(T);

    public T Value
    {
        set
        {
            if (_onChange != null) { _onChange(value);  }
            _value = value;
        }
        get {
            return _value;
        }
    }
}

