public class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ConnectionManagementElementCollection() {}

	// Methods
	public void Add(ConnectionManagementElement element) {}
	public void Clear() {}
	public int IndexOf(ConnectionManagementElement element) {}
	public void Remove(ConnectionManagementElement element) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConnectionManagementElement Item { get{} set{} }
	public ConnectionManagementElement Item { get{} set{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Configuration.ConfigurationElementCollectionType CollectionType { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

