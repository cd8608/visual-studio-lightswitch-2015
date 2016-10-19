﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace LightSwitchApplication.MailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailService.IMailService")]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMailService/SendMailSOAP", ReplyAction="http://tempuri.org/IMailService/SendMailSOAPResponse")]
        System.IAsyncResult BeginSendMailSOAP(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState);
        
        string EndSendMailSOAP(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMailService/SendMailREST", ReplyAction="http://tempuri.org/IMailService/SendMailRESTResponse")]
        System.IAsyncResult BeginSendMailREST(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState);
        
        string EndSendMailREST(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : LightSwitchApplication.MailService.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMailSOAPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SendMailSOAPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMailRESTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SendMailRESTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.ClientBase<LightSwitchApplication.MailService.IMailService>, LightSwitchApplication.MailService.IMailService {
        
        private BeginOperationDelegate onBeginSendMailSOAPDelegate;
        
        private EndOperationDelegate onEndSendMailSOAPDelegate;
        
        private System.Threading.SendOrPostCallback onSendMailSOAPCompletedDelegate;
        
        private BeginOperationDelegate onBeginSendMailRESTDelegate;
        
        private EndOperationDelegate onEndSendMailRESTDelegate;
        
        private System.Threading.SendOrPostCallback onSendMailRESTCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MailServiceClient() {
        }
        
        public MailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<SendMailSOAPCompletedEventArgs> SendMailSOAPCompleted;
        
        public event System.EventHandler<SendMailRESTCompletedEventArgs> SendMailRESTCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult LightSwitchApplication.MailService.IMailService.BeginSendMailSOAP(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSendMailSOAP(emailTo, subject, body, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string LightSwitchApplication.MailService.IMailService.EndSendMailSOAP(System.IAsyncResult result) {
            return base.Channel.EndSendMailSOAP(result);
        }
        
        private System.IAsyncResult OnBeginSendMailSOAP(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string emailTo = ((string)(inValues[0]));
            string subject = ((string)(inValues[1]));
            string body = ((string)(inValues[2]));
            return ((LightSwitchApplication.MailService.IMailService)(this)).BeginSendMailSOAP(emailTo, subject, body, callback, asyncState);
        }
        
        private object[] OnEndSendMailSOAP(System.IAsyncResult result) {
            string retVal = ((LightSwitchApplication.MailService.IMailService)(this)).EndSendMailSOAP(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSendMailSOAPCompleted(object state) {
            if ((this.SendMailSOAPCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendMailSOAPCompleted(this, new SendMailSOAPCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SendMailSOAPAsync(string emailTo, string subject, string body) {
            this.SendMailSOAPAsync(emailTo, subject, body, null);
        }
        
        public void SendMailSOAPAsync(string emailTo, string subject, string body, object userState) {
            if ((this.onBeginSendMailSOAPDelegate == null)) {
                this.onBeginSendMailSOAPDelegate = new BeginOperationDelegate(this.OnBeginSendMailSOAP);
            }
            if ((this.onEndSendMailSOAPDelegate == null)) {
                this.onEndSendMailSOAPDelegate = new EndOperationDelegate(this.OnEndSendMailSOAP);
            }
            if ((this.onSendMailSOAPCompletedDelegate == null)) {
                this.onSendMailSOAPCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendMailSOAPCompleted);
            }
            base.InvokeAsync(this.onBeginSendMailSOAPDelegate, new object[] {
                        emailTo,
                        subject,
                        body}, this.onEndSendMailSOAPDelegate, this.onSendMailSOAPCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult LightSwitchApplication.MailService.IMailService.BeginSendMailREST(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSendMailREST(emailTo, subject, body, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string LightSwitchApplication.MailService.IMailService.EndSendMailREST(System.IAsyncResult result) {
            return base.Channel.EndSendMailREST(result);
        }
        
        private System.IAsyncResult OnBeginSendMailREST(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string emailTo = ((string)(inValues[0]));
            string subject = ((string)(inValues[1]));
            string body = ((string)(inValues[2]));
            return ((LightSwitchApplication.MailService.IMailService)(this)).BeginSendMailREST(emailTo, subject, body, callback, asyncState);
        }
        
        private object[] OnEndSendMailREST(System.IAsyncResult result) {
            string retVal = ((LightSwitchApplication.MailService.IMailService)(this)).EndSendMailREST(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSendMailRESTCompleted(object state) {
            if ((this.SendMailRESTCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendMailRESTCompleted(this, new SendMailRESTCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SendMailRESTAsync(string emailTo, string subject, string body) {
            this.SendMailRESTAsync(emailTo, subject, body, null);
        }
        
        public void SendMailRESTAsync(string emailTo, string subject, string body, object userState) {
            if ((this.onBeginSendMailRESTDelegate == null)) {
                this.onBeginSendMailRESTDelegate = new BeginOperationDelegate(this.OnBeginSendMailREST);
            }
            if ((this.onEndSendMailRESTDelegate == null)) {
                this.onEndSendMailRESTDelegate = new EndOperationDelegate(this.OnEndSendMailREST);
            }
            if ((this.onSendMailRESTCompletedDelegate == null)) {
                this.onSendMailRESTCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendMailRESTCompleted);
            }
            base.InvokeAsync(this.onBeginSendMailRESTDelegate, new object[] {
                        emailTo,
                        subject,
                        body}, this.onEndSendMailRESTDelegate, this.onSendMailRESTCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override LightSwitchApplication.MailService.IMailService CreateChannel() {
            return new MailServiceClientChannel(this);
        }
        
        private class MailServiceClientChannel : ChannelBase<LightSwitchApplication.MailService.IMailService>, LightSwitchApplication.MailService.IMailService {
            
            public MailServiceClientChannel(System.ServiceModel.ClientBase<LightSwitchApplication.MailService.IMailService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSendMailSOAP(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = emailTo;
                _args[1] = subject;
                _args[2] = body;
                System.IAsyncResult _result = base.BeginInvoke("SendMailSOAP", _args, callback, asyncState);
                return _result;
            }
            
            public string EndSendMailSOAP(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("SendMailSOAP", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginSendMailREST(string emailTo, string subject, string body, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = emailTo;
                _args[1] = subject;
                _args[2] = body;
                System.IAsyncResult _result = base.BeginInvoke("SendMailREST", _args, callback, asyncState);
                return _result;
            }
            
            public string EndSendMailREST(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("SendMailREST", _args, result)));
                return _result;
            }
        }
    }
}
