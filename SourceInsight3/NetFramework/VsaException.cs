public class VsaException : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public VsaException() {}
	public VsaException(string message) {}
	public VsaException(string message, System.Exception innerException) {}
	public VsaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public VsaException(VsaError error) {}
	public VsaException(VsaError error, string message) {}
	public VsaException(VsaError error, string message, System.Exception innerException) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual string ToString() {}
	public virtual System.Exception GetBaseException() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VsaError ErrorCode { get{} }
	public int ErrorCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

