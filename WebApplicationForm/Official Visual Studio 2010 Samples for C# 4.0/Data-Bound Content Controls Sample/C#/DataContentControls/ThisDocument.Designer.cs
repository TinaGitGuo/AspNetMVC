﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20701.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace DataContentControls {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisDocument : Microsoft.Office.Tools.Word.Document, Microsoft.VisualStudio.Tools.Office.IOfficeEntryPoint {
        
        internal Microsoft.Office.Tools.ActionsPane ActionsPane;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl richTextContentControl1;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl1;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl2;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl3;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl4;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl datePickerContentControl1;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl5;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl6;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl7;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl8;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl plainTextContentControl9;
        
        internal Microsoft.Office.Tools.Word.PictureContentControl pictureContentControl1;
        
        internal Microsoft.Office.Tools.Word.GroupContentControl groupContentControl1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        internal Microsoft.Office.Interop.Word.Application ThisApplication;
        
        internal DataContentControls.NorthwindDataSet northwindDataSet;
        
        internal DataContentControls.NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        
        internal DataContentControls.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        
        internal System.Windows.Forms.BindingSource employeesBindingSource;
        
        private System.ComponentModel.IContainer components;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public ThisDocument() : 
                base("ThisDocument", "ThisDocument") {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.ThisApplication = this.GetHostItem<Microsoft.Office.Interop.Word.Application>(typeof(Microsoft.Office.Interop.Word.Application), "Application");
            Globals.ThisDocument = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
            this.plainTextContentControl1.DataBindings.Add("Text", this.employeesBindingSource, "EmployeeID", true, this.plainTextContentControl1.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl2.DataBindings.Add("Text", this.employeesBindingSource, "LastName", true, this.plainTextContentControl2.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl3.DataBindings.Add("Text", this.employeesBindingSource, "FirstName", true, this.plainTextContentControl3.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl4.DataBindings.Add("Text", this.employeesBindingSource, "Title", true, this.plainTextContentControl4.DataBindings.DefaultDataSourceUpdateMode);
            this.datePickerContentControl1.DataBindings.Add("Text", this.employeesBindingSource, "HireDate", true, this.datePickerContentControl1.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl5.DataBindings.Add("Text", this.employeesBindingSource, "Address", true, this.plainTextContentControl5.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl6.DataBindings.Add("Text", this.employeesBindingSource, "City", true, this.plainTextContentControl6.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl7.DataBindings.Add("Text", this.employeesBindingSource, "Region", true, this.plainTextContentControl7.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl8.DataBindings.Add("Text", this.employeesBindingSource, "PostalCode", true, this.plainTextContentControl8.DataBindings.DefaultDataSourceUpdateMode);
            this.plainTextContentControl9.DataBindings.Add("Text", this.employeesBindingSource, "HomePhone", true, this.plainTextContentControl9.DataBindings.DefaultDataSourceUpdateMode);
            this.pictureContentControl1.DataBindings.Add("Image", this.employeesBindingSource, "Photo", true, this.pictureContentControl1.DataBindings.DefaultDataSourceUpdateMode);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.ActionsPane.BeginInit();
            this.richTextContentControl1.BeginInit();
            this.plainTextContentControl1.BeginInit();
            this.plainTextContentControl2.BeginInit();
            this.plainTextContentControl3.BeginInit();
            this.plainTextContentControl4.BeginInit();
            this.datePickerContentControl1.BeginInit();
            this.plainTextContentControl5.BeginInit();
            this.plainTextContentControl6.BeginInit();
            this.plainTextContentControl7.BeginInit();
            this.plainTextContentControl8.BeginInit();
            this.plainTextContentControl9.BeginInit();
            this.pictureContentControl1.BeginInit();
            this.groupContentControl1.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.groupContentControl1.EndInit();
            this.pictureContentControl1.EndInit();
            this.plainTextContentControl9.EndInit();
            this.plainTextContentControl8.EndInit();
            this.plainTextContentControl7.EndInit();
            this.plainTextContentControl6.EndInit();
            this.plainTextContentControl5.EndInit();
            this.datePickerContentControl1.EndInit();
            this.plainTextContentControl4.EndInit();
            this.plainTextContentControl3.EndInit();
            this.plainTextContentControl2.EndInit();
            this.plainTextContentControl1.EndInit();
            this.richTextContentControl1.EndInit();
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = new Microsoft.Office.Tools.ActionsPane(this.ItemProvider, this.HostContext, "ActionsPane", this, "ActionsPane");
            this.richTextContentControl1 = new Microsoft.Office.Tools.Word.RichTextContentControl(this.ItemProvider, this.HostContext, "97801906", this, "richTextContentControl1");
            this.plainTextContentControl1 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628810", this, "plainTextContentControl1");
            this.plainTextContentControl2 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628811", this, "plainTextContentControl2");
            this.plainTextContentControl3 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628812", this, "plainTextContentControl3");
            this.plainTextContentControl4 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628813", this, "plainTextContentControl4");
            this.datePickerContentControl1 = new Microsoft.Office.Tools.Word.DatePickerContentControl(this.ItemProvider, this.HostContext, "326628814", this, "datePickerContentControl1");
            this.plainTextContentControl5 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628815", this, "plainTextContentControl5");
            this.plainTextContentControl6 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628816", this, "plainTextContentControl6");
            this.plainTextContentControl7 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628817", this, "plainTextContentControl7");
            this.plainTextContentControl8 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628818", this, "plainTextContentControl8");
            this.plainTextContentControl9 = new Microsoft.Office.Tools.Word.PlainTextContentControl(this.ItemProvider, this.HostContext, "326628819", this, "plainTextContentControl9");
            this.pictureContentControl1 = new Microsoft.Office.Tools.Word.PictureContentControl(this.ItemProvider, this.HostContext, "326628820", this, "pictureContentControl1");
            this.groupContentControl1 = new Microsoft.Office.Tools.Word.GroupContentControl(this.ItemProvider, this.HostContext, "326628825", this, "groupContentControl1");
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            this.components = new System.ComponentModel.Container();
            if ((this.northwindDataSet == null)) {
                // Instantiate the object if not yet loaded from the data cache.
                this.northwindDataSet = new DataContentControls.NorthwindDataSet();
            }
            this.tableAdapterManager = new DataContentControls.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new DataContentControls.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ActionsPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePickerContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ActionsPane
            // 
            this.ActionsPane.AutoSize = false;
            this.ActionsPane.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataContentControls.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // ThisDocument
            // 
            ((System.ComponentModel.ISupportInitialize)(this.ActionsPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePickerContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainTextContentControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.groupContentControl1.Dispose();
            this.pictureContentControl1.Dispose();
            this.plainTextContentControl9.Dispose();
            this.plainTextContentControl8.Dispose();
            this.plainTextContentControl7.Dispose();
            this.plainTextContentControl6.Dispose();
            this.plainTextContentControl5.Dispose();
            this.datePickerContentControl1.Dispose();
            this.plainTextContentControl4.Dispose();
            this.plainTextContentControl3.Dispose();
            this.plainTextContentControl2.Dispose();
            this.plainTextContentControl1.Dispose();
            this.richTextContentControl1.Dispose();
            this.ActionsPane.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisDocument _ThisDocument;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisDocument ThisDocument {
            get {
                return _ThisDocument;
            }
            set {
                if ((_ThisDocument == null)) {
                    _ThisDocument = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection();
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
    internal sealed partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection {
    }
}
