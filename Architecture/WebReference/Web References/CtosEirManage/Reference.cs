﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace CCT.WebReference.CtosEirManage {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EirSoap", Namespace="http://tempuri.org/")]
    public partial class Eir : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EirManageOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteEirOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Eir() {
            this.Url = global::CCT.WebReference.Properties.Settings.Default.CCT_WebReference_CtosEirManage_Eir;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event EirManageCompletedEventHandler EirManageCompleted;
        
        /// <remarks/>
        public event DeleteEirCompletedEventHandler DeleteEirCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EirManage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long EirManage(ref System.Data.DataSet eirs, out string errorMessage) {
            object[] results = this.Invoke("EirManage", new object[] {
                        eirs});
            eirs = ((System.Data.DataSet)(results[1]));
            errorMessage = ((string)(results[2]));
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void EirManageAsync(System.Data.DataSet eirs) {
            this.EirManageAsync(eirs, null);
        }
        
        /// <remarks/>
        public void EirManageAsync(System.Data.DataSet eirs, object userState) {
            if ((this.EirManageOperationCompleted == null)) {
                this.EirManageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEirManageOperationCompleted);
            }
            this.InvokeAsync("EirManage", new object[] {
                        eirs}, this.EirManageOperationCompleted, userState);
        }
        
        private void OnEirManageOperationCompleted(object arg) {
            if ((this.EirManageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EirManageCompleted(this, new EirManageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteEir", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long DeleteEir(ref System.Data.DataSet eirs, out string errorMessage) {
            object[] results = this.Invoke("DeleteEir", new object[] {
                        eirs});
            eirs = ((System.Data.DataSet)(results[1]));
            errorMessage = ((string)(results[2]));
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteEirAsync(System.Data.DataSet eirs) {
            this.DeleteEirAsync(eirs, null);
        }
        
        /// <remarks/>
        public void DeleteEirAsync(System.Data.DataSet eirs, object userState) {
            if ((this.DeleteEirOperationCompleted == null)) {
                this.DeleteEirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteEirOperationCompleted);
            }
            this.InvokeAsync("DeleteEir", new object[] {
                        eirs}, this.DeleteEirOperationCompleted, userState);
        }
        
        private void OnDeleteEirOperationCompleted(object arg) {
            if ((this.DeleteEirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteEirCompleted(this, new DeleteEirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void EirManageCompletedEventHandler(object sender, EirManageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EirManageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EirManageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public System.Data.DataSet eirs {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string errorMessage {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void DeleteEirCompletedEventHandler(object sender, DeleteEirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteEirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteEirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public System.Data.DataSet eirs {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string errorMessage {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591