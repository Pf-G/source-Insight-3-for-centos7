public class RequiredAttributeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RequiredAttributeAttribute(Type requiredContract) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type RequiredContract { get{} }
	public object TypeId { get{} }
}

