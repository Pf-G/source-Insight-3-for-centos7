public class HttpModuleCollection : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public void CopyTo(System.Array dest, int index) {}
	public IHttpModule Get(string name) {}
	public IHttpModule Get(int index) {}
	public string GetKey(int index) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IHttpModule Item { get{} }
	public IHttpModule Item { get{} }
	public string[] AllKeys { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

