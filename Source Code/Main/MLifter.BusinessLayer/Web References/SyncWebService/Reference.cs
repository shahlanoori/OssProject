﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace MLifter.BusinessLayer.SyncWebService {
	using System;
	using System.Web.Services;
	using System.Diagnostics;
	using System.Web.Services.Protocols;
	using System.ComponentModel;
	using System.Xml.Serialization;
	using System.Data;
	using Microsoft.Synchronization.Data;
	
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="PgSyncServiceSoap", Namespace="http://www.memorylifter.com/sync/service/")]
	public partial class PgSyncService : System.Web.Services.Protocols.SoapHttpClientProtocol {
		
		private System.Threading.SendOrPostCallback GetServerInfoOperationCompleted;
		
		private System.Threading.SendOrPostCallback GetSchemaOperationCompleted;
		
		private System.Threading.SendOrPostCallback GetChangesOperationCompleted;
		
		private System.Threading.SendOrPostCallback ApplyChangesOperationCompleted;
		
		private bool useDefaultCredentialsSetExplicitly;
		
		/// <remarks/>
		public PgSyncService() {
			this.Url = global::MLifter.BusinessLayer.Properties.Settings.Default.MLifterBusinessLayer_SyncWebService_PgSyncService;
			if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else {
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		
		public new string Url {
			get {
				return base.Url;
			}
			set {
				if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
							&& (this.useDefaultCredentialsSetExplicitly == false)) 
							&& (this.IsLocalFileSystemWebService(value) == false))) {
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}
		
		public new bool UseDefaultCredentials {
			get {
				return base.UseDefaultCredentials;
			}
			set {
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		
		/// <remarks/>
		public event GetServerInfoCompletedEventHandler GetServerInfoCompleted;
		
		/// <remarks/>
		public event GetSchemaCompletedEventHandler GetSchemaCompleted;
		
		/// <remarks/>
		public event GetChangesCompletedEventHandler GetChangesCompleted;
		
		/// <remarks/>
		public event ApplyChangesCompletedEventHandler ApplyChangesCompleted;
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.memorylifter.com/sync/service/GetServerInfo", RequestNamespace="http://www.memorylifter.com/sync/service/", ResponseNamespace="http://www.memorylifter.com/sync/service/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public SyncServerInfo GetServerInfo(SyncSession syncSession) {
			object[] results = this.Invoke("GetServerInfo", new object[] {
						syncSession});
			return ((SyncServerInfo)(results[0]));
		}
		
		/// <remarks/>
		public void GetServerInfoAsync(SyncSession syncSession) {
			this.GetServerInfoAsync(syncSession, null);
		}
		
		/// <remarks/>
		public void GetServerInfoAsync(SyncSession syncSession, object userState) {
			if ((this.GetServerInfoOperationCompleted == null)) {
				this.GetServerInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServerInfoOperationCompleted);
			}
			this.InvokeAsync("GetServerInfo", new object[] {
						syncSession}, this.GetServerInfoOperationCompleted, userState);
		}
		
		private void OnGetServerInfoOperationCompleted(object arg) {
			if ((this.GetServerInfoCompleted != null)) {
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.GetServerInfoCompleted(this, new GetServerInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.memorylifter.com/sync/service/GetSchema", RequestNamespace="http://www.memorylifter.com/sync/service/", ResponseNamespace="http://www.memorylifter.com/sync/service/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public SyncSchema GetSchema(string[] tableNames, SyncSession syncSession) {
			object[] results = this.Invoke("GetSchema", new object[] {
						tableNames,
						syncSession});
			return ((SyncSchema)(results[0]));
		}
		
		/// <remarks/>
		public void GetSchemaAsync(string[] tableNames, SyncSession syncSession) {
			this.GetSchemaAsync(tableNames, syncSession, null);
		}
		
		/// <remarks/>
		public void GetSchemaAsync(string[] tableNames, SyncSession syncSession, object userState) {
			if ((this.GetSchemaOperationCompleted == null)) {
				this.GetSchemaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSchemaOperationCompleted);
			}
			this.InvokeAsync("GetSchema", new object[] {
						tableNames,
						syncSession}, this.GetSchemaOperationCompleted, userState);
		}
		
		private void OnGetSchemaOperationCompleted(object arg) {
			if ((this.GetSchemaCompleted != null)) {
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.GetSchemaCompleted(this, new GetSchemaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.memorylifter.com/sync/service/GetChanges", RequestNamespace="http://www.memorylifter.com/sync/service/", ResponseNamespace="http://www.memorylifter.com/sync/service/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public SyncContext GetChanges(SyncGroupMetadata groupMetadata, SyncSession syncSession) {
			object[] results = this.Invoke("GetChanges", new object[] {
						groupMetadata,
						syncSession});
			return ((SyncContext)(results[0]));
		}
		
		/// <remarks/>
		public void GetChangesAsync(SyncGroupMetadata groupMetadata, SyncSession syncSession) {
			this.GetChangesAsync(groupMetadata, syncSession, null);
		}
		
		/// <remarks/>
		public void GetChangesAsync(SyncGroupMetadata groupMetadata, SyncSession syncSession, object userState) {
			if ((this.GetChangesOperationCompleted == null)) {
				this.GetChangesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangesOperationCompleted);
			}
			this.InvokeAsync("GetChanges", new object[] {
						groupMetadata,
						syncSession}, this.GetChangesOperationCompleted, userState);
		}
		
		private void OnGetChangesOperationCompleted(object arg) {
			if ((this.GetChangesCompleted != null)) {
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.GetChangesCompleted(this, new GetChangesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.memorylifter.com/sync/service/ApplyChanges", RequestNamespace="http://www.memorylifter.com/sync/service/", ResponseNamespace="http://www.memorylifter.com/sync/service/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public SyncContext ApplyChanges(SyncGroupMetadata groupMetadata, System.Data.DataSet dataSet, SyncSession syncSession) {
			object[] results = this.Invoke("ApplyChanges", new object[] {
						groupMetadata,
						dataSet,
						syncSession});
			return ((SyncContext)(results[0]));
		}
		
		/// <remarks/>
		public void ApplyChangesAsync(SyncGroupMetadata groupMetadata, System.Data.DataSet dataSet, SyncSession syncSession) {
			this.ApplyChangesAsync(groupMetadata, dataSet, syncSession, null);
		}
		
		/// <remarks/>
		public void ApplyChangesAsync(SyncGroupMetadata groupMetadata, System.Data.DataSet dataSet, SyncSession syncSession, object userState) {
			if ((this.ApplyChangesOperationCompleted == null)) {
				this.ApplyChangesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplyChangesOperationCompleted);
			}
			this.InvokeAsync("ApplyChanges", new object[] {
						groupMetadata,
						dataSet,
						syncSession}, this.ApplyChangesOperationCompleted, userState);
		}
		
		private void OnApplyChangesOperationCompleted(object arg) {
			if ((this.ApplyChangesCompleted != null)) {
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.ApplyChangesCompleted(this, new ApplyChangesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		
		/// <remarks/>
		public new void CancelAsync(object userState) {
			base.CancelAsync(userState);
		}
		
		private bool IsLocalFileSystemWebService(string url) {
			if (((url == null) 
						|| (url == string.Empty))) {
				return false;
			}
			System.Uri wsUri = new System.Uri(url);
			if (((wsUri.Port >= 1024) 
						&& (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
				return true;
			}
			return false;
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	public delegate void GetServerInfoCompletedEventHandler(object sender, GetServerInfoCompletedEventArgs e);
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GetServerInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
		
		private object[] results;
		
		internal GetServerInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
				base(exception, cancelled, userState) {
			this.results = results;
		}
		
		/// <remarks/>
		public SyncServerInfo Result {
			get {
				this.RaiseExceptionIfNecessary();
				return ((SyncServerInfo)(this.results[0]));
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	public delegate void GetSchemaCompletedEventHandler(object sender, GetSchemaCompletedEventArgs e);
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GetSchemaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
		
		private object[] results;
		
		internal GetSchemaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
				base(exception, cancelled, userState) {
			this.results = results;
		}
		
		/// <remarks/>
		public SyncSchema Result {
			get {
				this.RaiseExceptionIfNecessary();
				return ((SyncSchema)(this.results[0]));
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	public delegate void GetChangesCompletedEventHandler(object sender, GetChangesCompletedEventArgs e);
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GetChangesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
		
		private object[] results;
		
		internal GetChangesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
				base(exception, cancelled, userState) {
			this.results = results;
		}
		
		/// <remarks/>
		public SyncContext Result {
			get {
				this.RaiseExceptionIfNecessary();
				return ((SyncContext)(this.results[0]));
			}
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	public delegate void ApplyChangesCompletedEventHandler(object sender, ApplyChangesCompletedEventArgs e);
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ApplyChangesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
		
		private object[] results;
		
		internal ApplyChangesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
				base(exception, cancelled, userState) {
			this.results = results;
		}
		
		/// <remarks/>
		public SyncContext Result {
			get {
				this.RaiseExceptionIfNecessary();
				return ((SyncContext)(this.results[0]));
			}
		}
	}
}

#pragma warning restore 1591