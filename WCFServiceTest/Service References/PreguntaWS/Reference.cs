﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceTest.PreguntaWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pregunta", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
    [System.SerializableAttribute()]
    public partial class Pregunta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDCursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDPreguntaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string respuestaField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDAlumno {
            get {
                return this.IDAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.IDAlumnoField, value) != true)) {
                    this.IDAlumnoField = value;
                    this.RaisePropertyChanged("IDAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDCurso {
            get {
                return this.IDCursoField;
            }
            set {
                if ((this.IDCursoField.Equals(value) != true)) {
                    this.IDCursoField = value;
                    this.RaisePropertyChanged("IDCurso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDPregunta {
            get {
                return this.IDPreguntaField;
            }
            set {
                if ((this.IDPreguntaField.Equals(value) != true)) {
                    this.IDPreguntaField = value;
                    this.RaisePropertyChanged("IDPregunta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelField, value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string respuesta {
            get {
                return this.respuestaField;
            }
            set {
                if ((object.ReferenceEquals(this.respuestaField, value) != true)) {
                    this.respuestaField = value;
                    this.RaisePropertyChanged("respuesta");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorPresentado", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
    [System.SerializableAttribute()]
    public partial class ErrorPresentado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeErrorField;
        
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
        public int CodigoError {
            get {
                return this.CodigoErrorField;
            }
            set {
                if ((this.CodigoErrorField.Equals(value) != true)) {
                    this.CodigoErrorField = value;
                    this.RaisePropertyChanged("CodigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeError {
            get {
                return this.MensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeErrorField, value) != true)) {
                    this.MensajeErrorField = value;
                    this.RaisePropertyChanged("MensajeError");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Curso", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
    [System.SerializableAttribute()]
    public partial class Curso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemaField;
        
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
        public int IdCurso {
            get {
                return this.IdCursoField;
            }
            set {
                if ((this.IdCursoField.Equals(value) != true)) {
                    this.IdCursoField = value;
                    this.RaisePropertyChanged("IdCurso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tema {
            get {
                return this.TemaField;
            }
            set {
                if ((object.ReferenceEquals(this.TemaField, value) != true)) {
                    this.TemaField = value;
                    this.RaisePropertyChanged("Tema");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PreguntaWS.IPreguntaService")]
    public interface IPreguntaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/preguntar", ReplyAction="http://tempuri.org/IPreguntaService/preguntarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServiceTest.PreguntaWS.ErrorPresentado), Action="http://tempuri.org/IPreguntaService/preguntarErrorPresentadoFault", Name="ErrorPresentado", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
        WCFServiceTest.PreguntaWS.Pregunta preguntar(int IDPregunta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/preguntar", ReplyAction="http://tempuri.org/IPreguntaService/preguntarResponse")]
        System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta> preguntarAsync(int IDPregunta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/crear", ReplyAction="http://tempuri.org/IPreguntaService/crearResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServiceTest.PreguntaWS.ErrorPresentado), Action="http://tempuri.org/IPreguntaService/crearErrorPresentadoFault", Name="ErrorPresentado", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
        WCFServiceTest.PreguntaWS.Pregunta crear(string IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/crear", ReplyAction="http://tempuri.org/IPreguntaService/crearResponse")]
        System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta> crearAsync(string IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ObtenerCurso", ReplyAction="http://tempuri.org/IPreguntaService/ObtenerCursoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServiceTest.PreguntaWS.ErrorPresentado), Action="http://tempuri.org/IPreguntaService/ObtenerCursoErrorPresentadoFault", Name="ErrorPresentado", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPregunta.Dominio")]
        WCFServiceTest.PreguntaWS.Curso ObtenerCurso(int IDCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ObtenerCurso", ReplyAction="http://tempuri.org/IPreguntaService/ObtenerCursoResponse")]
        System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Curso> ObtenerCursoAsync(int IDCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ListarCurso", ReplyAction="http://tempuri.org/IPreguntaService/ListarCursoResponse")]
        WCFServiceTest.PreguntaWS.Curso[] ListarCurso();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ListarCurso", ReplyAction="http://tempuri.org/IPreguntaService/ListarCursoResponse")]
        System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Curso[]> ListarCursoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ListarPregunta", ReplyAction="http://tempuri.org/IPreguntaService/ListarPreguntaResponse")]
        WCFServiceTest.PreguntaWS.Pregunta[] ListarPregunta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPreguntaService/ListarPregunta", ReplyAction="http://tempuri.org/IPreguntaService/ListarPreguntaResponse")]
        System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta[]> ListarPreguntaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPreguntaServiceChannel : WCFServiceTest.PreguntaWS.IPreguntaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PreguntaServiceClient : System.ServiceModel.ClientBase<WCFServiceTest.PreguntaWS.IPreguntaService>, WCFServiceTest.PreguntaWS.IPreguntaService {
        
        public PreguntaServiceClient() {
        }
        
        public PreguntaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PreguntaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PreguntaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PreguntaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServiceTest.PreguntaWS.Pregunta preguntar(int IDPregunta) {
            return base.Channel.preguntar(IDPregunta);
        }
        
        public System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta> preguntarAsync(int IDPregunta) {
            return base.Channel.preguntarAsync(IDPregunta);
        }
        
        public WCFServiceTest.PreguntaWS.Pregunta crear(string IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta) {
            return base.Channel.crear(IDAlumno, IDcurso, Descripcion, Nivel, respuesta);
        }
        
        public System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta> crearAsync(string IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta) {
            return base.Channel.crearAsync(IDAlumno, IDcurso, Descripcion, Nivel, respuesta);
        }
        
        public WCFServiceTest.PreguntaWS.Curso ObtenerCurso(int IDCurso) {
            return base.Channel.ObtenerCurso(IDCurso);
        }
        
        public System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Curso> ObtenerCursoAsync(int IDCurso) {
            return base.Channel.ObtenerCursoAsync(IDCurso);
        }
        
        public WCFServiceTest.PreguntaWS.Curso[] ListarCurso() {
            return base.Channel.ListarCurso();
        }
        
        public System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Curso[]> ListarCursoAsync() {
            return base.Channel.ListarCursoAsync();
        }
        
        public WCFServiceTest.PreguntaWS.Pregunta[] ListarPregunta() {
            return base.Channel.ListarPregunta();
        }
        
        public System.Threading.Tasks.Task<WCFServiceTest.PreguntaWS.Pregunta[]> ListarPreguntaAsync() {
            return base.Channel.ListarPreguntaAsync();
        }
    }
}
