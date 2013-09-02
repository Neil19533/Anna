﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anna.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.aonaware.com/webservices/", ConfigurationName="ServiceReference1.CountCheatServiceSoap")]
    public interface CountCheatServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.aonaware.com/webservices/LetterSolutions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] LetterSolutions(string anagram);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.aonaware.com/webservices/LetterSolutions", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> LetterSolutionsAsync(string anagram);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.aonaware.com/webservices/LetterSolutionsMin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] LetterSolutionsMin(string anagram, int minLetters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.aonaware.com/webservices/LetterSolutionsMin", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> LetterSolutionsMinAsync(string anagram, int minLetters);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CountCheatServiceSoapChannel : Anna.ServiceReference1.CountCheatServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CountCheatServiceSoapClient : System.ServiceModel.ClientBase<Anna.ServiceReference1.CountCheatServiceSoap>, Anna.ServiceReference1.CountCheatServiceSoap {
        
        public CountCheatServiceSoapClient() {
        }
        
        public CountCheatServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CountCheatServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountCheatServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountCheatServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] LetterSolutions(string anagram) {
            return base.Channel.LetterSolutions(anagram);
        }
        
        public System.Threading.Tasks.Task<string[]> LetterSolutionsAsync(string anagram) {
            return base.Channel.LetterSolutionsAsync(anagram);
        }
        
        public string[] LetterSolutionsMin(string anagram, int minLetters) {
            return base.Channel.LetterSolutionsMin(anagram, minLetters);
        }
        
        public System.Threading.Tasks.Task<string[]> LetterSolutionsMinAsync(string anagram, int minLetters) {
            return base.Channel.LetterSolutionsMinAsync(anagram, minLetters);
        }
    }
}