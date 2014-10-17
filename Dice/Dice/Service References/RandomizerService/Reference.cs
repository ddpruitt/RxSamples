﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace Dice.RandomizerService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiceContract", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class DiceContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int _DotCountField;
        
        private int _SideCountField;
        
        private int _indexField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _DotCount {
            get {
                return this._DotCountField;
            }
            set {
                if ((this._DotCountField.Equals(value) != true)) {
                    this._DotCountField = value;
                    this.RaisePropertyChanged("_DotCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _SideCount {
            get {
                return this._SideCountField;
            }
            set {
                if ((this._SideCountField.Equals(value) != true)) {
                    this._SideCountField = value;
                    this.RaisePropertyChanged("_SideCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _index {
            get {
                return this._indexField;
            }
            set {
                if ((this._indexField.Equals(value) != true)) {
                    this._indexField = value;
                    this.RaisePropertyChanged("_index");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RandomizerService.IRandomizer")]
    public interface IRandomizer {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRandomizer/Roll", ReplyAction="http://tempuri.org/IRandomizer/RollResponse")]
        System.IAsyncResult BeginRoll(int sideCount, System.AsyncCallback callback, object asyncState);
        
        int EndRoll(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRandomizer/RandomDiceResult", ReplyAction="http://tempuri.org/IRandomizer/RandomDiceResultResponse")]
        System.IAsyncResult BeginRandomDiceResult(int sideCount, int index, System.AsyncCallback callback, object asyncState);
        
        Dice.RandomizerService.DiceContract EndRandomDiceResult(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRandomizerChannel : Dice.RandomizerService.IRandomizer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RollCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public RollCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RandomDiceResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public RandomDiceResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Dice.RandomizerService.DiceContract Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Dice.RandomizerService.DiceContract)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RandomizerClient : System.ServiceModel.ClientBase<Dice.RandomizerService.IRandomizer>, Dice.RandomizerService.IRandomizer {
        
        private BeginOperationDelegate onBeginRollDelegate;
        
        private EndOperationDelegate onEndRollDelegate;
        
        private System.Threading.SendOrPostCallback onRollCompletedDelegate;
        
        private BeginOperationDelegate onBeginRandomDiceResultDelegate;
        
        private EndOperationDelegate onEndRandomDiceResultDelegate;
        
        private System.Threading.SendOrPostCallback onRandomDiceResultCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public RandomizerClient() {
        }
        
        public RandomizerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomizerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomizerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomizerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<RollCompletedEventArgs> RollCompleted;
        
        public event System.EventHandler<RandomDiceResultCompletedEventArgs> RandomDiceResultCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Dice.RandomizerService.IRandomizer.BeginRoll(int sideCount, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRoll(sideCount, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int Dice.RandomizerService.IRandomizer.EndRoll(System.IAsyncResult result) {
            return base.Channel.EndRoll(result);
        }
        
        private System.IAsyncResult OnBeginRoll(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int sideCount = ((int)(inValues[0]));
            return ((Dice.RandomizerService.IRandomizer)(this)).BeginRoll(sideCount, callback, asyncState);
        }
        
        private object[] OnEndRoll(System.IAsyncResult result) {
            int retVal = ((Dice.RandomizerService.IRandomizer)(this)).EndRoll(result);
            return new object[] {
                    retVal};
        }
        
        private void OnRollCompleted(object state) {
            if ((this.RollCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RollCompleted(this, new RollCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RollAsync(int sideCount) {
            this.RollAsync(sideCount, null);
        }
        
        public void RollAsync(int sideCount, object userState) {
            if ((this.onBeginRollDelegate == null)) {
                this.onBeginRollDelegate = new BeginOperationDelegate(this.OnBeginRoll);
            }
            if ((this.onEndRollDelegate == null)) {
                this.onEndRollDelegate = new EndOperationDelegate(this.OnEndRoll);
            }
            if ((this.onRollCompletedDelegate == null)) {
                this.onRollCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRollCompleted);
            }
            base.InvokeAsync(this.onBeginRollDelegate, new object[] {
                        sideCount}, this.onEndRollDelegate, this.onRollCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Dice.RandomizerService.IRandomizer.BeginRandomDiceResult(int sideCount, int index, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRandomDiceResult(sideCount, index, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dice.RandomizerService.DiceContract Dice.RandomizerService.IRandomizer.EndRandomDiceResult(System.IAsyncResult result) {
            return base.Channel.EndRandomDiceResult(result);
        }
        
        private System.IAsyncResult OnBeginRandomDiceResult(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int sideCount = ((int)(inValues[0]));
            int index = ((int)(inValues[1]));
            return ((Dice.RandomizerService.IRandomizer)(this)).BeginRandomDiceResult(sideCount, index, callback, asyncState);
        }
        
        private object[] OnEndRandomDiceResult(System.IAsyncResult result) {
            Dice.RandomizerService.DiceContract retVal = ((Dice.RandomizerService.IRandomizer)(this)).EndRandomDiceResult(result);
            return new object[] {
                    retVal};
        }
        
        private void OnRandomDiceResultCompleted(object state) {
            if ((this.RandomDiceResultCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RandomDiceResultCompleted(this, new RandomDiceResultCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RandomDiceResultAsync(int sideCount, int index) {
            this.RandomDiceResultAsync(sideCount, index, null);
        }
        
        public void RandomDiceResultAsync(int sideCount, int index, object userState) {
            if ((this.onBeginRandomDiceResultDelegate == null)) {
                this.onBeginRandomDiceResultDelegate = new BeginOperationDelegate(this.OnBeginRandomDiceResult);
            }
            if ((this.onEndRandomDiceResultDelegate == null)) {
                this.onEndRandomDiceResultDelegate = new EndOperationDelegate(this.OnEndRandomDiceResult);
            }
            if ((this.onRandomDiceResultCompletedDelegate == null)) {
                this.onRandomDiceResultCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRandomDiceResultCompleted);
            }
            base.InvokeAsync(this.onBeginRandomDiceResultDelegate, new object[] {
                        sideCount,
                        index}, this.onEndRandomDiceResultDelegate, this.onRandomDiceResultCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Dice.RandomizerService.IRandomizer CreateChannel() {
            return new RandomizerClientChannel(this);
        }
        
        private class RandomizerClientChannel : ChannelBase<Dice.RandomizerService.IRandomizer>, Dice.RandomizerService.IRandomizer {
            
            public RandomizerClientChannel(System.ServiceModel.ClientBase<Dice.RandomizerService.IRandomizer> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginRoll(int sideCount, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = sideCount;
                System.IAsyncResult _result = base.BeginInvoke("Roll", _args, callback, asyncState);
                return _result;
            }
            
            public int EndRoll(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("Roll", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginRandomDiceResult(int sideCount, int index, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = sideCount;
                _args[1] = index;
                System.IAsyncResult _result = base.BeginInvoke("RandomDiceResult", _args, callback, asyncState);
                return _result;
            }
            
            public Dice.RandomizerService.DiceContract EndRandomDiceResult(System.IAsyncResult result) {
                object[] _args = new object[0];
                Dice.RandomizerService.DiceContract _result = ((Dice.RandomizerService.DiceContract)(base.EndInvoke("RandomDiceResult", _args, result)));
                return _result;
            }
        }
    }
}
