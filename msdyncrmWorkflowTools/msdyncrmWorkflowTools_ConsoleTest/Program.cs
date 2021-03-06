﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using msdyncrmWorkflowTools;

namespace msdyncrmWorkflowTools_ConsoleTest
{
    class Program
    {
        static IOrganizationService service = GetCrmService();

        static void Main(string[] args)
        {
            var classObj = new msdyncrmWorkflowTools_Class(service);


            classObj.InsertOptionValue(true, "purchaseprocess", "opportunity", "Tipo22", 22, 3082);
            classObj.InsertOptionValue(false, "cdi_test", "opportunity", "Tipo4", 1, 3082);


            classObj.DeleteOptionValue(true,"purchaseprocess", "opportunity", 22);

            classObj.DeleteOptionValue(false, "cdi_test", "opportunity",  1);


            //classObj.AssociateEntity("list", new Guid("F9F76AF5-91DF-E311-B8E5-6C3BE5A8B200"), "cdi_emailsend_list", "cdi_emailsend_list", "cdi_emailsend", "5D84160C-A31C-E711-80FF-5065F38A9A01");

            //classObj.UpdateChildRecords("contact_customer_accounts", "account", "D17BAB26-98BF-E611-810A-3863BB350E28","emailaddress1", "", "emailaddress1");
            //classObj.UpdateChildRecords("contact_customer_accounts", "account", "D17BAB26-98BF-E611-810A-3863BB350E28", "new_campaa", "", "new_campaa");
            //classObj.AssociateEntity("opportunity",new Guid("D9AA2BB3-A8F0-E611-80FA-5065F38A4A21"), "opportunitycompetitors_association", "opportunitycompetitors", "competitor", "C53B2A00-57F0-E611-80FA-5065F38A4A21");
            //classObj.InsertOptionValue(true,"purchaseprocess", "opportunity", "Tipo22",22, 3082);
            // classObj.InsertOptionValue(false,"cdi_test", "opportunity", "Tipo4",1, 3082);
        }
        public static IOrganizationService GetCrmService()
        {

            const string crmServerUrl = "https://XXXX.crm4.dynamics.com";
            const string userName = "admin@XXXX.onmicrosoft.com";
            const string password = "XXXXX";

             var connectionStringCrmOnline = string.Format("Url={0}; Username={1}; Password={2};authtype=Office365;", crmServerUrl, userName, password);

            CrmServiceClient conn = new Microsoft.Xrm.Tooling.Connector.CrmServiceClient(connectionStringCrmOnline);
            
            IOrganizationService _service = (IOrganizationService)conn.OrganizationWebProxyClient != null ? (IOrganizationService)conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;


           
            return _service;
        }

    }
}
