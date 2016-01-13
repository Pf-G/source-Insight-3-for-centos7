public class GacIdentityPermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IBuiltInPermission
{

	// Constructors
	public GacIdentityPermission(PermissionState state) {}
	public GacIdentityPermission() {}

	// Methods
	public virtual System.Security.IPermission Copy() {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement securityElement) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
}

