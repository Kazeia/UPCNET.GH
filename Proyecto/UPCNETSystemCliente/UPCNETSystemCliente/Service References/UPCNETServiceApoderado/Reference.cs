﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPCNETSystemCliente.UPCNETServiceApoderado {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Services.upcnet.upc.com/", ConfigurationName="UPCNETServiceApoderado.UPCNETServiceApoderado")]
    public interface UPCNETServiceApoderado {
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/setApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/setApoderadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse setApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/setApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/setApoderadoResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse> setApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/editApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/editApoderadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse editApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/editApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/editApoderadoResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse> editApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/getApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/getApoderadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse getApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceApoderado/getApoderadoRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceApoderado/getApoderadoResponse")]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse> getApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setApoderado", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setApoderadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg4;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg5;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg6;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg7;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg8;
        
        public setApoderadoRequest() {
        }
        
        public setApoderadoRequest(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
            this.arg6 = arg6;
            this.arg7 = arg7;
            this.arg8 = arg8;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setApoderadoResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setApoderadoResponse {
        
        public setApoderadoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editApoderado", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editApoderadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg4;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg5;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg6;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg7;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg8;
        
        public editApoderadoRequest() {
        }
        
        public editApoderadoRequest(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
            this.arg6 = arg6;
            this.arg7 = arg7;
            this.arg8 = arg8;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editApoderadoResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editApoderadoResponse {
        
        public editApoderadoResponse() {
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class apoderado : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string condicionField;
        
        private string correoField;
        
        private int dNIField;
        
        private string direccionField;
        
        private int edadField;
        
        private string iDApoderadoField;
        
        private string nombreField;
        
        private string passField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string condicion {
            get {
                return this.condicionField;
            }
            set {
                this.condicionField = value;
                this.RaisePropertyChanged("condicion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int DNI {
            get {
                return this.dNIField;
            }
            set {
                this.dNIField = value;
                this.RaisePropertyChanged("DNI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int edad {
            get {
                return this.edadField;
            }
            set {
                this.edadField = value;
                this.RaisePropertyChanged("edad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string IDApoderado {
            get {
                return this.iDApoderadoField;
            }
            set {
                this.iDApoderadoField = value;
                this.RaisePropertyChanged("IDApoderado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApoderado", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getApoderadoRequest {
        
        public getApoderadoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getApoderadoResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getApoderadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETSystemCliente.UPCNETServiceApoderado.apoderado[] @return;
        
        public getApoderadoResponse() {
        }
        
        public getApoderadoResponse(UPCNETSystemCliente.UPCNETServiceApoderado.apoderado[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCNETServiceApoderadoChannel : UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCNETServiceApoderadoClient : System.ServiceModel.ClientBase<UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado>, UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado {
        
        public UPCNETServiceApoderadoClient() {
        }
        
        public UPCNETServiceApoderadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCNETServiceApoderadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceApoderadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceApoderadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.setApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest request) {
            return base.Channel.setApoderado(request);
        }
        
        public void setApoderado(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            inValue.arg5 = arg5;
            inValue.arg6 = arg6;
            inValue.arg7 = arg7;
            inValue.arg8 = arg8;
            UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse retVal = ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).setApoderado(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse> UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.setApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest request) {
            return base.Channel.setApoderadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoResponse> setApoderadoAsync(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.setApoderadoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            inValue.arg5 = arg5;
            inValue.arg6 = arg6;
            inValue.arg7 = arg7;
            inValue.arg8 = arg8;
            return ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).setApoderadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.editApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest request) {
            return base.Channel.editApoderado(request);
        }
        
        public void editApoderado(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            inValue.arg5 = arg5;
            inValue.arg6 = arg6;
            inValue.arg7 = arg7;
            inValue.arg8 = arg8;
            UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse retVal = ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).editApoderado(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse> UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.editApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest request) {
            return base.Channel.editApoderadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoResponse> editApoderadoAsync(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
            UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.editApoderadoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            inValue.arg5 = arg5;
            inValue.arg6 = arg6;
            inValue.arg7 = arg7;
            inValue.arg8 = arg8;
            return ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).editApoderadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.getApoderado(UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest request) {
            return base.Channel.getApoderado(request);
        }
        
        public UPCNETSystemCliente.UPCNETServiceApoderado.apoderado[] getApoderado() {
            UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest();
            UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse retVal = ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).getApoderado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse> UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado.getApoderadoAsync(UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest request) {
            return base.Channel.getApoderadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoResponse> getApoderadoAsync() {
            UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest inValue = new UPCNETSystemCliente.UPCNETServiceApoderado.getApoderadoRequest();
            return ((UPCNETSystemCliente.UPCNETServiceApoderado.UPCNETServiceApoderado)(this)).getApoderadoAsync(inValue);
        }
    }
}
