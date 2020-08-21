//generic class
public class Sample<T> where T : class
{
    private T _x;

    public T X
    {
        set
        {
            _x = value;
        }
        get
        {
            return _x;
        }
    }
}

