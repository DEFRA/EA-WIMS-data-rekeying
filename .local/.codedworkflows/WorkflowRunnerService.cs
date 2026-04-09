using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using WIMSdatarekeying;

[assembly: WorkflowRunnerServiceAttribute(typeof(WIMSdatarekeying.WorkflowRunnerService))]
namespace WIMSdatarekeying
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new customer.xaml
        /// </summary>
        public string Create_new_customer(string in_strPhoneNumber, string in_strCompanyNumber, string in_strOrgName, string[] in_arrAddress, string in_strPostcode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new customer.xaml", new Dictionary<string, object>{{"in_strPhoneNumber", in_strPhoneNumber}, {"in_strCompanyNumber", in_strCompanyNumber}, {"in_strOrgName", in_strOrgName}, {"in_arrAddress", in_arrAddress}, {"in_strPostcode", in_strPostcode}}, default, default, default, GetAssemblyName());
            return (string)result["out_strOrgID"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new customer.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Create_new_customer(string in_strPhoneNumber, string in_strCompanyNumber, string in_strOrgName, string[] in_arrAddress, string in_strPostcode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new customer.xaml", new Dictionary<string, object>{{"in_strPhoneNumber", in_strPhoneNumber}, {"in_strCompanyNumber", in_strCompanyNumber}, {"in_strOrgName", in_strOrgName}, {"in_arrAddress", in_arrAddress}, {"in_strPostcode", in_strPostcode}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_strOrgID"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if customer exists.xaml
        /// </summary>
        public UiPath.Core.UiElement Check_if_customer_exists(string in_strOrgName, string in_strReportAddress)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if customer exists.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strReportAddress", in_strReportAddress}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiMonitoring"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if customer exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement Check_if_customer_exists(string in_strOrgName, string in_strReportAddress, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if customer exists.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strReportAddress", in_strReportAddress}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiMonitoring"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if permit exists.xaml
        /// </summary>
        public (UiPath.Core.UiElement out_uiHomePage, UiPath.Core.UiElement out_uiPermits) Check_if_permit_exists(string in_strPermitNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if permit exists.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["out_uiHomePage"], (UiPath.Core.UiElement)result["out_uiPermits"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if permit exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement out_uiHomePage, UiPath.Core.UiElement out_uiPermits) Check_if_permit_exists(string in_strPermitNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if permit exists.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["out_uiHomePage"], (UiPath.Core.UiElement)result["out_uiPermits"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if NGR exists.xaml
        /// </summary>
        public bool Check_if_NGR_exists(string in_strGridReference, string in_strReportAddress)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if NGR exists.xaml", new Dictionary<string, object>{{"in_strGridReference", in_strGridReference}, {"in_strReportAddress", in_strReportAddress}}, default, default, default, GetAssemblyName());
            return (bool)result["out_boolNGRfound"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if NGR exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool Check_if_NGR_exists(string in_strGridReference, string in_strReportAddress, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if NGR exists.xaml", new Dictionary<string, object>{{"in_strGridReference", in_strGridReference}, {"in_strReportAddress", in_strReportAddress}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_boolNGRfound"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new outlet.xaml
        /// </summary>
        public UiPath.Core.UiElement Create_new_outlet(string in_strReference, string in_strGridReference, string in_strEnvironmentCode, string in_strTotalOutlets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new outlet.xaml", new Dictionary<string, object>{{"in_strReference", in_strReference}, {"in_strGridReference", in_strGridReference}, {"in_strEnvironmentCode", in_strEnvironmentCode}, {"in_strTotalOutlets", in_strTotalOutlets}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiOutletRef"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new outlet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement Create_new_outlet(string in_strReference, string in_strGridReference, string in_strEnvironmentCode, string in_strTotalOutlets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new outlet.xaml", new Dictionary<string, object>{{"in_strReference", in_strReference}, {"in_strGridReference", in_strGridReference}, {"in_strEnvironmentCode", in_strEnvironmentCode}, {"in_strTotalOutlets", in_strTotalOutlets}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiOutletRef"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Update Party Name Sheet.xaml
        /// </summary>
        public void tc01_Update_Party_Name_Sheet()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Update Party Name Sheet.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Update Party Name Sheet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Update_Party_Name_Sheet(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Update Party Name Sheet.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/tc01 Process Transaction.xaml
        /// </summary>
        public void tc01_Process_Transaction()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\tc01 Process Transaction.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/tc01 Process Transaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Process_Transaction(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\tc01 Process Transaction.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Init next release.xaml
        /// </summary>
        public void tc01_Init_next_release()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Init next release.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Init next release.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Init_next_release(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Init next release.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
        public void Process_Transaction(System.Data.DataTable in_dtLookups)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{{"in_dtLookups", in_dtLookups}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process_Transaction(System.Data.DataTable in_dtLookups, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{{"in_dtLookups", in_dtLookups}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Extract Permit Info.xaml
        /// </summary>
        public void tc01_Extract_Permit_Info()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Extract Permit Info.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Extract Permit Info.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Extract_Permit_Info(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Extract Permit Info.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if party name exists.xaml
        /// </summary>
        public (bool out_boolPartyRecordFound, string out_strPartyID) Check_if_party_name_exists(string in_strOrgName, string in_strReportAddress)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if party name exists.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strReportAddress", in_strReportAddress}}, default, default, default, GetAssemblyName());
            return ((bool)result["out_boolPartyRecordFound"], (string)result["out_strPartyID"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check if party name exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (bool out_boolPartyRecordFound, string out_strPartyID) Check_if_party_name_exists(string in_strOrgName, string in_strReportAddress, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check if party name exists.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strReportAddress", in_strReportAddress}}, default, isolated, default, GetAssemblyName());
            return ((bool)result["out_boolPartyRecordFound"], (string)result["out_strPartyID"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Party Name Sheet.xaml
        /// </summary>
        public string Update_Party_Name_Sheet(object in_strOrgName, object in_strRegion)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Party Name Sheet.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strRegion", in_strRegion}}, default, default, default, GetAssemblyName());
            return (string)result["out_strPTK"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Party Name Sheet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Update_Party_Name_Sheet(object in_strOrgName, object in_strRegion, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Party Name Sheet.xaml", new Dictionary<string, object>{{"in_strOrgName", in_strOrgName}, {"in_strRegion", in_strRegion}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_strPTK"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new discharge site.xaml
        /// </summary>
        public void tc01_Create_new_discharge_site()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new discharge site.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new discharge site.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_new_discharge_site(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new discharge site.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new customer.xaml
        /// </summary>
        public void tc01_Create_new_customer()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new customer.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new customer.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_new_customer(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new customer.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Amend Permit.xaml
        /// </summary>
        public void Amend_Permit(string in_strPermitNumber, string in_strOrgID, bool in_boolConfidential, string in_strPartyID, string in_strOrgName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Amend Permit.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}, {"in_strOrgID", in_strOrgID}, {"in_boolConfidential", in_boolConfidential}, {"in_strPartyID", in_strPartyID}, {"in_strOrgName", in_strOrgName}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Amend Permit.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Amend_Permit(string in_strPermitNumber, string in_strOrgID, bool in_boolConfidential, string in_strPartyID, string in_strOrgName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Amend Permit.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}, {"in_strOrgID", in_strOrgID}, {"in_boolConfidential", in_boolConfidential}, {"in_strPartyID", in_strPartyID}, {"in_strOrgName", in_strOrgName}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Close WIMS.xaml
        /// </summary>
        public void tc01_Close_WIMS()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Close WIMS.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Close WIMS.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Close_WIMS(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Close WIMS.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Responsibility.xaml
        /// </summary>
        public void Add_Responsibility(string in_strOrgID, string in_strPartyID, string in_strRole)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Responsibility.xaml", new Dictionary<string, object>{{"in_strOrgID", in_strOrgID}, {"in_strPartyID", in_strPartyID}, {"in_strRole", in_strRole}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Responsibility.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Add_Responsibility(string in_strOrgID, string in_strPartyID, string in_strRole, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Responsibility.xaml", new Dictionary<string, object>{{"in_strOrgID", in_strOrgID}, {"in_strPartyID", in_strPartyID}, {"in_strRole", in_strRole}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Log in to WIMS region.xaml
        /// </summary>
        public void tc01_Log_in_to_WIMS_region()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Log in to WIMS region.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Log in to WIMS region.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Log_in_to_WIMS_region(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Log in to WIMS region.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if customer exists.xaml
        /// </summary>
        public void tc01_Check_if_customer_exists()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if customer exists.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if customer exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Check_if_customer_exists(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if customer exists.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
        public void NetworkConnectivityTool()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NetworkConnectivityTool(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 DEV ONLY Go to dummy permit.xaml
        /// </summary>
        public void tc01_DEV_ONLY_Go_to_dummy_permit()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 DEV ONLY Go to dummy permit.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 DEV ONLY Go to dummy permit.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_DEV_ONLY_Go_to_dummy_permit(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 DEV ONLY Go to dummy permit.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Add Responsibilities.xaml
        /// </summary>
        public void tc01_Add_Responsibilities()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Add Responsibilities.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Add Responsibilities.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Add_Responsibilities(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Add Responsibilities.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/tc01 GetTransactionData.xaml
        /// </summary>
        public void tc01_GetTransactionData()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\tc01 GetTransactionData.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/tc01 GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_GetTransactionData(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\tc01 GetTransactionData.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Search Permit in Power BI.xaml
        /// </summary>
        public void Search_Permit_in_Power_BI()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Search Permit in Power BI.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Search Permit in Power BI.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Search_Permit_in_Power_BI(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Search Permit in Power BI.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Log in to WIMS region.xaml
        /// </summary>
        public void Log_in_to_WIMS_region(string in_strRegion)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Log in to WIMS region.xaml", new Dictionary<string, object>{{"in_strRegion", in_strRegion}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Log in to WIMS region.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Log_in_to_WIMS_region(string in_strRegion, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Log in to WIMS region.xaml", new Dictionary<string, object>{{"in_strRegion", in_strRegion}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc02 Create new outlet.xaml
        /// </summary>
        public void tc02_Create_new_outlet()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc02 Create new outlet.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc02 Create new outlet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc02_Create_new_outlet(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc02 Create new outlet.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new party.xaml
        /// </summary>
        public void tc01_Create_new_party()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new party.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new party.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_new_party(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new party.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if NGR exists.xaml
        /// </summary>
        public void tc01_Check_if_NGR_exists()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if NGR exists.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if NGR exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Check_if_NGR_exists(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if NGR exists.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Init next release.xaml
        /// </summary>
        public void Init_next_release(bool in_boolMoreRecords)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Init next release.xaml", new Dictionary<string, object>{{"in_boolMoreRecords", in_boolMoreRecords}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Init next release.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Init_next_release(bool in_boolMoreRecords, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Init next release.xaml", new Dictionary<string, object>{{"in_boolMoreRecords", in_boolMoreRecords}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new discharge site.xaml
        /// </summary>
        public void Create_new_discharge_site(string in_strAssetPropertyCode, bool in_boolConfidential, string[] in_arrAddress, string in_strPostcode, string in_strAreaCode, string in_strSubAreaCode, string in_strLocalAuthorityCode, string in_strGridReference)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new discharge site.xaml", new Dictionary<string, object>{{"in_strAssetPropertyCode", in_strAssetPropertyCode}, {"in_boolConfidential", in_boolConfidential}, {"in_arrAddress", in_arrAddress}, {"in_strPostcode", in_strPostcode}, {"in_strAreaCode", in_strAreaCode}, {"in_strSubAreaCode", in_strSubAreaCode}, {"in_strLocalAuthorityCode", in_strLocalAuthorityCode}, {"in_strGridReference", in_strGridReference}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new discharge site.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_new_discharge_site(string in_strAssetPropertyCode, bool in_boolConfidential, string[] in_arrAddress, string in_strPostcode, string in_strAreaCode, string in_strSubAreaCode, string in_strLocalAuthorityCode, string in_strGridReference, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new discharge site.xaml", new Dictionary<string, object>{{"in_strAssetPropertyCode", in_strAssetPropertyCode}, {"in_boolConfidential", in_boolConfidential}, {"in_arrAddress", in_arrAddress}, {"in_strPostcode", in_strPostcode}, {"in_strAreaCode", in_strAreaCode}, {"in_strSubAreaCode", in_strSubAreaCode}, {"in_strLocalAuthorityCode", in_strLocalAuthorityCode}, {"in_strGridReference", in_strGridReference}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Return to main page.xaml
        /// </summary>
        public void tc01_Return_to_main_page()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Return to main page.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Return to main page.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Return_to_main_page(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Return to main page.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Log in to WIMS region STORED CREDS.xaml
        /// </summary>
        public void tc01_Log_in_to_WIMS_region_STORED_CREDS()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Log in to WIMS region STORED CREDS.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Log in to WIMS region STORED CREDS.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Log_in_to_WIMS_region_STORED_CREDS(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Log in to WIMS region STORED CREDS.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new outlet.xaml
        /// </summary>
        public void tc01_Create_new_outlet()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new outlet.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create new outlet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_new_outlet(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create new outlet.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if permit exists.xaml
        /// </summary>
        public void tc01_Check_if_permit_exists()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if permit exists.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if permit exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Check_if_permit_exists(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if permit exists.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Amend Permit.xaml
        /// </summary>
        public void tc01_Amend_Permit()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Amend Permit.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Amend Permit.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Amend_Permit(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Amend Permit.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Return to earlier page.xaml
        /// </summary>
        public void Return_to_earlier_page(UiPath.Core.UiElement in_uiPage)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Return to earlier page.xaml", new Dictionary<string, object>{{"in_uiPage", in_uiPage}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Return to earlier page.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Return_to_earlier_page(UiPath.Core.UiElement in_uiPage, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Return to earlier page.xaml", new Dictionary<string, object>{{"in_uiPage", in_uiPage}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Log in to WIMS region STORED CREDS.xaml
        /// </summary>
        public void Log_in_to_WIMS_region_STORED_CREDS(string in_strRegion)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Log in to WIMS region STORED CREDS.xaml", new Dictionary<string, object>{{"in_strRegion", in_strRegion}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Log in to WIMS region STORED CREDS.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Log_in_to_WIMS_region_STORED_CREDS(string in_strRegion, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Log in to WIMS region STORED CREDS.xaml", new Dictionary<string, object>{{"in_strRegion", in_strRegion}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/DEV ONLY Go to dummy permit.xaml
        /// </summary>
        public void DEV_ONLY_Go_to_dummy_permit()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\DEV ONLY Go to dummy permit.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/DEV ONLY Go to dummy permit.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void DEV_ONLY_Go_to_dummy_permit(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\DEV ONLY Go to dummy permit.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Close WIMS.xaml
        /// </summary>
        public void Close_WIMS()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Close WIMS.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Close WIMS.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Close_WIMS(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Close WIMS.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Next record or next block.xaml
        /// </summary>
        public void Next_record_or_next_block(bool in_boolLastRecord)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Next record or next block.xaml", new Dictionary<string, object>{{"in_boolLastRecord", in_boolLastRecord}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Next record or next block.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Next_record_or_next_block(bool in_boolLastRecord, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Next record or next block.xaml", new Dictionary<string, object>{{"in_boolLastRecord", in_boolLastRecord}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new release.xaml
        /// </summary>
        public UiPath.Core.UiElement Create_new_release(string in_strName, string in_strDischargeTypes, string in_strGridReference, string in_strTreatmentType, string in_strFlowCode, string in_strDescription)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new release.xaml", new Dictionary<string, object>{{"in_strName", in_strName}, {"in_strDischargeTypes", in_strDischargeTypes}, {"in_strGridReference", in_strGridReference}, {"in_strTreatmentType", in_strTreatmentType}, {"in_strFlowCode", in_strFlowCode}, {"in_strDescription", in_strDescription}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiReleases"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new release.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement Create_new_release(string in_strName, string in_strDischargeTypes, string in_strGridReference, string in_strTreatmentType, string in_strFlowCode, string in_strDescription, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new release.xaml", new Dictionary<string, object>{{"in_strName", in_strName}, {"in_strDischargeTypes", in_strDischargeTypes}, {"in_strGridReference", in_strGridReference}, {"in_strTreatmentType", in_strTreatmentType}, {"in_strFlowCode", in_strFlowCode}, {"in_strDescription", in_strDescription}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["out_uiReleases"];
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(bool in_boolUnattended)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(bool in_boolUnattended, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Extract Permit Info.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, string> out_dictPermitDetails, System.Data.DataTable out_dtReleaseDetails, System.Data.DataTable out_dtOutlets, System.Data.DataTable out_dtReleases) Extract_Permit_Info(System.Data.DataTable in_dtLookups)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Extract Permit Info.xaml", new Dictionary<string, object>{{"in_dtLookups", in_dtLookups}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, string>)result["out_dictPermitDetails"], (System.Data.DataTable)result["out_dtReleaseDetails"], (System.Data.DataTable)result["out_dtOutlets"], (System.Data.DataTable)result["out_dtReleases"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Extract Permit Info.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Collections.Generic.Dictionary<string, string> out_dictPermitDetails, System.Data.DataTable out_dtReleaseDetails, System.Data.DataTable out_dtOutlets, System.Data.DataTable out_dtReleases) Extract_Permit_Info(System.Data.DataTable in_dtLookups, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Extract Permit Info.xaml", new Dictionary<string, object>{{"in_dtLookups", in_dtLookups}}, default, isolated, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, string>)result["out_dictPermitDetails"], (System.Data.DataTable)result["out_dtReleaseDetails"], (System.Data.DataTable)result["out_dtOutlets"], (System.Data.DataTable)result["out_dtReleases"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new release detail.xaml
        /// </summary>
        public void Create_new_release_detail(string in_strParamCode, string in_strCorA, string in_strStartDay, string in_strStartMonth, string in_strEndDay, string in_strEndMonth, string in_strLimitValue, string in_strIndex, string in_strComplianceStatisticCode, bool in_boolLastReleaseDetail)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new release detail.xaml", new Dictionary<string, object>{{"in_strParamCode", in_strParamCode}, {"in_strCorA", in_strCorA}, {"in_strStartDay", in_strStartDay}, {"in_strStartMonth", in_strStartMonth}, {"in_strEndDay", in_strEndDay}, {"in_strEndMonth", in_strEndMonth}, {"in_strLimitValue", in_strLimitValue}, {"in_strIndex", in_strIndex}, {"in_strComplianceStatisticCode", in_strComplianceStatisticCode}, {"in_boolLastReleaseDetail", in_boolLastReleaseDetail}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new release detail.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_new_release_detail(string in_strParamCode, string in_strCorA, string in_strStartDay, string in_strStartMonth, string in_strEndDay, string in_strEndMonth, string in_strLimitValue, string in_strIndex, string in_strComplianceStatisticCode, bool in_boolLastReleaseDetail, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new release detail.xaml", new Dictionary<string, object>{{"in_strParamCode", in_strParamCode}, {"in_strCorA", in_strCorA}, {"in_strStartDay", in_strStartDay}, {"in_strStartMonth", in_strStartMonth}, {"in_strEndDay", in_strEndDay}, {"in_strEndMonth", in_strEndMonth}, {"in_strLimitValue", in_strLimitValue}, {"in_strIndex", in_strIndex}, {"in_strComplianceStatisticCode", in_strComplianceStatisticCode}, {"in_boolLastReleaseDetail", in_boolLastReleaseDetail}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Go to outlets reference block.xaml
        /// </summary>
        public void Go_to_outlets_reference_block()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Go to outlets reference block.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Go to outlets reference block.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Go_to_outlets_reference_block(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Go to outlets reference block.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new permit.xaml
        /// </summary>
        public void Create_new_permit(string in_strPermitNumber, string in_strGridReference, string in_strIssuedDate, string in_strEffectiveDate, string in_strReceivingWater, string in_strNumericOrDescriptive)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new permit.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}, {"in_strGridReference", in_strGridReference}, {"in_strIssuedDate", in_strIssuedDate}, {"in_strEffectiveDate", in_strEffectiveDate}, {"in_strReceivingWater", in_strReceivingWater}, {"in_strNumericOrDescriptive", in_strNumericOrDescriptive}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new permit.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_new_permit(string in_strPermitNumber, string in_strGridReference, string in_strIssuedDate, string in_strEffectiveDate, string in_strReceivingWater, string in_strNumericOrDescriptive, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new permit.xaml", new Dictionary<string, object>{{"in_strPermitNumber", in_strPermitNumber}, {"in_strGridReference", in_strGridReference}, {"in_strIssuedDate", in_strIssuedDate}, {"in_strEffectiveDate", in_strEffectiveDate}, {"in_strReceivingWater", in_strReceivingWater}, {"in_strNumericOrDescriptive", in_strNumericOrDescriptive}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public bool GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}}, default, default, default, GetAssemblyName());
            return (bool)result["out_boolLastTransaction"];
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_boolLastTransaction"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if party name exists.xaml
        /// </summary>
        public void tc01_Check_if_party_name_exists()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if party name exists.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Check if party name exists.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Check_if_party_name_exists(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Check if party name exists.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Select discharge, treatment and flow code.xaml
        /// </summary>
        public (string out_strDischargeCode, string out_strFlowCode) Select_discharge__treatment_and_flow_code(string out_strTreatmentCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Select discharge, treatment and flow code.xaml", new Dictionary<string, object>{{"out_strTreatmentCode", out_strTreatmentCode}}, default, default, default, GetAssemblyName());
            return ((string)result["out_strDischargeCode"], (string)result["out_strFlowCode"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Select discharge, treatment and flow code.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_strDischargeCode, string out_strFlowCode) Select_discharge__treatment_and_flow_code(string out_strTreatmentCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Select discharge, treatment and flow code.xaml", new Dictionary<string, object>{{"out_strTreatmentCode", out_strTreatmentCode}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_strDischargeCode"], (string)result["out_strFlowCode"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Init next outlet.xaml
        /// </summary>
        public void Init_next_outlet(bool in_boolMoreRecords)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Init next outlet.xaml", new Dictionary<string, object>{{"in_boolMoreRecords", in_boolMoreRecords}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Init next outlet.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Init_next_outlet(bool in_boolMoreRecords, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Init next outlet.xaml", new Dictionary<string, object>{{"in_boolMoreRecords", in_boolMoreRecords}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new party.xaml
        /// </summary>
        public void Create_new_party(string in_strPartyName, string in_strPartyID, string in_strPostcode, string in_strTelephone, string[] in_arrAddress)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new party.xaml", new Dictionary<string, object>{{"in_strPartyName", in_strPartyName}, {"in_strPartyID", in_strPartyID}, {"in_strPostcode", in_strPostcode}, {"in_strTelephone", in_strTelephone}, {"in_arrAddress", in_arrAddress}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create new party.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Create_new_party(string in_strPartyName, string in_strPartyID, string in_strPostcode, string in_strTelephone, string[] in_arrAddress, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create new party.xaml", new Dictionary<string, object>{{"in_strPartyName", in_strPartyName}, {"in_strPartyID", in_strPartyID}, {"in_strPostcode", in_strPostcode}, {"in_strTelephone", in_strTelephone}, {"in_arrAddress", in_arrAddress}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}