public class FormViewDeleteEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public FormViewDeleteEventArgs(int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public System.Collections.Specialized.IOrderedDictionary Keys { get{} }
	public System.Collections.Specialized.IOrderedDictionary Values { get{} }
	public bool Cancel { get{} set{} }
}

