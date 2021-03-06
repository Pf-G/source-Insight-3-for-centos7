public class EncoderFallbackException : System.ArgumentException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public EncoderFallbackException() {}
	public EncoderFallbackException(string message) {}
	public EncoderFallbackException(string message, System.Exception innerException) {}

	// Methods
	public bool IsUnknownSurrogate() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public char CharUnknown { get{} }
	public char CharUnknownHigh { get{} }
	public char CharUnknownLow { get{} }
	public int Index { get{} }
	public string Message { get{} }
	public string ParamName { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

