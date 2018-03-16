// 2018 - Author : Jefferson Scomaca - Observer Pattern
// 
// how to use:  
// var f = new Observer<float>().OnChange ( (ff) => { Debug.Log(ff); } );
// f.Value = 10f;

public class Observer<T>
{

    Action<T> _onChange;

    public Observer <T>OnChange(Action<T> a)
    {
        _onChange += a;
        return this;
    }

    public void RemoveAction(Action<T> a)
    {
        _onChange -= a;
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

