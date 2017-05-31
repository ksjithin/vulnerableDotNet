﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace HacmeBank_v2_Website.WS_AccountManagement {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_AccountManagementSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public class WS_AccountManagement : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
		public WS_AccountManagement(string IPAddressOfWebService) 
		{
			this.Url = "http://"+IPAddressOfWebService+"/HacmeBank_v2_WS/WebServices/AccountManagement.asmx";
		}
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserAccounts_using_UserID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetUserAccounts_using_UserID(string SessionID, string userID) {
            object[] results = this.Invoke("GetUserAccounts_using_UserID", new object[] {
                        SessionID,
                        userID});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetUserAccounts_using_UserID(string SessionID, string userID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetUserAccounts_using_UserID", new object[] {
                        SessionID,
                        userID}, callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetUserAccounts_using_UserID(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountDetails_using_AccountID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetAccountDetails_using_AccountID(string SessionID, string accountID) {
            object[] results = this.Invoke("GetAccountDetails_using_AccountID", new object[] {
                        SessionID,
                        accountID});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAccountDetails_using_AccountID(string SessionID, string accountID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAccountDetails_using_AccountID", new object[] {
                        SessionID,
                        accountID}, callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetAccountDetails_using_AccountID(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountTransactions_using_AccountID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetAccountTransactions_using_AccountID(string SessionID, string accountID) {
            object[] results = this.Invoke("GetAccountTransactions_using_AccountID", new object[] {
                        SessionID,
                        accountID});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAccountTransactions_using_AccountID(string SessionID, string accountID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAccountTransactions_using_AccountID", new object[] {
                        SessionID,
                        accountID}, callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetAccountTransactions_using_AccountID(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountTransactionDetails_using_TransactionID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetAccountTransactionDetails_using_TransactionID(string SessionID, string transactionID) {
            object[] results = this.Invoke("GetAccountTransactionDetails_using_TransactionID", new object[] {
                        SessionID,
                        transactionID});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAccountTransactionDetails_using_TransactionID(string SessionID, string transactionID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAccountTransactionDetails_using_TransactionID", new object[] {
                        SessionID,
                        transactionID}, callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetAccountTransactionDetails_using_TransactionID(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TransferFunds", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int TransferFunds(string SessionID, string sourceAccount, string destinationAccount, double amount, string comment) {
            object[] results = this.Invoke("TransferFunds", new object[] {
                        SessionID,
                        sourceAccount,
                        destinationAccount,
                        amount,
                        comment});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginTransferFunds(string SessionID, string sourceAccount, string destinationAccount, int amount, string comment, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("TransferFunds", new object[] {
                        SessionID,
                        sourceAccount,
                        destinationAccount,
                        amount,
                        comment}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndTransferFunds(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetLoanRates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetLoanRates(string SessionID) {
            object[] results = this.Invoke("GetLoanRates", new object[] {
                        SessionID});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetLoanRates(string SessionID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetLoanRates", new object[] {
                        SessionID}, callback, asyncState);
        }
        
        /// <remarks/>
        public object[] EndGetLoanRates(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RequestALoan", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int RequestALoan(string SessionID, string destinationAccount, int amount, int loanPeriod, System.Decimal loanInterestRate, string comment) {
            object[] results = this.Invoke("RequestALoan", new object[] {
                        SessionID,
                        destinationAccount,
                        amount,
                        loanPeriod,
                        loanInterestRate,
                        comment});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRequestALoan(string SessionID, string destinationAccount, int amount, int loanPeriod, System.Decimal loanInterestRate, string comment, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RequestALoan", new object[] {
                        SessionID,
                        destinationAccount,
                        amount,
                        loanPeriod,
                        loanInterestRate,
                        comment}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndRequestALoan(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MakePayment_Using_CreditCard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int MakePayment_Using_CreditCard(string SessionID, string sourceAccount_CCNumber, string sourceAccount_CCExpiryDate, string destinationAccount, int amount, string comment) {
            object[] results = this.Invoke("MakePayment_Using_CreditCard", new object[] {
                        SessionID,
                        sourceAccount_CCNumber,
                        sourceAccount_CCExpiryDate,
                        destinationAccount,
                        amount,
                        comment});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginMakePayment_Using_CreditCard(string SessionID, string sourceAccount_CCNumber, string sourceAccount_CCExpiryDate, string destinationAccount, int amount, string comment, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("MakePayment_Using_CreditCard", new object[] {
                        SessionID,
                        sourceAccount_CCNumber,
                        sourceAccount_CCExpiryDate,
                        destinationAccount,
                        amount,
                        comment}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndMakePayment_Using_CreditCard(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateAccount(string SessionID, string accountNumber, string userID, string accountCurrency, string accountBranch, string accountInitalBalance, string accountType) {
            this.Invoke("CreateAccount", new object[] {
                        SessionID,
                        accountNumber,
                        userID,
                        accountCurrency,
                        accountBranch,
                        accountInitalBalance,
                        accountType});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateAccount(string SessionID, string accountNumber, string userID, string accountCurrency, string accountBranch, string accountInitalBalance, string accountType, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateAccount", new object[] {
                        SessionID,
                        accountNumber,
                        userID,
                        accountCurrency,
                        accountBranch,
                        accountInitalBalance,
                        accountType}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreateAccount(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/recalculateAllAccountBalances", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string recalculateAllAccountBalances() {
            object[] results = this.Invoke("recalculateAllAccountBalances", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginrecalculateAllAccountBalances(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("recalculateAllAccountBalances", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndrecalculateAllAccountBalances(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecuteSqlQuery", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object ExecuteSqlQuery(string SessionID, string sqlQueryToExecute) {
            object[] results = this.Invoke("ExecuteSqlQuery", new object[] {
                        SessionID,
                        sqlQueryToExecute});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginExecuteSqlQuery(string SessionID, string sqlQueryToExecute, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ExecuteSqlQuery", new object[] {
                        SessionID,
                        sqlQueryToExecute}, callback, asyncState);
        }
        
        /// <remarks/>
        public object EndExecuteSqlQuery(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object)(results[0]));
        }
    }
}
