public class CollectionBase : IList, ICollection, IEnumerable
{

	// Methods
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

