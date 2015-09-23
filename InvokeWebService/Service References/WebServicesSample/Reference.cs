﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvokeWebService.WebServicesSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2014", ConfigurationName="WebServicesSample.SampleServiceSoap")]
    public interface SampleServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2014/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.wrox.com/BeginningCSharp/2014/HelloWorld", ReplyAction="*")]
        System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState);
        
        string EndHelloWorld(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2014/ReverseString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ReverseString(string message);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.wrox.com/BeginningCSharp/2014/ReverseString", ReplyAction="*")]
        System.IAsyncResult BeginReverseString(string message, System.AsyncCallback callback, object asyncState);
        
        string EndReverseString(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/BeginningCSharp/2014/GetWeather", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        InvokeWebService.WebServicesSample.GetWeatherResponse GetWeather(InvokeWebService.WebServicesSample.GetWeatherRequest req);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.wrox.com/BeginningCSharp/2014/GetWeather", ReplyAction="*")]
        System.IAsyncResult BeginGetWeather(InvokeWebService.WebServicesSample.GetWeatherRequest req, System.AsyncCallback callback, object asyncState);
        
        InvokeWebService.WebServicesSample.GetWeatherResponse EndGetWeather(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2014")]
    public partial class GetWeatherRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private TemperatureType temperatureTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TemperatureType TemperatureType {
            get {
                return this.temperatureTypeField;
            }
            set {
                this.temperatureTypeField = value;
                this.RaisePropertyChanged("TemperatureType");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2014")]
    public enum TemperatureType {
        
        /// <remarks/>
        Fahrenheit,
        
        /// <remarks/>
        Celsius,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2014")]
    public partial class GetWeatherResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TemperatureCondition temperatureConditionField;
        
        private int temperatureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TemperatureCondition TemperatureCondition {
            get {
                return this.temperatureConditionField;
            }
            set {
                this.temperatureConditionField = value;
                this.RaisePropertyChanged("TemperatureCondition");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
                this.RaisePropertyChanged("Temperature");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/BeginningCSharp/2014")]
    public enum TemperatureCondition {
        
        /// <remarks/>
        Rainy,
        
        /// <remarks/>
        Sunny,
        
        /// <remarks/>
        Cloudy,
        
        /// <remarks/>
        Thunderstorm,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleServiceSoapChannel : InvokeWebService.WebServicesSample.SampleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class ReverseStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ReverseStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class GetWeatherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetWeatherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public InvokeWebService.WebServicesSample.GetWeatherResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((InvokeWebService.WebServicesSample.GetWeatherResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceSoapClient : System.ServiceModel.ClientBase<InvokeWebService.WebServicesSample.SampleServiceSoap>, InvokeWebService.WebServicesSample.SampleServiceSoap {
        
        private BeginOperationDelegate onBeginHelloWorldDelegate;
        
        private EndOperationDelegate onEndHelloWorldDelegate;
        
        private System.Threading.SendOrPostCallback onHelloWorldCompletedDelegate;
        
        private BeginOperationDelegate onBeginReverseStringDelegate;
        
        private EndOperationDelegate onEndReverseStringDelegate;
        
        private System.Threading.SendOrPostCallback onReverseStringCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetWeatherDelegate;
        
        private EndOperationDelegate onEndGetWeatherDelegate;
        
        private System.Threading.SendOrPostCallback onGetWeatherCompletedDelegate;
        
        public SampleServiceSoapClient() {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<HelloWorldCompletedEventArgs> HelloWorldCompleted;
        
        public event System.EventHandler<ReverseStringCompletedEventArgs> ReverseStringCompleted;
        
        public event System.EventHandler<GetWeatherCompletedEventArgs> GetWeatherCompleted;
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHelloWorld(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHelloWorld(System.IAsyncResult result) {
            return base.Channel.EndHelloWorld(result);
        }
        
        private System.IAsyncResult OnBeginHelloWorld(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginHelloWorld(callback, asyncState);
        }
        
        private object[] OnEndHelloWorld(System.IAsyncResult result) {
            string retVal = this.EndHelloWorld(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloWorldCompleted(object state) {
            if ((this.HelloWorldCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        public void HelloWorldAsync(object userState) {
            if ((this.onBeginHelloWorldDelegate == null)) {
                this.onBeginHelloWorldDelegate = new BeginOperationDelegate(this.OnBeginHelloWorld);
            }
            if ((this.onEndHelloWorldDelegate == null)) {
                this.onEndHelloWorldDelegate = new EndOperationDelegate(this.OnEndHelloWorld);
            }
            if ((this.onHelloWorldCompletedDelegate == null)) {
                this.onHelloWorldCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloWorldCompleted);
            }
            base.InvokeAsync(this.onBeginHelloWorldDelegate, null, this.onEndHelloWorldDelegate, this.onHelloWorldCompletedDelegate, userState);
        }
        
        public string ReverseString(string message) {
            return base.Channel.ReverseString(message);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginReverseString(string message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginReverseString(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndReverseString(System.IAsyncResult result) {
            return base.Channel.EndReverseString(result);
        }
        
        private System.IAsyncResult OnBeginReverseString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string message = ((string)(inValues[0]));
            return this.BeginReverseString(message, callback, asyncState);
        }
        
        private object[] OnEndReverseString(System.IAsyncResult result) {
            string retVal = this.EndReverseString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnReverseStringCompleted(object state) {
            if ((this.ReverseStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ReverseStringCompleted(this, new ReverseStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ReverseStringAsync(string message) {
            this.ReverseStringAsync(message, null);
        }
        
        public void ReverseStringAsync(string message, object userState) {
            if ((this.onBeginReverseStringDelegate == null)) {
                this.onBeginReverseStringDelegate = new BeginOperationDelegate(this.OnBeginReverseString);
            }
            if ((this.onEndReverseStringDelegate == null)) {
                this.onEndReverseStringDelegate = new EndOperationDelegate(this.OnEndReverseString);
            }
            if ((this.onReverseStringCompletedDelegate == null)) {
                this.onReverseStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnReverseStringCompleted);
            }
            base.InvokeAsync(this.onBeginReverseStringDelegate, new object[] {
                        message}, this.onEndReverseStringDelegate, this.onReverseStringCompletedDelegate, userState);
        }
        
        public InvokeWebService.WebServicesSample.GetWeatherResponse GetWeather(InvokeWebService.WebServicesSample.GetWeatherRequest req) {
            return base.Channel.GetWeather(req);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetWeather(InvokeWebService.WebServicesSample.GetWeatherRequest req, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetWeather(req, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public InvokeWebService.WebServicesSample.GetWeatherResponse EndGetWeather(System.IAsyncResult result) {
            return base.Channel.EndGetWeather(result);
        }
        
        private System.IAsyncResult OnBeginGetWeather(object[] inValues, System.AsyncCallback callback, object asyncState) {
            InvokeWebService.WebServicesSample.GetWeatherRequest req = ((InvokeWebService.WebServicesSample.GetWeatherRequest)(inValues[0]));
            return this.BeginGetWeather(req, callback, asyncState);
        }
        
        private object[] OnEndGetWeather(System.IAsyncResult result) {
            InvokeWebService.WebServicesSample.GetWeatherResponse retVal = this.EndGetWeather(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetWeatherCompleted(object state) {
            if ((this.GetWeatherCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetWeatherCompleted(this, new GetWeatherCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetWeatherAsync(InvokeWebService.WebServicesSample.GetWeatherRequest req) {
            this.GetWeatherAsync(req, null);
        }
        
        public void GetWeatherAsync(InvokeWebService.WebServicesSample.GetWeatherRequest req, object userState) {
            if ((this.onBeginGetWeatherDelegate == null)) {
                this.onBeginGetWeatherDelegate = new BeginOperationDelegate(this.OnBeginGetWeather);
            }
            if ((this.onEndGetWeatherDelegate == null)) {
                this.onEndGetWeatherDelegate = new EndOperationDelegate(this.OnEndGetWeather);
            }
            if ((this.onGetWeatherCompletedDelegate == null)) {
                this.onGetWeatherCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetWeatherCompleted);
            }
            base.InvokeAsync(this.onBeginGetWeatherDelegate, new object[] {
                        req}, this.onEndGetWeatherDelegate, this.onGetWeatherCompletedDelegate, userState);
        }
    }
}