public class ByteViewer : System.Windows.Forms.TableLayoutPanel, System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods.IOleControl, System.Windows.Forms.UnsafeNativeMethods.IOleObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods.IOleWindow, System.Windows.Forms.UnsafeNativeMethods.IViewObject, System.Windows.Forms.UnsafeNativeMethods.IViewObject2, System.Windows.Forms.UnsafeNativeMethods.IPersist, System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods.IPersistStorage, System.Windows.Forms.UnsafeNativeMethods.IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public ByteViewer() {}

	// Methods
	public virtual byte[] GetBytes() {}
	public virtual DisplayMode GetDisplayMode() {}
	public virtual void SaveToFile(string path) {}
	public virtual void SetBytes(byte[] bytes) {}
	public virtual void SetDisplayMode(DisplayMode mode) {}
	public virtual void SetFile(string path) {}
	public virtual void SetStartLine(int line) {}
	public void SetRow(System.Windows.Forms.Control control, int row) {}
	public void SetColumn(System.Windows.Forms.Control control, int column) {}
	public int GetColumnSpan(System.Windows.Forms.Control control) {}
	public void SetColumnSpan(System.Windows.Forms.Control control, int value) {}
	public int GetRowSpan(System.Windows.Forms.Control control) {}
	public void SetRowSpan(System.Windows.Forms.Control control, int value) {}
	public int GetRow(System.Windows.Forms.Control control) {}
	public System.Windows.Forms.TableLayoutPanelCellPosition GetCellPosition(System.Windows.Forms.Control control) {}
	public void SetCellPosition(System.Windows.Forms.Control control, System.Windows.Forms.TableLayoutPanelCellPosition position) {}
	public int GetColumn(System.Windows.Forms.Control control) {}
	public System.Windows.Forms.Control GetControlFromPosition(int column, int row) {}
	public System.Windows.Forms.TableLayoutPanelCellPosition GetPositionFromControl(System.Windows.Forms.Control control) {}
	public int[] GetColumnWidths() {}
	public int[] GetRowHeights() {}
	public virtual string ToString() {}
	public void ScrollControlIntoView(System.Windows.Forms.Control activeControl) {}
	public void SetAutoScrollMargin(int x, int y) {}
	public void ResetImeMode() {}
	public void PerformLayout() {}
	public virtual bool PreProcessMessage(System.Windows.Forms.Message& msg) {}
	public virtual void ResetBackColor() {}
	public virtual void ResetCursor() {}
	public virtual void ResetFont() {}
	public virtual void ResetForeColor() {}
	public virtual void ResetRightToLeft() {}
	public virtual void Refresh() {}
	public virtual void ResetText() {}
	public void ResumeLayout() {}
	public void ResumeLayout(bool performLayout) {}
	public void SetBounds(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified) {}
	public void SuspendLayout() {}
	public void PerformLayout(System.Windows.Forms.Control affectedControl, string affectedProperty) {}
	public System.Drawing.Point PointToClient(System.Drawing.Point p) {}
	public System.Drawing.Point PointToScreen(System.Drawing.Point p) {}
	public System.Windows.Forms.PreProcessControlState PreProcessControlMessage(System.Windows.Forms.Message& msg) {}
	public System.Drawing.Rectangle RectangleToClient(System.Drawing.Rectangle r) {}
	public System.Drawing.Rectangle RectangleToScreen(System.Drawing.Rectangle r) {}
	public void Scale(float ratio) {}
	public void Scale(float dx, float dy) {}
	public void Scale(System.Drawing.SizeF factor) {}
	public void Select() {}
	public bool SelectNextControl(System.Windows.Forms.Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap) {}
	public void SendToBack() {}
	public void SetBounds(int x, int y, int width, int height) {}
	public void Show() {}
	public void Update() {}
	public virtual System.IAsyncResult BeginInvoke(System.Delegate method, object[] args) {}
	public void CreateControl() {}
	public virtual object EndInvoke(System.IAsyncResult asyncResult) {}
	public void Invalidate() {}
	public virtual object Invoke(System.Delegate method, object[] args) {}
	public System.IAsyncResult BeginInvoke(System.Delegate method) {}
	public void BringToFront() {}
	public bool Contains(System.Windows.Forms.Control ctl) {}
	public System.Drawing.Graphics CreateGraphics() {}
	public System.Windows.Forms.DragDropEffects DoDragDrop(object data, System.Windows.Forms.DragDropEffects allowedEffects) {}
	public void DrawToBitmap(System.Drawing.Bitmap bitmap, System.Drawing.Rectangle targetBounds) {}
	public System.Windows.Forms.Form FindForm() {}
	public bool Focus() {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point pt, System.Windows.Forms.GetChildAtPointSkip skipValue) {}
	public System.Windows.Forms.Control GetChildAtPoint(System.Drawing.Point pt) {}
	public System.Windows.Forms.IContainerControl GetContainerControl() {}
	public System.Windows.Forms.Control GetNextControl(System.Windows.Forms.Control ctl, bool forward) {}
	public void Hide() {}
	public void Invalidate(System.Drawing.Region region) {}
	public void Invalidate(System.Drawing.Region region, bool invalidateChildren) {}
	public void Invalidate(bool invalidateChildren) {}
	public void Invalidate(System.Drawing.Rectangle rc) {}
	public void Invalidate(System.Drawing.Rectangle rc, bool invalidateChildren) {}
	public object Invoke(System.Delegate method) {}
	public virtual System.Drawing.Size GetPreferredSize(System.Drawing.Size proposedSize) {}
	public void ResetBindings() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public System.Windows.Forms.TableLayoutSettings LayoutSettings { get{} set{} }
	public System.Windows.Forms.BorderStyle BorderStyle { get{} set{} }
	public System.Windows.Forms.TableLayoutPanelCellBorderStyle CellBorderStyle { get{} set{} }
	public System.Windows.Forms.TableLayoutControlCollection Controls { get{} }
	public int ColumnCount { get{} set{} }
	public System.Windows.Forms.TableLayoutPanelGrowStyle GrowStyle { get{} set{} }
	public int RowCount { get{} set{} }
	public System.Windows.Forms.TableLayoutRowStyleCollection RowStyles { get{} }
	public System.Windows.Forms.TableLayoutColumnStyleCollection ColumnStyles { get{} }
	public bool AutoSize { get{} set{} }
	public System.Windows.Forms.AutoSizeMode AutoSizeMode { get{} set{} }
	public bool TabStop { get{} set{} }
	public string Text { get{} set{} }
	public bool AutoScroll { get{} set{} }
	public System.Drawing.Size AutoScrollMargin { get{} set{} }
	public System.Drawing.Point AutoScrollPosition { get{} set{} }
	public System.Drawing.Size AutoScrollMinSize { get{} set{} }
	public System.Drawing.Rectangle DisplayRectangle { get{} }
	public System.Windows.Forms.HScrollProperties HorizontalScroll { get{} }
	public System.Windows.Forms.VScrollProperties VerticalScroll { get{} }
	public System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding { get{} }
	public System.Windows.Forms.AccessibleObject AccessibilityObject { get{} }
	public string AccessibleDefaultActionDescription { get{} set{} }
	public string AccessibleDescription { get{} set{} }
	public string AccessibleName { get{} set{} }
	public System.Windows.Forms.AccessibleRole AccessibleRole { get{} set{} }
	public bool AllowDrop { get{} set{} }
	public System.Windows.Forms.AnchorStyles Anchor { get{} set{} }
	public System.Drawing.Point AutoScrollOffset { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Image BackgroundImage { get{} set{} }
	public System.Windows.Forms.ImageLayout BackgroundImageLayout { get{} set{} }
	public System.Windows.Forms.BindingContext BindingContext { get{} set{} }
	public int Bottom { get{} }
	public System.Drawing.Rectangle Bounds { get{} set{} }
	public bool CanFocus { get{} }
	public bool CanSelect { get{} }
	public bool Capture { get{} set{} }
	public bool CausesValidation { get{} set{} }
	public System.Drawing.Rectangle ClientRectangle { get{} }
	public System.Drawing.Size ClientSize { get{} set{} }
	public string CompanyName { get{} }
	public bool ContainsFocus { get{} }
	public System.Windows.Forms.ContextMenu ContextMenu { get{} set{} }
	public System.Windows.Forms.ContextMenuStrip ContextMenuStrip { get{} set{} }
	public System.Windows.Forms.Control.ControlCollection Controls { get{} }
	public bool Created { get{} }
	public System.Windows.Forms.Cursor Cursor { get{} set{} }
	public System.Windows.Forms.ControlBindingsCollection DataBindings { get{} }
	public bool IsDisposed { get{} }
	public bool Disposing { get{} }
	public System.Windows.Forms.DockStyle Dock { get{} set{} }
	public bool Enabled { get{} set{} }
	public bool Focused { get{} }
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.IntPtr Handle { get{} }
	public bool HasChildren { get{} }
	public int Height { get{} set{} }
	public bool IsHandleCreated { get{} }
	public bool InvokeRequired { get{} }
	public bool IsAccessible { get{} set{} }
	public bool IsMirrored { get{} }
	public int Left { get{} set{} }
	public System.Drawing.Point Location { get{} set{} }
	public System.Windows.Forms.Padding Margin { get{} set{} }
	public System.Drawing.Size MaximumSize { get{} set{} }
	public System.Drawing.Size MinimumSize { get{} set{} }
	public string Name { get{} set{} }
	public System.Windows.Forms.Control Parent { get{} set{} }
	public string ProductName { get{} }
	public string ProductVersion { get{} }
	public bool RecreatingHandle { get{} }
	public System.Drawing.Region Region { get{} set{} }
	public int Right { get{} }
	public System.Windows.Forms.RightToLeft RightToLeft { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.Drawing.Size Size { get{} set{} }
	public int TabIndex { get{} set{} }
	public object Tag { get{} set{} }
	public int Top { get{} set{} }
	public System.Windows.Forms.Control TopLevelControl { get{} }
	public bool UseWaitCursor { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public System.Windows.Forms.IWindowTarget WindowTarget { get{} set{} }
	public System.Drawing.Size PreferredSize { get{} }
	public System.Windows.Forms.Padding Padding { get{} set{} }
	public System.Windows.Forms.ImeMode ImeMode { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Windows.Forms.TableLayoutCellPaintEventHandler CellPaint;
	public event System.EventHandler AutoSizeChanged;
	public event System.Windows.Forms.KeyEventHandler KeyUp;
	public event System.Windows.Forms.KeyEventHandler KeyDown;
	public event System.Windows.Forms.KeyPressEventHandler KeyPress;
	public event System.EventHandler TextChanged;
	public event System.Windows.Forms.ScrollEventHandler Scroll;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler BackgroundImageChanged;
	public event System.EventHandler BackgroundImageLayoutChanged;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler CausesValidationChanged;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.EventHandler CursorChanged;
	public event System.EventHandler DockChanged;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler FontChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TabStopChanged;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Click;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.Windows.Forms.DragEventHandler DragDrop;
	public event System.Windows.Forms.DragEventHandler DragEnter;
	public event System.Windows.Forms.DragEventHandler DragOver;
	public event System.EventHandler DragLeave;
	public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
	public event System.EventHandler HandleCreated;
	public event System.EventHandler HandleDestroyed;
	public event System.Windows.Forms.HelpEventHandler HelpRequested;
	public event System.Windows.Forms.InvalidateEventHandler Invalidated;
	public event System.EventHandler PaddingChanged;
	public event System.Windows.Forms.PaintEventHandler Paint;
	public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.EventHandler DoubleClick;
	public event System.EventHandler Enter;
	public event System.EventHandler GotFocus;
	public event System.Windows.Forms.LayoutEventHandler Layout;
	public event System.EventHandler Leave;
	public event System.EventHandler LostFocus;
	public event System.Windows.Forms.MouseEventHandler MouseClick;
	public event System.Windows.Forms.MouseEventHandler MouseDoubleClick;
	public event System.EventHandler MouseCaptureChanged;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.EventHandler MouseEnter;
	public event System.EventHandler MouseLeave;
	public event System.EventHandler MouseHover;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.Windows.Forms.MouseEventHandler MouseWheel;
	public event System.EventHandler Move;
	public event System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
	public event System.EventHandler Resize;
	public event System.Windows.Forms.UICuesEventHandler ChangeUICues;
	public event System.EventHandler StyleChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler Validated;
	public event System.EventHandler ParentChanged;
	public event System.EventHandler ImeModeChanged;
	public event System.EventHandler Disposed;
}

