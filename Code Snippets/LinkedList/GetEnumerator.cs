// As a Method
public IEnumerator GetEnumerator()
{
    for (Node<type> dd = HeadNode; dd != null; dd = dd.Next)
    {
        yield return dd.Data;
    }
}

IEnumerator IEnumerable.GetEnumerator()
{
    yield return GetEnumerator();
}

// As a Property
public IEnumerator Enumerator
{
    get
    {
        for (Node<type> dd = HeadNode; dd != null; dd = dd.Next)
        {
            yield return dd.Data;
        }
    }
}