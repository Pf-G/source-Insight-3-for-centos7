public class ManagementClass : ManagementObject, System.ComponentModel.IComponent, System.IDisposable, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ManagementClass() {}
	public ManagementClass(ManagementPath path) {}
	public ManagementClass(string path) {}
	public ManagementClass(ManagementPath path, ObjectGetOptions options) {}
	public ManagementClass(string path, ObjectGetOptions options) {}
	public ManagementClass(ManagementScope scope, ManagementPath path, ObjectGetOptions options) {}
	public ManagementClass(string scope, string path, ObjectGetOptions options) {}

	// Methods
	public ManagementObjectCollection GetInstances() {}
	public ManagementObjectCollection GetInstances(EnumerationOptions options) {}
	public void GetInstances(ManagementOperationObserver watcher) {}
	public void GetInstances(ManagementOperationObserver watcher, EnumerationOptions options) {}
	public ManagementObjectCollection GetSubclasses() {}
	public ManagementObjectCollection GetSubclasses(EnumerationOptions options) {}
	public void GetSubclasses(ManagementOperationObserver watcher) {}
	public void GetSubclasses(ManagementOperationObserver watcher, EnumerationOptions options) {}
	public ManagementClass Derive(string newClassName) {}
	public ManagementObject CreateInstance() {}
	public virtual object Clone() {}
	public ManagementObjectCollection GetRelatedClasses() {}
	public ManagementObjectCollection GetRelatedClasses(string relatedClass) {}
	public ManagementObjectCollection GetRelatedClasses(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, EnumerationOptions options) {}
	public void GetRelatedClasses(ManagementOperationObserver watcher) {}
	public void GetRelatedClasses(ManagementOperationObserver watcher, string relatedClass) {}
	public void GetRelatedClasses(ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, EnumerationOptions options) {}
	public ManagementObjectCollection GetRelationshipClasses() {}
	public ManagementObjectCollection GetRelationshipClasses(string relationshipClass) {}
	public ManagementObjectCollection GetRelationshipClasses(string relationshipClass, string relationshipQualifier, string thisRole, EnumerationOptions options) {}
	public void GetRelationshipClasses(ManagementOperationObserver watcher) {}
	public void GetRelationshipClasses(ManagementOperationObserver watcher, string relationshipClass) {}
	public void GetRelationshipClasses(ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, EnumerationOptions options) {}
	public System.CodeDom.CodeTypeDeclaration GetStronglyTypedClassCode(bool includeSystemClassInClassDef, bool systemPropertyClass) {}
	public bool GetStronglyTypedClassCode(CodeLanguage lang, string filePath, string classNamespace) {}
	public void Dispose() {}
	public void Get() {}
	public void Get(ManagementOperationObserver watcher) {}
	public ManagementObjectCollection GetRelated() {}
	public ManagementObjectCollection GetRelated(string relatedClass) {}
	public ManagementObjectCollection GetRelated(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, EnumerationOptions options) {}
	public void GetRelated(ManagementOperationObserver watcher) {}
	public void GetRelated(ManagementOperationObserver watcher, string relatedClass) {}
	public void GetRelated(ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, EnumerationOptions options) {}
	public ManagementObjectCollection GetRelationships() {}
	public ManagementObjectCollection GetRelationships(string relationshipClass) {}
	public ManagementObjectCollection GetRelationships(string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, EnumerationOptions options) {}
	public void GetRelationships(ManagementOperationObserver watcher) {}
	public void GetRelationships(ManagementOperationObserver watcher, string relationshipClass) {}
	public void GetRelationships(ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, EnumerationOptions options) {}
	public ManagementPath Put() {}
	public ManagementPath Put(PutOptions options) {}
	public void Put(ManagementOperationObserver watcher) {}
	public void Put(ManagementOperationObserver watcher, PutOptions options) {}
	public ManagementPath CopyTo(ManagementPath path) {}
	public ManagementPath CopyTo(string path) {}
	public ManagementPath CopyTo(string path, PutOptions options) {}
	public ManagementPath CopyTo(ManagementPath path, PutOptions options) {}
	public void CopyTo(ManagementOperationObserver watcher, ManagementPath path) {}
	public void CopyTo(ManagementOperationObserver watcher, string path) {}
	public void CopyTo(ManagementOperationObserver watcher, string path, PutOptions options) {}
	public void CopyTo(ManagementOperationObserver watcher, ManagementPath path, PutOptions options) {}
	public void Delete() {}
	public void Delete(DeleteOptions options) {}
	public void Delete(ManagementOperationObserver watcher) {}
	public void Delete(ManagementOperationObserver watcher, DeleteOptions options) {}
	public object InvokeMethod(string methodName, object[] args) {}
	public void InvokeMethod(ManagementOperationObserver watcher, string methodName, object[] args) {}
	public ManagementBaseObject InvokeMethod(string methodName, ManagementBaseObject inParameters, InvokeMethodOptions options) {}
	public void InvokeMethod(ManagementOperationObserver watcher, string methodName, ManagementBaseObject inParameters, InvokeMethodOptions options) {}
	public ManagementBaseObject GetMethodParameters(string methodName) {}
	public virtual string ToString() {}
	public void Dispose() {}
	public object GetPropertyValue(string propertyName) {}
	public object GetQualifierValue(string qualifierName) {}
	public void SetQualifierValue(string qualifierName, object qualifierValue) {}
	public object GetPropertyQualifierValue(string propertyName, string qualifierName) {}
	public void SetPropertyQualifierValue(string propertyName, string qualifierName, object qualifierValue) {}
	public string GetText(TextFormat format) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public bool CompareTo(ManagementBaseObject otherObject, ComparisonSettings settings) {}
	public void SetPropertyValue(string propertyName, object propertyValue) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}

	// Properties
	public ManagementPath Path { get{} set{} }
	public System.Collections.Specialized.StringCollection Derivation { get{} }
	public MethodDataCollection Methods { get{} }
	public ManagementScope Scope { get{} set{} }
	public ObjectGetOptions Options { get{} set{} }
	public ManagementPath ClassPath { get{} }
	public PropertyDataCollection Properties { get{} }
	public PropertyDataCollection SystemProperties { get{} }
	public QualifierDataCollection Qualifiers { get{} }
	public object Item { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

