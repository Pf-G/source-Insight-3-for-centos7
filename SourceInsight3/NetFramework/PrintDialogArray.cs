public class PrintDialogArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public PrintDialogArray() {}
	public PrintDialogArray(System.ComponentModel.IContainer Container) {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public short GetIndex(System.Windows.Forms.PrintDialog o) {}
	public void SetIndex(System.Windows.Forms.PrintDialog o, short Index) {}
	public bool ShouldSerializeIndex(System.Windows.Forms.PrintDialog o) {}
	public void ResetIndex(System.Windows.Forms.PrintDialog o) {}
	public void Load(short Index) {}
	public void Unload(short Index) {}
	public short LBound() {}
	public short UBound() {}
	public short Count() {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.PrintDialog Item { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}

