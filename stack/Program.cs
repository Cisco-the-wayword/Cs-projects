using System;

public class Stack
{
    private object[] _items;
    private int _index;

    public Stack()
    {
        _items = new object[0];
        _index = -1;
    }

    public void Push(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException("Cannot push null onto stack.");

        if (_index == _items.Length - 1)
        {
            Array.Resize(ref _items, _items.Length + 1);
        }

        _index++;
        _items[_index] = obj;
    }

    public object Pop()
    {
        if (_index < 0)
            throw new InvalidOperationException("Cannot pop from an empty stack.");

        object obj = _items[_index];
        _index--;

        return obj;
    }

    public void Clear()
    {
        _items = new object[0];
        _index = -1;
    }
}
