using System.Collections;

public class MyList<T> : ICollection<T>, IEnumerable<T>
{
    private T[] items;
    private int count;
    public MyList()
    {
        items = new T[4];
        count = 0;
    }
    public void Add(T item)
    {
        if (count == items.Length)
        {
            T[] newArray = new T[items.Length * 2];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }
        items[count++] = item;
    }
    public int Count => count;
    public bool IsReadOnly => false;

    public void Clear()
    {
        items = new T[4];
        count = 0;
    }
    public bool Contains(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(items[i], item))
            {
                return true;
            }
        }
        return false;
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
        Array.Copy(items, 0, array, arrayIndex, count);
    }
    public bool Remove(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(items[i], item))
            {
                for (int j = i; j < count - 1; j++)
                    items[j] = items[j + 1];
                items[--count] = default;
                return true;
            }
        }
        return false;
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return items[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
