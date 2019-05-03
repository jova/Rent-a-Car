﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop.RentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rentalinformation", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Rentalinformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private int HowManyDaysField;
        
        private int StartKmField;
        
        private int LastKmField;
        
        private int PaymentField;
        
        private bool IsActiveField;
        
        private int VehicleIDField;
        
        private int CustomerIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int HowManyDays {
            get {
                return this.HowManyDaysField;
            }
            set {
                if ((this.HowManyDaysField.Equals(value) != true)) {
                    this.HowManyDaysField = value;
                    this.RaisePropertyChanged("HowManyDays");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int StartKm {
            get {
                return this.StartKmField;
            }
            set {
                if ((this.StartKmField.Equals(value) != true)) {
                    this.StartKmField = value;
                    this.RaisePropertyChanged("StartKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int LastKm {
            get {
                return this.LastKmField;
            }
            set {
                if ((this.LastKmField.Equals(value) != true)) {
                    this.LastKmField = value;
                    this.RaisePropertyChanged("LastKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Payment {
            get {
                return this.PaymentField;
            }
            set {
                if ((this.PaymentField.Equals(value) != true)) {
                    this.PaymentField = value;
                    this.RaisePropertyChanged("Payment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int VehicleID {
            get {
                return this.VehicleIDField;
            }
            set {
                if ((this.VehicleIDField.Equals(value) != true)) {
                    this.VehicleIDField = value;
                    this.RaisePropertyChanged("VehicleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RentServiceReference.RentServiceSoap")]
    public interface RentServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        Desktop.RentServiceReference.GetResponse Get(Desktop.RentServiceReference.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.RentServiceReference.GetResponse> GetAsync(Desktop.RentServiceReference.GetRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        Desktop.RentServiceReference.GetAllResponse GetAll(Desktop.RentServiceReference.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.RentServiceReference.GetAllResponse> GetAllAsync(Desktop.RentServiceReference.GetAllRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.RentServiceReference.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(Desktop.RentServiceReference.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int rentalId;
        
        public GetRequestBody() {
        }
        
        public GetRequestBody(int rentalId) {
            this.rentalId = rentalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.RentServiceReference.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(Desktop.RentServiceReference.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Desktop.RentServiceReference.Rentalinformation GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(Desktop.RentServiceReference.Rentalinformation GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.RentServiceReference.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(Desktop.RentServiceReference.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.RentServiceReference.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(Desktop.RentServiceReference.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Desktop.RentServiceReference.Rentalinformation[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(Desktop.RentServiceReference.Rentalinformation[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RentServiceSoapChannel : Desktop.RentServiceReference.RentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RentServiceSoapClient : System.ServiceModel.ClientBase<Desktop.RentServiceReference.RentServiceSoap>, Desktop.RentServiceReference.RentServiceSoap {
        
        public RentServiceSoapClient() {
        }
        
        public RentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.RentServiceReference.GetResponse Desktop.RentServiceReference.RentServiceSoap.Get(Desktop.RentServiceReference.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public Desktop.RentServiceReference.Rentalinformation Get(int rentalId) {
            Desktop.RentServiceReference.GetRequest inValue = new Desktop.RentServiceReference.GetRequest();
            inValue.Body = new Desktop.RentServiceReference.GetRequestBody();
            inValue.Body.rentalId = rentalId;
            Desktop.RentServiceReference.GetResponse retVal = ((Desktop.RentServiceReference.RentServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.RentServiceReference.GetResponse> Desktop.RentServiceReference.RentServiceSoap.GetAsync(Desktop.RentServiceReference.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.RentServiceReference.GetResponse> GetAsync(int rentalId) {
            Desktop.RentServiceReference.GetRequest inValue = new Desktop.RentServiceReference.GetRequest();
            inValue.Body = new Desktop.RentServiceReference.GetRequestBody();
            inValue.Body.rentalId = rentalId;
            return ((Desktop.RentServiceReference.RentServiceSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.RentServiceReference.GetAllResponse Desktop.RentServiceReference.RentServiceSoap.GetAll(Desktop.RentServiceReference.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public Desktop.RentServiceReference.Rentalinformation[] GetAll() {
            Desktop.RentServiceReference.GetAllRequest inValue = new Desktop.RentServiceReference.GetAllRequest();
            inValue.Body = new Desktop.RentServiceReference.GetAllRequestBody();
            Desktop.RentServiceReference.GetAllResponse retVal = ((Desktop.RentServiceReference.RentServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.RentServiceReference.GetAllResponse> Desktop.RentServiceReference.RentServiceSoap.GetAllAsync(Desktop.RentServiceReference.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.RentServiceReference.GetAllResponse> GetAllAsync() {
            Desktop.RentServiceReference.GetAllRequest inValue = new Desktop.RentServiceReference.GetAllRequest();
            inValue.Body = new Desktop.RentServiceReference.GetAllRequestBody();
            return ((Desktop.RentServiceReference.RentServiceSoap)(this)).GetAllAsync(inValue);
        }
    }
}