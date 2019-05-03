﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop.VehicleServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleInformation", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class VehicleInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        private int MinLicenseAgeField;
        
        private int MinAgeField;
        
        private int DailyBorderKmField;
        
        private bool AirbagField;
        
        private int BaggageVolumeField;
        
        private int SeatingCapacityField;
        
        private int DailyRentalPriceField;
        
        private int CompanyIDField;
        
        private int CustomerIDField;
        
        private bool isRentaledField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int MinLicenseAge {
            get {
                return this.MinLicenseAgeField;
            }
            set {
                if ((this.MinLicenseAgeField.Equals(value) != true)) {
                    this.MinLicenseAgeField = value;
                    this.RaisePropertyChanged("MinLicenseAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int MinAge {
            get {
                return this.MinAgeField;
            }
            set {
                if ((this.MinAgeField.Equals(value) != true)) {
                    this.MinAgeField = value;
                    this.RaisePropertyChanged("MinAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int DailyBorderKm {
            get {
                return this.DailyBorderKmField;
            }
            set {
                if ((this.DailyBorderKmField.Equals(value) != true)) {
                    this.DailyBorderKmField = value;
                    this.RaisePropertyChanged("DailyBorderKm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public bool Airbag {
            get {
                return this.AirbagField;
            }
            set {
                if ((this.AirbagField.Equals(value) != true)) {
                    this.AirbagField = value;
                    this.RaisePropertyChanged("Airbag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int BaggageVolume {
            get {
                return this.BaggageVolumeField;
            }
            set {
                if ((this.BaggageVolumeField.Equals(value) != true)) {
                    this.BaggageVolumeField = value;
                    this.RaisePropertyChanged("BaggageVolume");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int SeatingCapacity {
            get {
                return this.SeatingCapacityField;
            }
            set {
                if ((this.SeatingCapacityField.Equals(value) != true)) {
                    this.SeatingCapacityField = value;
                    this.RaisePropertyChanged("SeatingCapacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public int DailyRentalPrice {
            get {
                return this.DailyRentalPriceField;
            }
            set {
                if ((this.DailyRentalPriceField.Equals(value) != true)) {
                    this.DailyRentalPriceField = value;
                    this.RaisePropertyChanged("DailyRentalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public int CompanyID {
            get {
                return this.CompanyIDField;
            }
            set {
                if ((this.CompanyIDField.Equals(value) != true)) {
                    this.CompanyIDField = value;
                    this.RaisePropertyChanged("CompanyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public bool isRentaled {
            get {
                return this.isRentaledField;
            }
            set {
                if ((this.isRentaledField.Equals(value) != true)) {
                    this.isRentaledField = value;
                    this.RaisePropertyChanged("isRentaled");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VehicleServiceReference.VehicleServiceServiceSoap")]
    public interface VehicleServiceServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        Desktop.VehicleServiceReference.GetAllResponse GetAll(Desktop.VehicleServiceReference.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetAllResponse> GetAllAsync(Desktop.VehicleServiceReference.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name GetRentaledVehiclesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRentaledVehicles", ReplyAction="*")]
        Desktop.VehicleServiceReference.GetRentaledVehiclesResponse GetRentaledVehicles(Desktop.VehicleServiceReference.GetRentaledVehiclesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRentaledVehicles", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetRentaledVehiclesResponse> GetRentaledVehiclesAsync(Desktop.VehicleServiceReference.GetRentaledVehiclesRequest request);
        
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        Desktop.VehicleServiceReference.GetResponse Get(Desktop.VehicleServiceReference.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetResponse> GetAsync(Desktop.VehicleServiceReference.GetRequest request);
        
        // CODEGEN: Generating message contract since element name rental from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RentACar", ReplyAction="*")]
        Desktop.VehicleServiceReference.RentACarResponse RentACar(Desktop.VehicleServiceReference.RentACarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RentACar", ReplyAction="*")]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.RentACarResponse> RentACarAsync(Desktop.VehicleServiceReference.RentACarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UnRentACar", ReplyAction="*")]
        bool UnRentACar(int vehicleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UnRentACar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> UnRentACarAsync(int vehicleId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(Desktop.VehicleServiceReference.GetAllRequestBody Body) {
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
        public Desktop.VehicleServiceReference.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(Desktop.VehicleServiceReference.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Desktop.VehicleServiceReference.VehicleInformation[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(Desktop.VehicleServiceReference.VehicleInformation[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRentaledVehiclesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRentaledVehicles", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.GetRentaledVehiclesRequestBody Body;
        
        public GetRentaledVehiclesRequest() {
        }
        
        public GetRentaledVehiclesRequest(Desktop.VehicleServiceReference.GetRentaledVehiclesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRentaledVehiclesRequestBody {
        
        public GetRentaledVehiclesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRentaledVehiclesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRentaledVehiclesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.GetRentaledVehiclesResponseBody Body;
        
        public GetRentaledVehiclesResponse() {
        }
        
        public GetRentaledVehiclesResponse(Desktop.VehicleServiceReference.GetRentaledVehiclesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRentaledVehiclesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Desktop.VehicleServiceReference.VehicleInformation[] GetRentaledVehiclesResult;
        
        public GetRentaledVehiclesResponseBody() {
        }
        
        public GetRentaledVehiclesResponseBody(Desktop.VehicleServiceReference.VehicleInformation[] GetRentaledVehiclesResult) {
            this.GetRentaledVehiclesResult = GetRentaledVehiclesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.GetRequestBody Body;
        
        public GetRequest() {
        }
        
        public GetRequest(Desktop.VehicleServiceReference.GetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int vehicleId;
        
        public GetRequestBody() {
        }
        
        public GetRequestBody(int vehicleId) {
            this.vehicleId = vehicleId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.GetResponseBody Body;
        
        public GetResponse() {
        }
        
        public GetResponse(Desktop.VehicleServiceReference.GetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Desktop.VehicleServiceReference.VehicleInformation GetResult;
        
        public GetResponseBody() {
        }
        
        public GetResponseBody(Desktop.VehicleServiceReference.VehicleInformation GetResult) {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RentACarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RentACar", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.RentACarRequestBody Body;
        
        public RentACarRequest() {
        }
        
        public RentACarRequest(Desktop.VehicleServiceReference.RentACarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RentACarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int vehicleId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int customerId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public Desktop.VehicleServiceReference.Rentalinformation rental;
        
        public RentACarRequestBody() {
        }
        
        public RentACarRequestBody(int vehicleId, int customerId, Desktop.VehicleServiceReference.Rentalinformation rental) {
            this.vehicleId = vehicleId;
            this.customerId = customerId;
            this.rental = rental;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RentACarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RentACarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Desktop.VehicleServiceReference.RentACarResponseBody Body;
        
        public RentACarResponse() {
        }
        
        public RentACarResponse(Desktop.VehicleServiceReference.RentACarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RentACarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RentACarResult;
        
        public RentACarResponseBody() {
        }
        
        public RentACarResponseBody(bool RentACarResult) {
            this.RentACarResult = RentACarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VehicleServiceServiceSoapChannel : Desktop.VehicleServiceReference.VehicleServiceServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VehicleServiceServiceSoapClient : System.ServiceModel.ClientBase<Desktop.VehicleServiceReference.VehicleServiceServiceSoap>, Desktop.VehicleServiceReference.VehicleServiceServiceSoap {
        
        public VehicleServiceServiceSoapClient() {
        }
        
        public VehicleServiceServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VehicleServiceServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.VehicleServiceReference.GetAllResponse Desktop.VehicleServiceReference.VehicleServiceServiceSoap.GetAll(Desktop.VehicleServiceReference.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public Desktop.VehicleServiceReference.VehicleInformation[] GetAll() {
            Desktop.VehicleServiceReference.GetAllRequest inValue = new Desktop.VehicleServiceReference.GetAllRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetAllRequestBody();
            Desktop.VehicleServiceReference.GetAllResponse retVal = ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetAllResponse> Desktop.VehicleServiceReference.VehicleServiceServiceSoap.GetAllAsync(Desktop.VehicleServiceReference.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetAllResponse> GetAllAsync() {
            Desktop.VehicleServiceReference.GetAllRequest inValue = new Desktop.VehicleServiceReference.GetAllRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetAllRequestBody();
            return ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.VehicleServiceReference.GetRentaledVehiclesResponse Desktop.VehicleServiceReference.VehicleServiceServiceSoap.GetRentaledVehicles(Desktop.VehicleServiceReference.GetRentaledVehiclesRequest request) {
            return base.Channel.GetRentaledVehicles(request);
        }
        
        public Desktop.VehicleServiceReference.VehicleInformation[] GetRentaledVehicles() {
            Desktop.VehicleServiceReference.GetRentaledVehiclesRequest inValue = new Desktop.VehicleServiceReference.GetRentaledVehiclesRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetRentaledVehiclesRequestBody();
            Desktop.VehicleServiceReference.GetRentaledVehiclesResponse retVal = ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).GetRentaledVehicles(inValue);
            return retVal.Body.GetRentaledVehiclesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetRentaledVehiclesResponse> Desktop.VehicleServiceReference.VehicleServiceServiceSoap.GetRentaledVehiclesAsync(Desktop.VehicleServiceReference.GetRentaledVehiclesRequest request) {
            return base.Channel.GetRentaledVehiclesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetRentaledVehiclesResponse> GetRentaledVehiclesAsync() {
            Desktop.VehicleServiceReference.GetRentaledVehiclesRequest inValue = new Desktop.VehicleServiceReference.GetRentaledVehiclesRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetRentaledVehiclesRequestBody();
            return ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).GetRentaledVehiclesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.VehicleServiceReference.GetResponse Desktop.VehicleServiceReference.VehicleServiceServiceSoap.Get(Desktop.VehicleServiceReference.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public Desktop.VehicleServiceReference.VehicleInformation Get(int vehicleId) {
            Desktop.VehicleServiceReference.GetRequest inValue = new Desktop.VehicleServiceReference.GetRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetRequestBody();
            inValue.Body.vehicleId = vehicleId;
            Desktop.VehicleServiceReference.GetResponse retVal = ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetResponse> Desktop.VehicleServiceReference.VehicleServiceServiceSoap.GetAsync(Desktop.VehicleServiceReference.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.VehicleServiceReference.GetResponse> GetAsync(int vehicleId) {
            Desktop.VehicleServiceReference.GetRequest inValue = new Desktop.VehicleServiceReference.GetRequest();
            inValue.Body = new Desktop.VehicleServiceReference.GetRequestBody();
            inValue.Body.vehicleId = vehicleId;
            return ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Desktop.VehicleServiceReference.RentACarResponse Desktop.VehicleServiceReference.VehicleServiceServiceSoap.RentACar(Desktop.VehicleServiceReference.RentACarRequest request) {
            return base.Channel.RentACar(request);
        }
        
        public bool RentACar(int vehicleId, int customerId, Desktop.VehicleServiceReference.Rentalinformation rental) {
            Desktop.VehicleServiceReference.RentACarRequest inValue = new Desktop.VehicleServiceReference.RentACarRequest();
            inValue.Body = new Desktop.VehicleServiceReference.RentACarRequestBody();
            inValue.Body.vehicleId = vehicleId;
            inValue.Body.customerId = customerId;
            inValue.Body.rental = rental;
            Desktop.VehicleServiceReference.RentACarResponse retVal = ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).RentACar(inValue);
            return retVal.Body.RentACarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Desktop.VehicleServiceReference.RentACarResponse> Desktop.VehicleServiceReference.VehicleServiceServiceSoap.RentACarAsync(Desktop.VehicleServiceReference.RentACarRequest request) {
            return base.Channel.RentACarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Desktop.VehicleServiceReference.RentACarResponse> RentACarAsync(int vehicleId, int customerId, Desktop.VehicleServiceReference.Rentalinformation rental) {
            Desktop.VehicleServiceReference.RentACarRequest inValue = new Desktop.VehicleServiceReference.RentACarRequest();
            inValue.Body = new Desktop.VehicleServiceReference.RentACarRequestBody();
            inValue.Body.vehicleId = vehicleId;
            inValue.Body.customerId = customerId;
            inValue.Body.rental = rental;
            return ((Desktop.VehicleServiceReference.VehicleServiceServiceSoap)(this)).RentACarAsync(inValue);
        }
        
        public bool UnRentACar(int vehicleId) {
            return base.Channel.UnRentACar(vehicleId);
        }
        
        public System.Threading.Tasks.Task<bool> UnRentACarAsync(int vehicleId) {
            return base.Channel.UnRentACarAsync(vehicleId);
        }
    }
}
