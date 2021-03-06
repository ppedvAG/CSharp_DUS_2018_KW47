﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HalloWCF.Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Wurst", Namespace="http://schemas.datacontract.org/2004/07/HalloWCF.Host")]
    [System.SerializableAttribute()]
    public partial class Wurst : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BestBeforeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EndCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MeatTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BestBefore {
            get {
                return this.BestBeforeField;
            }
            set {
                if ((this.BestBeforeField.Equals(value) != true)) {
                    this.BestBeforeField = value;
                    this.RaisePropertyChanged("BestBefore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EndCount {
            get {
                return this.EndCountField;
            }
            set {
                if ((this.EndCountField.Equals(value) != true)) {
                    this.EndCountField = value;
                    this.RaisePropertyChanged("EndCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Length {
            get {
                return this.LengthField;
            }
            set {
                if ((this.LengthField.Equals(value) != true)) {
                    this.LengthField = value;
                    this.RaisePropertyChanged("Length");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MeatType {
            get {
                return this.MeatTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MeatTypeField, value) != true)) {
                    this.MeatTypeField = value;
                    this.RaisePropertyChanged("MeatType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWurst", ReplyAction="http://tempuri.org/IService1/GetWurstResponse")]
        HalloWCF.Client.ServiceReference1.Wurst[] GetWurst();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWurst", ReplyAction="http://tempuri.org/IService1/GetWurstResponse")]
        System.Threading.Tasks.Task<HalloWCF.Client.ServiceReference1.Wurst[]> GetWurstAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : HalloWCF.Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<HalloWCF.Client.ServiceReference1.IService1>, HalloWCF.Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public HalloWCF.Client.ServiceReference1.Wurst[] GetWurst() {
            return base.Channel.GetWurst();
        }
        
        public System.Threading.Tasks.Task<HalloWCF.Client.ServiceReference1.Wurst[]> GetWurstAsync() {
            return base.Channel.GetWurstAsync();
        }
    }
}
