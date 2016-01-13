public class ComEventInterfaceAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ComEventInterfaceAttribute(Type SourceInterface, Type EventProvider) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type SourceInterface { get{} }
	public Type EventProvider { get{} }
	public object TypeId { get{} }
}

