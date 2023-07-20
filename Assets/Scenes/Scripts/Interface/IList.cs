namespace DSASample
{

    public interface IList
    {
        object this[int index] {get;set;}
        void Add(object value);
        bool Contains(object value);
        void Clear();
        bool IsReadOnly{get;}
        bool IsFixedSize{get;}
        int IndexOf(object value);
        void Insert(int index,object value);
        void Remove(object value);
        void RemoveAt(int index);
    }
}