﻿using System;
using System.Collections;
using System.Collections.Generic;

public class CustomList<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private T[] data;

    public CustomList()
    {
        this.data = new T[4];
    }

    public int InnerArraySize => this.data.Length;

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            return this.data[index];
        }
        set
        {
            this.data[index] = value;
        }
    }


    public void Add(T element)
    {
        this.Count++;

        if (this.Count > this.InnerArraySize)
        {
            T[] newData = new T[this.InnerArraySize * 2];
            Array.Copy(this.data, newData, this.InnerArraySize);
            this.data = newData;

        }

        this.data[this.Count - 1] = element;
    }

    public T Remove(int index)
    {
        T element = this.data[index];

        this.Count--;

        for (int i = index; i < this.Count; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        this.data[this.Count] = default(T);

        if (this.Count < this.InnerArraySize / 3)
        {
            T[] newData = new T[this.InnerArraySize / 2];

            Array.Copy(this.data, newData, this.Count);

            this.data = newData;
        }

        return element;
    }

    public bool Contains(T element) // ok
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int firstindex, int secondIndex)//ok
    {
        T temp = this.data[firstindex];
        this.data[firstindex] = this.data[secondIndex];
        this.data[secondIndex] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;

        for (int i = 0; i < this.Count; i++)
        {
            T currentElement = this.data[i];

            if (currentElement.CompareTo(element) > 0)
            {
                count++;
            }
        }

        return count;
    }

    public void Sort(IComparer<T> comparer = null)
    {
        Array.Sort(this.data, 0, this.Count, comparer);
    }


    public T Min()
    {
        T minElement = this.data[0];

        for (int i = 0; i < this.Count; i++)
        {
            T currentElement = this.data[i];

            if (currentElement.CompareTo(minElement) < 0)
            {
                minElement = currentElement;
            }
        }

        return minElement;
    }

    public T Max()
    {
        T maxElement = this.data[0];

        for (int i = 0; i < this.Count; i++)
        {
            T currentElement = this.data[i];

            if (currentElement.CompareTo(maxElement) > 0)
            {
                maxElement = currentElement;
            }
        }

        return maxElement;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}