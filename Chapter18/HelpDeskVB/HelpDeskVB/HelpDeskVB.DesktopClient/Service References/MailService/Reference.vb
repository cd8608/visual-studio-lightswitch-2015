﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
'
Namespace MailService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="MailService.IMailService")>  _
    Public Interface IMailService
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IMailService/SendMailSOAP", ReplyAction:="http://tempuri.org/IMailService/SendMailSOAPResponse")>  _
        Function BeginSendMailSOAP(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndSendMailSOAP(ByVal result As System.IAsyncResult) As String
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IMailService/SendMailREST", ReplyAction:="http://tempuri.org/IMailService/SendMailRESTResponse")>  _
        Function BeginSendMailREST(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndSendMailREST(ByVal result As System.IAsyncResult) As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IMailServiceChannel
        Inherits MailService.IMailService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SendMailSOAPCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As String
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SendMailRESTCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As String
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class MailServiceClient
        Inherits System.ServiceModel.ClientBase(Of MailService.IMailService)
        Implements MailService.IMailService
        
        Private onBeginSendMailSOAPDelegate As BeginOperationDelegate
        
        Private onEndSendMailSOAPDelegate As EndOperationDelegate
        
        Private onSendMailSOAPCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginSendMailRESTDelegate As BeginOperationDelegate
        
        Private onEndSendMailRESTDelegate As EndOperationDelegate
        
        Private onSendMailRESTCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Property CookieContainer() As System.Net.CookieContainer
            Get
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    Return httpCookieContainerManager.CookieContainer
                Else
                    Return Nothing
                End If
            End Get
            Set
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    httpCookieContainerManager.CookieContainer = value
                Else
                    Throw New System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC"& _ 
                            "ookieContainerBindingElement.")
                End If
            End Set
        End Property
        
        Public Event SendMailSOAPCompleted As System.EventHandler(Of SendMailSOAPCompletedEventArgs)
        
        Public Event SendMailRESTCompleted As System.EventHandler(Of SendMailRESTCompletedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_BeginSendMailSOAP(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMailSOAP
            Return MyBase.Channel.BeginSendMailSOAP(emailTo, subject, body, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_EndSendMailSOAP(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMailSOAP
            Return MyBase.Channel.EndSendMailSOAP(result)
        End Function
        
        Private Function OnBeginSendMailSOAP(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim emailTo As String = CType(inValues(0),String)
            Dim subject As String = CType(inValues(1),String)
            Dim body As String = CType(inValues(2),String)
            Return CType(Me,MailService.IMailService).BeginSendMailSOAP(emailTo, subject, body, callback, asyncState)
        End Function
        
        Private Function OnEndSendMailSOAP(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As String = CType(Me,MailService.IMailService).EndSendMailSOAP(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnSendMailSOAPCompleted(ByVal state As Object)
            If (Not (Me.SendMailSOAPCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent SendMailSOAPCompleted(Me, New SendMailSOAPCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub SendMailSOAPAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String)
            Me.SendMailSOAPAsync(emailTo, subject, body, Nothing)
        End Sub
        
        Public Overloads Sub SendMailSOAPAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal userState As Object)
            If (Me.onBeginSendMailSOAPDelegate Is Nothing) Then
                Me.onBeginSendMailSOAPDelegate = AddressOf Me.OnBeginSendMailSOAP
            End If
            If (Me.onEndSendMailSOAPDelegate Is Nothing) Then
                Me.onEndSendMailSOAPDelegate = AddressOf Me.OnEndSendMailSOAP
            End If
            If (Me.onSendMailSOAPCompletedDelegate Is Nothing) Then
                Me.onSendMailSOAPCompletedDelegate = AddressOf Me.OnSendMailSOAPCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginSendMailSOAPDelegate, New Object() {emailTo, subject, body}, Me.onEndSendMailSOAPDelegate, Me.onSendMailSOAPCompletedDelegate, userState)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_BeginSendMailREST(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMailREST
            Return MyBase.Channel.BeginSendMailREST(emailTo, subject, body, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_EndSendMailREST(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMailREST
            Return MyBase.Channel.EndSendMailREST(result)
        End Function
        
        Private Function OnBeginSendMailREST(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim emailTo As String = CType(inValues(0),String)
            Dim subject As String = CType(inValues(1),String)
            Dim body As String = CType(inValues(2),String)
            Return CType(Me,MailService.IMailService).BeginSendMailREST(emailTo, subject, body, callback, asyncState)
        End Function
        
        Private Function OnEndSendMailREST(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As String = CType(Me,MailService.IMailService).EndSendMailREST(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnSendMailRESTCompleted(ByVal state As Object)
            If (Not (Me.SendMailRESTCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent SendMailRESTCompleted(Me, New SendMailRESTCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub SendMailRESTAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String)
            Me.SendMailRESTAsync(emailTo, subject, body, Nothing)
        End Sub
        
        Public Overloads Sub SendMailRESTAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal userState As Object)
            If (Me.onBeginSendMailRESTDelegate Is Nothing) Then
                Me.onBeginSendMailRESTDelegate = AddressOf Me.OnBeginSendMailREST
            End If
            If (Me.onEndSendMailRESTDelegate Is Nothing) Then
                Me.onEndSendMailRESTDelegate = AddressOf Me.OnEndSendMailREST
            End If
            If (Me.onSendMailRESTCompletedDelegate Is Nothing) Then
                Me.onSendMailRESTCompletedDelegate = AddressOf Me.OnSendMailRESTCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginSendMailRESTDelegate, New Object() {emailTo, subject, body}, Me.onEndSendMailRESTDelegate, Me.onSendMailRESTCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(callback, asyncState)
        End Function
        
        Private Function OnEndOpen(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndOpen(result)
            Return Nothing
        End Function
        
        Private Sub OnOpenCompleted(ByVal state As Object)
            If (Not (Me.OpenCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent OpenCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub OpenAsync()
            Me.OpenAsync(Nothing)
        End Sub
        
        Public Overloads Sub OpenAsync(ByVal userState As Object)
            If (Me.onBeginOpenDelegate Is Nothing) Then
                Me.onBeginOpenDelegate = AddressOf Me.OnBeginOpen
            End If
            If (Me.onEndOpenDelegate Is Nothing) Then
                Me.onEndOpenDelegate = AddressOf Me.OnEndOpen
            End If
            If (Me.onOpenCompletedDelegate Is Nothing) Then
                Me.onOpenCompletedDelegate = AddressOf Me.OnOpenCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginOpenDelegate, Nothing, Me.onEndOpenDelegate, Me.onOpenCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginClose(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(callback, asyncState)
        End Function
        
        Private Function OnEndClose(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndClose(result)
            Return Nothing
        End Function
        
        Private Sub OnCloseCompleted(ByVal state As Object)
            If (Not (Me.CloseCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent CloseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub CloseAsync()
            Me.CloseAsync(Nothing)
        End Sub
        
        Public Overloads Sub CloseAsync(ByVal userState As Object)
            If (Me.onBeginCloseDelegate Is Nothing) Then
                Me.onBeginCloseDelegate = AddressOf Me.OnBeginClose
            End If
            If (Me.onEndCloseDelegate Is Nothing) Then
                Me.onEndCloseDelegate = AddressOf Me.OnEndClose
            End If
            If (Me.onCloseCompletedDelegate Is Nothing) Then
                Me.onCloseCompletedDelegate = AddressOf Me.OnCloseCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginCloseDelegate, Nothing, Me.onEndCloseDelegate, Me.onCloseCompletedDelegate, userState)
        End Sub
        
        Protected Overrides Function CreateChannel() As MailService.IMailService
            Return New MailServiceClientChannel(Me)
        End Function
        
        Private Class MailServiceClientChannel
            Inherits ChannelBase(Of MailService.IMailService)
            Implements MailService.IMailService
            
            Public Sub New(ByVal client As System.ServiceModel.ClientBase(Of MailService.IMailService))
                MyBase.New(client)
            End Sub
            
            Public Function BeginSendMailSOAP(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMailSOAP
                Dim _args((3) - 1) As Object
                _args(0) = emailTo
                _args(1) = subject
                _args(2) = body
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("SendMailSOAP", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndSendMailSOAP(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMailSOAP
                Dim _args((0) - 1) As Object
                Dim _result As String = CType(MyBase.EndInvoke("SendMailSOAP", _args, result),String)
                Return _result
            End Function
            
            Public Function BeginSendMailREST(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMailREST
                Dim _args((3) - 1) As Object
                _args(0) = emailTo
                _args(1) = subject
                _args(2) = body
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("SendMailREST", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndSendMailREST(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMailREST
                Dim _args((0) - 1) As Object
                Dim _result As String = CType(MyBase.EndInvoke("SendMailREST", _args, result),String)
                Return _result
            End Function
        End Class
    End Class
End Namespace
