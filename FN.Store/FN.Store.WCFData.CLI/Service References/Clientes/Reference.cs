﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FN.Store.WCFData.CLI.Clientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteVM", Namespace="http://schemas.datacontract.org/2004/07/FN.Store.WCFData.Model")]
    [System.SerializableAttribute()]
    public partial class ClienteVM : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataLogField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public System.DateTime DataLog {
            get {
                return this.DataLogField;
            }
            set {
                if ((this.DataLogField.Equals(value) != true)) {
                    this.DataLogField = value;
                    this.RaisePropertyChanged("DataLog");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Clientes.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObterTodos", ReplyAction="http://tempuri.org/IClienteService/ObterTodosResponse")]
        FN.Store.WCFData.CLI.Clientes.ClienteVM[] ObterTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObterTodos", ReplyAction="http://tempuri.org/IClienteService/ObterTodosResponse")]
        System.Threading.Tasks.Task<FN.Store.WCFData.CLI.Clientes.ClienteVM[]> ObterTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObterPorId", ReplyAction="http://tempuri.org/IClienteService/ObterPorIdResponse")]
        FN.Store.WCFData.CLI.Clientes.ClienteVM ObterPorId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObterPorId", ReplyAction="http://tempuri.org/IClienteService/ObterPorIdResponse")]
        System.Threading.Tasks.Task<FN.Store.WCFData.CLI.Clientes.ClienteVM> ObterPorIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : FN.Store.WCFData.CLI.Clientes.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<FN.Store.WCFData.CLI.Clientes.IClienteService>, FN.Store.WCFData.CLI.Clientes.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FN.Store.WCFData.CLI.Clientes.ClienteVM[] ObterTodos() {
            return base.Channel.ObterTodos();
        }
        
        public System.Threading.Tasks.Task<FN.Store.WCFData.CLI.Clientes.ClienteVM[]> ObterTodosAsync() {
            return base.Channel.ObterTodosAsync();
        }
        
        public FN.Store.WCFData.CLI.Clientes.ClienteVM ObterPorId(string id) {
            return base.Channel.ObterPorId(id);
        }
        
        public System.Threading.Tasks.Task<FN.Store.WCFData.CLI.Clientes.ClienteVM> ObterPorIdAsync(string id) {
            return base.Channel.ObterPorIdAsync(id);
        }
    }
}
