﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberSitesi.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dotnet-revanth.blogspot.com/webservices", ConfigurationName="ServiceReference.SampleWebServiceSoap")]
    public interface SampleWebServiceSoap {
        
        // CODEGEN: http://dotnet-revanth.blogspot.com/webservices ad alanındaki HelloWorldResult öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/HelloWorld", ReplyAction="*")]
        HaberSitesi.ServiceReference.HelloWorldResponse HelloWorld(HaberSitesi.ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HelloWorldResponse> HelloWorldAsync(HaberSitesi.ServiceReference.HelloWorldRequest request);
        
        // CODEGEN: http://dotnet-revanth.blogspot.com/webservices ad alanındaki HaberBasligi öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/HaberGiris", ReplyAction="*")]
        HaberSitesi.ServiceReference.HaberGirisResponse HaberGiris(HaberSitesi.ServiceReference.HaberGirisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/HaberGiris", ReplyAction="*")]
        System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HaberGirisResponse> HaberGirisAsync(HaberSitesi.ServiceReference.HaberGirisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/kimliknumber", ReplyAction="*")]
        int kimliknumber(int tc_No);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnet-revanth.blogspot.com/webservices/kimliknumber", ReplyAction="*")]
        System.Threading.Tasks.Task<int> kimliknumberAsync(int tc_No);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://dotnet-revanth.blogspot.com/webservices", Order=0)]
        public HaberSitesi.ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(HaberSitesi.ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://dotnet-revanth.blogspot.com/webservices", Order=0)]
        public HaberSitesi.ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(HaberSitesi.ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dotnet-revanth.blogspot.com/webservices")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HaberGirisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HaberGiris", Namespace="http://dotnet-revanth.blogspot.com/webservices", Order=0)]
        public HaberSitesi.ServiceReference.HaberGirisRequestBody Body;
        
        public HaberGirisRequest() {
        }
        
        public HaberGirisRequest(HaberSitesi.ServiceReference.HaberGirisRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dotnet-revanth.blogspot.com/webservices")]
    public partial class HaberGirisRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HaberBasligi;
        
        public HaberGirisRequestBody() {
        }
        
        public HaberGirisRequestBody(string HaberBasligi) {
            this.HaberBasligi = HaberBasligi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HaberGirisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HaberGirisResponse", Namespace="http://dotnet-revanth.blogspot.com/webservices", Order=0)]
        public HaberSitesi.ServiceReference.HaberGirisResponseBody Body;
        
        public HaberGirisResponse() {
        }
        
        public HaberGirisResponse(HaberSitesi.ServiceReference.HaberGirisResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dotnet-revanth.blogspot.com/webservices")]
    public partial class HaberGirisResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HaberGirisResult;
        
        public HaberGirisResponseBody() {
        }
        
        public HaberGirisResponseBody(string HaberGirisResult) {
            this.HaberGirisResult = HaberGirisResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleWebServiceSoapChannel : HaberSitesi.ServiceReference.SampleWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleWebServiceSoapClient : System.ServiceModel.ClientBase<HaberSitesi.ServiceReference.SampleWebServiceSoap>, HaberSitesi.ServiceReference.SampleWebServiceSoap {
        
        public SampleWebServiceSoapClient() {
        }
        
        public SampleWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HaberSitesi.ServiceReference.HelloWorldResponse HaberSitesi.ServiceReference.SampleWebServiceSoap.HelloWorld(HaberSitesi.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            HaberSitesi.ServiceReference.HelloWorldRequest inValue = new HaberSitesi.ServiceReference.HelloWorldRequest();
            inValue.Body = new HaberSitesi.ServiceReference.HelloWorldRequestBody();
            HaberSitesi.ServiceReference.HelloWorldResponse retVal = ((HaberSitesi.ServiceReference.SampleWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HelloWorldResponse> HaberSitesi.ServiceReference.SampleWebServiceSoap.HelloWorldAsync(HaberSitesi.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            HaberSitesi.ServiceReference.HelloWorldRequest inValue = new HaberSitesi.ServiceReference.HelloWorldRequest();
            inValue.Body = new HaberSitesi.ServiceReference.HelloWorldRequestBody();
            return ((HaberSitesi.ServiceReference.SampleWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HaberSitesi.ServiceReference.HaberGirisResponse HaberSitesi.ServiceReference.SampleWebServiceSoap.HaberGiris(HaberSitesi.ServiceReference.HaberGirisRequest request) {
            return base.Channel.HaberGiris(request);
        }
        
        public string HaberGiris(string HaberBasligi) {
            HaberSitesi.ServiceReference.HaberGirisRequest inValue = new HaberSitesi.ServiceReference.HaberGirisRequest();
            inValue.Body = new HaberSitesi.ServiceReference.HaberGirisRequestBody();
            inValue.Body.HaberBasligi = HaberBasligi;
            HaberSitesi.ServiceReference.HaberGirisResponse retVal = ((HaberSitesi.ServiceReference.SampleWebServiceSoap)(this)).HaberGiris(inValue);
            return retVal.Body.HaberGirisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HaberGirisResponse> HaberSitesi.ServiceReference.SampleWebServiceSoap.HaberGirisAsync(HaberSitesi.ServiceReference.HaberGirisRequest request) {
            return base.Channel.HaberGirisAsync(request);
        }
        
        public System.Threading.Tasks.Task<HaberSitesi.ServiceReference.HaberGirisResponse> HaberGirisAsync(string HaberBasligi) {
            HaberSitesi.ServiceReference.HaberGirisRequest inValue = new HaberSitesi.ServiceReference.HaberGirisRequest();
            inValue.Body = new HaberSitesi.ServiceReference.HaberGirisRequestBody();
            inValue.Body.HaberBasligi = HaberBasligi;
            return ((HaberSitesi.ServiceReference.SampleWebServiceSoap)(this)).HaberGirisAsync(inValue);
        }
        
        public int kimliknumber(int tc_No) {
            return base.Channel.kimliknumber(tc_No);
        }
        
        public System.Threading.Tasks.Task<int> kimliknumberAsync(int tc_No) {
            return base.Channel.kimliknumberAsync(tc_No);
        }
    }
}