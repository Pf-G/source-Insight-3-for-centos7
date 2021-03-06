public class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public StringCollection() {}

	// Methods
	public StringEnumerator GetEnumerator() {}
	public int Add(string value) {}
	public void AddRange(string[] value) {}
	public virtual void Clear() {}
	public bool Contains(string value) {}
	public void CopyTo(string[] array, int index) {}
	public int IndexOf(string value) {}
	public void Insert(int index, string value) {}
	public void Remove(string value) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

