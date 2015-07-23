﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Builds.Client.BuildService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuildService.IBuildProvider")]
    public interface IBuildProvider {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildProvider/AddBuild", ReplyAction="http://tempuri.org/IBuildProvider/AddBuildResponse")]
        void AddBuild(int pullRequestNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildProvider/AddBuild", ReplyAction="http://tempuri.org/IBuildProvider/AddBuildResponse")]
        System.Threading.Tasks.Task AddBuildAsync(int pullRequestNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBuildProviderChannel : Builds.Client.BuildService.IBuildProvider, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BuildProviderClient : System.ServiceModel.ClientBase<Builds.Client.BuildService.IBuildProvider>, Builds.Client.BuildService.IBuildProvider {
        
        public BuildProviderClient() {
        }
        
        public BuildProviderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BuildProviderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildProviderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildProviderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBuild(int pullRequestNumber) {
            base.Channel.AddBuild(pullRequestNumber);
        }
        
        public System.Threading.Tasks.Task AddBuildAsync(int pullRequestNumber) {
            return base.Channel.AddBuildAsync(pullRequestNumber);
        }
    }
}
