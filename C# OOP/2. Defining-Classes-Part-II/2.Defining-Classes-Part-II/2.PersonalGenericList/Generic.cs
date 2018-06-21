﻿using System;

class GenericList<T>
{
    private const uint DefaultCapacity = 1;
    private T[] elements = null;

    public uint Count { get; private set; }
    public uint Capacity { get; private set; }

    public GenericList(uint capacity = DefaultCapacity)
    {
        this.Capacity = capacity;
        this.Count = 0;

        elements = new T[this.Capacity];
    }

    public void Clear()
    {
        this.Capacity = DefaultCapacity;
        this.Count = 0;

        elements = new T[this.Capacity];
    }

    private void Resize(uint capacity)
    {
        uint oldCapacity = this.Capacity;

        if (capacity == 0 || capacity == 1)
        {
            this.Capacity = 1;
        }
        else if (capacity <= this.Capacity / 2)
        {
            this.Capacity /= 2;
        }
        else if (capacity > this.Capacity)
        {
            this.Capacity *= 2;
        }
        if (oldCapacity != this.Capacity)
        {
            Array.Resize(ref elements, (int)this.Capacity);
        }
    }

    public void Add(T element)
    {
        this.Count++;

        Resize(this.Count);

        this.elements[this.Count - 1] = element;
    }

    public void Remove(uint i)
    {
        if (i >= this.Count)
            throw new IndexOutOfRangeException();

        this.Count--;

        Array.Copy(this.elements, i + 1, this.elements, i, Count - i);

        this.elements[this.Count] = default(T); // Clear last

        Resize(this.Count);
    }

    public void Insert(uint i, T element)
    {
        if (i > this.Count)
        {
            throw new IndexOutOfRangeException();
        }
        this.Count++;

        Resize(this.Count);

        Array.Copy(elements, i, elements, i + 1, Count - i - 1);

        this.elements[i] = element;
    }

    public int IndexOf(T element)
    {
        return Array.IndexOf(elements, element);
    }

    private T MinMax(bool value)
    {
        T best = this.elements[0];

        for (int i = 1; i < this.Count; i++)
            if (value ? (best < (dynamic)this.elements[i]) : (best > (dynamic)this.elements[i]))
            {
                best = this.elements[i];
            }
        return best;
    }

    public T Max()
    {
        return MinMax(true);
    }

    public T Min()
    {
        return MinMax(false);
    }

    public T this[uint index]
    {
        get
        {
            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return elements[index];
        }
    }

    public override string ToString()
    {
        if (this.Count == 0)
        {
            return "Empty list.";
        }
        string[] info = new string[this.Count];

        for (int i = 0; i < this.Count; i++)
        {
            info[i] = String.Format("{0}: {1}", i, this.elements[i].ToString());
        }
        return String.Join(Environment.NewLine, info);
    }
}
