public class EnvironmentPermissionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public EnvironmentPermissionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Read { get{} set{} }
	public string Write { get{} set{} }
	public string All { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

