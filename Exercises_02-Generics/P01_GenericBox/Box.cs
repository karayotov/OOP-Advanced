using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    public Box()
    {
        this.item = default(T);
    }

    public Box(T element)
    {
        this.item = element;
    }

    public T item;

    public override string ToString()
    {
        return $"{this.item.GetType().FullName}: {this.item}";
    }
}
//Create a generic class Box that can be initialized with any type and store the value.