﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_CSharp.srEscuelaCSharp {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srEscuelaCSharp.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string codEscuela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string codEscuela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string codEscuela, string Escuela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string codEscuela, string Escuela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string codEscuela, string Escuela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string codEscuela, string Escuela);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Cliente_CSharp.srEscuelaCSharp.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Cliente_CSharp.srEscuelaCSharp.WebService1Soap>, Cliente_CSharp.srEscuelaCSharp.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
        
        public string[] Eliminar(string codEscuela) {
            return base.Channel.Eliminar(codEscuela);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string codEscuela) {
            return base.Channel.EliminarAsync(codEscuela);
        }
        
        public string[] Agregar(string codEscuela, string Escuela) {
            return base.Channel.Agregar(codEscuela, Escuela);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string codEscuela, string Escuela) {
            return base.Channel.AgregarAsync(codEscuela, Escuela);
        }
        
        public string[] Actualizar(string codEscuela, string Escuela) {
            return base.Channel.Actualizar(codEscuela, Escuela);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string codEscuela, string Escuela) {
            return base.Channel.ActualizarAsync(codEscuela, Escuela);
        }
    }
}