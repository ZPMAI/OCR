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

namespace CCT.WebReference.GateDataSendReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GangKouShuJuJiaoHuanServiceImplServiceSoapBinding", Namespace="http://impl.service.pub.gyt.service.com/")]
    public partial class GangKouShuJuJiaoHuanServiceImplService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback qryDaoLuYunShuCyryXinxiOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendGytJinChuGangCheRenYuanXixiOperationCompleted;
        
        private System.Threading.SendOrPostCallback addGytIcKaSynchronizedOperatorOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GangKouShuJuJiaoHuanServiceImplService() {
            this.Url = global::CCT.WebReference.Properties.Settings.Default.CCT_WebReference_GateDataSendReference_GangKouShuJuJiaoHuanServiceImplService;
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
        public event qryDaoLuYunShuCyryXinxiCompletedEventHandler qryDaoLuYunShuCyryXinxiCompleted;
        
        /// <remarks/>
        public event SendGytJinChuGangCheRenYuanXixiCompletedEventHandler SendGytJinChuGangCheRenYuanXixiCompleted;
        
        /// <remarks/>
        public event addGytIcKaSynchronizedOperatorCompletedEventHandler addGytIcKaSynchronizedOperatorCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pub.gyt.service.com/", ResponseNamespace="http://service.pub.gyt.service.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string qryDaoLuYunShuCyryXinxi([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string xmlDoc) {
            object[] results = this.Invoke("qryDaoLuYunShuCyryXinxi", new object[] {
                        xmlDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void qryDaoLuYunShuCyryXinxiAsync(string xmlDoc) {
            this.qryDaoLuYunShuCyryXinxiAsync(xmlDoc, null);
        }
        
        /// <remarks/>
        public void qryDaoLuYunShuCyryXinxiAsync(string xmlDoc, object userState) {
            if ((this.qryDaoLuYunShuCyryXinxiOperationCompleted == null)) {
                this.qryDaoLuYunShuCyryXinxiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnqryDaoLuYunShuCyryXinxiOperationCompleted);
            }
            this.InvokeAsync("qryDaoLuYunShuCyryXinxi", new object[] {
                        xmlDoc}, this.qryDaoLuYunShuCyryXinxiOperationCompleted, userState);
        }
        
        private void OnqryDaoLuYunShuCyryXinxiOperationCompleted(object arg) {
            if ((this.qryDaoLuYunShuCyryXinxiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.qryDaoLuYunShuCyryXinxiCompleted(this, new qryDaoLuYunShuCyryXinxiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pub.gyt.service.com/", ResponseNamespace="http://service.pub.gyt.service.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SendGytJinChuGangCheRenYuanXixi([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string xmlDoc) {
            object[] results = this.Invoke("SendGytJinChuGangCheRenYuanXixi", new object[] {
                        xmlDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendGytJinChuGangCheRenYuanXixiAsync(string xmlDoc) {
            this.SendGytJinChuGangCheRenYuanXixiAsync(xmlDoc, null);
        }
        
        /// <remarks/>
        public void SendGytJinChuGangCheRenYuanXixiAsync(string xmlDoc, object userState) {
            if ((this.SendGytJinChuGangCheRenYuanXixiOperationCompleted == null)) {
                this.SendGytJinChuGangCheRenYuanXixiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendGytJinChuGangCheRenYuanXixiOperationCompleted);
            }
            this.InvokeAsync("SendGytJinChuGangCheRenYuanXixi", new object[] {
                        xmlDoc}, this.SendGytJinChuGangCheRenYuanXixiOperationCompleted, userState);
        }
        
        private void OnSendGytJinChuGangCheRenYuanXixiOperationCompleted(object arg) {
            if ((this.SendGytJinChuGangCheRenYuanXixiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendGytJinChuGangCheRenYuanXixiCompleted(this, new SendGytJinChuGangCheRenYuanXixiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pub.gyt.service.com/", ResponseNamespace="http://service.pub.gyt.service.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string addGytIcKaSynchronizedOperator([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string xmlDoc) {
            object[] results = this.Invoke("addGytIcKaSynchronizedOperator", new object[] {
                        xmlDoc});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void addGytIcKaSynchronizedOperatorAsync(string xmlDoc) {
            this.addGytIcKaSynchronizedOperatorAsync(xmlDoc, null);
        }
        
        /// <remarks/>
        public void addGytIcKaSynchronizedOperatorAsync(string xmlDoc, object userState) {
            if ((this.addGytIcKaSynchronizedOperatorOperationCompleted == null)) {
                this.addGytIcKaSynchronizedOperatorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddGytIcKaSynchronizedOperatorOperationCompleted);
            }
            this.InvokeAsync("addGytIcKaSynchronizedOperator", new object[] {
                        xmlDoc}, this.addGytIcKaSynchronizedOperatorOperationCompleted, userState);
        }
        
        private void OnaddGytIcKaSynchronizedOperatorOperationCompleted(object arg) {
            if ((this.addGytIcKaSynchronizedOperatorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addGytIcKaSynchronizedOperatorCompleted(this, new addGytIcKaSynchronizedOperatorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void qryDaoLuYunShuCyryXinxiCompletedEventHandler(object sender, qryDaoLuYunShuCyryXinxiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class qryDaoLuYunShuCyryXinxiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal qryDaoLuYunShuCyryXinxiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void SendGytJinChuGangCheRenYuanXixiCompletedEventHandler(object sender, SendGytJinChuGangCheRenYuanXixiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendGytJinChuGangCheRenYuanXixiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendGytJinChuGangCheRenYuanXixiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void addGytIcKaSynchronizedOperatorCompletedEventHandler(object sender, addGytIcKaSynchronizedOperatorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addGytIcKaSynchronizedOperatorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addGytIcKaSynchronizedOperatorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591