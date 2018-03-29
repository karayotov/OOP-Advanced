using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StackArray<T> : IEnumerable<T>
{

    public StackArray()
    {
        this.stackList = new T[DEFAULT_CAPACITY];
    }

    private const int DEFAULT_CAPACITY = 2;

    public int Length { get; set; }

    private T[] stackList;


    public T Pop()
    {
        if (this.Length == 0)
        {
            throw new ArgumentException("No elements");
        }

        this.Length--;
        T lastItem = this.stackList[this.Length];
        this.stackList[this.Length] = default(T);
        return lastItem;
    }

    public void Push(IEnumerable<T> items)
    {
        foreach (T item in items)
        {
            if (this.Length >= this.stackList.Length)
            {
                Array.Resize(ref this.stackList, this.stackList.Length * 2);//  👀
            }

            this.stackList[this.Length] = item;
            this.Length++;
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Length - 1; i >= 0 ; i--)//       👀
        {
            yield return this.stackList[i];             
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}